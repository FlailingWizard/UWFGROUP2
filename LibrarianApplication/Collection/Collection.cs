using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Collection
    {
        private String CollectionName;
        private String[] tags;
        private String targetPath;
        public Collection(String CollectionName, String[] tags, String targetPath)
        {
            this.CollectionName = CollectionName;
            this.tags = tags;
            this.targetPath = targetPath;

        }
    }
}
