using System;
using System.Collections.Generic;

namespace DevStore.Domain.Repositories
{
    public interface IProductRepository : IDisposable
    {
        List<Product> Get();
        Product Get(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
