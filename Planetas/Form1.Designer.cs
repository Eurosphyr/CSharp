namespace Planetas
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.planetPictureBox = new System.Windows.Forms.PictureBox();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.rdb_mercurio = new System.Windows.Forms.RadioButton();
			this.rdb_venus = new System.Windows.Forms.RadioButton();
			this.rdb_terra = new System.Windows.Forms.RadioButton();
			this.rdb_marte = new System.Windows.Forms.RadioButton();
			this.rdb_jupiter = new System.Windows.Forms.RadioButton();
			this.rdb_saturno = new System.Windows.Forms.RadioButton();
			this.rdb_urano = new System.Windows.Forms.RadioButton();
			this.rdb_netuno = new System.Windows.Forms.RadioButton();
			this.planetGroupBox = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.planetPictureBox)).BeginInit();
			this.planetGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// planetPictureBox
			// 
			this.planetPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.planetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.planetPictureBox.Location = new System.Drawing.Point(1, -5);
			this.planetPictureBox.Name = "planetPictureBox";
			this.planetPictureBox.Size = new System.Drawing.Size(275, 234);
			this.planetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.planetPictureBox.TabIndex = 8;
			this.planetPictureBox.TabStop = false;
			this.planetPictureBox.Click += new System.EventHandler(this.planetPictureBox_Click);
			// 
			// btnEnviar
			// 
			this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEnviar.AutoSize = true;
			this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEnviar.Location = new System.Drawing.Point(1133, 402);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(75, 25);
			this.btnEnviar.TabIndex = 9;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// rdb_mercurio
			// 
			this.rdb_mercurio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rdb_mercurio.AutoSize = true;
			this.rdb_mercurio.BackColor = System.Drawing.Color.Transparent;
			this.rdb_mercurio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rdb_mercurio.Location = new System.Drawing.Point(30, 69);
			this.rdb_mercurio.Name = "rdb_mercurio";
			this.rdb_mercurio.Size = new System.Drawing.Size(66, 17);
			this.rdb_mercurio.TabIndex = 0;
			this.rdb_mercurio.TabStop = true;
			this.rdb_mercurio.Text = "Mercúrio";
			this.rdb_mercurio.UseVisualStyleBackColor = false;
			this.rdb_mercurio.CheckedChanged += new System.EventHandler(this.rdb_mercurio_CheckedChanged);
			// 
			// rdb_venus
			// 
			this.rdb_venus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rdb_venus.AutoSize = true;
			this.rdb_venus.BackColor = System.Drawing.Color.Transparent;
			this.rdb_venus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rdb_venus.Location = new System.Drawing.Point(189, 69);
			this.rdb_venus.Name = "rdb_venus";
			this.rdb_venus.Size = new System.Drawing.Size(55, 17);
			this.rdb_venus.TabIndex = 1;
			this.rdb_venus.TabStop = true;
			this.rdb_venus.Text = "Vênus";
			this.rdb_venus.UseVisualStyleBackColor = false;
			this.rdb_venus.CheckedChanged += new System.EventHandler(this.rdb_venus_CheckedChanged);
			// 
			// rdb_terra
			// 
			this.rdb_terra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rdb_terra.AutoSize = true;
			this.rdb_terra.BackColor = System.Drawing.Color.Transparent;
			this.rdb_terra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rdb_terra.Location = new System.Drawing.Point(335, 69);
			this.rdb_terra.Name = "rdb_terra";
			this.rdb_terra.Size = new System.Drawing.Size(50, 17);
			this.rdb_terra.TabIndex = 2;
			this.rdb_terra.TabStop = true;
			this.rdb_terra.Text = "Terra";
			this.rdb_terra.UseVisualStyleBackColor = false;
			this.rdb_terra.CheckedChanged += new System.EventHandler(this.rdb_terra_CheckedChanged);
			// 
			// rdb_marte
			// 
			this.rdb_marte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rdb_marte.AutoSize = true;
			this.rdb_marte.BackColor = System.Drawing.Color.Transparent;
			this.rdb_marte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rdb_marte.Location = new System.Drawing.Point(491, 69);
			this.rdb_marte.Name = "rdb_marte";
			this.rdb_marte.Size = new System.Drawing.Size(52, 17);
			this.rdb_marte.TabIndex = 3;
			this.rdb_marte.TabStop = true;
			this.rdb_marte.Text = "Marte";
			this.rdb_marte.UseVisualStyleBackColor = false;
			this.rdb_marte.CheckedChanged += new System.EventHandler(this.rdb_marte_CheckedChanged);
			// 
			// rdb_jupiter
			// 
			this.rdb_jupiter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rdb_jupiter.AutoSize = true;
			this.rdb_jupiter.BackColor = System.Drawing.Color.Transparent;
			this.rdb_jupiter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rdb_jupiter.Location = new System.Drawing.Point(634, 69);
			this.rdb_jupiter.Name = "rdb_jupiter";
			this.rdb_jupiter.Size = new System.Drawing.Size(56, 17);
			this.rdb_jupiter.TabIndex = 4;
			this.rdb_jupiter.TabStop = true;
			this.rdb_jupiter.Text = "Júpiter";
			this.rdb_jupiter.UseVisualStyleBackColor = false;
			this.rdb_jupiter.CheckedChanged += new System.EventHandler(this.rdb_jupiter_CheckedChanged);
			// 
			// rdb_saturno
			// 
			this.rdb_saturno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rdb_saturno.AutoSize = true;
			this.rdb_saturno.BackColor = System.Drawing.Color.Transparent;
			this.rdb_saturno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rdb_saturno.Location = new System.Drawing.Point(787, 69);
			this.rdb_saturno.Name = "rdb_saturno";
			this.rdb_saturno.Size = new System.Drawing.Size(62, 17);
			this.rdb_saturno.TabIndex = 5;
			this.rdb_saturno.TabStop = true;
			this.rdb_saturno.Text = "Saturno";
			this.rdb_saturno.UseVisualStyleBackColor = false;
			this.rdb_saturno.CheckedChanged += new System.EventHandler(this.rdb_saturno_CheckedChanged);
			// 
			// rdb_urano
			// 
			this.rdb_urano.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rdb_urano.AutoSize = true;
			this.rdb_urano.BackColor = System.Drawing.Color.Transparent;
			this.rdb_urano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rdb_urano.Location = new System.Drawing.Point(935, 69);
			this.rdb_urano.Name = "rdb_urano";
			this.rdb_urano.Size = new System.Drawing.Size(54, 17);
			this.rdb_urano.TabIndex = 6;
			this.rdb_urano.TabStop = true;
			this.rdb_urano.Text = "Urano";
			this.rdb_urano.UseVisualStyleBackColor = false;
			this.rdb_urano.CheckedChanged += new System.EventHandler(this.rdb_urano_CheckedChanged);
			// 
			// rdb_netuno
			// 
			this.rdb_netuno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rdb_netuno.AutoSize = true;
			this.rdb_netuno.BackColor = System.Drawing.Color.Transparent;
			this.rdb_netuno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rdb_netuno.Location = new System.Drawing.Point(1082, 69);
			this.rdb_netuno.Name = "rdb_netuno";
			this.rdb_netuno.Size = new System.Drawing.Size(60, 17);
			this.rdb_netuno.TabIndex = 7;
			this.rdb_netuno.TabStop = true;
			this.rdb_netuno.Text = "Netuno";
			this.rdb_netuno.UseVisualStyleBackColor = false;
			this.rdb_netuno.CheckedChanged += new System.EventHandler(this.rdb_netuno_CheckedChanged);
			// 
			// planetGroupBox
			// 
			this.planetGroupBox.BackColor = System.Drawing.Color.Transparent;
			this.planetGroupBox.Controls.Add(this.rdb_netuno);
			this.planetGroupBox.Controls.Add(this.rdb_urano);
			this.planetGroupBox.Controls.Add(this.rdb_saturno);
			this.planetGroupBox.Controls.Add(this.rdb_jupiter);
			this.planetGroupBox.Controls.Add(this.rdb_marte);
			this.planetGroupBox.Controls.Add(this.rdb_terra);
			this.planetGroupBox.Controls.Add(this.rdb_venus);
			this.planetGroupBox.Controls.Add(this.rdb_mercurio);
			this.planetGroupBox.Location = new System.Drawing.Point(32, 449);
			this.planetGroupBox.Name = "planetGroupBox";
			this.planetGroupBox.Size = new System.Drawing.Size(1194, 161);
			this.planetGroupBox.TabIndex = 10;
			this.planetGroupBox.TabStop = false;
			this.planetGroupBox.Text = "Selecione um planeta";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1238, 614);
			this.Controls.Add(this.planetGroupBox);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.planetPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Sistema Solar";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.planetPictureBox)).EndInit();
			this.planetGroupBox.ResumeLayout(false);
			this.planetGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox planetPictureBox;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.RadioButton rdb_mercurio;
		private System.Windows.Forms.RadioButton rdb_venus;
		private System.Windows.Forms.RadioButton rdb_terra;
		private System.Windows.Forms.RadioButton rdb_marte;
		private System.Windows.Forms.RadioButton rdb_jupiter;
		private System.Windows.Forms.RadioButton rdb_saturno;
		private System.Windows.Forms.RadioButton rdb_urano;
		private System.Windows.Forms.RadioButton rdb_netuno;
		private System.Windows.Forms.GroupBox planetGroupBox;
	}
}

