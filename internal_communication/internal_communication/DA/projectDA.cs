using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace internal_communication
{
    class projectDA
    {
        public static void Save(List<Projects_class> proj)
        {
            StreamWriter outFile;

            outFile = File.CreateText("project2.txt");

            foreach (Projects_class pro in proj)
            {
                outFile.WriteLine(pro.ID);
                outFile.WriteLine(pro.Project_name);
                outFile.WriteLine(pro.Year);
                outFile.WriteLine(pro.Category);
               
            }

            outFile.Close();
        
        }

       

        public static List<Projects_class> Load()
        {
            List<Projects_class> proj = new List<Projects_class>();
            StreamReader inFile;
            Projects_class pro;

            try
            {
                inFile = File.OpenText("project2.txt");

                while (!inFile.EndOfStream)
                {
                    pro = new Projects_class();
                    pro.ID = Int32.Parse(inFile.ReadLine());
                    pro.Project_name = inFile.ReadLine();
                    pro.Year = Int32.Parse(inFile.ReadLine());
                    pro.Category = inFile.ReadLine();
              
                    

                    proj.Add(pro);

                }

                inFile.Close();

                return proj;

            }
            catch
            {
                return proj;
            }

        }

       
    }
    }

