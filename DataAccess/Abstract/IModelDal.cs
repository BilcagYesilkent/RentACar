using Core.DataAccess;
using Entities.Concrete;


namespace DataAccess.Abstract;

public interface IModelDal : IEntityRepository<Model, int>
{
    //public IList<Model> GetList();
    //public Model? GetById(Model id);
    //public void Add(Model entity);
    //public void Update(Model entity);
    //public void Delete(Model entity);
}

//IModelDal modelDal = new InMemoryModelDal();
//Model modelToAdd = new Model { Id = 1, Name = "Astra" };
//modelDal.Add(modelToAdd);