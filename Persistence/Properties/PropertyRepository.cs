using System;
using System.Threading.Tasks;
using Domain.Properties;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Properties
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly DataContext _context;
        public PropertyRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<Property> GetByIdAsync(int id)
        {
            return await _context.Peoperties
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveAsync(Property property)
        {
            _context.Peoperties.Add(property);
            return _context.SaveChangesAsync();
        }
    }
}