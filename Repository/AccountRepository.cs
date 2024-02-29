using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Repository
{
    public class AccountRepository
    {


        private readonly ApplicationDbContext _applicationDbContext;

        public AccountRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public string GetMyName()
        {
            throw new NotImplementedException();
        }

        public List<RegisterModel> GetUsers()
        {
            throw new NotImplementedException();
        }

        public LoginModel GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public List<RegisterModel> UpdateUser(int id, RegisterModel request)
        {
            throw new NotImplementedException();
        }
    }
}
