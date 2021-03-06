﻿using System;
using System.Collections.Generic;
using System.IO;
using NLPInterfaces;
using DocumentInterfaces;

namespace DocumentImplementation
{
    public class Document : IDocument
    {

        public string Name { get; }
        private string targetPath; // this should always be the full path to the file (including filename)
        public IFeatureVector vector { get; set; }
        
        private const bool OverwriteTargetFile = true;

        public string TargetPath
        {
            get
            {
                return targetPath;
            }

            set
            {
                string newPath = value;
                targetPath = value;
                // here we should change the location of the document
                //store(targetPath, newPath);

            }
        }

        public Document(string name, string targetPath, IFeatureVector vector)
        {
            this.Name = name;
            this.targetPath = targetPath;
            this.vector = vector; 
        }


        /// <summary>
        /// This method reads the content of the file pointed to by this document instance from the disk.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown if the provided targetpath is null or empty.</exception>
        /// <exception cref="IOException">Thrown if the file cannot be read.</exception>
        public string getText()
        {
            // read and return all of the text from the file
            if (targetPath == "" || targetPath == null)
            {
                throw new ArgumentNullException("No target path has been set");
            }

            try
            {
                using (StreamReader sr = new StreamReader(targetPath))
                {
                    String text = sr.ReadToEnd();
                    // validate this stuff before we return it
                    if (text == "")
                    {
                        throw new InvalidDataException($"The file {targetPath} is empty.");
                    }
                    return text;
                }
            }
            catch (Exception e)
            {
                throw new IOException($"Unable to open file {targetPath}", e);
            }

        }


        /// <summary>
        /// This method will move the file from the current directory to a new directory.
        /// </summary>
        /// <param name="sourcePath">The full path to where the file currently is.</param>
        /// <param name="targetPath">The full path to where the file should be moved.</param>
        /// <exception cref="ArgumentException">Thrown if the target directory does not exist.</exception>
        /// <exception cref="InvalidOperationException">Thrown if the source file no longer exists.</exception>
        public string getPath()
        {
            return TargetPath + @"\" + Name;
        }

        public String storeDoc(String sourcePath, String targetPath)
        {

            string fileN = new FileInfo(sourcePath).Name;
            string sourceP = @sourcePath;
            string targetP = @targetPath;

            //string sourceFile = System.IO.Path.Combine(sourceP, fileN);
            string destFile = System.IO.Path.Combine(targetP, fileN);

            // If the directory does not exist do nothing
            if (!System.IO.Directory.Exists(targetP))
            {
                Console.WriteLine("No directory to write to.");
                return null;
            }

            System.IO.File.Copy(sourceP, destFile, true);

            /*if (System.IO.Directory.Exists(sourceP))
            {
                string[] files = System.IO.Directory.GetFiles(sourceP);
                foreach (string s in files)
                {
                    // fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetP, fileN);
                    System.IO.File.Copy(s, destFile, true);
                }
                return targetP;
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
            */
            Console.Read();
            return targetPath;


        }
        /*
        private void store(string sourcePath, string targetPath)
        {

            if (!Directory.Exists(targetPath))
            {
                throw new ArgumentException($"Directory {targetPath} does not exist");
            }
            if (!File.Exists(sourcePath))
            {
                throw new InvalidOperationException($"Source file {sourcePath} does not exist");
            }

            try
            {
                File.Copy(sourcePath, targetPath, OverwriteTargetFile);    // this throws a ton of exceptions. you need to catch them
            }
            catch (Exception e)
            {
                throw new IOException($"Unable to move file from {sourcePath} to {targetPath}", e);
            }


            // i don't even know what is happening here, so i've commented it out

            //if (System.IO.Directory.Exists(sourcePath))
            //{
            //    string[] files = Directory.GetFiles(sourcePath);
            //    foreach (string s in files)
            //    {
            //        // fileName = System.IO.Path.GetFileName(s);
            //        destFile = System.IO.Path.Combine(targetPath, fileN);
            //        System.IO.File.Copy(s, destFile, true);
            //        return targetPath;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Source path does not exist!");
            //}
            //Console.Read();
            //return null;


        }
        */

        /// <summary>
        /// This will delete the file on the disk.
        /// </summary>
        /// <param name="deletePath"></param>
        public String delete()
        {
            if (File.Exists(targetPath))
            {
                try
                {
                    File.Delete(targetPath);
                    return targetPath;
                }
                catch (System.IO.IOException e)
                {
                    throw new IOException($"Unable to delete file {targetPath}", e);
                }
            }
            return null;  // not sure this is necessary?
        }

    }

}
