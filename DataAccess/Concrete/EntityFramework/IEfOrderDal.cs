namespace DataAccess.Concrete.EntityFramework
{
    public interface IEfOrderDal
    {
        bool Equals(object? obj);
        int GetHashCode();
        string? ToString();
    }
}