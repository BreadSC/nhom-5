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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(168, 252);
            this.btnCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(129, 66);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(684, 255);
            this.btnChia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(116, 64);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(499, 255);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(121, 64);
            this.btnNhan.TabIndex = 4;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(339, 252);
            this.btnTru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(119, 66);
            this.btnTru.TabIndex = 5;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(267, 107);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(501, 22);
            this.txtNumber1.TabIndex = 6;
            this.txtNumber1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(267, 182);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(501, 22);
            this.txtNumber2.TabIndex = 7;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(267, 371);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(501, 22);
            this.txtResult.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
    }
}

