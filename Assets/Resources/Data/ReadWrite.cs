
using System;
using System.Collections.Generic;

using System.Linq;

using System.Xml.Linq;


namespace Assets.Data
{
    public static class ReadWrite
    {

        public static bool CreatConfig(string path)
        {
            try
            {
                XDocument doc = new XDocument(
                                    new XDeclaration("1.0", "utf-8", "yes"),
                                    new XElement("ConfigDefault",
                                    new XElement("Config",
                                    new XElement("NamePlayer", ""),
                                    new XElement("Damage", 20),
                                    new XElement("Score", 0),
                                    new XElement("Blood", 100),
                                    new XElement("MaxBlood", 100),
                                    new XElement("MoveSpeed", 1.35)
                                    )));
                doc.Save(path);
                return true;
            }
            catch { return false; };
        }

        public static XElement LoadData(string path, string table, string row)
        {
            var booksFromFile = XDocument.Load(path);
           
            IEnumerable<XElement> select = from item in booksFromFile.Descendants(table) select item.Element(row);
            List<XElement> a = new List<XElement>();
            foreach (XElement i in select)
            {
                return i;
            }
            return null;
        }
          
        public static List<Score> LoadScore(string path, string table)
        {
            try
            {
                List<Score> lsScore = new List<Score>();
                XDocument booksFromFile =null;
                try
                {
                    booksFromFile = XDocument.Load(path);
                }
                catch
                {
                    CreatFileScore(path);
                    booksFromFile = XDocument.Load(path);
                }
                IEnumerable<XElement> select = from item in booksFromFile.Descendants(table).Elements("Point") select item;
                foreach (XElement i in select)
                {

                    lsScore.Add(new Score(i.Element("NamePlayer").Value, float.Parse(i.Element("Value").Value)));

                }
                return lsScore;
            }
            catch (System.Xml.XmlException e)
            {
                string err = "Error ReadWrite.LoadScore: " + e.Message;
                UnityEngine.Debug.Log(err);
                //Console.WriteLine(err);
                return null;
            }

        }

        public static bool CreatFileScore(string path)
        {
            try
            {
                XDocument doc = new XDocument(
                                    new XDeclaration("1.0", "utf-8", "yes"),
                                    new XElement("ListScore")                              
                                    );
                doc.Root.SetAttributeValue("ID", "Scorce");
                doc.Save(path);
                return true;
            }
            catch { return false; };
        }
        public static bool addScore(Score a) { return addScore(a.Name, a.Values); }
        public static bool addScore(string name,float value)
        {
           
            if (name.Length > 0 && value >= 0)
            {
                try
                {
                    string pathFile = "ListScore.xml";
                    string rootNode = "ListScore";
                    XDocument docXML;
                    #region check file
                    try
                    {
                        docXML = XDocument.Load(pathFile);

                        if (docXML.Root.Name != rootNode || docXML.Root.Attribute("ID").Value != "Scorce")
                        {
                            throw new Exception("Khong dung dinh dang");
                        }
                    }
                    catch
                    {
                       if(CreatFileScore(pathFile))
                         docXML = XDocument.Load(pathFile);
                        else
                        {
                            // Debug.Log("Game Error");
                            return false;
                        }
                       
                    }
                    #endregion

                    
                    #region update score
                    XElement point = new XElement(
                            new XElement("Point",
                            new XElement("NamePlayer", name),
                            new XElement("Value", value)
                            ));

                        point.SetAttributeValue("ID", DateTime.Now.Ticks);

                        docXML.Root.Add(point);
                        docXML.Save(pathFile);
                    #endregion
                    return true;
                }
                catch (Exception e)
                {
                    UnityEngine.Debug.Log("Error ReadWrite.addScore: " + e.Message);
                    Console.WriteLine("Error addScore: " + e.Message);
                    return false;
                }
            }
            return false;
        }
    }
}
