using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductQuery : IRequest<List<ProductView>>
    {

        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductView>>
        {
            private readonly IProductRepository productRepository;

            public GetAllProductsQueryHandler(IProductRepository productRepository)
            {
                this.productRepository = productRepository;
            }
            public async Task<List<ProductView>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var result =  productRepository.GetAll();
                return result.Select(x => new ProductView
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }
    }
}
