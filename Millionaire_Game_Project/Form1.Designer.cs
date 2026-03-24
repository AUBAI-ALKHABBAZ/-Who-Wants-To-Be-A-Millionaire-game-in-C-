
namespace Millionaire_Game_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.question_label = new System.Windows.Forms.Label();
            this.Startgame_button = new System.Windows.Forms.Button();
            this.level_label = new System.Windows.Forms.Label();
            this.money_label = new System.Windows.Forms.Label();
            this.current_label = new System.Windows.Forms.Label();
            this.Fifty_fifty_button = new System.Windows.Forms.Button();
            this.Switch_button = new System.Windows.Forms.Button();
            this.Withdraw_button = new System.Windows.Forms.Button();
            this.Answer_A_button = new System.Windows.Forms.Button();
            this.Answer_B_button = new System.Windows.Forms.Button();
            this.Answer_C_button = new System.Windows.Forms.Button();
            this.Answer_D_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.BackColor = System.Drawing.Color.Purple;
            this.question_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.question_label.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_label.ForeColor = System.Drawing.Color.Gold;
            this.question_label.Location = new System.Drawing.Point(154, 120);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(349, 33);
            this.question_label.TabIndex = 0;
            this.question_label.Text = "Question will appear here";
            // 
            // Startgame_button
            // 
            this.Startgame_button.BackColor = System.Drawing.Color.Purple;
            this.Startgame_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Startgame_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Startgame_button.Location = new System.Drawing.Point(755, 26);
            this.Startgame_button.Name = "Startgame_button";
            this.Startgame_button.Size = new System.Drawing.Size(114, 80);
            this.Startgame_button.TabIndex = 1;
            this.Startgame_button.Text = "Start Game";
            this.Startgame_button.UseVisualStyleBackColor = false;
            this.Startgame_button.Click += new System.EventHandler(this.startgame_button_Click);
            // 
            // level_label
            // 
            this.level_label.AutoSize = true;
            this.level_label.BackColor = System.Drawing.Color.Purple;
            this.level_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.level_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.level_label.ForeColor = System.Drawing.Color.Gold;
            this.level_label.Location = new System.Drawing.Point(12, 26);
            this.level_label.Name = "level_label";
            this.level_label.Size = new System.Drawing.Size(97, 26);
            this.level_label.TabIndex = 2;
            this.level_label.Text = "Level : 0";
            // 
            // money_label
            // 
            this.money_label.AutoSize = true;
            this.money_label.BackColor = System.Drawing.Color.Purple;
            this.money_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.money_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.money_label.ForeColor = System.Drawing.Color.Gold;
            this.money_label.Location = new System.Drawing.Point(242, 26);
            this.money_label.Name = "money_label";
            this.money_label.Size = new System.Drawing.Size(124, 26);
            this.money_label.TabIndex = 3;
            this.money_label.Text = "Money : 0$";
            // 
            // current_label
            // 
            this.current_label.AutoSize = true;
            this.current_label.BackColor = System.Drawing.Color.Purple;
            this.current_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.current_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.current_label.ForeColor = System.Drawing.Color.YellowGreen;
            this.current_label.Location = new System.Drawing.Point(506, 26);
            this.current_label.Name = "current_label";
            this.current_label.Size = new System.Drawing.Size(134, 26);
            this.current_label.TabIndex = 4;
            this.current_label.Text = "Current : $0";
            // 
            // Fifty_fifty_button
            // 
            this.Fifty_fifty_button.BackColor = System.Drawing.Color.Purple;
            this.Fifty_fifty_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Fifty_fifty_button.Location = new System.Drawing.Point(154, 231);
            this.Fifty_fifty_button.Name = "Fifty_fifty_button";
            this.Fifty_fifty_button.Size = new System.Drawing.Size(127, 34);
            this.Fifty_fifty_button.TabIndex = 5;
            this.Fifty_fifty_button.Text = "50:50";
            this.Fifty_fifty_button.UseVisualStyleBackColor = false;
            this.Fifty_fifty_button.Click += new System.EventHandler(this.fifty_fifty_button_Click);
            // 
            // Switch_button
            // 
            this.Switch_button.BackColor = System.Drawing.Color.Purple;
            this.Switch_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Switch_button.Location = new System.Drawing.Point(506, 231);
            this.Switch_button.Name = "Switch_button";
            this.Switch_button.Size = new System.Drawing.Size(120, 34);
            this.Switch_button.TabIndex = 6;
            this.Switch_button.Text = "Switch";
            this.Switch_button.UseVisualStyleBackColor = false;
            this.Switch_button.Click += new System.EventHandler(this.switch_button_Click);
            // 
            // Withdraw_button
            // 
            this.Withdraw_button.BackColor = System.Drawing.Color.Purple;
            this.Withdraw_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Withdraw_button.Location = new System.Drawing.Point(316, 231);
            this.Withdraw_button.Name = "Withdraw_button";
            this.Withdraw_button.Size = new System.Drawing.Size(161, 33);
            this.Withdraw_button.TabIndex = 7;
            this.Withdraw_button.Text = "Withdraw";
            this.Withdraw_button.UseVisualStyleBackColor = false;
            this.Withdraw_button.Click += new System.EventHandler(this.Withdraw_button_Click);
            // 
            // Answer_A_button
            // 
            this.Answer_A_button.BackColor = System.Drawing.Color.Purple;
            this.Answer_A_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Answer_A_button.Location = new System.Drawing.Point(114, 286);
            this.Answer_A_button.Name = "Answer_A_button";
            this.Answer_A_button.Size = new System.Drawing.Size(220, 69);
            this.Answer_A_button.TabIndex = 8;
            this.Answer_A_button.Text = "Answer A";
            this.Answer_A_button.UseVisualStyleBackColor = false;
            this.Answer_A_button.Click += new System.EventHandler(this.answer_A_button_Click);
            // 
            // Answer_B_button
            // 
            this.Answer_B_button.BackColor = System.Drawing.Color.Purple;
            this.Answer_B_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Answer_B_button.Location = new System.Drawing.Point(465, 286);
            this.Answer_B_button.Name = "Answer_B_button";
            this.Answer_B_button.Size = new System.Drawing.Size(222, 69);
            this.Answer_B_button.TabIndex = 9;
            this.Answer_B_button.Text = "Answer B";
            this.Answer_B_button.UseVisualStyleBackColor = false;
            this.Answer_B_button.Click += new System.EventHandler(this.answer_B_button_Click);
            // 
            // Answer_C_button
            // 
            this.Answer_C_button.BackColor = System.Drawing.Color.Purple;
            this.Answer_C_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Answer_C_button.Location = new System.Drawing.Point(114, 413);
            this.Answer_C_button.Name = "Answer_C_button";
            this.Answer_C_button.Size = new System.Drawing.Size(220, 76);
            this.Answer_C_button.TabIndex = 10;
            this.Answer_C_button.Text = "Answer C";
            this.Answer_C_button.UseVisualStyleBackColor = false;
            this.Answer_C_button.Click += new System.EventHandler(this.answer_C_button_Click);
            // 
            // Answer_D_button
            // 
            this.Answer_D_button.BackColor = System.Drawing.Color.Purple;
            this.Answer_D_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Answer_D_button.Location = new System.Drawing.Point(465, 413);
            this.Answer_D_button.Name = "Answer_D_button";
            this.Answer_D_button.Size = new System.Drawing.Size(222, 76);
            this.Answer_D_button.TabIndex = 11;
            this.Answer_D_button.Text = "Answer D";
            this.Answer_D_button.UseVisualStyleBackColor = false;
            this.Answer_D_button.Click += new System.EventHandler(this.answer_D_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Purple;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Olive;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(755, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 292);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::Millionaire_Game_Project.Properties.Resources.Layout_game;
            this.ClientSize = new System.Drawing.Size(881, 529);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Answer_D_button);
            this.Controls.Add(this.Answer_C_button);
            this.Controls.Add(this.Answer_B_button);
            this.Controls.Add(this.Answer_A_button);
            this.Controls.Add(this.Withdraw_button);
            this.Controls.Add(this.Switch_button);
            this.Controls.Add(this.Fifty_fifty_button);
            this.Controls.Add(this.current_label);
            this.Controls.Add(this.money_label);
            this.Controls.Add(this.level_label);
            this.Controls.Add(this.Startgame_button);
            this.Controls.Add(this.question_label);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Who wants to Be a Millionaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Button Startgame_button;
        private System.Windows.Forms.Label level_label;
        private System.Windows.Forms.Label money_label;
        private System.Windows.Forms.Label current_label;
        private System.Windows.Forms.Button Fifty_fifty_button;
        private System.Windows.Forms.Button Switch_button;
        private System.Windows.Forms.Button Withdraw_button;
        private System.Windows.Forms.Button Answer_A_button;
        private System.Windows.Forms.Button Answer_B_button;
        private System.Windows.Forms.Button Answer_C_button;
        private System.Windows.Forms.Button Answer_D_button;
        private System.Windows.Forms.ListBox listBox1;
    }
}

