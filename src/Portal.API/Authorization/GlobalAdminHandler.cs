using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Portal.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.API.Authorization
{
    public class GlobalAdminHandler : AuthorizationHandler<GlobalAdminRequirement>
    {
        private readonly IProductRepository _productRepository;

        public GlobalAdminHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository ??
                throw new ArgumentNullException(nameof(productRepository));
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, GlobalAdminRequirement requirement)
        {
            var userId = context.User.Claims.FirstOrDefault(c => c.Type == "sub").Value;

            if (_productRepository.GetProducts(int.Parse(userId)).Count() < 3)
            {
                context.Fail();
                return Task.CompletedTask;
            }

            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
