namespace HolloFabrika.Api.Contracts;

public static class ApiRoutes
{
    public static class Products
    {
        private const string Base = "/product";

        public const string Get = Base;

        public const string GetById = $"{Base}/{{id:guid}}";

        public const string Create = Base;

        public const string Delete = $"{Base}/{{id:guid}}";

        public const string Update = $"{Base}/{{id:guid}}";
    }

    public static class Categories
    {
        private const string Base = "/category";

        public const string Get = Base;

        public const string GetById = $"{Base}/{{id:guid}}";

        public const string Create = Base;

        public const string Delete = $"{Base}/{{id:guid}}";
        
        public const string Update = $"{Base}/{{id:guid}}";
    }

    public static class Attributes
    {
        private const string Base = "/attribute";

        public const string Get = Base;

        public const string GetById = $"{Base}/{{id:guid}}";

        public const string Create = Base;

        public const string Delete = $"{Base}/{{id:guid}}";
        
        public const string Update = $"{Base}/{{id:guid}}";
    }
}