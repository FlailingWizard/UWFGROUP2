﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace ApplicationStorageImplementation
{
    public class ApplicationStorage
    {

        /**
         * Checks if a xml file exists when creating new storage class
         */
        public ApplicationStorage()
        {
            checkIfSaveExisits();
        }

        private string getBaseDirectory()
        {
            String baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            return baseDirectory;
        }

        public bool checkIfSaveExisits()
        {
            String saveFilePath = getBaseDirectory() + "saveFile.xml";

            bool exists = File.Exists(saveFilePath);

            if(exists == false)
            {
                createNewSaveFile();

                exists = true;
            }

            return exists;
        }

        /**
         * Creates new xml save file, saves it in base directory
         */
        private void createNewSaveFile()
        {
            XDocument saveFile = new XDocument
             (
               new XDeclaration("1.0", "UTF - 8", string.Empty),
               new XElement("storage")
             );

            XElement root = saveFile.Element("storage");
        
            saveFile.Save(getBaseDirectory() + "saveFile.xml");
        }

        public void saveNewCollection(string collectionName, string filePath)
        {
            // Save new collection in xml here
            XDocument saveFile = XDocument.Load(getBaseDirectory() + "saveFile.xml");
        }

        public void saveNewDocument(string documentName, string filePath)
        {
            // Save new document in xml here
        }

        public void deleteCollection(string collectionName)
        {
            // Delete collection in xml here
        }

        public void deleteDocument(string documentName)
        {
            // Delete document in xml here
        }



    }
}
