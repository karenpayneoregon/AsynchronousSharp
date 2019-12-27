using System;

namespace CodeSnippets.Classes
{
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