namespace _11_tree_list_view
{
    class FileViewModel
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public FileViewModel(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public override string ToString() => Name;
    }
}
