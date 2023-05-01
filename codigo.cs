using System;
using System.Collections.Generic;

public class Class1
{
	public Class1()
	{

    {
    public class WebStore
    {
        private List<Product> products;
        private List<User> users;
        private List<Review> reviews;

        public WebStore()
        {
            products = new List<Product>();
            users = new List<User>();
            reviews = new List<Review>();
        }

        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public void removeProduct(Product product)
        {
            products.Remove(product);
        }

        public void addUser(User user)
        {
            users.Add(user);
        }

        public void removeUser(User user)
        {
            users.Remove(user);
        }

        public void addReview(Review review)
        {
            reviews.Add(review);
        }

        public void removeReview(Review review)
        {
            reviews.Remove(review);
        }
    }

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public List<string> images { get; set; }
        public string description { get; set; }
        public double basePrice { get; set; }
        public double discount { get; set; }
        public Category category { get; set; }
        public Subcategory subcategory { get; set; }
        public List<string> labels { get; set; }
    }

    public class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
        public string dni { get; set; }
        public List<Order> orders { get; set; }
        public List<Product> wishlist { get; set; }
    }

    public class Review
    {
        public Product product { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public List<Subcategory> subcategories { get; set; }
    }

    public class Subcategory
    {
        public string name { get; set; }
        public List<Subcategory> subcategories { get; set; }
    }

    public class Order
    {
        public string orderNumber { get; set; }
        public DateTime orderDate { get; set; }
        public List<Product> products { get; set; }
        public List<int> quantity { get; set; }
        public double totalPrice { get; set; }
    }
}
