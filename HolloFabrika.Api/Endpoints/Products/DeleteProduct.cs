using HolloFabrika.Api.Contracts;
using HolloFabrika.Api.Endpoints.Interfaces;
using HolloFabrika.Feature.Features.Products;

namespace HolloFabrika.Api.Endpoints.Products;

public class DeleteProduct : IEndpoint
{
    public static void DefineEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete(ApiRoutes.Products.Delete, async (string id, DeleteProductFeature deleteProductFeature) =>
        {
            var result = await deleteProductFeature.Delete(id);

            if (result.IsFailed) return Results.NotFound(result.Reasons);

            return Results.Ok(result.Value);
        });
    }
}