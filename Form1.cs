using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void buttond_Click(object sender, EventArgs e)
		{
			btn = (Button)sender;
			textBox1.Text = textBox1.Text + btn.Text;
		}

		private void buttonop_Click(object sender, EventArgs e)
		{
			btn = (Button)sender;

			if (btn.Text.Equals("="))
			{
				string temp = textBox1.Text;
				string[] strArray = { };
				int op = 0;


				if (temp.Contains("+"))
				{
					strArray = temp.Split('+');
					op = 1;
				}

				if (temp.Contains("-"))
				{
					strArray = temp.Split('-'); 
					op = 2;
				}

				if (temp.Contains("*"))
				{
					strArray = temp.Split('*');
					op = 3;
				}


				if (temp.Contains("/"))
				{
					strArray = temp.Split('/');
					op = 4;
				}

				if (op == 0)
				{
					MessageBox.Show("请检查表达式！！！");
				}
				else
				{
					float x = float.Parse(strArray[0]);
					float y = float.Parse(strArray[1]);

					switch (op)
					{
						case 1:
							{
								textBox1.Text = "" + (x + y);
								break;
							}
						case 2:
							{
								textBox1.Text = "" + (x - y);
								break;
							}
						case 3:
							{
								textBox1.Text = "" + (x * y);
								break;
							}
						case 4:
							{
								textBox1.Text = "" + (x / y);
								break;
							}
					}
				}
				
			}
			else
			{
				if (textBox1.Text.Length==0)
				{
					MessageBox.Show("请检查表达式！！！");
				}
				else
				{
					textBox1.Text = textBox1.Text + btn.Text;
				}
			}
		}
	}
}
