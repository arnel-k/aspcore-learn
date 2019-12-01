using hellomvc.Models;

namespace hellomvc.Services
{
    public class HelloService<T>: IHelloService<T> where T: class
    {
     
        public string HelloMvc(T model)
        {
            return $"Hello from mvc, {model.GetType().GetProperty("FirstName").GetValue(model)}";
        }
    }
}