using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DocumentInterfaces;

namespace DocumentImplementation
{

    public class DocumentCreation : IDocumentCreation
    {
        public String storeDoc(String fileName, String sourcePath, String targetPath)
        {


            string fileN = fileName;
            string sourceP = @sourcePath;
            string targetP = @targetPath;

            string sourceFile = System.IO.Path.Combine(sourceP, fileN);
            string destFile = System.IO.Path.Combine(targetP, fileN);

            // If the directory does not exist do nothing
            if (!System.IO.Directory.Exists(targetP))
            {
                Console.WriteLine("No directory to write to.");
                return targetP;
            }

            System.IO.File.Copy(sourceFile, destFile, true);

            if (System.IO.Directory.Exists(sourceP))
            {
                string[] files = System.IO.Directory.GetFiles(sourceP);
                foreach (string s in files)
                {
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetP, fileN);
                    System.IO.File.Copy(s, destFile, true);
                    return targetP;
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
            Console.Read();
            return null;


        }

    }
}
