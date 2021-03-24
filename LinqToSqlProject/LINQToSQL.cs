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
    public partial class LINQToSQL : Form
    {
        public static DataClasses1DataContext db = new DataClasses1DataContext();
        public LINQToSQL()
        {
            InitializeComponent();
            
        }

        private void LINQToSQL_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Players.ToList();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertForm insert = new InsertForm();
            insert.ShowDialog();
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {

                InsertForm form = new InsertForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].DataBoundItem as Player);
                form.tb_fname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                form.tb_lname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                form.cb_position.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                form.cb_position.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                
                form.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("You must select player to perform update!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id=(int)dataGridView1.SelectedRows[0].Cells[0].Value;
                Player player = db.Players.SingleOrDefault(P => P.PlayerID == id);
                if (MessageBox.Show($"Are you sure that you want to delete player {player.PFirstName} " +
                     $"{player.PLastName}?", "Delete player",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"{player.PFirstName} " +
                     $"{player.PLastName} deleted!", "Info",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.Players.DeleteOnSubmit(player);
                    db.SubmitChanges();
                    LoadData();
                 
                }

            }
            else
            {
                MessageBox.Show("You must select player which you want to delete!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
