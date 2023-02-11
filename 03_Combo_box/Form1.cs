namespace _03_Combo_box
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            LoadProducts();
        }

        private void LoadProducts()
        {
            // initialize
            products.AddRange(new[] {
                new Product() { Name = "iPhone 14 Pro", Price = 1099, Manufacture = "Apple"},
                new Product() { Name = "Ball", Price = 25, Manufacture = "Nike" },
                new Product() { Name = "T-Shirt", Price = 129, Manufacture = "Adidas" },
                new Product() { Name = "Laptop IdeaPad", Price = 580, Manufacture = "Lenono" }
            });

            // add items (manual mode)
            //productsComboBox.Items.AddRange(products.ToArray());

            UpdateProductComboBox();
        }

        private void UpdateProductComboBox()
        {
            // reset data source
            productsComboBox.DataSource = null;
            // bind data
            productsComboBox.DataSource = products;
        }

        private void AddressBtnClick(object sender, EventArgs e)
        {
            string country = countryComboBox.Text;
            string city = cityComboBox.Text;

            MessageBox.Show($"You are from {city} {country}!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if no selected item: SelectedItem: null, SelectedIndex: -1

            if (productsComboBox.SelectedItem == null)
            {
                MessageBox.Show("No selected product!");
                return;
            }

            var item = (Product)productsComboBox.SelectedItem; // object as Product;

            MessageBox.Show($"Selected product: {item.Name}, {item.Manufacture} : {item.Price}$");
        }

        private void AddProductBtnClick(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = nameTxtBox.Text,
                Price = rand.Next(10000),
                Manufacture = "no data"
            };

            products.Add(product);
            UpdateProductComboBox();
        }

        private void RemoveProductBtnClick(object sender, EventArgs e)
        {
            if (productsComboBox.SelectedItem == null) return;

            products.Remove((Product)productsComboBox.SelectedItem);
            UpdateProductComboBox();
        }
    }
}