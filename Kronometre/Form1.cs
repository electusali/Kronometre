using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int saat = 0;
		int dakika = 0;
		int saniye = 0;
		private void btnBasla_Click(object sender, EventArgs e)
		{
			timer1.Start();	
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			saniye++;
			lblSaat.Text = Convert.ToString(saat);
			lblSaniye.Text = Convert.ToString(saniye);
			lblDakika.Text = Convert.ToString(dakika);
			if (saniye==59)
			{
				saniye = 0;
				dakika += 1;
				if (dakika==59)
				{
					dakika = 0;
					saat += 1;
				}
			}

		}

		private void btndurdur_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		private void btnsifirla_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			saat = 0;
			dakika = 0;
			saniye = 0;

			lblSaat.Text = Convert.ToString("0");
			lblSaniye.Text = Convert.ToString("0");
			lblDakika.Text = Convert.ToString("0");

		}
	}
}
