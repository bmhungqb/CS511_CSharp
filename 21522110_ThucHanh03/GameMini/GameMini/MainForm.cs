using AxWMPLib;
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
            game1.Visible = false;
        }
        public void FunctionParent(string id)
        {
            if(id == "back_game")
            {
                game1.Visible = false;
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
            }
            else
            {
                media.Ctlcontrols.play();
            }
        }

        private void btn_playGame_Click_1(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if (btn.Name == "btn_playGame")
            {
                game1.Visible = true;
                pnl_Home.Visible = false;
            }
        }
    }
}
