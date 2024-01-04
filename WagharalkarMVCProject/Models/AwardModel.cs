using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WagharalkarMVCProject.Data;

namespace WagharalkarMVCProject.Models
{
    public class AwardModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }

        public string saveAward(AwardModel model)
        {
            WagharalKarDBEntities db = new WagharalKarDBEntities();
            string msg = "award saved successfully";
            var saveAward = new tblAward()
            {
                Title = model.Title,
                Details = model.Details,
                Image1 = model.Image1,
                Image2 = model.Image2,
                Type = model.Type,
                Date=model.Date,
                CreateDate = model.CreateDate,
                UpdateDate = model.UpdateDate,
                CreatedBy = model.CreatedBy,
                UpdatedBy = model.UpdatedBy
            };
            db.tblAwards.Add(saveAward);
            db.SaveChanges();
            return msg;
        }
    }
}