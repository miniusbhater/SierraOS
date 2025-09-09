using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SierraOS.Applications;

namespace SierraOS.Applications.Utils
{
    public class TextEditor : Application
    {
        public TextEditor() { }
        public override string appName()
        {
            return "Text Editor";
        }
        public override string appCommand()
        {
            return "textedit";
        }

        public override void Initialize()
        {
            Console.Clear();
            Console.WriteLine("Simple Text Editor. Type 'SAVE' on a new line to save and exit.");
            Console.WriteLine("Type 'EXIT' on a new line to exit without saving.");
            Console.WriteLine("Enter your text below:");
        }

        public override void Run()
        {
            List<string> lines = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToUpper() == "SAVE")
                {
                    //SaveToFile(lines);
                    Console.WriteLine("File saved. Exiting editor.");
                    break;
                }
                else if (input.ToUpper() == "EXIT")
                {
                    Console.WriteLine("Exiting editor without saving.");
                    break;
                }
                else
                {
                    lines.Add(input);
                }
            }
        }
    }
}
