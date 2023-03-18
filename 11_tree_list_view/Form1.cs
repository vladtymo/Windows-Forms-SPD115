using System.Diagnostics;

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

            listBox1.Items.Clear();
            foreach (var f in dir.GetFiles())
            {
                listBox1.Items.Add(new FileViewModel(f.Name, f.FullName));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            var item = listBox1.SelectedItem as FileViewModel;

            MessageBox.Show(item.Path);

            // open file: Process.Start(path);
        }
    }
}
