using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UnityEngine;

namespace Assets.Data
{
   public class ReadWrite
    {
        string path = Application.dataPath;

         public void CreatXML()
        {
            XmlDocument fileNew = new XmlDocument();
            // Create new declaration
            XmlDeclaration dec = fileNew.CreateXmlDeclaration("1.0", "utf-8", "yes");
            fileNew.AppendChild(dec);
            XmlProcessingInstruction pro = fileNew.CreateProcessingInstruction("xml-stylesheet",
"href='stenw.css' title='STENW' type='text/css'");
            fileNew.AppendChild(pro);
            fileNew.Save("Test.xml");
        }
    }
}
