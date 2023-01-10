namespace DAL;
using BOL;
using System.Text.Json;
using MySql.Data.MySqlClient;

public class DBManager
{
    public static string conStr = @"server=localhost;port=3306;user=root;password=root123;database=ravinaorg";

    public static List<Product> GetAllProductsFromDatabase(){
        //Connected Data Access
        List<Product> allProducts = new List<Product>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conStr;
        try{
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string query = "select * from products";
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                int productId = int.Parse(reader["productId"].ToString());
                string productName = reader["productName"].ToString();
                double price = double.Parse(reader["price"].ToString());
                int quantity = int.Parse(reader["quantity"].ToString());

                Product prod = new Product { ProductId = productId, ProductName=productName, Price = price, Quantity=quantity};
                allProducts.Add(prod);
            }
        }   
        catch(Exception e){
            Console.WriteLine(e.Message);
        } 
        finally{
            con.Close();
        }
        return allProducts;

        return allProducts;
    }

    public static List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        allProducts.Add(new Product{ProductId = 101, ProductName = "Pen" , Price = 10 , Quantity = 100});
        allProducts.Add(new Product{ProductId = 102, ProductName = "Pensil" , Price = 5 , Quantity = 200});
        allProducts.Add(new Product{ProductId = 103, ProductName = "Eraser" , Price = 7 , Quantity = 75});
        allProducts.Add(new Product{ProductId = 104, ProductName = "Sharpner" , Price = 20 , Quantity = 34});
        allProducts.Add(new Product{ProductId = 105, ProductName = "Scale" , Price = 50 , Quantity = 98});
        return allProducts;
    }   



    public static List<Product> GetAllProductsFromFile(String path){
        string jsonString = File.ReadAllText(path);
        List<Product> allProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
        return allProducts;
    }


}
