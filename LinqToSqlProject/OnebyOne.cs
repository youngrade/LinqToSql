using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSqlProject
{
    public partial class OnebyOne : Form
    {
        public DataClasses1DataContext dc = new DataClasses1DataContext();
        public List<Player> players = new List<Player>();
        int index = 0;
        public OnebyOne()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnebyOne_Load(object sender, EventArgs e)
        {
            players = dc.Players.ToList();
            btn_prev.Enabled = false;
            ShowData();
        }
        private void ShowData()
        {
            tb_fname.Text = players[index].PFirstName;
            tb_lname.Text = players[index].PLastName;
            tb_team.Text = players[index].Team.TeamName;
            tb_city.Text = players[index].Team.TeamCity;
            cb_position.Text = players[index].Position.ToString();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                btn_next.Enabled = true;
                if (index == 0)
                    btn_prev.Enabled = false;

                ShowData();
            }


        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            {
                if (index < players.Count - 1)
                {
                    index++;
                    btn_prev.Enabled = true;
                    if (index == players.Count - 1)
                        btn_next.Enabled = false;

                    ShowData();
                }
            }
        }



        private void OnebyOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
