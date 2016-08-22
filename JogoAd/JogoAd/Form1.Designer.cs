namespace JogoAd
{
	partial class Form1
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
			this.lblTentativas = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPalpite = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTentativas
			// 
			this.lblTentativas.AutoSize = true;
			this.lblTentativas.Location = new System.Drawing.Point(12, 95);
			this.lblTentativas.Name = "lblTentativas";
			this.lblTentativas.Size = new System.Drawing.Size(57, 13);
			this.lblTentativas.TabIndex = 0;
			this.lblTentativas.Text = "Tentativas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Seu palpite :";
			// 
			// textBoxPalpite
			// 
			this.textBoxPalpite.Location = new System.Drawing.Point(84, 64);
			this.textBoxPalpite.Name = "textBoxPalpite";
			this.textBoxPalpite.Size = new System.Drawing.Size(51, 20);
			this.textBoxPalpite.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 149);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "palpite";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtInfo
			// 
			this.txtInfo.AutoSize = true;
			this.txtInfo.Location = new System.Drawing.Point(15, 123);
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.Size = new System.Drawing.Size(0, 13);
			this.txtInfo.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txtInfo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxPalpite);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTentativas);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTentativas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPalpite;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label txtInfo;
	}
}

