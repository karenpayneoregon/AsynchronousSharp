namespace CodeSnippets.Classes
{
    /// <summary>
    /// Used in ShortSamples.Example1Async
    /// to keep parameters received to a minimum.
    /// </summary>
    public class PersonArguments
    {
        /// <summary>
        /// File to read
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// First name to find
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name to find
        /// </summary>
        public string LastName { get; set; }
    }
}
