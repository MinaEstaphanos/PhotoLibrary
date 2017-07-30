using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoLibrary.DTO;
using PhotoLibrary.DAL;
using PhotoLibraryHelper;

namespace PhotoLibrary.BLL
{
    public class PhotoLibraryManager
    {

        private static PhotoLibraryManager _libraryMgr = null;

        public static PhotoLibraryManager LibraryMgr { get {
                if (null == _libraryMgr)
                    _libraryMgr = new PhotoLibraryManager();

                return _libraryMgr;
            } }

        public LoginHandler LoginHandler { get { return _loginHandler; }  }
        public PhotoHandler PhotoHandler { get { return _photoHandler; } }

        public PhotoLibraryEntities DBContext { get { return _photoLibDb; } }

        private LoginHandler _loginHandler = null;
        private PhotoHandler _photoHandler = null;


        private PhotoLibraryEntities _photoLibDb = null;
                

        private PhotoLibraryManager()
        {
            _photoLibDb = new PhotoLibraryEntities();

            _loginHandler = new LoginHandler();
            _photoHandler = new PhotoHandler();

        }
        
        public bool SaveChanges()
        {
            return 0<_photoLibDb.SaveChanges();
        }

    }

}

