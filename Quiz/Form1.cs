using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int CorrectA = 0;
        int QuestionID = 0;
        int Score = 0;
        string PromptMessage = "Select the answer!";
        bool GaveA = false;


        public Form1()
        {
            InitializeComponent();
            PromptMessage = "Select the answer!";

            ManageQuiz();
        }

        private void On_ButtonA_Click(object sender, EventArgs e)
        {
            if (CorrectA == 1)
            {
                lblResult.Text = "Correct choice!";
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonD.Enabled = false;
                buttonC.Enabled = false;
                timer1.Start();
                
                

                if (GaveA == false)
                {
                    Score++;
                }

                //QuestionID++;
            }

            else
            {
                lblResult.Text = "Incorrect choice!";
            }

            if (GaveA == false)
            {
                GaveA = true;
            }


            //ManageQuiz();
        }

        private void On_ButtonB_Click(object sender, EventArgs e)
        {
            if (CorrectA == 2)
            {
                lblResult.Text = "Correct choice!";
                buttonC.Enabled = false;
                buttonB.Enabled = false;
                buttonD.Enabled = false;
                buttonA.Enabled = false;
                timer1.Start();
                


                if (GaveA == false)
                {
                    Score++;
                }
                
                //QuestionID++;
            }

            else
            {
                lblResult.Text = "Incorrect choice!";
            }

            if (GaveA == false)
            {
                GaveA = true;
            }


            //ManageQuiz();

        }

        private void On_ButtonC_Click(object sender, EventArgs e)
        {
            if (CorrectA == 3)
            {
                lblResult.Text = "Correct choice!";
                buttonA.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonB.Enabled = false;
                timer1.Start();
                


                if (GaveA == false)
                {
                    Score++;
                }

                //QuestionID++;
            }

            else
            {
                lblResult.Text = "Incorrect choice!";
            }

            if (GaveA == false)
            {
                GaveA = true;
            }


            //ManageQuiz();

        }

        private void On_ButtonD_Click(object sender, EventArgs e)
        {
            if (CorrectA == 4)
            {
                lblResult.Text = "Correct choice!";
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                timer1.Start();


                if (GaveA == false)
                {
                    Score++;
                }

                //QuestionID++;   
            }

            else
            {
                lblResult.Text = "Incorrect choice!";
            }

            if (GaveA == false)
            {
                GaveA = true;
            }


           //ManageQuiz();

        }


        private void ManageQuiz()
        {
            timer1.Stop();
            QuestionID++;
            lblScore.Text = "Score: " + Score;

            Question(1, "Writes Hello World!", "Gives a error: Hello World!", "Writes Hello world", "Plays a mp3: Hello world", 1, "Console.WriteLine(\"Hello World!\")");
            Question(2, "Writes Hello World", "Gives a error!", "Writes Hello world", "Gives you free bitcoin", 2, "Console.WriteLine(Hello World!)");
            Question(3, "Writes 4", "Gives a error!", "Writes 2 + 2", "Gives you free bitcoin", 3, "Console.WriteLine(\"2 + 2\")");

            if (QuestionID == 4)
            {
                //End of the Quiz
                lblFrage.Text = "End of the Quiz!";
                lblResult.Text = "Score: " + Score;
                buttonC.Enabled = false;
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonD.Enabled = false;
            }
        }


        public void Question(int QuestionNumber, string A1, string A2, string A3, string A4, int CorrectBtn, string Frage)
        {
            if (QuestionNumber == QuestionID)
            {
                GaveA = false;

                buttonA.Text = A1;
                buttonB.Text = A2;
                buttonC.Text = A3;
                buttonD.Text = A4;
                lblFrage.Text = Frage;

                CorrectA = CorrectBtn;

                buttonC.Enabled = true;
                buttonA.Enabled = true;
                buttonB.Enabled = true;
                buttonD.Enabled = true;

                lblResult.Text = PromptMessage;

                  
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            ManageQuiz();
        }
    }
}
