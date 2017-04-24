using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    public class Document
    {
        private String fileName;
        private List<double> vectors;
        private String targetPath;
        public Document(String fileName, List<double> vectors, String targetPath)
        {
            this.fileName = fileName;
            this.vectors = vectors;
            this.targetPath = targetPath;

        }
        public String getTargetPath()
        {
            return targetPath;
        }
        public List<double> getVectors()
        {
            return vectors;
        }
        public void setVectors(List<double> vectors)
        {
            this.vectors = vectors;
        }

    }
}
