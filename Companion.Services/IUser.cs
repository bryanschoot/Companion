using Companion.Models;

namespace Companion.Services
{
    /// <summary>
    /// Implements IServices.
    /// Interface designed for the user models.
    /// </summary>
    public interface IUser : IServices<User>
    {
        User GetByEmail(string email);
    }
}