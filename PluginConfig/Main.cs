namespace PluginConfig
{
	public partial class Main : Form
	{
		public string rootPath = "";
		string pluginsPath = "";

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			rootFolderBrowser.Description = "Select the root folder of the server!";
			rootFolderBrowser.UseDescriptionForTitle = true;

			while (!Directory.Exists(rootFolderBrowser.SelectedPath + @"\plugins"))
				rootFolderBrowser.ShowDialog();
			rootPath = rootFolderBrowser.SelectedPath;

			pluginsPath = rootPath + @"\plugins";

			Text += " - " + pluginsPath;

			Browser browser = new Browser(pluginsPath);
			browser.MdiParent = this;
			browser.Dock = DockStyle.Left;
			browser.Show();

			TopMost = true;
			TopMost = false;
		}
	}
}
