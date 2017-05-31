using System;
using System.Linq;
using System.Xml.Linq;

namespace EleksCamp_CA
{
    public class XmlWork
    {
        public void CreateXML(int id, string autor, string department, string name, int pages, string fileName)
        {
            XDocument doc = XDocument.Load(fileName);
            XElement root = new XElement("book");
            root.Add(new XAttribute("id", id));
            root.Add(new XElement("name", name));
            root.Add(new XElement("autor", autor));
            root.Add(new XElement("pages", pages));
            root.Add(new XElement("departmentname", department));
            doc.Element("library").Add(root);
            doc.Save(fileName);
        }

        public void SortByPages(string xmlFile)
        {
            XDocument doc = XDocument.Load(xmlFile);
            var xnodes = doc.Element("library").Elements();
            var sortedXNodes = xnodes.OrderBy(node => Convert.ToInt32(node.Element("pages").Value));
            var newXdoc = new XDocument(new XElement("library", sortedXNodes));
            newXdoc.Save("LibrarySort.xml");
        }
    }
}
