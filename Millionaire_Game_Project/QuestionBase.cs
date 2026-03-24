using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire_Game_Project
{
    // define abstract class 
    internal abstract class QuestionBase
    {
        // define fields Text of Question and the level of it 
        private string text;
        private int level;

        //define Property for string Text
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        //define Property for int Level
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        // define Constractor for ABS class {QuestionBase}
        public QuestionBase(string text, int level)
        {
            Text = text;
            Level = level;
        }
        //define abstract function to use in Class{Question}
        public abstract bool IsCorrect(string answer);
    }
}
