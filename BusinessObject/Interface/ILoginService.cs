using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;


namespace BusinessObject.Interface
{
    public interface ILoginService
    {
        public Task<User?> ValidateUserAsync(string email, string password);
    }
}
