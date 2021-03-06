using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB3_EXC_001
{
    internal partial class MyLanguageParser
    {
        public MyLanguageParser() : base(null) { }

        public void Parse(string s)
        {
            byte[] inputBuffer = System.Text.Encoding.Default.GetBytes(s);
            MemoryStream stream = new MemoryStream(inputBuffer);
            this.Scanner = new MyLanguageScanner(stream);
            this.Parse();
        }
    }
}
