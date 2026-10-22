using CinemaDomain;
using CinemaRepository.Base;
using CinemaRepository.Context;

namespace CinemaRepository.Repository
{
    public class BaseRepository<TypeEntity> : IBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyDBContext _myDBContext;
        public BaseRepository(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
            _myDBContext.Set<TypeEntity>();
        }
        public void Create(TypeEntity entity)
        {
            _myDBContext.Set<TypeEntity>().Add(entity);
            _myDBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _myDBContext.Remove(ReadbyId(id));
            _myDBContext.SaveChanges();
        }

        public IList<TypeEntity> ReadAll()
        {
            var dbContext = _myDBContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList();
        }

        public TypeEntity ReadbyId(int id)
        {
            var dbContext = _myDBContext.Set<TypeEntity>().AsQueryable();
            return dbContext.ToList().Find(x => x.Id == id);
        }

        public void Update(TypeEntity entity)
        {
            _myDBContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _myDBContext.SaveChanges();
        }
    }
}
