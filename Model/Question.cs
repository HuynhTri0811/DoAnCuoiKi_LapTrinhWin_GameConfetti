using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Question
    {
        private string _rightAnswer;
        public int ID { get; set; }
        public string _contentQuestion { get; set; }
        public string _a_Answer { get; set; }
        public string _b_Answer { get; set; }
        public string _c_Answer { get; set; }
        public string _d_Answer { get; set; }

        public string RightAnswer
        {
            set
            {
                if (value == "A" || value == "B" || value == "C" || value == "D")
                {
                    _rightAnswer = value;
                }
                else
                {
                    _rightAnswer = "0";
                }
            }
            get { return _rightAnswer; }
        }


        public Question(int ID, string ContentQuestion, string A_Answer, string B_Answer, string C_Answer, string D_Answer, string RightAnswer)
        {
            this.ID = ID;
            this._contentQuestion = ContentQuestion;
            this._a_Answer = A_Answer;
            this._b_Answer = B_Answer;
            this._c_Answer = C_Answer;
            this._d_Answer = D_Answer;
            this.RightAnswer = RightAnswer;
        }

        public Question()
        {

        }
    }
}
