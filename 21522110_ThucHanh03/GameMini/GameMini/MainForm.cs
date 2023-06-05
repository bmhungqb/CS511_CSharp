using AxWMPLib;
using GameMini.AboutBox;
using GameMini.UserControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMini
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainForm_Load();
        }
        private void MainForm_Load()
        {
            // Set the URL property of the Windows Media Player control
            media.URL = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/GameMini/Resources/drive-download-20230529T014147Z-001/nhacgame01.mp3";
            media.settings.setMode("loop", true);
        }
        public void FunctionParent(string id)
        {
            if(id == "back_game")
            {
                gamePage.Visible = false;
                pnl_Home.Visible = true;
            }
            else if (id == "back_scoreboard")
            {
                scoreBoard.Visible = false;
                pnl_Home.Visible = true;
            }
            else if(id== "back_dictionary")
            {
                dictionary.Visible = false;
                pnl_Home.Visible = true;
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void speaker_bg_Click_1(object sender, EventArgs e)
        {
            if (media.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                media.Ctlcontrols.pause();
                speaker_bg.Image = Image.FromFile("C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/GameMini/Resources/icons/2203527_mute_sound_speaker_volume_icon.png");
            }
            else
            {
                media.Ctlcontrols.play();
                speaker_bg.Image = Image.FromFile("C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/GameMini/Resources/icons/2203528_lound_sound_speaker_volume_icon (1).png");
            }
        }

        private void btn_gameBoard(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if (btn.Name == "btn_playGame")
            {
                gamePage.Visible = true;
                gamePage.BringToFront();
                //pnl_Home.Visible = false;
                scoreBoard.Visible = false;

            }
            else if(btn.Name == "btn_Ranking")
            {
                scoreBoard.UpdateStateFromScoreBoard();
                scoreBoard.Visible = true;
                scoreBoard.BringToFront();
                //pnl_Home.Visible = false;
                gamePage.Visible = false;
            }
            else if(btn.Name == "btn_dictionary")
            {
                dictionary.Visible = true;
                dictionary.BringToFront();

            }
            else if(btn.Name == "btn_setting")
            {
                SettingBoard settingBoard = new SettingBoard(media.settings.volume);
                settingBoard.FunctionCalled += SettingBoard_FunctionCalled;
                settingBoard.BringToFront();
                settingBoard.Show();
            }
            else if(btn.Name == "btn_exit")
            {
                this.Close();
            }
        }
        private void SettingBoard_FunctionCalled(int argument)
        {
            HanldeChangeVolumeFromParent(argument); // Call the desired function in the parent form with the provided argument
        }

        public void HanldeChangeVolumeFromParent(int argument)
        {
            media.settings.volume = argument;
        }
    }
}
