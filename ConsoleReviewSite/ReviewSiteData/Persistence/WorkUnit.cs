using ReviewSiteData.Base;
using ReviewSiteData.Base.Repo;
using ReviewSiteData.Persistence.Repo;

namespace ReviewSiteData.Persistence
{
    public class WorkUnit : IWorkUnit
    {
        private readonly ReviewSiteContext _context;

        public IRestaurantRepository Restaurants { get; }
        
        public WorkUnit(ReviewSiteContext context)
        {
            _context = context;
            Restaurants = new RestaurantRepository(_context);
        }

        public int SaveChanges() => _context.SaveChanges();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
