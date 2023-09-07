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

namespace Planetas
{
	public partial class Form1 : Form
	{
		public string SelectedPlanetName { get; private set; }
		public string SelectedPlanetDescription { get; private set; }
		public Image SelectedPlanetImage { get; private set; }
		public double SelectedPlanetDistancia { get; private set; }
		public string SelectedPlanetMateria { get; private set; }



		private List<Planet> planets;
		private Form2 planetDetailForm;
		public class Planet
		{
			public string Name { get; set; }
			public string Description { get; set; }
			public string Materia { get; set; }
			public double Distancia { get; set; }
			public Planet(string name, string description, string materia, double distancia)
			{
				Name = name;
				Description = description;
				Materia = materia;
				Distancia = distancia;
			}
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			
			DialogResult result = MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
		public Form1()
		{
			InitializeComponent();
			InitializePlanets();
			this.FormClosing += Form1_FormClosing;
		}

		private void InitializePlanets()
		{
			planets = new List<Planet>
		{
		new Planet("Mercurio", "Mercurio é o menor e mais interno planeta do Sistema Solar, orbitando o Sol a cada 87,969 dias terrestres. A sua órbita tem a maior excentricidade e o seu eixo apresenta a menor inclinação em relação ao plano da órbita dentre todos os planetas do Sistema Solar.", "Rochoso", 0.39),
		new Planet("Venus", "Vênus é o segundo planeta do Sistema Solar em ordem de distância a partir do Sol, orbitando-o a cada 224,7 dias. Recebeu seu nome em homenagem à deusa romana do amor e da beleza, Vênus, equivalente a Afrodite.", "Rochoso", 0.72),
		new Planet("Terra", "Terra é o terceiro planeta mais próximo do Sol, o mais denso e o quinto maior dos oito planetas do Sistema Solar. É também o maior dos quatro planetas telúricos. É por vezes designada como Mundo ou Planeta Azul .", "Rochoso", 1.0),
		new Planet("Marte", "Marte é o quarto planeta a partir do Sol, o segundo menor do Sistema Solar. Batizado em homenagem ao deus romano da guerra, muitas vezes é descrito como o Planeta Vermelho, porque o óxido de ferro predominante em sua superfície lhe dá uma aparência avermelhada.", "Rochoso", 1.52),
		new Planet("Jupiter", "Júpiter é o maior planeta do Sistema Solar, tanto em diâmetro quanto em massa, e é o quinto mais próximo do Sol. Possui menos de um milésimo da massa solar, contudo tem 2,5 vezes a massa de todos os outros planetas em conjunto.", "Gasoso", 5.20),
		new Planet("Saturno", "Saturno é o sexto planeta a partir do Sol e o segundo maior do Sistema Solar atrás de Júpiter. Pertencente ao grupo dos gigantes gasosos, possui cerca de 95 massas terrestres e orbita a uma distância média de 9,5 unidades astronômicas.", "Gasoso", 9.58),
		new Planet("Urano", "Urano é o sétimo planeta a partir do Sol, o terceiro maior e o quarto mais massivo dos oito planetas do Sistema Solar. Foi nomeado em homenagem ao deus grego do céu, Urano, o pai de Cronos e o avô de Zeus.", "Gasoso", 19.20),
		new Planet("Netuno", "Netuno é o oitavo planeta do Sistema Solar, o último a partir do Sol desde a reclassificação de Plutão para a categoria de planeta anão, em 2006. Pertencente ao grupo dos gigantes gasosos, possui um tamanho ligeiramente menor que o de Urano.", "Gasoso", 30.05)
		};
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			rdb_mercurio.Checked = false;
			rdb_venus.Checked = false;
			rdb_terra.Checked = false;
			rdb_marte.Checked = false;
			rdb_jupiter.Checked = false;
			rdb_saturno.Checked = false;
			rdb_urano.Checked = false;
			rdb_netuno.Checked = false;

			planetPictureBox.Image = null;

		}

		private void rdb_mercurio_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_mercurio.Checked == true)
			{
				planetPictureBox.Image = Properties.Resources.mercurio;
				Planet mercurioPlanet = planets.Find(planet => planet.Name == "Mercurio");
				if (mercurioPlanet != null)
				{
					SelectedPlanetName = "Mercurio";
					SelectedPlanetDescription = mercurioPlanet.Description;
					SelectedPlanetImage = Properties.Resources.mercurio;
					SelectedPlanetDistancia = mercurioPlanet.Distancia;
					SelectedPlanetMateria = mercurioPlanet.Materia;

				}
			}
		}





		private void rdb_venus_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_venus.Checked == true)
			{

				planetPictureBox.Image = Properties.Resources.venus;
				Planet venusPlanet = planets.Find(planet => planet.Name == "Venus");
				if (venusPlanet != null)
				{
					SelectedPlanetName = "Venus";
					SelectedPlanetDescription = venusPlanet.Description;
					SelectedPlanetImage = Properties.Resources.venus;
					SelectedPlanetDistancia = venusPlanet.Distancia;
					SelectedPlanetMateria = venusPlanet.Materia;
				}
			}
		}

		private void rdb_terra_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_terra.Checked == true)
			{

				planetPictureBox.Image = Properties.Resources.terra;
				Planet terraPlanet = planets.Find(planet => planet.Name == "Terra");
				if (terraPlanet != null)
				{
					SelectedPlanetName = "Terra";
					SelectedPlanetDescription = terraPlanet.Description;
					SelectedPlanetImage = Properties.Resources.terra;
					SelectedPlanetDistancia = terraPlanet.Distancia;
					SelectedPlanetMateria = terraPlanet.Materia;
				}
			}
		}

		private void rdb_marte_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_marte.Checked == true)
			{

				planetPictureBox.Image = Properties.Resources.marte;
				Planet martePlanet = planets.Find(planet => planet.Name == "Marte");
				if (martePlanet != null)
				{
					SelectedPlanetName = "Marte";
					SelectedPlanetDescription = martePlanet.Description;
					SelectedPlanetImage = Properties.Resources.marte;
					SelectedPlanetDistancia = martePlanet.Distancia;
					SelectedPlanetMateria = martePlanet.Materia;
				}
			}
		}

		private void rdb_jupiter_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_jupiter.Checked == true)
			{

				planetPictureBox.Image = Properties.Resources.jupiter;
				Planet jupiterPlanet = planets.Find(planet => planet.Name == "Jupiter");
				if (jupiterPlanet != null)
				{
					SelectedPlanetName = "Jupiter";
					SelectedPlanetDescription = jupiterPlanet.Description;
					SelectedPlanetImage = Properties.Resources.jupiter;
					SelectedPlanetDistancia = jupiterPlanet.Distancia;
					SelectedPlanetMateria = jupiterPlanet.Materia;
				}
			}
		}

		private void rdb_saturno_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_saturno.Checked == true)
			{

				planetPictureBox.Image = Properties.Resources.saturno;
				Planet saturnoPlanet = planets.Find(planet => planet.Name == "Saturno");
				if (saturnoPlanet != null)
				{
					SelectedPlanetName = "Saturno";
					SelectedPlanetDescription = saturnoPlanet.Description;
					SelectedPlanetImage = Properties.Resources.saturno;
					SelectedPlanetDistancia = saturnoPlanet.Distancia;
					SelectedPlanetMateria = saturnoPlanet.Materia;
				}
			}

		}

		private void rdb_urano_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_urano.Checked == true)
			{

				planetPictureBox.Image = Properties.Resources.urano;
				Planet uranoPlanet = planets.Find(planet => planet.Name == "Urano");
				if (uranoPlanet != null)
				{
					SelectedPlanetName = "Urano";
					SelectedPlanetDescription = uranoPlanet.Description;
					SelectedPlanetImage = Properties.Resources.urano;
					SelectedPlanetDistancia = uranoPlanet.Distancia;
					SelectedPlanetMateria = uranoPlanet.Materia;
				}
			}
		}

		private void rdb_netuno_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_netuno.Checked == true)
			{

				planetPictureBox.Image = Properties.Resources.netuno;
				Planet netunoPlanet = planets.Find(planet => planet.Name == "Netuno");
				if (netunoPlanet != null)
				{
					SelectedPlanetName = "Netuno";
					SelectedPlanetDescription = netunoPlanet.Description;
					SelectedPlanetImage = Properties.Resources.netuno;
					SelectedPlanetDistancia = netunoPlanet.Distancia;
					SelectedPlanetMateria = netunoPlanet.Materia;
				}
			}
		}

		private void planetPictureBox_Click(object sender, EventArgs e)
		{

		}

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(SelectedPlanetName))
			{
				
				MessageBox.Show("Por favor, selecione um planeta antes de enviar.", "Nenhum planeta selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				
				if (planetDetailForm == null)
				{
					planetDetailForm = new Form2();
				}

				planetDetailForm.SetSelectedPlanet(SelectedPlanetName, SelectedPlanetDescription, SelectedPlanetImage, SelectedPlanetDistancia, SelectedPlanetMateria);
				planetDetailForm.ShowDialog();
			}
		}
	}
}
