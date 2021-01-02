using System;
using System.Windows.Forms;

namespace GitHub_Badge_Generator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
  
			comboBox1.Items.AddRange(badgeColorNames);

			comboBox1.SelectedIndexChanged += (sender_, e_) =>
			{
				for (int i = 0; i < comboBox1.Items.Count; i++)
				{
					if (i == comboBox1.SelectedIndex)
					{
						badgeColor = badgeColorNames[i];
					}
				}
			};
			label.TextChanged += (sender_, e_) =>
			{
				labelText = label.Text;
			};
			message.TextChanged += (sender_, e_) =>
			{
				messageText = message.Text;
			};
		}

		private string badgeColor;
		private string labelText;
		private string messageText;

		private string[] badgeColorNames =
		{
			"brightgreen",
			"green",
			"yellowgreen",
			"yellow",
			"orange",
			"red",
			"blue",
			"lightgrey",
			"success",
			"important",
			"critical",
			"informational",
			"inactive",
			"blueviolet",
			"pink",
			"skyblue"
		};

		private void button1_Click(object sender, EventArgs e)
		{
			string url = "https://img.shields.io/badge/{0}-{1}-{2}";
			badgeLink.Text = string.Format("![](" + url + ")", labelText, messageText, badgeColor);
			badgeDisplay.Url = new Uri(string.Format(url, labelText, messageText, badgeColor));
		}

		private void badgeLink_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(badgeLink.Text);
			MessageBox.Show("Copied link to clipboard.", "Link Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
