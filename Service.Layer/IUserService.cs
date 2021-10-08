using Data.Access.Layer;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Service.Layer
{
    /// <summary>
    /// Interface for service method calls 
    /// </summary>
    public interface IUserService
    {
        void Init();
        Task<HttpResponseMessage> onCreate(UserModel user);
        Task<HttpResponseMessage> onUpdate(UserModel user);
        Task<HttpResponseMessage> onDelete(int user);
        Task<IList<User>> onGetUsers();
        Task<User> onGetUserById(int id);
        Task<IList<User>> onGetUserByName(string name);
    }
}
