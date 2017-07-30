
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
    public class PhotoHandler
    {

        
        internal PhotoHandler()
        {

        }

        
        public List<DTOPhoto> GetCurrentUsersPhotos( )
        {
            return GetPhotoGraphersPhotos(PhotoLibraryManager.LibraryMgr.LoginHandler.CurrentUser.Id);
        }
        public List<DTOPhoto> GetPhotoGraphersPhotos(int userId)
        {
            List<DTOPhoto> photos = new List<DTOPhoto>();
            var query = PhotoLibraryManager.LibraryMgr.DBContext.Users.Where(x => x.Id == userId && (x.RoleId==UserRoles.PhotographerRole)).FirstOrDefault();
            if(null!=query)
            {
                foreach (var item in query.Photos)
                {
                    DTOPhoto photo = new DTOPhoto
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                        PhotographerId = item.OwnerId,
                        DateCreated = item.DateCreated,
                        LastChanged = item.LastChanged
                    };

                    photos.Add(photo);
                }
                
            }
            return photos;
        }

        public bool AddPhoto(DTOPhoto photo)
        {
                int userId = PhotoLibraryManager.LibraryMgr.LoginHandler.CurrentUser.Id;
                //retrieve user from entity.
                var query = PhotoLibraryManager.LibraryMgr.DBContext.Users
                    .Where(x => x.Id == userId).FirstOrDefault();
                if(query!=null)
                {
                    Photo dbPhoto = new Photo
                    {
                        Name = photo.Name,
                        Description = photo.Description,
                        DateCreated = photo.DateCreated,
                        LastChanged = photo.LastChanged,
                        OwnerId = query.Id
                    };
                    query.Photos.Add(dbPhoto);
                    return PhotoLibraryManager.LibraryMgr.SaveChanges();
                
            }
            return false;
        }

      
    }
}
