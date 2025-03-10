using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret
{
    public class Controllers
    {
        
        List<Customer> users = new List<Customer>();
        List<Seller> user = new List<Seller>();
        List<Product> cart = new List<Product>();
        List<Product> productList = new List<Product>();
        public void AddUser(string name, string email, string password, int age)
        {
            Customer customer = new Customer(name, email, password, 1, age);
            users.Add(customer);
            Console.WriteLine("Kullanıcı eklendi");

        }
        public void AddUser(string name, string email, string password, string taxId, string location)
        {

            Seller seller = new Seller(name, email, password, 2, taxId, location);
            user.Add(seller);
            Console.WriteLine("Kullanıcı eklendi");
        }

        public int CheckUser(string email, string password, int type)
        {

            if (type == 1)
            {
                Customer FoundCustomer = users.FirstOrDefault(x => x.Email == email && x.CheckPassword(password));
                if (FoundCustomer != null)
                {
                    Console.WriteLine("Login Successfull!!");
                    return 10;
                }
                else
                {
                    Console.WriteLine("Invalid EMail or Password");
                    return 0;

                }
            }
            else if (type == 2)
            {
                Seller FoundSeller = user.FirstOrDefault(a => a.Email == email && a.CheckPassword(password));
                if (FoundSeller != null)
                {
                    Console.WriteLine("Login Successfull!!");
                    return 15;
                }
                else
                {
                    Console.WriteLine("Invalid EMail or Password");
                    return 0;

                }
            }
            else
            {
                return 0;
            }
        }
        

        public void AddProduct()
        {
        Console.WriteLine("Add a Product");
        Console.Write("Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Product Type: ");
        string type = Console.ReadLine();

        Console.Write("Stock Quantity: ");
        int stock = Convert.ToInt32(Console.ReadLine());

        // Yeni ürünü oluştur ve listeye ekle
        Product newProduct = new Product(name, type, stock);
        productList.Add(newProduct);

        Console.WriteLine("Product added successfully!");
        }
        
        public void ShowProducts()
        {
        Console.WriteLine("Available Products:");
        foreach (Product product in productList)
        {
            if (product.Stock > 0) // Stoğu 0 olan ürünler gösterilmeyecek
            {
                Console.WriteLine($"Name: {product.Name}, Type: {product.Type}, Stock: {product.Stock}");
            }
        }
    }

        public void AddToCart()
        {
            Console.Write("Enter Product Name to Add to Cart: ");
            string selectedProduct = Console.ReadLine();

            Product product = productList.FirstOrDefault(p => p.Name == selectedProduct && p.Stock > 0);

            if (product != null)
            {
            cart.Add(product);
            product.Stock--; 
            Console.WriteLine($"{product.Name} added to cart.");
        }
        else
        {
        Console.WriteLine("Product not available.");
        }
    }
        public void ShowCart()
        {
        Console.WriteLine("Your Cart:");
        foreach (Product product in cart)
        {
        Console.WriteLine($"- {product.Name} ({product.Type})");
        }
    }

    }
}
