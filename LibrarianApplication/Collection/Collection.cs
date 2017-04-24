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
        private List<int> vectors;
        private String targetPath;
        public Collection(String CollectionName, List<int> vectors, String targetPath)
        {
            this.CollectionName = CollectionName;
            this.vectors = vectors;
            this.targetPath = targetPath;

        }
        public String getTargetPath()
        {
            return targetPath;
        }
        public List<int> getVectors()
        {
            return vectors;
        }
        public void setVectors(List<int> vectors)
        {
            this.vectors = vectors;
        }
    }
}
