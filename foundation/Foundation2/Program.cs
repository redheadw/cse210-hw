using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Use the full path of your CSV file with @ for verbatim string
        string csvFilePath = @"C:\Users\thort\Downloads\cse 210\cse210-hw\foundation\Foundation2\orders.csv";
        
        List<Order> orders = ReadOrdersFromCSV(csvFilePath);

        // Display each order
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}\n");
        }
    }

    static List<Order> ReadOrdersFromCSV(string filePath)
    {
        List<Order> orders = new List<Order>();
        Dictionary<string, Order> customerOrders = new Dictionary<string, Order>();

        string[] lines = File.ReadAllLines(filePath);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] fields = ParseCSVLine(line);

            // Parse product and customer information
            string productName = fields[0];
            string productId = fields[1];
            double pricePerUnit = double.Parse(fields[2].Trim());
            int quantity = int.Parse(fields[3]);
            string customerName = fields[4];
            string streetAddress = fields[5];
            string city = fields[6];
            string state = fields[7];
            string country = fields[8];

            // Create Address, Customer, and Product objects
            Address address = new Address(streetAddress, city, state, country);
            Customer customer = new Customer(customerName, address);
            Product product = new Product(productName, productId, pricePerUnit, quantity);

            // Check if an order for the customer already exists
            if (!customerOrders.ContainsKey(customerName))
            {
                Order newOrder = new Order(customer);
                customerOrders[customerName] = newOrder;
                orders.Add(newOrder);
            }

            // Add the product to the existing order
            customerOrders[customerName].AddProduct(product);
        }

        return orders;
    }
    static string[] ParseCSVLine(string line)
    {
        List<string> result = new List<string>();
        bool insideQuote = false;
        string currentField = string.Empty;
        foreach (char c in line)
        {
            if (c == '"')
            {
                insideQuote = !insideQuote;
            }
            else if (c == ',' && !insideQuote)
            {
                result.Add(currentField);
                currentField = string.Empty;
            }
            else
            {
                currentField += c;
            }
        }
        result.Add(currentField);
        return result.ToArray();
    }
}