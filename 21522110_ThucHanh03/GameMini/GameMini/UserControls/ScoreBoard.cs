using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GameMini.UserControls
{
    struct struc_score
    {
        public string score;
        public string level;
        public string time;
        public string name;
        public string date;
    };
    public partial class ScoreBoard : UserControl
    {
        public ScoreBoard()
        {
            InitializeComponent();
            ViewScoreBoard("easy");
        }
        public void UpdateStateFromScoreBoard()
        {
            ViewScoreBoard("easy");
        }
        #region DataScore
        List<struc_score> sc_easy = new List<struc_score>();
        List<struc_score> sc_medium = new List<struc_score>();
        List<struc_score> sc_hard = new List<struc_score>();
        #endregion
        #region define path
        const string path_score = "C:/Users/bmhun/Documents/TaiLieuHocTapDaiHoc/Year2/HK_II/UIT/C-Sharp/ThucHanh/21522110_ThucHanh03/GameMini/Dataset/Ranking/SaveGame.txt";
        #endregion
        private void btn_back_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null && parentForm is MainForm mainForm)
            {
                mainForm.FunctionParent("back_scoreboard");
            }
        }
        struc_score resInList;
        struc_score insertList;
        private void addToList(ref List<struc_score>list, string[] res)
        {
            insertList.score = res[2];
            insertList.level = res[0];
            insertList.time = res[3];
            insertList.name = res[4];
            insertList.date = res[5];
            if(list.Count == 0)
            {
                list.Insert(0, insertList);
                return;
            }
            for(int i =0;i<list.Count;i++)
            {
                if (i > 4) break;
                if (
                    int.Parse(list[i].score) < int.Parse(res[2]) ||
                    (
                    int.Parse(list[i].score) == int.Parse(res[2]) &&
                    int.Parse(list[i].time) > int.Parse(res[3])
                    )
                )
                {
                    list.Insert(i, insertList);
                    return;
                }
                if (
                    int.Parse(list[i].score) == int.Parse(res[2]) &&
                    int.Parse(list[i].time) == int.Parse(res[3])
                )
                {
                    list.Insert(i, insertList);
                    return;
                }
            }
            list.Insert(list.Count-1, insertList);
            return;
        }
        private void updateScore()
        {
            sc_easy.Clear();
            sc_medium.Clear();
            sc_hard.Clear();
            using (StreamReader reader = new StreamReader(path_score, Encoding.UTF8))
            {
                string res;
                while ((res = reader.ReadLine()) != null)
                {
                    string[] infor = res.Split('_');
                    if (infor[0] == "easy")
                    {
                        addToList(ref sc_easy, infor);
                    }
                    else if (infor[0] == "medium")
                    {
                        addToList(ref sc_medium, infor);
                    }
                    else if (infor[0] =="hard")
                    {
                        addToList(ref sc_hard, infor);
                    }
                }
                reader.Close(); 
            }
        }
        DataTable data = new DataTable();
        private void ViewScoreBoard(string option)
        {
            updateScore();
            data.Clear();
            data.Columns.Clear();
            data.Columns.Add("Top", typeof(string));
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Score", typeof(string));
            data.Columns.Add("Time", typeof(string));
            data.Columns.Add("Date", typeof(string));
            data.Rows.Clear();
            dataGridScore.DataSource = data;
            dataGridScore.ColumnHeadersHeight = 50;
            string[] row = new string[5];   
            if (option == "easy")
            {
                data.Rows.Clear();
                for (int i =0;i < sc_easy.Count;i++)
                {
                    if (i > 4) return;
                    row[0] = i.ToString();  
                    row[1] = sc_easy[i].name;
                    row[2] = sc_easy[i].score;
                    row[3] = sc_easy[i].time;
                    row[4] = sc_easy[i].date;
                    data.Rows.Add(row);
                }
            }
            else if (option == "medium")
            {
                data.Rows.Clear();
                for (int i = 0; i < sc_medium.Count; i++)
                {
                    if (i > 4) return;
                    row[0] = i.ToString();
                    row[1] = sc_medium[i].name;
                    row[2] = sc_medium[i].score;
                    row[3] = sc_medium[i].time;
                    row[4] = sc_medium[i].date;
                    data.Rows.Add(row);
                }
            }
            else
            {
                data.Rows.Clear();
                for (int i = 0; i < sc_hard.Count; i++)
                {
                    if (i > 4) return;
                    row[0] = i.ToString();
                    row[1] = sc_hard[i].name;
                    row[2] = sc_hard[i].score;
                    row[3] = sc_hard[i].time;
                    row[4] = sc_hard[i].date;
                    data.Rows.Add(row);
                }
            }
            
        }

        private void btn_chooseLevel(object sender, EventArgs e)
        {
            Guna2GradientButton btn = sender as Guna2GradientButton;
            if(btn.Name == "btn_easy")
            {
                ViewScoreBoard("easy");
            }
            else if(btn.Name == "btn_medium")
            {
                ViewScoreBoard("medium");
            }
            else
            {
                ViewScoreBoard("hard");
            }
        }
    } 
}
