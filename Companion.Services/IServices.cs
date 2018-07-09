using System.Collections.Generic;

namespace Companion.Services
{
    /// <summary>
    /// Base Interface.
    /// Contains the basic interface functions like: getAll, getByEmail etc.
    /// </summary>
    public interface IServices<TT>
    {
        IEnumerable<TT> GetAll();

        TT GetById(int id);

        bool Create(TT entity);
        bool Read(TT entity);
        bool Update(TT entity);
        bool Delete(TT entity);
    }
}