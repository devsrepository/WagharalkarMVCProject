using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WagharalkarMVCProject.Data;

namespace WagharalkarMVCProject.Models
{
    public class ActivityModel
    {
        public int ID { get; set; }
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


        public string saveActivity(ActivityModel model)
        {
            WagharalKarDBEntities db = new WagharalKarDBEntities();
            string msg = "activities done successfully";
            var saveActivity = new tblActivity()
            {
                Title = model.Title,
                Details = model.Details,
                Image1 = model.Image1,
                Image2 = model.Image2,
                Type = model.Type,
                Date = model.Date,
                CreateDate = model.CreateDate,
                UpdateDate = model.UpdateDate,
                CreatedBy = model.CreatedBy,
                UpdatedBy = model.UpdatedBy
            };

            db.tblActivities.Add(saveActivity);
            db.SaveChanges();
            return msg;
        }

        //to get the list from model
        public List<ActivityModel> GetActivityList()
        {
            WagharalKarDBEntities db = new WagharalKarDBEntities();
            List<ActivityModel> lstActivity = new List<ActivityModel>();//make the list obj
            var getlist = db.tblActivities.ToList(); // store data to the variable getlist using linq ToList().
            if(getlist !=null)
            {
                foreach(var list in getlist) // to fetch each n every row which stores in lstActivity obj
                {
                    lstActivity.Add(new ActivityModel()
                    {
                        ID = list.ID,
                        Title = list.Title,
                        Details = list.Details,
                        Image1 = list.Image1,
                        Image2 = list.Image2,
                        Type = list.Type,
                        Date = list.Date,
                        CreateDate = list.CreateDate,
                        UpdateDate = list.UpdateDate,
                        CreatedBy = list.CreatedBy,
                        UpdatedBy = list.UpdatedBy

                    });
                }
                
            }
            return lstActivity;  // return to activitycontroller
        }
    }
}