namespace PieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PieDbContext _context;

        public CategoryRepository(PieDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> AllCategories => _context.Categories.OrderBy(c => c.CategoryName);
    }
}
