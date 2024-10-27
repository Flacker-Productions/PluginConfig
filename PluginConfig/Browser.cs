using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginConfig
{
	public partial class Browser : Form
	{
		string path;

		public Browser(string path)
		{
			InitializeComponent();
			this.path = path;
		}

		private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
		{
			var directoryNode = new TreeNode(directoryInfo.Name);

			foreach (var directory in directoryInfo.GetDirectories())
			{
				directoryNode.Nodes.Add(CreateDirectoryNode(directory));
			}

			foreach (var file in directoryInfo.GetFiles())
			{
				TreeNode tn = new TreeNode(file.Name);

				if (!file.Name.EndsWith(".jar"))
					directoryNode.Nodes.Add(tn);

				if (file.Name.Contains(".")) {
					tn.ImageIndex = 1;
					tn.SelectedImageIndex = 1;
				}

				if (file.Name.EndsWith(".yml") || file.Name.EndsWith(".yaml") || file.Name.EndsWith(".conf") || file.Name.EndsWith(".json"))
				{
					tn.ImageIndex = 0;
					tn.SelectedImageIndex = 0;
				}

				if (file.Name.EndsWith(".txt"))
				{
					tn.ImageIndex = 3;
					tn.SelectedImageIndex = 3;
				}
			}

			return directoryNode;
		}

		private void Browser_Load(object sender, EventArgs e)
		{
			folderTree.Nodes.Clear();
			var rootDirectoryInfo = new DirectoryInfo(path);
			folderTree.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
		}

		private void folderTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			TreeView tv = (TreeView)sender;

			if (tv.SelectedNode.ImageIndex == 0 || tv.SelectedNode.ImageIndex == 3)
			{
				Editor editor = new Editor(tv.SelectedNode.FullPath, path);
				editor.MdiParent = MdiParent;
				editor.Show();
			}
		}
	}
}
