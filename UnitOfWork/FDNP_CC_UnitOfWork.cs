using EFCoreTutorial;
using EFCoreTutorial.Repos.FDNP_CC_Repo;
using System;

namespace UnitOfWorkProject
{
    public class FDNP_CC_UnitOfWork : IDisposable
    {
        private EFCoreTutorialContext _eFCoreTutorialContext;
        //private IDbContextTransaction _transaction;
        //private Task<IDbContextTransaction> transaction;

        public FDNP_CC_UnitOfWork()
        {
            _eFCoreTutorialContext = new EFCoreTutorialContext();
            //_transaction = _eFCoreTutorialContext.Database.BeginTransaction(); //TODO Am: read why we should use this
            //transaction = _pMDataContext.Database.BeginTransactionAsync(); //TODO Am: read why we should use this
        }

        #region Repos

        private IFDNP_Address_CC_Repo _fDNP_Address_CC_Repo;
        public IFDNP_Address_CC_Repo FDNP_Address_CC_Repo
        {
            get
            {
                if(_fDNP_Address_CC_Repo == null)
                    _fDNP_Address_CC_Repo = new FDNP_Address_CC_Repo(_eFCoreTutorialContext);

                return _fDNP_Address_CC_Repo;
            }
        }

        private IFDNP_Blog_CC_Repo _fDNP_Blog_CC_Repo;
        public IFDNP_Blog_CC_Repo FDNP_Blog_CC_Repo
        {
            get
            {
                if(_fDNP_Blog_CC_Repo == null)
                    _fDNP_Blog_CC_Repo = new FDNP_Blog_CC_Repo(_eFCoreTutorialContext);

                return _fDNP_Blog_CC_Repo;
            }
        }

        private IFDNP_Blogger_CC_Repo _fDNP_Blogger_CC_Repo;
        public IFDNP_Blogger_CC_Repo FDNP_Blogger_CC_Repo
        {
            get
            {
                if(_fDNP_Blogger_CC_Repo == null)
                    _fDNP_Blogger_CC_Repo = new FDNP_Blogger_CC_Repo(_eFCoreTutorialContext);

                return _fDNP_Blogger_CC_Repo;
            }
        }

        private IFDNP_Group_CC_Repo _fDNP_Group_CC_Repo;
        public IFDNP_Group_CC_Repo FDNP_Group_CC_Repo
        {
            get
            {
                if(_fDNP_Group_CC_Repo == null)
                    _fDNP_Group_CC_Repo = new FDNP_Group_CC_Repo(_eFCoreTutorialContext);

                return _fDNP_Group_CC_Repo;
            }
        }

        private IFDNP_Point_CC_Repo _fDNP_Point_CC_Repo;
        public IFDNP_Point_CC_Repo FDNP_Point_CC_Repo
        {
            get
            {
                if(_fDNP_Point_CC_Repo == null)
                    _fDNP_Point_CC_Repo = new FDNP_Point_CC_Repo(_eFCoreTutorialContext);

                return _fDNP_Point_CC_Repo;
            }
        }

        private IFDNP_Post_CC_Repo _fDNP_Post_CC_Repo;
        public IFDNP_Post_CC_Repo FDNP_Post_CC_Repo
        {
            get
            {
                if(_fDNP_Post_CC_Repo == null)
                    _fDNP_Post_CC_Repo = new FDNP_Post_CC_Repo(_eFCoreTutorialContext);

                return _fDNP_Post_CC_Repo;
            }
        }

        private IFDNP_Process_CC_Repo _fDNP_Process_CC_Repo;
        public IFDNP_Process_CC_Repo FDNP_Process_CC_Repo
        {
            get
            {
                if(_fDNP_Process_CC_Repo == null)
                    _fDNP_Process_CC_Repo = new FDNP_Process_CC_Repo(_eFCoreTutorialContext);

                return _fDNP_Process_CC_Repo;
            }
        }

        private IFDNP_Tag_CC_Repo _fDNP_Tag_CC_Repo;
        public IFDNP_Tag_CC_Repo FDNP_Tag_CC_Repo
        {
            get
            {
                if(_fDNP_Tag_CC_Repo == null)
                    _fDNP_Tag_CC_Repo = new FDNP_Tag_CC_Repo(_eFCoreTutorialContext);

                return _fDNP_Tag_CC_Repo;
            }
        }

        #endregion

        #region public methods

        public void SaveChanges()
        {
            _eFCoreTutorialContext.SaveChanges();//TODO AM: _pMDataContext has async as well, see if it works as well
            //transaction.Result.Commit();
            //_transaction.Commit();
        }

        public void Dispose()
        {
            _eFCoreTutorialContext.Dispose();
        }

        #endregion
    }
}
