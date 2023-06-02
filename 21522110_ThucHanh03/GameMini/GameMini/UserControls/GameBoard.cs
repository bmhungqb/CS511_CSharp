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
using System.Collections;
using System.Speech.Synthesis;
using WMPLib;
namespace GameMini.UserControls
{
    public partial class GameBoard : UserControl
    {
        public GameBoard(Dictionary<string, string> data)
        {
            InitializeComponent();
            CreateGame(data);
            setupGame();
            dataGame = data;
        }
        #region Define const path
        const string path_bgGame = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/BackgroundGame";
        const string path_dataGame = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/Game";
        #endregion
        #region Define data game
        Dictionary<string, string> resultFinal = new Dictionary<string, string>();
        string[] Images;
        List<string> ExactResult = new List<string>();
        List<int> OrderImage = new List<int>();
        int timer = 0;
        int timerCurrent = 0;
        int currentQuestion = 0;
        int resPoint = 0;
        int resTime = 0;
        Dictionary<string, string> dataGame;
        #endregion
        #region define speaker
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        #endregion
        private void setupGame()
        {
            updateResView();
            img_game.Image = Image.FromFile(Images[OrderImage[currentQuestion]]);
            timer1.Start();
        }
        private void CreateGame(Dictionary<string, string> data)
        {
            string path_data = path_dataGame + "/" + data["Topic"] + "/" + data["Level"];
            Images = Directory.GetFiles(path_data);
            foreach(string i in  Images)
            {
                string res = i.Split('/')[15].Split('\\')[1].Split('.')[0];
                ExactResult.Add(res);
            }
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
        }
        private void updateResView()
        {
            lb_questionview.Text = "Question: " + (currentQuestion+1).ToString() + "/5";
            lb_scoreview.Text = "Score: " + resPoint.ToString();
        }
        private void submit_result()
        {
            timer1.Stop();
            //Check result and update point

            if(tb_typeRes.Text.ToLower() == ExactResult[OrderImage[currentQuestion]].ToLower())
            {
                resPoint += 10;
                media_sound_res.URL = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/GameMini/Resources/drive-download-20230529T014147Z-001/correct_Sound.mp3";
                media_sound_res.settings.volume = 100;
                media_sound_res.Visible = false;
            }
            else
            {
                resPoint += 0;
                media_sound_res.URL = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/GameMini/Resources/drive-download-20230529T014147Z-001/wrong_Sound.mp3"; ;
                media_sound_res.Visible = false;
            }
            // update update result time
            resTime += timer - timerCurrent;
            // check: continue or finish
            tb_typeRes.Text = "";
            if (currentQuestion < 4)
            {
                timerCurrent = timer;
                currentQuestion++;
                setupGame();
            }
            else
            {
                EndGame();
            }
        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (timerCurrent > 0)
            {
                timerCurrent--;
                timer_show.Text = timerCurrent.ToString();
            }
            else if(timerCurrent == 0)
            {
                submit_result();
            }
        }
        private void resetGame()
        {
            ExactResult.Clear();
            OrderImage.Clear();
            timer = 0;
            timerCurrent = 0;
            currentQuestion = 0;
            resPoint = 0;
            resTime = 0;
            CreateGame(dataGame);
            setupGame();
        }
        private void EndGame()
        {
            resultFinal.Clear();
            resultFinal.Add("Point", resPoint.ToString());
            resultFinal.Add("Time", resTime.ToString());
            resultFinal.Add("Topic", dataGame["Topic"]);
            resultFinal.Add("Level", dataGame["Level"]);
            Control parentControl = this.Parent;
            ViewResult viewResult = new ViewResult(resultFinal);
            DialogResult result = viewResult.ShowDialog();
            if (result == DialogResult.OK)
            {
                resetGame();
            }
            else
            {
                parentControl.Controls.Remove(this);
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            timer1.Stop();
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

        private void submit_click(object sender, EventArgs e)
        {
            submit_result();
        }

        private void speaker_hint_Click(object sender, EventArgs e)
        {
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            // Set the rate of speech
            synthesizer.Rate = 0; // Default value is 0, range: -10 to 10

            // Set the volume
            synthesizer.Volume = 100; // Default value is 100, range: 0 to 100
            synthesizer.Speak(ExactResult[OrderImage[currentQuestion]]);
        }
    }
}
