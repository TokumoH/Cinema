using CinemaDomain.Base;
using System;
using System.Collections.Generic;
using System.Text;


namespace CinemaRepository.Base
{
    public interface IBaseRepository<TypeEntity> where TypeEntity : IBaseEntity // typeEnity eh o tipo generico
    {
        void Create(TypeEntity entity);
        TypeEntity ReadbyId(int id);
        IList<TypeEntity> ReadAll();
        void Update(TypeEntity entity);
        void Delete(int id);
    }
}
