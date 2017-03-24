using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Document
    {
        private String fileName;
        private String[] tags;
        private String targetPath;
        public Document(String fileName, String[] tags, String targetPath)
        {
            this.fileName = fileName;
            this.tags = tags;
            this.targetPath = targetPath;

        }
        
    }
}
