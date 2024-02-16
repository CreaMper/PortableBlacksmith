using PortableBlacksmith.EF;

namespace PortableBlacksmith.WebAPI.Services
{
    public class DatabaseInitializationService
    {
        private readonly PBDBContext _context;

        public DatabaseInitializationService(PBDBContext context)
        {
            _context = context;
        }

        public void FillWithData()
        {
            _context.InitialDataFill();
        }
    }
}
