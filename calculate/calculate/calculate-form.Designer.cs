namespace calculate
{
	partial class calculate
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnCong = new System.Windows.Forms.Button();
			this.btnChia = new System.Windows.Forms.Button();
			this.btnNhan = new System.Windows.Forms.Button();
			this.btnTru = new System.Windows.Forms.Button();
			this.txtNumber1 = new System.Windows.Forms.TextBox();
			this.txtNumber2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(123, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number 1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(123, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Number 2";
			// 
			// btnCong
			// 
			this.btnCong.Location = new System.Drawing.Point(126, 205);
			this.btnCong.Name = "btnCong";
			this.btnCong.Size = new System.Drawing.Size(97, 54);
			this.btnCong.TabIndex = 2;
			this.btnCong.Text = "Cộng";
			this.btnCong.UseVisualStyleBackColor = true;
			// 
			// btnChia
			// 
			this.btnChia.Location = new System.Drawing.Point(513, 207);
			this.btnChia.Name = "btnChia";
			this.btnChia.Size = new System.Drawing.Size(87, 52);
			this.btnChia.TabIndex = 3;
			this.btnChia.Text = "Chia";
			this.btnChia.UseVisualStyleBackColor = true;
			// 
			// btnNhan
			// 
			this.btnNhan.Location = new System.Drawing.Point(374, 207);
			this.btnNhan.Name = "btnNhan";
			this.btnNhan.Size = new System.Drawing.Size(91, 52);
			this.btnNhan.TabIndex = 4;
			this.btnNhan.Text = "Nhân";
			this.btnNhan.UseVisualStyleBackColor = true;
			// 
			// btnTru
			// 
			this.btnTru.Location = new System.Drawing.Point(254, 205);
			this.btnTru.Name = "btnTru";
			this.btnTru.Size = new System.Drawing.Size(89, 54);
			this.btnTru.TabIndex = 5;
			this.btnTru.Text = "Trừ";
			this.btnTru.UseVisualStyleBackColor = true;
			// 
			// txtNumber1
			// 
			this.txtNumber1.Location = new System.Drawing.Point(200, 87);
			this.txtNumber1.Name = "txtNumber1";
			this.txtNumber1.Size = new System.Drawing.Size(377, 20);
			this.txtNumber1.TabIndex = 6;
			this.txtNumber1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtNumber2
			// 
			this.txtNumber2.Location = new System.Drawing.Point(200, 148);
			this.txtNumber2.Name = "txtNumber2";
			this.txtNumber2.Size = new System.Drawing.Size(377, 20);
			this.txtNumber2.TabIndex = 7;
			// 
			// calculate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtNumber2);
			this.Controls.Add(this.txtNumber1);
			this.Controls.Add(this.btnTru);
			this.Controls.Add(this.btnNhan);
			this.Controls.Add(this.btnChia);
			this.Controls.Add(this.btnCong);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "calculate";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.calculate_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCong;
		private System.Windows.Forms.Button btnChia;
		private System.Windows.Forms.Button btnNhan;
		private System.Windows.Forms.Button btnTru;
		private System.Windows.Forms.TextBox txtNumber1;
		private System.Windows.Forms.TextBox txtNumber2;
	}
}

