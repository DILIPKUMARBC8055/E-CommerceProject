﻿
using Catalog.Application.Responses;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetProductsByBrandQuery : IRequest<IList<ProductResponse>>
    {
        public GetProductsByBrandQuery(string brandName)
        {
            BrandName = brandName;
        }

        public string BrandName { get; }
    }
}
