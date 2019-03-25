using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace SVGTest
{
    class ItemsId
    {
        public void GetElements()
        {

            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"TestGraafika2.svg");
            //XmlNodeList elementList = doc.GetElementsByTagName("rect");
            //string[] labels = new string[elementList.Count];
            //for (int i = 0; i < elementList.Count; i++)
            //{
            //    int id = int.Parse(elementList[i].Attributes["id"].Value);
            //    labels[id] = elementList[i].Attributes["inkspace:label"].Value;
            //}

            XDocument xdoc = XDocument.Load(@"TestGraafika2.svg");
            var elements = xdoc.Root.Elements().Select(e => new
            {
                id = e.Attributes("id").FirstOrDefault()?.Value ?? "",
                type = e.Name,
                x = e.Attributes("x").FirstOrDefault()?.Value ?? "",
                y = e.Attributes("y").FirstOrDefault()?.Value ?? "",
                w = e.Attributes("width").FirstOrDefault()?.Value ?? "",
                h = e.Attributes("height").FirstOrDefault()?.Value ?? "",
                element = e
            });

            if (elements.Count() > 0)
            {

            }
        }
    }
            
            
                
}
    


