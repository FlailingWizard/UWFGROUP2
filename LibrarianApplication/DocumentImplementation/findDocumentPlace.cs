using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Documents;
using System.Xml;
using NLPImplementations;
using Collections;
namespace DocumentImplementation
{
    class findDocumentPlace
    {
        public void findDocPlace(Document doc)
        {
            XmlTextReader reader = new XmlTextReader("this is our xml");
            int collNum = 0; //logic to pull this from collections
            FeatureVector vector = new FeatureVector();
            int lowestAngle = 0, angle = 0;
            vector.prep(doc);
            Collection collPlace;
            for (int i = 0; i < collNum; i++)
            {
                //logic to pull the collection
                //vector.setScalars(pulledcollection.getVectors());
                //angle = vector.similarity(doc.getVectors())
                if (angle < lowestAngle)
                {
                    lowestAngle = angle;
                    //collPlace = collectionpulled;
                }

            }
            //logic to place doc into collPlace
        }

    }
}
