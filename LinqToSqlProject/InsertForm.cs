using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSqlProject
{
    public partial class InsertForm : Form
    {
        DataClasses1DataContext dc = LINQToSQL.db;
        bool Edit = false;
        Player player { get; set; }
        int Id { get; set; }
        public InsertForm()
        {
            InitializeComponent();
        }
        public InsertForm(string id, Player player)
        {
            InitializeComponent();
            this.Id = int.Parse(id);
            this.player = player;
            Edit = true;
            label1.Text = "Update player";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!Edit)
            {
                Player player = new Player()
                {
                    PFirstName = tb_fname.Text,
                    PLastName = tb_lname.Text,
                    Position = int.Parse(cb_position.Text),
                    Team = cb_team.SelectedItem as Team
                };
                dc.Players.InsertOnSubmit(player);
                dc.SubmitChanges();
                MessageBox.Show($"{player.PFirstName} {player.PLastName} dodan!");
            }
            else
            {
                Player player = dc.Players.SingleOrDefault(p=>p.PlayerID==Id);
                player.PFirstName = tb_fname.Text;
                player.PLastName = tb_lname.Text;
                player.Position = int.Parse(cb_position.Text);
                player.Team = cb_team.SelectedItem as Team;
                dc.SubmitChanges();
                MessageBox.Show("Player edited!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            int[] positions = { 1, 2, 3, 4, 5 };
            cb_position.DataSource =positions;
            cb_team.DataSource = dc.Teams;
            if(Edit)
            {
                cb_team.Text = "";
                cb_team.Text = player.Team.ToString();
                cb_position.Text = "";
                cb_position.SelectedText = player.Position.ToString();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Clear();
                }
            }
        }
    }
}
