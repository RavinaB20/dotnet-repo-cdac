using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using BOL;
using BLL;

namespace EStoreWebApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        CatalogManager manager = new CatalogManager();
        List<Product> allProducts = manager.GetAllProducts();
        this.ViewData["products"] = allProducts;
        return View();
    }

    public IActionResult Details(int id){
        CatalogManager manager = new CatalogManager();
        Product foundProd = manager.GetProduct(id);
        this.ViewData["product"] = foundProd;
        return View();
    }
}
