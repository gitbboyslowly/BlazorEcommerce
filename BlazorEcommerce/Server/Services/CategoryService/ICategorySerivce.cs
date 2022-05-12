namespace BlazorEcommerce.Server.Services.CategoryService
{
    public interface ICategorySerivce
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
