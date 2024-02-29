using WebApplication4.Models;

namespace WebApplication4.Repository
{
    public interface IAccountRepository
    {
        string GetMyName();


        List<RegisterModel> GetUsers();


    }
}
