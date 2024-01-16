namespace ConsoleUI;

internal interface IUserDal  //Soyut //Data Access
{
    public void GetById(int id);
    public void Add(User user);
    public void Update(User user);
    public void Delete(User user);

}
