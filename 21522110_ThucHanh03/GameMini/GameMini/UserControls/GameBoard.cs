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
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Timers;
using System.Threading;
using System.Diagnostics;
using GameMini.AboutBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GameMini.UserControls
{
    public partial class GameBoard : UserControl
    {
        public GameBoard(Dictionary<string, string> data)
        {
            InitializeComponent();
            CreateGame(data);
            setupGame();
        }
        #region Define const path
        const string path_bgGame = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/BackgroundGame";
        const string path_dataGame = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/Game";
        #endregion
        #region Define data game
        string[] Images;
        List<int> OrderImage = new List<int>();
        int timer = 0;
        int timerCurrent = 0;
        #endregion
        private void setupGame()
        {
            img_game.Image = Image.FromFile(Images[OrderImage[0]]);
        }
        private void CreateGame(Dictionary<string, string> data)
        {
            string path_data = path_dataGame + "/" + data["Topic"] + "/" + data["Level"];
            Images = Directory.GetFiles(path_data);
            if (data["NewGame"] == "True")
            {
                Random random = new Random();
                int idx_background = random.Next(1, 7);
                string path_bg = path_bgGame + '/' + idx_background.ToString() + ".jpg";
                pic_bg.Image = Image.FromFile(path_bg);
                while(OrderImage.Count != 5)
                {
                    int rdn = random.Next(0,Images.Length-1);
                    if(!OrderImage.Contains(rdn))
                    {
                        OrderImage.Add(rdn);  
                    }
                }
            }
            else
            {

            }
            if (data["Level"] == "easy")
            {
                timer = 20;
                speaker_hint.Visible = true;
            }
            else if (data["Level"] == "medium")
            {
                timer = 10;
                speaker_hint.Visible= false;
            }
            else if (data["Level"] == "hard")
            {
                timer = 5;
                speaker_hint.Visible = false;
            }
            timerCurrent = timer;
            timer1.Start();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (timerCurrent > 0)
            {
                timerCurrent--;
                timer_show.Text = timerCurrent.ToString();
            }
            else if(OrderImage.Count > 0)
            {
                timer1.Stop();
                OrderImage.RemoveAt(0);
                timerCurrent = timer;
                setupGame();
                timer1.Start();
            }
            else if(OrderImage.Count == 0)
            {
                timer1.Stop();
                EndGame();
            }
        }
        private void EndGame()
        {
            ViewResult viewResult = new ViewResult();
            DialogResult result = viewResult.ShowDialog();
            Control parentControl = this.Parent;
            if (result == DialogResult.OK)
            {
                parentControl.Controls.Remove(this);
            }
            else
            {
                parentControl.Controls.Remove(this);
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;    
            if(btn.Name == "btn_stop")
            {
                Control parentControl = this.Parent;
                if (parentControl != null)
                {
                    parentControl.Controls.Remove(this);
                }
            }
            else if(btn.Name == "btn_finish")
            {
                EndGame();
            }
        }
    }
}
