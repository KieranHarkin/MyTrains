﻿using System.Threading.Tasks;
using MyTrains.Core.Models;

namespace MyTrains.Core.Contracts.Services
{
    public interface IUserDataService
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);

        User GetActiveUser();
    }
}