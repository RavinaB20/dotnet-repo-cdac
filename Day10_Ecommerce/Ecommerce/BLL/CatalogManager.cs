namespace BLL;
using BOL;
using DAL;

public class CatalogManager
{
    public List<Product> GetAllProducts(){
        List<Product> allProducts = new List<Product>();
        
        /* TO GET HARDCODED DATA - USER DEFINED LIST
          allProducts =  DBManager.GetAllProducts();
        */
        /*  TO GET PRODUCTS FROM FILE
            allProducts = DBManager.GetAllProductsFromFile("../DAL/Products.json");
        */
        //GET PRODUCT FROM DB
        allProducts = DBManager.GetAllProductsFromDatabase();
        return allProducts;
    }

    public Product GetProduct(int id){
        List<Product> allProducts = new List<Product>();
        allProducts = DBManager.GetAllProductsFromDatabase();
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
