using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire_Game_Project
{
    class Question : QuestionBase
    {
        //defing field type string for CorrectAnswer
        private string correctAnswer;
        //defing field type string array for WrongAnswers
        private string[] wrongAnswers = new string[6];
        // override IsCorrect function => return true if the playersanswer == to the correct answer || return false if its  wrong
        public override bool IsCorrect(string answer)
        {
            if (String.Compare(answer, this.CorrectAnswer) == 0)
            {
                return true;
            }
            else { return false; }
        }
        //define Property for string CorrectAnswer
        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
        //define Property for string[] WrongAnswers
        public string[] WrongAnswers
        {
            get { return wrongAnswers; }
            set { wrongAnswers = value; }
        }
        // define Constractor for Class Question 
        // enter vars for  child{ Question} and parent{QuestionBase} classes 
        public Question(string[] wrongAnswers, string correctAnswer, string text, int level) : base(text, level)
        {
            // Assign inputs to fields 
            WrongAnswers = wrongAnswers;
            CorrectAnswer = correctAnswer;

        }



    }
}
