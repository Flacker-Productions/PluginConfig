namespace PluginConfig
{
	partial class Browser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
			folderTree = new TreeView();
			icons = new ImageList(components);
			SuspendLayout();
			// 
			// folderTree
			// 
			folderTree.BackColor = Color.FromArgb(17, 17, 17);
			folderTree.Dock = DockStyle.Fill;
			folderTree.ForeColor = Color.Crimson;
			folderTree.ImageIndex = 2;
			folderTree.ImageList = icons;
			folderTree.Location = new Point(0, 0);
			folderTree.Name = "folderTree";
			folderTree.SelectedImageIndex = 2;
			folderTree.Size = new Size(324, 548);
			folderTree.TabIndex = 0;
			folderTree.NodeMouseDoubleClick += folderTree_NodeMouseDoubleClick;
			// 
			// icons
			// 
			icons.ColorDepth = ColorDepth.Depth32Bit;
			icons.ImageStream = (ImageListStreamer)resources.GetObject("icons.ImageStream");
			icons.TransparentColor = Color.Transparent;
			icons.Images.SetKeyName(0, "cog");
			icons.Images.SetKeyName(1, "empty");
			icons.Images.SetKeyName(2, "folder");
			icons.Images.SetKeyName(3, "text");
			// 
			// Browser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(324, 548);
			ControlBox = false;
			Controls.Add(folderTree);
			FormBorderStyle = FormBorderStyle.None;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Browser";
			Text = "Browser";
			Load += Browser_Load;
			ResumeLayout(false);
		}

		#endregion

		private TreeView folderTree;
		private ImageList icons;
	}
}