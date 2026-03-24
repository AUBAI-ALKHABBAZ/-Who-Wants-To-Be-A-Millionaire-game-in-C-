using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire_Game_Project
{
    class GameManager
    {
        // define 2D array [5, 15] => 5 questions and 15 levels
        //  this 2D array  containts objects of Type Class (Question)
        
        private Question[,] QuestionObjectArray = new Question[5, 15];
        // define Random object for GetRandomQuestion and GetShuffledAnswers functions
        private Random numberRandom = new Random();


        //GetRandomQuestion(int)=>object /this function returns a random object from QuestionObjectArray
        public Question GetRandomQuestion(int lvl)
        {
            //numberRandom.Next(0, 5) / becuase we have 5 questions to select (0,1,2,3,4)
            return QuestionObjectArray[numberRandom.Next(0, 5), lvl];
        }

        //GetShuffledAnswers(object) =>1D String Arrray /this function returns an array of string from entered object that return from function |public GetRandomQuestion(int lvl)|
        public string[] GetShuffledAnswers(Question q)
        {
            string[] new_array = new string[4];
            int i = 0;
            // select 4  random values from string of 6 values
            while (i < 4)
            {
                
                int x = numberRandom.Next(0, 6);
                //6 string in array  to select(0, 1, 2, 3, 4,5)
                
                //  check for dublicate of items
                if (q.WrongAnswers[x] != new_array[0] && q.WrongAnswers[x] != new_array[1] && q.WrongAnswers[x] != new_array[2])
                {
                    new_array[i] = q.WrongAnswers[x];
                    
                    i++;
                    

                }

            }
            //4 string in array  to select(0, 1, 2, 3)
            // select random index to assign correct answer in array 
            new_array[numberRandom.Next(0, 4)] = q.CorrectAnswer;

            return new_array;

        }

        //LoadQuestions(path) => generate question objects and add to QuestionObjectArray that content 5 objects in each level (0,1,2,3,.....14)
        public void LoadQuestions(string path)
        {
            string[,] questionsArrayInLevel = new string[5, 15];
            int levelNumber = 0;
            string Line;
            string fname = path;
            string[] lines = System.IO.File.ReadAllLines(fname);
            int j = 0;
            int o = 0;
            

            for (int k = 0; k <= lines.Length - 1; k++)
            {
                try
                {
                    Line = lines[k];
                    if (lines[k][0] == '#')
                    {
                        if (Line.Split('#')[1].Length < 7)
                        {
                            levelNumber = int.Parse(Line.Split('#')[1].Last().ToString());

                        }
                        else if (Line.Split('#')[1].Length == 7)
                        {
                            string lastTwoChars = Line.Split('#')[1].Substring(Line.Split('#')[1].Length - 2);
                            levelNumber = int.Parse(lastTwoChars);

                        }

                    }
                    else if (lines[k][0] == ' ')
                    {
                        Console.WriteLine("this is a space.........");
                    }
                    else if (lines[k][0] == 'W' || lines[k][0] == 'H')
                    {
                        string[] wrongAnswersArray = new string[6];
                        questionsArrayInLevel[j, o] = Line.Split(';')[0];
                        string correctAnswer = Line.Split(';')[1];

                        for (int i = 0; i < wrongAnswersArray.Length; i++)
                        {
                            wrongAnswersArray[i] = Line.Split(';')[i + 2];

                        }
                        
                        //define object type Question to add into 2d array
                        Question question = new Question(wrongAnswersArray, correctAnswer, questionsArrayInLevel[j, o], levelNumber);
                        QuestionObjectArray[j, o] = question;
                        

                        j++;

                        if (j == 5)
                        {
                            // 5 Questions in each Level

                            //j is a counter for Questions in level O
                            j = 0;
                            //O is a counter for Levels => When the number of j == 5 => O++
                            
                            o++;

                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }



            }

        }
    }
}
