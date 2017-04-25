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
        private string CollectionName { get; }
        // allowing modifications to the name is not supported
        private IFeatureVector Vector { get; set; }
        private string TargetPath { get; }
        private List<IDocument> documents;

        private const bool DeleteRecursively = true;

        public DocumentCollection(string collectionName, IFeatureVector vector, string targetPath)
        {
            this.CollectionName = collectionName;
            this.Vector = vector;
            this.TargetPath = targetPath;

            create();
        }



        /// <summary>
        /// This creates a new directory for the collection, if necessary.
        /// </summary>
        /// <param name="targetPath"></param>
        /// <exception cref="ArgumentNullException">Thrown if the parameter is null or empty.</exception>
        /// <exception cref="IOException">Thrown if an error occurs while creating the directory. Check the inner exception for details.</exception>
        private void create()
        {
            if (TargetPath == "" || TargetPath == null)
                throw new ArgumentNullException("The path paramater cannot be empty or null");
            // create the directory if it doesn't already exist
            if (!Directory.Exists(TargetPath))
            {
                try
                {
                    Directory.CreateDirectory(TargetPath);
                }
                catch (Exception e)
                {
                    throw new IOException($"Could not create directory {TargetPath}", e);
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
            throw new NotImplementedException();
        }

        public void addDocument()
        {
            throw new NotImplementedException();
        }

        public void removeDocument()
        {
            throw new NotImplementedException();
        }
    }
}
