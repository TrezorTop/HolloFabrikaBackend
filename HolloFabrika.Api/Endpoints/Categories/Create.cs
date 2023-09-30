using HolloFabrika.Api.Contracts;
using HolloFabrika.Api.Endpoints.Interfaces;
using HolloFabrika.Feature.Entities;
using HolloFabrika.Feature.Features.Categories;
using Attribute = HolloFabrika.Feature.Entities.Attribute;

namespace HolloFabrika.Api.Endpoints.Categories;

public class Create : IEndpoint
{
    public static void DefineEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost(ApiRoutes.Categories.Create, async (CategoryDto.CategoryRequest categoryRequest, CreateCategoryFeature createCategoryFeature) =>
        {
            var category = new Category
            {
                Name = categoryRequest.Name,
                Attributes = categoryRequest.Attributes.Select(x => new Attribute
                {
                    Name = x.Name,
                    Value = x.Value
                }).ToList()
            };

            var result = await createCategoryFeature.CreateAsync(category);

            if (result.IsFailed) return Results.BadRequest(result.Reasons);

            return Results.Ok(new CategoryDto.CategoryResponse
            {
                Id = result.Value.Id,
                Name = result.Value.Name,
                Attributes = result.Value.Attributes.Select(x => new CategoryDto.CategoryAttributeResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Value = x.Value
                }).ToList(),
            });
        });
    }
}