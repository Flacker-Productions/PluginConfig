namespace PluginConfig
{
	partial class Editor
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
			tbxEditor = new FastColoredTextBoxNS.FastColoredTextBox();
			((System.ComponentModel.ISupportInitialize)tbxEditor).BeginInit();
			SuspendLayout();
			// 
			// tbxEditor
			// 
			tbxEditor.AccessibleDescription = "Textbox control";
			tbxEditor.AccessibleName = "Fast Colored Text Box";
			tbxEditor.AccessibleRole = AccessibleRole.Text;
			tbxEditor.AutoCompleteBracketsList = new char[]
	{
	'(',
	')',
	'{',
	'}',
	'[',
	']',
	'"',
	'"',
	'\'',
	'\''
	};
			tbxEditor.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
			tbxEditor.AutoScrollMinSize = new Size(75, 14);
			tbxEditor.BackBrush = null;
			tbxEditor.BackColor = Color.FromArgb(17, 17, 17);
			tbxEditor.CharHeight = 14;
			tbxEditor.CharWidth = 8;
			tbxEditor.DefaultMarkerSize = 8;
			tbxEditor.DisabledColor = Color.FromArgb(100, 180, 180, 180);
			tbxEditor.Dock = DockStyle.Fill;
			tbxEditor.FindForm = null;
			tbxEditor.ForeColor = Color.Crimson;
			tbxEditor.GoToForm = null;
			tbxEditor.Hotkeys = resources.GetString("tbxEditor.Hotkeys");
			tbxEditor.IndentBackColor = Color.FromArgb(38, 38, 38);
			tbxEditor.IsReplaceMode = false;
			tbxEditor.LineNumberColor = Color.Crimson;
			tbxEditor.Location = new Point(0, 0);
			tbxEditor.Name = "tbxEditor";
			tbxEditor.Paddings = new Padding(0);
			tbxEditor.ReplaceForm = null;
			tbxEditor.SelectionColor = Color.FromArgb(60, 220, 20, 60);
			tbxEditor.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("tbxEditor.ServiceColors");
			tbxEditor.Size = new Size(1018, 562);
			tbxEditor.TabIndex = 0;
			tbxEditor.Text = "Editor";
			tbxEditor.ToolTipDelay = 100;
			tbxEditor.Zoom = 100;
			tbxEditor.TextChanged += tbxEditor_TextChanged;
			tbxEditor.Load += Editor_Load;
			tbxEditor.KeyDown += tbxEditor_KeyDown;
			// 
			// Editor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1018, 562);
			Controls.Add(tbxEditor);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Editor";
			Text = "Editor";
			TopMost = true;
			FormClosing += Editor_FormClosing;
			Load += Editor_Load;
			((System.ComponentModel.ISupportInitialize)tbxEditor).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private FastColoredTextBoxNS.FastColoredTextBox tbxEditor;
	}
}