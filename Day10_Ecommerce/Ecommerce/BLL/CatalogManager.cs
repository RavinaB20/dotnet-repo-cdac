namespace BLL;
using BOL;
using DAL;

public class CatalogManager
{
    public List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        Console.WriteLine("***************");
     //   allProducts =  DBManager.GetAllProducts();
        allProducts = DBManager.GetAllProductsFromFile("../DAL/Products.json");
        Console.WriteLine("All products from file");
        return allProducts;
    }

    public Product GetProduct(int id){
        List<Product> allProducts = new List<Product>();
        allProducts = DBManager.GetAllProducts();
        Product foundProduct = null;
        foreach(Product prod in  allProducts){
            if(prod.ProductId == id){
                foundProduct = prod;
                break;
            }
        }
        return foundProduct;
    }

}
