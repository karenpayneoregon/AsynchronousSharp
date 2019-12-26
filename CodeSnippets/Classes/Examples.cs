using System;
using System.Threading;
using System.Threading.Tasks;

namespace CodeSnippets.Classes
{
    /// <summary>
    /// Basic asynchronous code samples where
    /// 
    /// * No code actual does anything, there are other code samples in
    ///   this solution which actual do work.
    /// 
    /// * Each example provides a cancellation option, this is important
    ///   as without this a user may simple close the application from
    ///   a close button or from Windows Task Manager.
    ///
    /// * Callers of these methods use try-catch statements
    ///   * Required for cancellations as cancelling throws OperationCanceledException
    ///     exception which can be captured.
    ///   * In the event there is a runtime exception. Later form examples go deeper
    ///     with exception handling
    /// 
    /// </summary>
    public class Examples
    {
        public delegate void IndexHandler(object sender, ProcessIndexingArgs args);
        public event IndexHandler OnIterate;

        /// <summary>
        /// In this example each time await is called we go back to the captured
        /// context after the execution of the awaited task.
        ///
        /// Calling ConfigureAwait(false) after the task means that we do not care
        /// if the code after the await, runs on the captured context or not.
        /// </summary>
        /// <param name="loop"></param>
        /// <returns></returns>
        public async Task<int> ProcessAsync1(int loop, CancellationToken ct)
        {
            int result = 0;

            for (var index = 0; index < loop; index++)
            {

                Console.WriteLine(SynchronizationContext.Current == null);
                await Task.Delay(10, ct);

                OnIterate?.Invoke(this, new ProcessIndexingArgs(index));


                if (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                }


                result += index;

            }

            return result;
        }
        /// <summary>
        /// Run a long running task composed of small awaited and configured tasks
        /// Using ConfigureAwait(false) makes this particular method run a bit faster
        /// then the example above.
        /// </summary>
        public async Task<int> ProcessAsync2(int loop, CancellationToken ct)
        {
            int index = 0;

            for (int i = 0; i < loop; i++)
            {

                Console.WriteLine(SynchronizationContext.Current == null);
                await Task.Delay(10, ct).ConfigureAwait(false);
                OnIterate?.Invoke(this, new ProcessIndexingArgs(index));


                if (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                }


                index += i;
            }

            return index;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="millisecondsTimeout"></param>
        /// <returns></returns>
        public static Task Sleep(int millisecondsTimeout)
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();

            ThreadPool.QueueUserWorkItem((state) =>
            {
                Thread.Sleep(millisecondsTimeout);
                taskCompletionSource.SetResult(true);
            }, null);

            return taskCompletionSource.Task;
        }

    }

    public class ProcessIndexingArgs : EventArgs
    {
        protected int Index;

        public ProcessIndexingArgs(int sender)
        {
            Index = sender;
        }
        public int Value => Index;

        public override string ToString()
        {
            return Index.ToString();
        }
    }
}
