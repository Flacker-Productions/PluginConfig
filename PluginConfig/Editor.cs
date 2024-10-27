using FastColoredTextBoxNS;
using FastColoredTextBoxNS.Text;
using FastColoredTextBoxNS.Types;
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

namespace PluginConfig
{
	public partial class Editor : Form
	{
		string rootPath;
		string filePath;
		private string selectedFile = "";

		private readonly TextStyle keyStyle = new TextStyle(Brushes.Crimson, null, FontStyle.Regular);
		private readonly TextStyle valueStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
		private readonly TextStyle commentStyle = new TextStyle(Brushes.Gray, null, FontStyle.Italic);
		private readonly TextStyle specialCharStyle = new TextStyle(Brushes.Crimson, null, FontStyle.Bold);

		public Editor(string filePath, string rootPath)
		{
			InitializeComponent();
			this.filePath = filePath;
			this.rootPath = rootPath;
		}

		private void Editor_Load(object sender, EventArgs e)
		{
			tbxEditor.Clear();

			//          |         *Held together by duct tape*            |
			//          |                                                 |
			//          V                                                 V
			selectedFile = (rootPath + filePath).Replace("pluginsplugins", "plugins");

			Text = selectedFile.Split('\\')[selectedFile.Split('\\').Length - 2] + "\\" + selectedFile.Split('\\')[selectedFile.Split('\\').Length - 1];

			StreamReader sr = new StreamReader(selectedFile);

			tbxEditor.Text += sr.ReadToEnd() + "\n";

			sr.Close();
		}

		private void tbxEditor_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (selectedFile.EndsWith(".yml") || selectedFile.EndsWith(".yaml"))
			{
				e.ChangedRange.ClearStyle(keyStyle, valueStyle, commentStyle, specialCharStyle);

				ApplySpecialCharStyle(e);
				ApplyCommentStyle(e);
				ApplyKeyStyle(e);
				ApplyValueStyle(e);
			}

			if (selectedFile.EndsWith(".txt"))
				e.ChangedRange.ClearStyle(keyStyle, valueStyle, commentStyle, specialCharStyle);

			if (selectedFile.EndsWith(".json"))
				tbxEditor.Language = Language.JSON;
		}

		private void ApplyKeyStyle(TextChangedEventArgs e)
		{
			e.ChangedRange.SetStyle(keyStyle, @"^\s*([a-zA-Z0-9_\-\.]+):", RegexOptions.Multiline);
		}

		private void ApplyValueStyle(TextChangedEventArgs e)
		{
			e.ChangedRange.SetStyle(valueStyle, @":\s*(""[^""]*""|'[^']*'|[^\s#]+)", RegexOptions.Multiline);
		}

		private void ApplyCommentStyle(TextChangedEventArgs e)
		{
			e.ChangedRange.SetStyle(commentStyle, @"#.*$", RegexOptions.Multiline);
		}

		private void ApplySpecialCharStyle(TextChangedEventArgs e)
		{
			e.ChangedRange.SetStyle(specialCharStyle, @"^\s*-\s|(\||>)\s*$", RegexOptions.Multiline);
		}

		private void tbxEditor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				StreamWriter sw = new StreamWriter(selectedFile);
				sw.Write(tbxEditor.Text);
				sw.Close();

				Text = selectedFile.Split('\\')[selectedFile.Split('\\').Length - 2] + "\\" + selectedFile.Split('\\')[selectedFile.Split('\\').Length - 1];
			} else
			{
				Text = "* " + selectedFile.Split('\\')[selectedFile.Split('\\').Length - 2] + "\\" + selectedFile.Split('\\')[selectedFile.Split('\\').Length - 1];
			}
		}

		private void Editor_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Text[0] == '*')
			{
				DialogResult result = MessageBox.Show("Unsaved changes.\nClose without saving?", "", MessageBoxButtons.YesNo);

				if (result == DialogResult.No)
					e.Cancel = true;
			}
		}
	}
}