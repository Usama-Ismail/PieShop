using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly PieDbContext _context;

        public PieRepository(PieDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pie> AllPies => _context.Pies.Include(c => c.Category);

        public IEnumerable<Pie> PiesOfTheWeek => _context.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);

        public Pie? GetPieById(int pieId)
        {
            return _context.Pies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
