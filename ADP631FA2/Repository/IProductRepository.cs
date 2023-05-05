using System.Collections.Generic;
using ADP631FA2.Models;

namespace ADP631FA2.Repository 
{
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductByID(int productId);

        void InsertProduct(Product Product);

        void DeleteProduct(int ProductId);

        void UpdateProduct(Product Product);

        void Save();
    }
}

