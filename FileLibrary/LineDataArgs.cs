using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLibrary
{
    public class LineDataArgs : EventArgs
    {
        protected string[] Line;

        public LineDataArgs(string[] sender)
        {
            Line = sender;
        }
        public string[] LineArray => Line;
    }
}
