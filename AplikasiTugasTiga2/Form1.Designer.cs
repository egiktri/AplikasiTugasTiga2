namespace AplikasiTugasTiga2
{
	partial class frmTugasTiga2
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtPesan2 = new System.Windows.Forms.TextBox();
			this.txtPesan1 = new System.Windows.Forms.TextBox();
			this.txtPesan3 = new System.Windows.Forms.TextBox();
			this.lstPekerjaan = new System.Windows.Forms.ListBox();
			this.cmbPendidikan = new System.Windows.Forms.ComboBox();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(54, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 18);
			this.label3.TabIndex = 32;
			this.label3.Text = "PEKERJAAN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(53, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 18);
			this.label2.TabIndex = 31;
			this.label2.Text = "PENDIDIKAN";
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.Maroon;
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(205, 399);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(288, 37);
			this.btnOk.TabIndex = 30;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtPesan2
			// 
			this.txtPesan2.Enabled = false;
			this.txtPesan2.Location = new System.Drawing.Point(56, 292);
			this.txtPesan2.Multiline = true;
			this.txtPesan2.Name = "txtPesan2";
			this.txtPesan2.Size = new System.Drawing.Size(564, 38);
			this.txtPesan2.TabIndex = 29;
			// 
			// txtPesan1
			// 
			this.txtPesan1.Enabled = false;
			this.txtPesan1.Location = new System.Drawing.Point(56, 248);
			this.txtPesan1.Multiline = true;
			this.txtPesan1.Name = "txtPesan1";
			this.txtPesan1.Size = new System.Drawing.Size(564, 38);
			this.txtPesan1.TabIndex = 28;
			// 
			// txtPesan3
			// 
			this.txtPesan3.Enabled = false;
			this.txtPesan3.Location = new System.Drawing.Point(56, 336);
			this.txtPesan3.Multiline = true;
			this.txtPesan3.Name = "txtPesan3";
			this.txtPesan3.Size = new System.Drawing.Size(564, 38);
			this.txtPesan3.TabIndex = 27;
			// 
			// lstPekerjaan
			// 
			this.lstPekerjaan.BackColor = System.Drawing.Color.White;
			this.lstPekerjaan.ForeColor = System.Drawing.Color.Black;
			this.lstPekerjaan.FormattingEnabled = true;
			this.lstPekerjaan.Items.AddRange(new object[] {
            "PEDAGANG ",
            "PNS",
            "DOSEN",
            "SWASTA",
            "ABRI"});
			this.lstPekerjaan.Location = new System.Drawing.Point(269, 105);
			this.lstPekerjaan.Name = "lstPekerjaan";
			this.lstPekerjaan.Size = new System.Drawing.Size(313, 108);
			this.lstPekerjaan.TabIndex = 26;
			// 
			// cmbPendidikan
			// 
			this.cmbPendidikan.BackColor = System.Drawing.Color.White;
			this.cmbPendidikan.ForeColor = System.Drawing.Color.Black;
			this.cmbPendidikan.FormattingEnabled = true;
			this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "SARJANA",
            "PASCASARJANA"});
			this.cmbPendidikan.Location = new System.Drawing.Point(269, 68);
			this.cmbPendidikan.Name = "cmbPendidikan";
			this.cmbPendidikan.Size = new System.Drawing.Size(313, 21);
			this.cmbPendidikan.TabIndex = 25;
			// 
			// txtNama
			// 
			this.txtNama.BackColor = System.Drawing.Color.White;
			this.txtNama.ForeColor = System.Drawing.Color.Black;
			this.txtNama.Location = new System.Drawing.Point(269, 28);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(313, 20);
			this.txtNama.TabIndex = 24;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Green;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.flowLayoutPanel1.TabIndex = 33;
			// 
			// frmTugasTiga2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtPesan2);
			this.Controls.Add(this.txtPesan1);
			this.Controls.Add(this.txtPesan3);
			this.Controls.Add(this.lstPekerjaan);
			this.Controls.Add(this.cmbPendidikan);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "frmTugasTiga2";
			this.Text = "Tugas 3.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtPesan2;
		private System.Windows.Forms.TextBox txtPesan1;
		private System.Windows.Forms.TextBox txtPesan3;
		private System.Windows.Forms.ListBox lstPekerjaan;
		private System.Windows.Forms.ComboBox cmbPendidikan;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}

