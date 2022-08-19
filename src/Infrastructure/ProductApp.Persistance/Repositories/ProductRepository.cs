using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Entities;
using ProductApp.Persistance.Context;

namespace ProductApp.Persistance.Repositories
{
    public class ProductRepository :EfRepository<Product,ApplicationDbContext> ,IProductRepository
    {
    }
}
