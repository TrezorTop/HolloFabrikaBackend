using HolloFabrika.Api.Endpoints.Interfaces;

namespace HolloFabrika.Api.Endpoints.Categories;

public class CreateCategory : IEndpoint
{
    public static void DefineEndpoint(IEndpointRouteBuilder app)
    {
        // app.MapPost(ApiRoutes.Categories.Create, async (CreateCategoryRequest categoryRequest, CreateCategoryFeature createCategoryFeature) =>
        // {
        //     var result = await createCategoryFeature.CreateAsync(new Category
        //     {
        //         Name = categoryRequest.Name,
        //         Attributes = categoryRequest.Attributes.Select(x => new Attribute
        //         {
        //             Name = x.Name,
        //             Value = x.Value
        //         }).ToList()
        //     });
        //     
        //     if (result.IsFailed) return Results.BadRequest(result.Reasons);
        //     
        //     return Results.Ok(new CreateCategoryAttributeRequest
        //     {
        //         Name = result.Value.Name,
        //     });
        // });
    }
}