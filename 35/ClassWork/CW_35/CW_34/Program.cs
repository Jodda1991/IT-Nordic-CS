using CW_34.Data;
using CW_34.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CW_34
{
    class Program
    {
        private static OnlineStoreContext _context = new OnlineStoreContext();

        static void Main(string[] args)
        {
            //InsertCustomers();
            //InsertProducts();

            // SelectCustomers();

            //MoreQueries();

            //UpdateCustomers();

            //UpdateProductsDisconnected();

            DeleteCustomers();
        }

        private static void DeleteCustomers()
        {
            // var customer = _context.Customers.First(c=>c.Id==3);
            var customer = new Customer { Id = 4 };
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        private static void UpdateProductsDisconnected()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Polaroid",
                Price = 10M - 10M * 0.1M
            };
            using (var newContext = new OnlineStoreContext())
            {
                newContext.Products.Update(product);
                newContext.SaveChanges();
            }
        }

        private static void UpdateCustomers()
        {
            var customer = _context.Customers.Last();
            customer.Name = "Mr. " + customer.Name;
            _context.SaveChanges();
        }

        private static void MoreQueries()
        {
            //var customers = _context.Customers.Where(c => c.Name.StartsWith("Al")).ToList();

            /*var customers = _context
                .Customers
                .OrderBy(c=>c.Id)
                .Last(c=>c.Name.Length>3);
                */

            var products = _context
                .Products
                .Where(p =>EF.Functions.Like( p.Name,"iP%"))
                .ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name {product.Name} ({product.Id}) : {product.Price}");
            }
        }

        private static void SelectCustomers()
        {
            using (var context = new OnlineStoreContext())
            {
                string tom = "Tom";
                // var allCustomers = context
                //.Customers
                //.Where(x=>x.Name==tom)
                //.ToList();
                var customers = context.Customers.ToList();
                foreach(var customer in customers)
                {
                    Console.WriteLine($"Customer{customer.Name} has ID = {customer.Id}");
                }
            }
        }

        private static void InsertProducts()
        {
            var product = new Product { Name = "iPhone XsMax",Price = 119990 };
            var products = new Product[]
            {
                new Product{Name = "Samsung A8",Price = 69990},
                new Product{Name = "Sony XperiaZ",Price = 59990}
            };

            using (var context = new OnlineStoreContext())
            {
                context.Add(product);
                context.AddRange(products);
                context.SaveChanges();
            }
        }

        private static void InsertCustomers()
        {
            var customer = new Customer { Name = "Alex" };
            var customerSet = new Customer[]
            {
                new Customer {Name = "Tom"},
                new Customer {Name = "John"}
            };

            using (var context = new OnlineStoreContext())
            {
                context.Customers.Add(customer);
                context.AddRange(customerSet);
                context.SaveChanges();
            }
        }
    }
}
