using GameMini.AboutBox;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMini.UserControls
{
    public partial class game : UserControl
    {
        public game()
        {
            InitializeComponent();
        }
        #region
        string topic = "Animals";
        string level = "easy";
        #endregion
        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null && parentForm is MainForm mainForm)
            {
                mainForm.FunctionParent("back_game");
            }
        }

        public void StartGame(bool newGame)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("NewGame", newGame.ToString());
            data.Add("Topic", topic);
            data.Add("Level", level);
            GameBoard gameBoard = new GameBoard(data);
            Controls.Add(gameBoard);
            gameBoard.BringToFront();
        }
        private void button_Game_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if(btn.Name == "btn_rule")
            {
                AboutBox1 rule = new AboutBox1();
                rule.ShowDialog();  
            }
            if(btn.Name == "btn_start")
            {
                StartGame(true);  
            }
            if(btn.Name == "btn_continue")
            {
                StartGame(false);
            }
        }

        private void btn_radio_click(object sender, EventArgs e)
        {
            Guna2CustomCheckBox cb = sender as Guna2CustomCheckBox;
            if(cb.Name == "ck_animals")
            {
                ck_animals.Checked = true;
                ck_jobs.Checked = false;
                ck_vehicles.Checked = false;
                topic = "Animals";
            }
            else if(cb.Name == "ck_jobs")
            {
                ck_animals.Checked = false;
                ck_jobs.Checked = true;
                ck_vehicles.Checked = false;
                topic = "Jobs";
            }
            else if(cb.Name == "ck_vehicles")
            {
                ck_animals.Checked = false;
                ck_jobs.Checked = false;
                ck_vehicles.Checked = true;
                topic = "Vehicles";
            }

            if (cb.Name == "ck_easy")
            {
                ck_easy.Checked = true;
                ck_medium.Checked = false;
                ck_hard.Checked = false;
                level = "easy";
            }
            else if (cb.Name == "ck_medium")
            {
                ck_easy.Checked = false;
                ck_medium.Checked = true;
                ck_hard.Checked = false;
                level = "medium";
            }
            else if (cb.Name == "ck_hard")
            {
                ck_easy.Checked = false;
                ck_medium.Checked = false;
                ck_hard.Checked = true;
                level = "hard";
            }
        }
    }
}
