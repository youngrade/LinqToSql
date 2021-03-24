namespace LinqToSqlProject
{
    partial class OnebyOne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.tb_team = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F);
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player details";
            // 
            // tb_fname
            // 
            this.tb_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tb_fname.Location = new System.Drawing.Point(148, 57);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(165, 26);
            this.tb_fname.TabIndex = 1;
            // 
            // tb_lname
            // 
            this.tb_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tb_lname.Location = new System.Drawing.Point(148, 89);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(165, 26);
            this.tb_lname.TabIndex = 2;
            // 
            // tb_team
            // 
            this.tb_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tb_team.Location = new System.Drawing.Point(148, 153);
            this.tb_team.Name = "tb_team";
            this.tb_team.Size = new System.Drawing.Size(165, 26);
            this.tb_team.TabIndex = 4;
            // 
            // tb_city
            // 
            this.tb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tb_city.Location = new System.Drawing.Point(148, 121);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(165, 26);
            this.tb_city.TabIndex = 5;
            // 
            // cb_position
            // 
            this.cb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cb_position.FormattingEnabled = true;
            this.cb_position.Location = new System.Drawing.Point(148, 185);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(165, 28);
            this.cb_position.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(80, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(62, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Position";
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(27, 257);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(95, 30);
            this.btn_prev.TabIndex = 11;
            this.btn_prev.Text = "Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(128, 257);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(95, 30);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(228, 257);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(95, 30);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(92, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "City";
            // 
            // OnebyOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(344, 299);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_position);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_team);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.label1);
            this.Name = "OnebyOne";
            this.Text = "OnebyOne";
            this.Load += new System.EventHandler(this.OnebyOne_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnebyOne_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.TextBox tb_team;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.ComboBox cb_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label6;
    }
}