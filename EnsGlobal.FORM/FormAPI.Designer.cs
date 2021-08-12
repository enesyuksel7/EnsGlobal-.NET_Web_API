
namespace EnsGlobal.FORM
{
    partial class FormAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAPI));
            this.BtnGET = new System.Windows.Forms.Button();
            this.BtnPUT = new System.Windows.Forms.Button();
            this.BtnGETALL = new System.Windows.Forms.Button();
            this.BtnPOST = new System.Windows.Forms.Button();
            this.BtnDELETE = new System.Windows.Forms.Button();
            this.BtnKucult = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtSatisID = new System.Windows.Forms.TextBox();
            this.RtbResponce = new System.Windows.Forms.RichTextBox();
            this.txtVergi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGET
            // 
            this.BtnGET.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnGET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGET.ForeColor = System.Drawing.Color.White;
            this.BtnGET.Location = new System.Drawing.Point(245, 141);
            this.BtnGET.Name = "BtnGET";
            this.BtnGET.Size = new System.Drawing.Size(123, 48);
            this.BtnGET.TabIndex = 0;
            this.BtnGET.Text = "GET";
            this.BtnGET.UseVisualStyleBackColor = false;
            this.BtnGET.Click += new System.EventHandler(this.BtnGET_Click);
            // 
            // BtnPUT
            // 
            this.BtnPUT.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnPUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPUT.ForeColor = System.Drawing.Color.White;
            this.BtnPUT.Location = new System.Drawing.Point(809, 84);
            this.BtnPUT.Name = "BtnPUT";
            this.BtnPUT.Size = new System.Drawing.Size(102, 68);
            this.BtnPUT.TabIndex = 1;
            this.BtnPUT.Text = "PUT";
            this.BtnPUT.UseVisualStyleBackColor = false;
            this.BtnPUT.Click += new System.EventHandler(this.BtnPUT_Click);
            // 
            // BtnGETALL
            // 
            this.BtnGETALL.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnGETALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGETALL.ForeColor = System.Drawing.Color.White;
            this.BtnGETALL.Location = new System.Drawing.Point(72, 102);
            this.BtnGETALL.Name = "BtnGETALL";
            this.BtnGETALL.Size = new System.Drawing.Size(105, 90);
            this.BtnGETALL.TabIndex = 2;
            this.BtnGETALL.Text = "GET ALL";
            this.BtnGETALL.UseVisualStyleBackColor = false;
            this.BtnGETALL.Click += new System.EventHandler(this.BtnGETALL_Click);
            // 
            // BtnPOST
            // 
            this.BtnPOST.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnPOST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPOST.ForeColor = System.Drawing.Color.White;
            this.BtnPOST.Location = new System.Drawing.Point(664, 83);
            this.BtnPOST.Name = "BtnPOST";
            this.BtnPOST.Size = new System.Drawing.Size(102, 68);
            this.BtnPOST.TabIndex = 3;
            this.BtnPOST.Text = "POST";
            this.BtnPOST.UseVisualStyleBackColor = false;
            this.BtnPOST.Click += new System.EventHandler(this.BtnPOST_Click);
            // 
            // BtnDELETE
            // 
            this.BtnDELETE.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDELETE.ForeColor = System.Drawing.Color.White;
            this.BtnDELETE.Location = new System.Drawing.Point(753, 209);
            this.BtnDELETE.Name = "BtnDELETE";
            this.BtnDELETE.Size = new System.Drawing.Size(102, 68);
            this.BtnDELETE.TabIndex = 4;
            this.BtnDELETE.Text = "DELETE";
            this.BtnDELETE.UseVisualStyleBackColor = false;
            this.BtnDELETE.Click += new System.EventHandler(this.BtnDELETE_Click);
            // 
            // BtnKucult
            // 
            this.BtnKucult.BackColor = System.Drawing.Color.Black;
            this.BtnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnKucult.ForeColor = System.Drawing.Color.White;
            this.BtnKucult.Location = new System.Drawing.Point(1012, -1);
            this.BtnKucult.Name = "BtnKucult";
            this.BtnKucult.Size = new System.Drawing.Size(60, 49);
            this.BtnKucult.TabIndex = 6;
            this.BtnKucult.Text = "_";
            this.BtnKucult.UseVisualStyleBackColor = false;
            this.BtnKucult.Click += new System.EventHandler(this.BtnKucult_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCikis.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCikis.Location = new System.Drawing.Point(1069, -1);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(60, 49);
            this.BtnCikis.TabIndex = 7;
            this.BtnCikis.Text = "X";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(440, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "WEB API TEST UYGULAMASI";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 49);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(927, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(489, 141);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(140, 26);
            this.txtYetkili.TabIndex = 11;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(489, 220);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(140, 26);
            this.txtUcret.TabIndex = 12;
            // 
            // txtSatisID
            // 
            this.txtSatisID.Location = new System.Drawing.Point(276, 106);
            this.txtSatisID.Name = "txtSatisID";
            this.txtSatisID.Size = new System.Drawing.Size(92, 26);
            this.txtSatisID.TabIndex = 13;
            this.txtSatisID.TextChanged += new System.EventHandler(this.txtSatisID_TextChanged);
            // 
            // RtbResponce
            // 
            this.RtbResponce.Location = new System.Drawing.Point(514, 365);
            this.RtbResponce.Name = "RtbResponce";
            this.RtbResponce.Size = new System.Drawing.Size(341, 280);
            this.RtbResponce.TabIndex = 14;
            this.RtbResponce.Text = "";
            // 
            // txtVergi
            // 
            this.txtVergi.Location = new System.Drawing.Point(489, 259);
            this.txtVergi.Name = "txtVergi";
            this.txtVergi.Size = new System.Drawing.Size(140, 26);
            this.txtVergi.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(425, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yetkili:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(429, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(429, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ücret:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(430, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Vergi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(205, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Satış ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(48, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 280);
            this.dataGridView1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(410, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ürün ID:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(489, 102);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(140, 26);
            this.txtUrunID.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(489, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 26);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // FormAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 715);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVergi);
            this.Controls.Add(this.RtbResponce);
            this.Controls.Add(this.txtSatisID);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtYetkili);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnKucult);
            this.Controls.Add(this.BtnDELETE);
            this.Controls.Add(this.BtnPOST);
            this.Controls.Add(this.BtnGETALL);
            this.Controls.Add(this.BtnPUT);
            this.Controls.Add(this.BtnGET);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Api Test Application";
            this.Load += new System.EventHandler(this.FormAPI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGET;
        private System.Windows.Forms.Button BtnPUT;
        private System.Windows.Forms.Button BtnGETALL;
        private System.Windows.Forms.Button BtnPOST;
        private System.Windows.Forms.Button BtnDELETE;
        private System.Windows.Forms.Button BtnKucult;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtSatisID;
        private System.Windows.Forms.RichTextBox RtbResponce;
        private System.Windows.Forms.TextBox txtVergi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}