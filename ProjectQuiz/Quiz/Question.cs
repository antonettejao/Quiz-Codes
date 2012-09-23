using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz
{
    class Question
    {
        string question;
        string[] selection;
        int answer;

        public Question()
        {
            question = "";
            selection = new string[4];
            answer = 0;
        }

        public void setQuestion(string ques)
        {
            question = ques;
        }

        public void setSelections(string option1, string option2, string option3, string option4)
        {
            selection[0] = option1;
            selection[1] = option2;
            selection[2] = option3;
            selection[3] = option4;


        }

        public void setAnswer(int index)
        {
            answer = index;
        }

        public string[] getSelections()
        {
            return selection;
        }

        public string getQuestion()
        {
            return question;
        }

       
    }
}
