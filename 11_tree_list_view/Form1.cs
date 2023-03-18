using System.Diagnostics;
using System.Windows.Forms;

namespace _11_tree_list_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            treeView1.Nodes.Clear();

            // "C:\Users\Vlad"
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            LoadDirectories(userProfilePath, treeView1.Nodes);
        }

        private void LoadDirectories(string root, TreeNodeCollection nodes)
        {
            try
            {
                var dirInfo = new DirectoryInfo(root);

                foreach (var d in dirInfo.GetDirectories())
                {
                    // create directory node
                    TreeNode node = new TreeNode(d.Name);
                    node.Tag = d.FullName;

                    // recursively load subdirectories
                    LoadDirectories(d.FullName, node.Nodes);

                    // add node to the collection
                    nodes.Add(node);
                }
            }
            catch { }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            var node = treeView1.SelectedNode;

            if (node.Tag == null) return;

            DirectoryInfo dir = new(node.Tag.ToString());

            listView1.Items.Clear();
            foreach (var f in dir.GetFiles())
            {
                ListViewItem item = new(f.Name, 0);

                item.SubItems.Add(Path.GetExtension(f.Name));
                item.SubItems.Add($"{Math.Round(f.Length / 1024.0, 2, MidpointRounding.ToEven)} KB");

                item.Tag = f.FullName;
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var path = listView1.SelectedItems[0].Tag.ToString();

            MessageBox.Show(path);

            // open file: Process.Start(path);
        }
    }
}
