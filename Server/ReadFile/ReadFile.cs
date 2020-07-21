using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ReadFile
{
    public class ReadFile
    {
        public static List<Question> LoadQuestionData(string path)
        {
            List<Question> listQuestion = new List<Question>();
            if (String.IsNullOrEmpty(path))
            {
                return null;
            }
            try
            {
                DataSet dataSetQuestion = new DataSet();
                dataSetQuestion.ReadXml(path); // read file in path

                DataTable dataTableQuestion = new DataTable();
                dataTableQuestion = dataSetQuestion.Tables["Question"];

                foreach(DataRow dataRow in dataTableQuestion.Rows)
                {
                    int ID = Int16.Parse(dataRow["ID"].ToString());
                    string _contentQuestion = dataRow["_contentQuestion"].ToString();
                    string _a_Answer = dataRow["_a_Answer"].ToString();
                    string _b_Answer = dataRow["_b_Answer"].ToString();
                    string _c_Answer = dataRow["_c_Answer"].ToString();
                    string _d_Answer = dataRow["_d_Answer"].ToString();
                    string RightAnswer = dataRow["RightAnswer"].ToString();

                    Question question = new Question(ID,_contentQuestion,_a_Answer,_b_Answer,_c_Answer,_d_Answer,RightAnswer);

                    listQuestion.Add(question);
                }
                
                return listQuestion;
            }
            catch
            {
                return null;
            }
        }

        public static Question GetQuestionLast(string path)
        {
            List<Question> listQuestion =  LoadQuestionData(path);

            Question question = listQuestion.ElementAt(listQuestion.Count - 1);

            return question;
        }
    }
}
