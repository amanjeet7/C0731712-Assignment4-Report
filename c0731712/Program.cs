using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace c0731712
{
    class Program
    {
        ArrayList Beowulf;
         int counterletters = 0;
         int countSpaces = 0;
        static void Main(string[] args)
        {
           
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadLine();
            
        }
  
        public void Run() { this.ReadTextFiles(); }
        public void ReadTextFiles()
        {

            using (StreamReader sr = new StreamReader("U:\\Users\\731712.STUDENT.000\\Downloads\\Beowulf.txt"))
            {
                string line;
                int counter = 0;
                int a = 0, myWord = 1;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Beowulf.Add(line);
                    FindNumberOfBlankSpaces(line);
                    counter++;

                    while (a <= line.Length - 1)
                    {
                        if (line[a] == ' ' || line[a] == '\n' || line[a] == '\t')
                        {
                            myWord++;
                        }
                        a++;
                    }
                    a = 0;

                }


                Console.WriteLine("\n\n\n\n Number of lines in this file are " + counter);
                Console.WriteLine("The word count is " + myWord);
              
            }

        }
        public int FindNumberOfBlankSpaces(string line)
        {


            foreach (char c in line)
            {
                if (char.IsLetter(c)) { counterletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}