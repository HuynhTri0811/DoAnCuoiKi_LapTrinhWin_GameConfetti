using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server.ReadFile
{
    public class WriteFile
    {
        public static bool AddQuestion(string path,Question question)
        {
            try
            {
                XDocument document = XDocument.Load(path);
                XElement newQuestion = new XElement(
                    "Question",
                    new XElement("_contentQuestion", question._contentQuestion),
                    new XElement("_a_Answer", question._a_Answer),
                    new XElement("_b_Answer",question._b_Answer),
                    new XElement("_c_Answer", question._c_Answer),
                    new XElement("_d_Answer",question._d_Answer),
                    new XElement("RightAnswer",question.RightAnswer)
                    );
                newQuestion.SetAttributeValue("ID", question.ID);
                document.Element("Questions").Add(newQuestion);
                document.Save(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteQuestion(string path,Question questionDelete)
        {
            try
            {
                XDocument getXML = XDocument.Load(path);
                
                XElement getQuestion = getXML.Descendants("Question").Where(question
                                                                           => question.Attribute("ID").Value.Equals(questionDelete.ID.ToString())
                                                                            ).FirstOrDefault();
                
                getQuestion.Remove();
                getXML.Save(path);
                
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
