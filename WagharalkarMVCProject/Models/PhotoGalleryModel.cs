using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WagharalkarMVCProject.Data;

namespace WagharalkarMVCProject.Models
{
    public class PhotoGalleryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }


        public string savePhotoGallery(PhotoGalleryModel model)
        {
            //6. here, make obj of entity.then save this model field data to the database table photogallery field.
            WagharalKarDBEntities db = new WagharalKarDBEntities();
            string msg = "photogallery saved successfully";
            var savePhotoGal = new tblPhotoGallery()
            { 
                Title = model.Title,
                Image1 = model.Image1,
                Image2 = model.Image2,
                Type = model.Type,
                CreateDate = model.CreateDate,
                UpdateDate = model.UpdateDate,
                CreatedBy = model.CreatedBy,
                UpdatedBy = model.UpdatedBy
            };
            db.tblPhotoGalleries.Add(savePhotoGal);
            db.SaveChanges();
            return msg;
           
        }
    }
}