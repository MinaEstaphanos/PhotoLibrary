
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
    public class LoginHandler
    {
        public DTOUser CurrentUser{get { return _currentUser; }}

        private DTOUser _currentUser = null;

        internal LoginHandler()
        {
            _currentUser = new DTOUser { RoleId = (int)UserRoles.GuestRole }; ;
        }


        public bool UserLogin(string email, string password)
        {
            var query = PhotoLibraryManager.LibraryMgr.DBContext.Users.Where(x => (x.Email.ToLower() == email.ToLower()) &&
            PhotoLibraryHelper.PasswordManager.HashPassword(password) == x.Password).FirstOrDefault();

            if (null == query)
                return false;

            _currentUser = new DTOUser { Id = query.Id, Email = query.Email,
                RoleId = (int)query.RoleId,DateCreated = query.DateCreated,LastChanged = query.LastChanged};

            return true;

        }


    }
}
