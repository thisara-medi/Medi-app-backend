

namespace UnitOfWorkDemo.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPatientRepository Patient { get; }
        IPatientRecordRepository PatientRecord { get; }

        int Save();
    }
}
