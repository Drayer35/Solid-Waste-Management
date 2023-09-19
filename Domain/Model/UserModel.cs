using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using Common.Cache;
namespace Domain.Model
{
    public class UserModel
    {
        UserDao userdao = new UserDao();
        public bool LoginUser(string username,string password) { 
            return userdao.Login(username,password);
        }
    }
}
