namespace hellomvc.Services
{
    public interface IHelloService<T>
    {
         string HelloMvc(T model);
    }
}