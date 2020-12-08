using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace internal_communication
{
    class SubjectDA
    {
        public static void Savesub(List<Subject_class> subj)
        {
            StreamWriter outFile;

            outFile = File.CreateText("subject.txt");

            foreach (Subject_class sub in subj)
            {
                outFile.WriteLine(sub.Subject);
                outFile.WriteLine(sub.Project_id);
            }

            outFile.Close();

        }


        public static List<Subject_class> Loadsub(int proj)
        {
            List<Subject_class> subj = new List<Subject_class>();
            StreamReader inFile;
            Subject_class sub;

            try
            {
                inFile = File.OpenText("subject.txt");

                while (!inFile.EndOfStream)
                {
                    sub = new Subject_class();
                    proj = Convert.ToInt32(sub.Project_id);
                    sub.Subject = inFile.ReadLine();
                    subj.Add(sub);

                }

                inFile.Close();

                return subj;

            }
            catch
            {
                return subj;
            }

        }
    }
}
