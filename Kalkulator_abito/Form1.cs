using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_abito
{
	public partial class Form1 : Form
	{
		double value = 0;
		string operation = "";
		bool operation_pressed = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if ((hasil.Text == "0") || (operation_pressed))
				hasil.Clear();

			operation_pressed = false;
			Button b = (Button)sender;
			hasil.Text = hasil.Text + b.Text;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			hasil.Text = hasil.Text = "0";
		}

		private void operator_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			operation = b.Text;
			value = Double.Parse(hasil.Text);
			operation_pressed = true;
			equation.Text = value + " " + operation;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			equation.Text = "";
			switch (operation)
			{
				case "+":
					hasil.Text = (value + Double.Parse(hasil.Text)).ToString();
					break;
				case "-":
					hasil.Text = (value - Double.Parse(hasil.Text)).ToString();
					break;
				case "*":
					hasil.Text = (value * Double.Parse(hasil.Text)).ToString();
					break;
				case "/":
					hasil.Text = (value / Double.Parse(hasil.Text)).ToString();
					break;
				default:
					break;
			}//akhir dari switch
		}

		private void button16_Click(object sender, EventArgs e)
		{
			hasil.Text = "0";
			value = 0;
		}
	}
}
