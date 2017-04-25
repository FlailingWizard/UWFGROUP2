using System;
using System.Collections.Generic;
using System.IO;

using DocumentImplementation;
using DocumentInterfaces;
using NLPInterfaces;
using CollectionInterfaces;

namespace CollectionImplementation
{
    public class DocumentCollection : IDocumentCollection
    {
        public string CollectionName { get; }
        // allowing modifications to the name is not supported
        private IFeatureVector Vector { get; set; }
        private string TargetPath { get; }
        public List<IDocument> documents { get; }

        private const bool DeleteRecursively = true;

        public DocumentCollection(string collectionName, IFeatureVector vector, string targetPath)
        {
            Console.WriteLine($"New collection: ({collectionName},{targetPath})");
            this.CollectionName = collectionName;
            this.Vector = vector;
            this.TargetPath = targetPath;

            create();
        }

        private string getPath()
        {
            return TargetPath + @"\" + CollectionName;
        }

        /// <summary>
        /// This creates a new directory for the collection, if necessary.
        /// </summary>
        /// <param name="targetPath"></param>
        /// <exception cref="ArgumentNullException">Thrown if the parameter is null or empty.</exception>
        /// <exception cref="IOException">Thrown if an error occurs while creating the directory. Check the inner exception for details.</exception>
        private void create()
        {
            string path = getPath();
            if (path == "" || path == null)
                throw new ArgumentNullException("The path paramater cannot be empty or null");
            
            // create the directory if it doesn't already exist
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"Created directory {path}");
                }
                catch (Exception e)
                {
                    throw new IOException($"Could not create directory {path}", e);
                }

            }

        }

        /// <summary>
        /// This will delete the collection (directory) on disk.
        /// </summary>
        /// <param name="deletePath"></param>
        /// <returns></returns>
        public void delete()
        {
            if (Directory.Exists(TargetPath))
            {
                try
                {
                    Directory.Delete(TargetPath, DeleteRecursively);
                }
                catch (Exception e)
                {
                    throw new IOException($"Could not delete directory {TargetPath}", e);
                }
            }
        }

        public int count()
        {
            return documents.Count;
        }

        public void addDocument(IDocument document)
        {
            documents.Add(document);
        }

        public void removeDocument(IDocument document)
        {
            documents.Remove(document);
        }
    }
}
