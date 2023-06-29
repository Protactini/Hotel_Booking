using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBookingService.Models;
using HotelBookingService.DAO;

namespace HotelBookingService.Services
{
    public class UserService : IUserService
    {
        private readonly IUserDAO _userDAO;

        public UserService(IUserDAO userDAO)
        {
            _userDAO = userDAO;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _userDAO.GetAllUsers();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userDAO.GetUserById(id);
        }

        public async Task<User> CreateUser(User user)
        {
            return await _userDAO.CreateUser(user);
        }

        public async Task UpdateUser(User user)
        {
            await _userDAO.UpdateUser(user);
        }

        public async Task DeleteUser(int id)
        {
            await _userDAO.DeleteUser(id);
        }
    }
}
