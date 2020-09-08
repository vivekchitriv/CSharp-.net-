using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Product_FIle_IO
{
    [Serializable]
    public class Product
    {
        #region private properties
        private string _title;
        private float _price;
        private string _category;
        private string _manufacturer;
        [NonSerialized]
        private string _proudct_code;
        #endregion

        #region Getter And Setter Propertis
        public string manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        public string product_code
        {
            get { return _proudct_code; }
            set { _proudct_code = value; }
        }

        public string category
        {
            get { return _category; }
            set { _category = value; }
        }

        public float price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        #endregion

        #region 0-Paramter Constructor
        public Product()
        {
            _title = " ";
            _price = 0.0f;
            _category = " ";
            _manufacturer = "";
            _proudct_code = "";
        }

        #endregion

        #region 5 Parameter COnstructor
        public Product(string title, float price, string category, string manufacturer, string proudct_code)
        {
            _title = title;
            _price = price;
            _category = category;
            _manufacturer = manufacturer;
            _proudct_code = proudct_code;
        }
        #endregion

        #region Write data into product.txt file
        public void writeDetails()
        {
            //open file in File Mode,Access
            FileStream fs = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\assignment\Assignment3\Product.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //Create Object of Binary Formatter 
            BinaryFormatter writer = new BinaryFormatter();
            //create Object of Product class
            Product prod = new Product();

            //write data into prod object
            Console.WriteLine("Enter the title");
            prod.title = Console.ReadLine();

            Console.WriteLine("Enter the Price");
            prod.price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Category");
            prod.category = Console.ReadLine();

            Console.WriteLine("Enter the manufaturer");
            prod.manufacturer = Console.ReadLine();

            Console.WriteLine("Enter the Product Code");
            prod.product_code = Console.ReadLine();

            //serialize product
            writer.Serialize(fs, prod);

            //close open object
            writer = null;

            fs.Close();
        }
        #endregion

        #region Read data from Product.txt file
        public void ReadDetails (  )
        {
            // FileStream object created for file read operation FileMode is Open and FileAccess in Read mode
            FileStream fo = new FileStream(@"D:\KDAC_Online_COurse\msnet_vivek_36441\assignment\Assignment3\Product.txt", FileMode.Open, FileAccess.Read);
            
            // create object of BinaryFormatter 
            BinaryFormatter reader = new BinaryFormatter();

            //read data from file and put on product class object
            Product readDataFromProduct = (Product)reader.Deserialize(fo);
            Console.WriteLine(readDataFromProduct.title);
            Console.WriteLine(readDataFromProduct.price);
            Console.WriteLine(readDataFromProduct.category);
            Console.WriteLine(readDataFromProduct.manufacturer);

            Console.WriteLine("Product data is Read From file successfully");

            //close open object
            reader = null;
            fo.Close();
        }
        #endregion

    }
}
