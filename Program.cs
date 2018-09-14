using System;
using System.IO;

namespace Csharpdoc
{
    class Program
    {
        static void Main(string[] args)
        {            
             string thepath = String.Format("{0}{1}{2}","C:\users\admin\documents\GitHub\CSharpDocument",idTextBox.text,".txt");

             using(StreamWriter writer = new StreamWriter(thepath))
             {
             writer.WriteLine();
             }
             
        }
    }
}
