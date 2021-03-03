using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace EFCoreTutorial.UnitOfWork
{
    internal class UnitOfWork : IDisposable
    {
        private EFCoreTutorialContext _pMDataContext;
        private IDbContextTransaction _transaction;

        public UnitOfWork()
        {
            _pMDataContext = new EFCoreTutorialContext();
            _transaction = _pMDataContext.Database.BeginTransaction();
        }

        #region Repos

        //private IProcessRepo _processRepo;
        //public IProcessRepo ProcessRepo
        //{
        //    get
        //    {
        //        if (_processRepo == null)
        //            _processRepo = new ProcessRepo(_pMDataContext);

        //        return _processRepo;
        //    }
        //}

        #endregion

        public async Task SaveChangesAsync()
        {
            _pMDataContext.SaveChanges();
            _transaction.Commit();
        }

        public void Dispose()
        {
            _pMDataContext.Dispose();
        }
    }
}
