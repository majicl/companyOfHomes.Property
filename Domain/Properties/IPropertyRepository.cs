using System.Threading.Tasks;

namespace Domain.Properties
{
    public interface IPropertyRepository
    {
        Task<Property> GetByIdAsync(int id);
        Task<int> SaveAsync(Property property);
    }
}
