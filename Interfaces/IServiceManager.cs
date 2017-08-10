namespace ServiceLocater.Interfaces
{
    public interface IServiceManager
    {
        T GetService<T>();
    }
}
