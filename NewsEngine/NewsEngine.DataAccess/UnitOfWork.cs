using System;
using System.Threading.Tasks;
using NewsEngine.Contracts;
using NewsEngine.Models;

namespace NewsEngine.DataAccess
{
    public class UnitOfWork : IDisposable,
        IUnitOfWork<User>,
        IUnitOfWork<Category>,
        IUnitOfWork<Group>,
        IUnitOfWork<News>
    {

        private readonly DataContext _context = new DataContext();

        private Repository<User> _userRepository;
        private Repository<Category> _categoryRepository;
        private Repository<Group> _groupRepository;
        private Repository<News> _newsRepository;


        IRepository<User> IUnitOfWork<User>.Repository
        {
            get
            {
                _userRepository = _userRepository ?? new Repository<User>(_context);
                return _userRepository;
            }
        }

        IRepository<Category> IUnitOfWork<Category>.Repository
        {
            get
            {
                _categoryRepository = _categoryRepository ?? new Repository<Category>(_context);
                return _categoryRepository;
            }
        }

        IRepository<Group> IUnitOfWork<Group>.Repository
        {
            get
            {
                _groupRepository = _groupRepository ?? new Repository<Group>(_context);
                return _groupRepository;
            }
        }

        IRepository<News> IUnitOfWork<News>.Repository
        {
            get
            {
                _newsRepository = _newsRepository ?? new Repository<News>(_context);
                return _newsRepository;
            }
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
       
        public void Dispose()
        {
            _context.Dispose();
        }       
    }
}
