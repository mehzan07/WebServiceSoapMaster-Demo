using WebIdentityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceSoapDemo;

namespace WebIdentityDemo.Repository
{
   public interface IRepository
    {

        Task<WebServiceSoapDemoSoapClient> GetInstanceAsync();
        Task<Response<IdentityModel>> LoginAsync(LoginViewModel loginView);
         Task<Response<string>> RegisterAsync(RegisterViewModel registerView);

    }
}
