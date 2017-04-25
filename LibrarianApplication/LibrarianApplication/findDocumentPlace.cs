using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentImplementation;
using System.Xml;

using NLPImplementations;
using CollectionImplementation;

namespace DocumentImplementation
{
    public class findDocumentPlace
    {
        public static void findDocPlace(Document doc)
        {
            XmlTextReader reader = new XmlTextReader("this is our xml");
            int collNum = 0; //logic to pull this from collections
            FeatureVector vector = new FeatureVector(doc.getText());
            int lowestAngle = 0, angle = 0;
            vector.process();
            DocumentCollection collPlace;
            for (int i = 0; i < collNum; i++)
            {
                //logic to pull the collection
                //angle = vector.similarity(collectionpulled)
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