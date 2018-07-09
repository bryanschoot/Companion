using System;
using System.Collections.Generic;
using Companion.Services;

namespace Companion.Logic
{
    /// <summary>
    /// Here we implement the business logic for the user.
    /// </summary>
    public class User : IUser
    {
        /// <summary>
        /// Constructor for the user business logic.
        /// </summary>
        public User() {}
        
        public IEnumerable<Models.User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Models.User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(Models.User entity)
        {
            throw new NotImplementedException();
        }

        public bool Read(Models.User entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Models.User entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Models.User entity)
        {
            throw new NotImplementedException();
        }

        public Models.User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}