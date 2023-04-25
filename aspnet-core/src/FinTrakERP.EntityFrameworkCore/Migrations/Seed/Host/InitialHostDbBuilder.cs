using FinTrakERP.EntityFrameworkCore;

namespace FinTrakERP.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly FinTrakERPDbContext _context;

        public InitialHostDbBuilder(FinTrakERPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
