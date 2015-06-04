using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace Common.XML
{
    public static class Tools
    {
        /// <summary>
        /// Generates the node from executable path.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="xpath">The xpath.</param>
        /// <param name="parent">The parent.</param>
        /// <returns></returns>
        private static XmlNode GenerateNodeFromXPath(this XmlDocument doc, string xpath, XmlNode parent = null)
        {
            if (parent == null) parent = doc;

            xpath = xpath.Trim();

            //drop root ref.
            if (xpath.StartsWith("//"))
                xpath = xpath.Substring(2, xpath.Length - 2);

            // grab the next node name in the xpath; or return parent if empty
            string[] partsOfXPath = xpath.Trim('/').Split('/');

            if (partsOfXPath.Length == 0)
                return parent;

            string nextNodeInXPath = partsOfXPath[0];
            if (string.IsNullOrEmpty(nextNodeInXPath))
                return parent;


            // get or create the node from the name
            XmlNode node = parent.SelectSingleNode(nextNodeInXPath);
            if (node == null)
            {
                if (nextNodeInXPath.StartsWith("@"))
                {
                    XmlAttribute anode = doc.CreateAttribute(nextNodeInXPath.Substring(1));
                    node = parent.Attributes.Append(anode);
                }
                else
                    node = parent.AppendChild(doc.CreateElement(nextNodeInXPath));
            }

            // rejoin the remainder of the array as an xpath expression and recurse
            string rest = String.Join("/", partsOfXPath, 1, partsOfXPath.Length - 1);
            return doc.GenerateNodeFromXPath(rest, node);
        }

    }
}
