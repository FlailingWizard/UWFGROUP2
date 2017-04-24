using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Collection
    {
        private String CollectionName;
        private List<double> vectors;
        private String targetPath;
        public Collection(String CollectionName, List<double> vectors, String targetPath)
        {
            this.CollectionName = CollectionName;
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
