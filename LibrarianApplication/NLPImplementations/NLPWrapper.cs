﻿using System;
using System.IO;
using Console = System.Console;
using edu.stanford.nlp.simple;
using edu.stanford.nlp.trees;
using java.util;
using System.Collections.Generic;




/*
 * 
 */

namespace NLPImplementations
{
    public class NLPWrapper
    {

        public String nlpModelsDirectory { get; set; }
        private String previousDirectory;

        public NLPWrapper()
        {
            this.nlpModelsDirectory = @"..\..\..\stanford-english-corenlp-2016-10-31-models\";
        }


        private void switchToModelsDirectory()
        {
            if (nlpModelsDirectory == "" || nlpModelsDirectory == null)
            {
                throw new ArgumentNullException("models directory is empty or null");
            }
            String thisDirectory = Directory.GetCurrentDirectory();
            if (thisDirectory != nlpModelsDirectory)
            {
                previousDirectory = thisDirectory;
                try
                {
                    Directory.SetCurrentDirectory(nlpModelsDirectory);
                }
                catch (DirectoryNotFoundException)
                {
                    // throw exception back to caller
                    throw new DirectoryNotFoundException($"The directory specified for the NLP library models can't be found [{nlpModelsDirectory}]");
                }
            }
        }

        private void switchToPreviousDirectory()
        {
            if (previousDirectory == "" || previousDirectory == null)
            {
                throw new ArgumentNullException("previous directory is empty or null");
            }
            try
            {
                Directory.SetCurrentDirectory(previousDirectory);
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException($"The previous directory no longer exists [{previousDirectory}]");
            }
        }

        public List<string> analyzeText(String text)
        {
            List<string> realTags = new List<string>();
            switchToModelsDirectory();

            // run the parser on each sentence
            Document doc = new Document(text);
            for (int i = 0; i < doc.sentences().size(); i++)
            {

                List posTags = doc.sentence(i).posTags();

                for (int j = 0; j < posTags.size(); j++)
                {
                    realTags.Add((string)(posTags.get(j).ToString()));
                    Console.WriteLine(realTags[j]);
                }
 
            }

            switchToPreviousDirectory();
            return realTags;
        }
    }
}