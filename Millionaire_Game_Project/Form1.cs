using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire_Game_Project
{
    public partial class Form1 : Form
    {
        // define object from class{GameManager}
        GameManager gameManager = new GameManager();
        // define object from Class{Question}
        Question question_select;
        
        int index_money = 14;
        // define array of String to use it in ListBox
        string[] lstLadder = {"$1,000,000"
                            ,"$500,000"
                            ,"$250,000"
                            ,"$125,000"
                            ,"$64,000"
                            ,"$32,000"
                            ,"$16,000"
                            ,"$8,000"
                            ,"$4,000"
                            ,"$2,000"
                            ,"$1,000"
                            ,"$500"
                            ,"$300"
                            ,"$200"
                            ,"$100"};
        int next_lvl = 0;
        // flag  for switch function
        bool flag_switch = true;
        
        private void fifty_fiftyFunctionButton()

        {
            
            Fifty_fifty_button.Enabled = false;
            for (int i = 0; i < 2; i++) { 
            if (!(question_select.IsCorrect(Answer_A_button.Text)) && Answer_A_button.Enabled != false)
            {
                
                Answer_A_button.Enabled = false;

            }
            else if (!(question_select.IsCorrect(Answer_B_button.Text)) && Answer_B_button.Enabled != false)
            {
                
                Answer_B_button.Enabled = false;
            }
            else if (!(question_select.IsCorrect(Answer_C_button.Text)) && Answer_C_button.Enabled != false)
            {
                
                Answer_C_button.Enabled = false;
            }
            else if (!(question_select.IsCorrect(Answer_D_button.Text)) && Answer_D_button.Enabled != false)
            {
                
                Answer_D_button.Enabled = false;
            }
                     }

        }
        private void Load(int lvl)
        {
            if (lvl< 15)
            {
                // selet random object (question)
                // we use flag operation
                
                if (flag_switch == false)
                {

                    Question question_select_current = question_select;

                    while (true)
                    {
                        // selet Text in object question 
                        question_select = gameManager.GetRandomQuestion(lvl);


                        // check the last question with the new one => because when we switch question in sometimes will return the same question (random select number between 0,1,2,3,4) 

                        if ((question_select_current != question_select)) // or we can check if both of fields (Text) in object  ((question_select_current.Text != question_select.Text))
                        {

                            flag_switch = true;
                            break;
                        }
                    }

                }
                else {
                    // selet random object {question} 
                    question_select = gameManager.GetRandomQuestion(lvl);
                }
                
                // selet Text in object question 
                
                question_label.Text = question_select.Text;
                // selet level in object question
                level_label.Text = "Level : "+question_select.Level.ToString();
                // select money from player
                money_label.Text = (question_select.Level==1 ? "Money : $0"   :"Money : " + listBox1.Items[index_money+1]);
                
                listBox1.SelectedIndex = index_money;
                // select current money from level
                current_label.Text = "Current : " + listBox1.Items[index_money];
                // get answers
                string[] shuffleAnswers = gameManager.GetShuffledAnswers(question_select);
                // add answers to buttons
                Answer_A_button.Text = shuffleAnswers[0];
                Answer_B_button.Text = shuffleAnswers[1];
                Answer_C_button.Text = shuffleAnswers[2];
                Answer_D_button.Text = shuffleAnswers[3];

                Answer_A_button.Enabled = true;
                Answer_B_button.Enabled = true;
                Answer_C_button.Enabled = true;
                Answer_D_button.Enabled = true;
            }
            else
            {
                MessageBox.Show("You Reached the top prize !!!!");
                resetGame();

            }



        }
        public Form1()
        {
            this.Size = new Size(899, 576);

            InitializeComponent();
            
            gameManager.LoadQuestions("questions.txt");
            Switch_button.ForeColor = Color.White;
            Answer_A_button.ForeColor = Color.White;
            Answer_B_button.ForeColor = Color.White;
            Answer_C_button.ForeColor = Color.White;
            Answer_D_button.ForeColor = Color.White;
            Fifty_fifty_button.ForeColor = Color.White;
            Withdraw_button.ForeColor = Color.White;
            Startgame_button.ForeColor = Color.White;
            

            Answer_A_button.Enabled = false;
            Answer_B_button.Enabled = false;
            Answer_C_button.Enabled = false;
            Answer_D_button.Enabled = false;
            Switch_button.Enabled = false;
            Fifty_fifty_button.Enabled = false;
            Withdraw_button.Enabled = false;


        }

        private void startgame_button_Click(object sender, EventArgs e)
        {
            Lis_add_items(lstLadder);
            Load(next_lvl);
            
            Switch_button.Enabled = true;
            Fifty_fifty_button.Enabled = true;
            Withdraw_button.Enabled = true;
            Startgame_button.Enabled = false;

        }

        private void answer_A_button_Click(object sender, EventArgs e)
        {
            string message = String.Format("Is '{0}' your final answer?", Answer_A_button.Text);
            DialogResult result = MessageBox.Show(message, "Final Answer", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (question_select.IsCorrect(Answer_A_button.Text))
                {
                    if (next_lvl < 15)
                    {
                        
                        message = String.Format(" Correct! you won {0} ", listBox1.Items[index_money]);
                        MessageBox.Show(message);
                        
                        index_money--;
                        next_lvl++;
                        Load(next_lvl);
                    }


                }
                else
                {
                    Losefunction();
                }
            }
            else
            {
                
            }

        }

        private void answer_B_button_Click(object sender, EventArgs e)
        {

            string message = String.Format("Is '{0}' your final answer?", Answer_B_button.Text);
            DialogResult result = MessageBox.Show(message, "Final Answer", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (question_select.IsCorrect(Answer_B_button.Text))
                {
                    if (next_lvl < 15)
                    {
                        
                        message = String.Format(" Correct! you won {0} ", listBox1.Items[index_money]);
                        MessageBox.Show(message);
                        
                        index_money--;
                        next_lvl++;
                        Load(next_lvl);
                    }


                }
                else
                {
                    Losefunction();
                }
            }
            else
            {

            }
        }

        private void answer_C_button_Click(object sender, EventArgs e)
        {
            string message = String.Format("Is '{0}' your final answer?", Answer_C_button.Text);
            DialogResult result = MessageBox.Show(message, "Final Answer", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (question_select.IsCorrect(Answer_C_button.Text))
                {
                    if (next_lvl < 15)
                    {
                        
                        message = String.Format(" Correct! you won {0} ", listBox1.Items[index_money]);
                        MessageBox.Show(message);
                       
                        index_money--;

                        next_lvl++;
                        Load(next_lvl);
                    }


                }
                else
                {
                    Losefunction();
                }
            }
            else
            {

            }
        }

        private void answer_D_button_Click(object sender, EventArgs e)
        {

            string message = String.Format("Is '{0}' your final answer?", Answer_D_button.Text);
            DialogResult result = MessageBox.Show(message, "Final Answer", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (question_select.IsCorrect(Answer_D_button.Text))
                {
                    if (next_lvl < 15)
                    {
                        
                        message = String.Format(" Correct! you won {0} ", listBox1.Items[index_money]);
                        MessageBox.Show(message);
                        
                        index_money--;
                        next_lvl++;
                        Load(next_lvl);
                    }


                }
                else
                {
                    Losefunction();
                }
            }
            else
            {

            }
        }

        private void switch_button_Click(object sender, EventArgs e)
        {
            
            Switch_button.Enabled = false;
            
            flag_switch = false;
            Load(next_lvl);
        }

        private void fifty_fifty_button_Click(object sender, EventArgs e)
        {
            fifty_fiftyFunctionButton();
        }

        private void Lis_add_items(string [] items)
        {
            for(int i = 0; i<items.Length ; i++) {

                
                listBox1.Items.Add(items[i]);

            }
            
        }
        private void Withdrawfunction()
        {
            string message = String.Format("You will withdraw with {0}\nIs this your final decision?", (question_select.Level == 1 ? "$0" : listBox1.Items[index_money + 1]));
            DialogResult result = MessageBox.Show(message, "Withdraw - Final Decision", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                message = String.Format("You decided to walk away with {0}, Thanks for playing!", (question_select.Level == 1 ? "$0" : listBox1.Items[index_money + 1]));
                MessageBox.Show(message);
                resetGame();
            }
            else
            {
                
            }
        }

        private void resetGame()
        {
            string message = String.Format("Play again ?");
            DialogResult result = MessageBox.Show(message, "play again", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                next_lvl = 0;
                
                index_money = 14;
                Switch_button.Enabled = true;
                Fifty_fifty_button.Enabled = true;
                
                Load(next_lvl);


            }
            else { this.Close(); }
            
        }

        private void Losefunction()
        {
            if(question_select.Level <= 5)
            {
                MessageBox.Show("X Wrong answer! Game over,\nYou earned $0");
                resetGame();
            }
            else if (question_select.Level > 5 && question_select.Level <= 7)
            {
                MessageBox.Show("X Wrong answer! Game over,\nYou earned $500 ");
                resetGame();
            }
            else if (question_select.Level > 7 && question_select.Level <=10)
            {
                MessageBox.Show("X Wrong answer! Game over,\nYou earned $2,000 ");
                resetGame();
            }
            else if (question_select.Level > 10 )
            {
                MessageBox.Show("X Wrong answer! Game over,\nYou earned $16,000 ");
                resetGame();
            }

        }

        private void Withdraw_button_Click(object sender, EventArgs e)
        {
            Withdrawfunction();
        }
    }
}
