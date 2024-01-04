using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WagharalkarMVCProject.Data;

namespace WagharalkarMVCProject.Models
{
    public class VideoGalleryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string YouTubeUrl { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }

        public string saveVideoGallery(VideoGalleryModel model)
        {
            WagharalKarDBEntities db = new WagharalKarDBEntities();
            string msg = "videos are saved successfully";
            var saveVideoGallery = new tblVideoGallery()
            {
                Title = model.Title,
                YouTubeUrl = model.YouTubeUrl,
                Type = model.Type,
                CreateDate = model.CreateDate,
                UpdateDate = model.UpdateDate,
                CreatedBy = model.CreatedBy,
                UpdatedBy = model.UpdatedBy

            };

            db.tblVideoGalleries.Add(saveVideoGallery);
            db.SaveChanges();
            return msg;
        }
    }
}