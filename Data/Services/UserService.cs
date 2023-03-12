using Primal_e.Data.Models;
using Primal_e.Data.Dtos;

namespace Primal_e.Data.Services
{
    public class UserService
    {
        PolyAiContext _db;
        public UserService()
        {
            _db = new PolyAiContext();
        }


        public async Task<AddUserResponse> AddUserAsync(User user, CancellationToken cancellationToken = default(CancellationToken))
        {
            AddUserResponse response = new AddUserResponse();
            if (IsUserExist(user.EmailAddress))
            {
                response.Statues = false;
                response.Message = "The user already exists";
                return response;
            }
            await _db.Users.AddAsync(user, cancellationToken);
           
            response.Statues =  _db.SaveChanges();;
            response.Message = "The user Added successfully";
            return response;

        }


        private bool IsUserExist(string emailAddress)
        {
            return _db.Users.Any(c => c.EmailAddress == emailAddress);
        }
    }
}