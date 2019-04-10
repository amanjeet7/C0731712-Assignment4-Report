using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0731712
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
           
            Program p = new Program();
            p.Beowulf = new ArrayList();

        }
        public void run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:\\Users\\731712.STUDENT.000\\Downloads\\Beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) !=null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has { counter} lines.");
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countspaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countletters++; }
            }
            return countspaces;
        }
    }
}
