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
namespace GameMini.UserControls
{
    public partial class GameBoard : UserControl
    {
        public GameBoard(Dictionary<string, string> data)
        {
            InitializeComponent();
            CreateGame(data);
        }
        #region
        const string path_bgGame = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/BackgroundGame";
        const string path_dataGame = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/Game";
        int time = 10;
        #endregion
        private void setupGame(string path)
        {
            img_game.Image = Image.FromFile(path);
        }
        private void CreateGame(Dictionary<string, string> data)
        {
            string path_data = path_dataGame + "/" + data["Topic"] + "/" + data["Level"];
            string[] images = Directory.GetFiles(path_data);
            List<int> listGame = new List<int>();
            if (data["NewGame"] == "True")
            {
                Random random = new Random();
                int idx_background = random.Next(1, 7);
                string path_bg = path_bgGame + '/' + idx_background.ToString() + ".jpg";
                pic_bg.Image = Image.FromFile(path_bg);
                while(listGame.Count != 5)
                {
                    int rdn = random.Next(0,images.Length-1);
                    if(!listGame.Contains(rdn))
                    {
                        listGame.Add(rdn);  
                    }
                }
            }
            else
            {

            }
                setupGame(images[listGame[0]]);
            //for (int i = 0; i < listGame.Count; i++)
            //{
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();

            //    while (stopwatch.Elapsed.TotalSeconds < 10)
            //    {
            //    }

            //    stopwatch.Stop();
            //}
        }
        private void timer_tick(object sender, EventArgs e)
        {
            time--;
            timer_show.Text = time.ToString(); 
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

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
                Control parentControl = this.Parent;
                if(parentControl != null)
                {
                    parentControl.Controls.Remove(this);
                }
            }
        }
    }
}
