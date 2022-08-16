using ConsoleWebApi.Models;

namespace ConsoleWebApi.Repositry
{
    public interface IProductRepositry
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();
    }
}