using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoAd
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		byte numeroTentativas = 11;
		byte numerosSorteados;

		public void button1_Click(object sender, EventArgs e)
		{
			numeroTentativas--;
			lblTentativas.Text = "Tentativas " + numeroTentativas;

			byte palpite = byte.Parse(textBoxPalpite.Text);

			if (numeroTentativas > 0)
			{
				if (numerosSorteados == palpite)
				{
                    textBoxPalpite.Visible = false;
                    label2.Visible = false;
                    txtInfo.Visible = false;
                    button1.Visible = false;                   
                    lblTentativas.Text = "Você acertou.";
				}
				else
				{
					if(palpite > numerosSorteados)
					{
						txtInfo.Text = "Você errou! O número sorteado é mais baixo.";
					}
					else
					{
						txtInfo.Text = "Você errou! O número sorteado é mais alto.";
					}
				}
			}
			else
			{
				lblTentativas.Text = "Você perdeu! O número sorteado era " + numerosSorteados;
				textBoxPalpite.Visible = false;
				label2.Visible = false;
                txtInfo.Visible = false;
                button1.Visible = false;
			}
		
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			Random rnd = new Random();
			numerosSorteados = (byte)rnd.Next(1, 51);
		}
	}
}
