

namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPatientRepository Patient { get; }

        int Save();
    }
}
