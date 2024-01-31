using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

internal class EfBrandDal : IBrandDal
{
    public Brand Add(Brand entity)
    {
        throw new NotImplementedException();
    }

    public Brand Delete(Brand entity, bool softDelete)
    {
        throw new NotImplementedException();
    }

    //public IList<Brand> GetBrandsByNameSearch(string nameSearch)
    //{
    //    throw new NotImplementedException();
    //}

    public Brand? Get(Func<Brand, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IList<Brand> GetList(Func<Brand, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public Brand Update(Brand entity)
    {
        throw new NotImplementedException();
    }

    //void IEntityRepository<Brand, int>.Add(Brand entity)
    //{
    //    throw new NotImplementedException();
    //}

    //void IEntityRepository<Brand, int>.Delete(Brand entity)
    //{
    //    throw new NotImplementedException();
    //}

    //void IEntityRepository<Brand, int>.Update(Brand entity)
    //{
    //    throw new NotImplementedException();
    //}
}