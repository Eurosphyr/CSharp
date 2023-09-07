namespace Planetas
{
	partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.planetDescriptionLabel = new System.Windows.Forms.Label();
            this.planetNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materiaLabel = new System.Windows.Forms.Label();
            this.distanciaLabel = new System.Windows.Forms.Label();
            this.planetPictureBox = new System.Windows.Forms.PictureBox();
            this.btl_fechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // planetDescriptionLabel
            // 
            this.planetDescriptionLabel.AutoSize = true;
            this.planetDescriptionLabel.Location = new System.Drawing.Point(46, 146);
            this.planetDescriptionLabel.MaximumSize = new System.Drawing.Size(250, 250);
            this.planetDescriptionLabel.Name = "planetDescriptionLabel";
            this.planetDescriptionLabel.Size = new System.Drawing.Size(55, 13);
            this.planetDescriptionLabel.TabIndex = 0;
            this.planetDescriptionLabel.Text = "Descrição";
            this.planetDescriptionLabel.Click += new System.EventHandler(this.planetDescriptionLabel_Click);
            // 
            // planetNameLabel
            // 
            this.planetNameLabel.AutoSize = true;
            this.planetNameLabel.Location = new System.Drawing.Point(46, 31);
            this.planetNameLabel.Name = "planetNameLabel";
            this.planetNameLabel.Size = new System.Drawing.Size(74, 13);
            this.planetNameLabel.TabIndex = 1;
            this.planetNameLabel.Text = "Nome Planeta";
            this.planetNameLabel.Click += new System.EventHandler(this.planetNameLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.materiaLabel);
            this.groupBox1.Controls.Add(this.distanciaLabel);
            this.groupBox1.Controls.Add(this.planetNameLabel);
            this.groupBox1.Controls.Add(this.planetDescriptionLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 370);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Planetas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // materiaLabel
            // 
            this.materiaLabel.AutoSize = true;
            this.materiaLabel.Location = new System.Drawing.Point(330, 146);
            this.materiaLabel.Name = "materiaLabel";
            this.materiaLabel.Size = new System.Drawing.Size(42, 13);
            this.materiaLabel.TabIndex = 3;
            this.materiaLabel.Text = "Matéria";
            this.materiaLabel.Click += new System.EventHandler(this.materiaLabel_Click);
            // 
            // distanciaLabel
            // 
            this.distanciaLabel.AutoSize = true;
            this.distanciaLabel.Location = new System.Drawing.Point(330, 31);
            this.distanciaLabel.Name = "distanciaLabel";
            this.distanciaLabel.Size = new System.Drawing.Size(119, 13);
            this.distanciaLabel.TabIndex = 2;
            this.distanciaLabel.Text = "Distância do Sol em UA";
            this.distanciaLabel.Click += new System.EventHandler(this.distanciaLabel_Click);
            // 
            // planetPictureBox
            // 
            this.planetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.planetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.planetPictureBox.Location = new System.Drawing.Point(649, -3);
            this.planetPictureBox.Name = "planetPictureBox";
            this.planetPictureBox.Size = new System.Drawing.Size(488, 370);
            this.planetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.planetPictureBox.TabIndex = 2;
            this.planetPictureBox.TabStop = false;
            this.planetPictureBox.Click += new System.EventHandler(this.planetPictureBox_Click);
            // 
            // btl_fechar
            // 
            this.btl_fechar.Location = new System.Drawing.Point(406, 408);
            this.btl_fechar.Name = "btl_fechar";
            this.btl_fechar.Size = new System.Drawing.Size(75, 23);
            this.btl_fechar.TabIndex = 4;
            this.btl_fechar.Text = "Fechar";
            this.btl_fechar.UseVisualStyleBackColor = true;
            this.btl_fechar.Click += new System.EventHandler(this.btl_fechar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 601);
            this.Controls.Add(this.btl_fechar);
            this.Controls.Add(this.planetPictureBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Informações sobre os planetas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planetPictureBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label planetDescriptionLabel;
		private System.Windows.Forms.Label planetNameLabel;
		private System.Windows.Forms.PictureBox planetPictureBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label materiaLabel;
		private System.Windows.Forms.Label distanciaLabel;
		private System.Windows.Forms.Button btl_fechar;
	}
}