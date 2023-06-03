using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Guna.UI2.WinForms;
using GameMini.AboutBox;

namespace GameMini.UserControls
{
    public partial class Dictionary : UserControl
    {
        public Dictionary()
        {
            InitializeComponent();
            LoadTopics();
            ViewDictionary(cb_topic.SelectedItem.ToString());
        }
        #region define path
        const string path_dic = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/Dictionary";
        #endregion
        #region define speaker
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        #endregion
        private void LoadTopics()
        {
            List<string> fileTopic = new List<string>();
            string[] filePathTopic = Directory.GetDirectories(path_dic);
            foreach(string filePath in filePathTopic)
            {
                fileTopic.Insert(0,Path.GetFileName(filePath));
            }
            foreach (string topic in fileTopic) 
            {
                cb_topic.Items.Add(topic);
            }
            cb_topic.SelectedIndex = 0;
        }
        private void ViewDictionary(string topic)
        {
            dataGridDictionary.Rows.Clear();
            string path_topic = path_dic + '/' + topic;
            string[] Images = Directory.GetFiles(path_topic);
            string path_sound = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/GameMini/Resources/icons/2203528_lound_sound_speaker_volume_icon.png";
            string path_delete = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/GameMini/Resources/icons/9004715_cross_delete_remove_cancel_icon.png";
            foreach (string image in Images)
            {
                string text = image.Split('/')[14].Split('\\')[1].Split('.')[0];
                dataGridDictionary.Rows.Add(Image.FromFile(image),text, Image.FromFile(path_sound), Image.FromFile(path_delete));
            }
            dataGridDictionary.ColumnHeadersHeight = 40;
            dataGridDictionary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            dataGridDictionary.Rows.Clear();
            Form parentForm = this.FindForm();
            if (parentForm != null && parentForm is MainForm mainForm)
            {
                mainForm.FunctionParent("back_dictionary");
            }
        }

        private void dataGridDictionary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string txt = dataGridDictionary.Rows[e.RowIndex].Cells["Text"].Value?.ToString();
            string path_image = path_dic + '/' + cb_topic.SelectedItem.ToString() + "/" + txt + ".png";
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                DialogResult res =  MessageBox.Show("Are you sure ?", "Delete", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridDictionary.Rows[e.RowIndex];
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value is IDisposable disposableValue)
                        {
                            disposableValue.Dispose();
                        }
                    }
                    row.Dispose();
                    dataGridDictionary.Rows.RemoveAt(e.RowIndex);
                    if(File.Exists(path_image))
                    {
                        File.Delete(path_image);    
                    }
                }
            }
            else if(e.RowIndex >=0 && e.ColumnIndex == 2)
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

                // Set the rate of speech
                synthesizer.Rate = 0; // Default value is 0, range: -10 to 10

                // Set the volume
                synthesizer.Volume = 100; // Default value is 100, range: 0 to 100
                synthesizer.Speak(txt);
            }
        }

        private void cb_topic_SelectedValueChanged(object sender, EventArgs e)
        {
            ViewDictionary(cb_topic.SelectedItem.ToString());
        }

        private void btn_addNewWord_Click(object sender, EventArgs e)
        {
            AddNewWord add = new AddNewWord(cb_topic.SelectedItem.ToString());
            DialogResult res =  add.ShowDialog();
            ViewDictionary(cb_topic.SelectedItem.ToString());
        }
    }

}
