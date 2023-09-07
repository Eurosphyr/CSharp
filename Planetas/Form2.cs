using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Planetas.Form1;

namespace Planetas
{
	public partial class Form2 : Form
	{
		private List<Planet> planets;
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		public void SetPlanets(List<Planet> planetList)
		{
			planets = planetList;
		}

		public void SetSelectedPlanet(string name, string description, Image image, double distancia, string materia)
		{
			planetNameLabel.Text = name;
			planetDescriptionLabel.Text = description;
			planetPictureBox.Image = image;
			distanciaLabel.Text = $"Distância: {distancia} UA";
			materiaLabel.Text = $"Matéria: {materia}";
		}

		private void planetPictureBox_Click(object sender, EventArgs e)
		{

		}

		private void planetNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void planetDescriptionLabel_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void materiaLabel_Click(object sender, EventArgs e)
		{

		}

		private void distanciaLabel_Click(object sender, EventArgs e)
		{

		}

		private void btl_fechar_Click(object sender, EventArgs e)
		{

			this.Close();
		}
	}
}
