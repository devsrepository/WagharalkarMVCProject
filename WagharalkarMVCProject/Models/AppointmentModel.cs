using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WagharalkarMVCProject.Data;

namespace WagharalkarMVCProject.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string MobileNo { get; set; }
        public string AppointmentDate { get; set; }
        public string Gender { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }

        public string saveAppointment(AppointmentModel model)
        {
            WagharalKarDBEntities db = new WagharalKarDBEntities();
            string msg = "appointment saved successfully";
            var savAppt = new tblAppointment()
            {
                Name = model.Name,
                Email = model.Email,
                City = model.City,
                MobileNo = model.MobileNo,
                AppointmentDate = model.AppointmentDate,
                Gender = model.Gender,
                Message = model.Message,
                CreateDate = model.CreateDate,
                UpdateDate = model.UpdateDate,
                CreatedBy = model.CreatedBy,
                UpdatedBy = model.UpdatedBy
            };

            db.tblAppointments.Add(savAppt);
            db.SaveChanges();
            return msg;
        }
        //1. get data from db through model in table.
        public List<AppointmentModel> GetAppointmentList()
        {
            WagharalKarDBEntities db = new WagharalKarDBEntities();
            List<AppointmentModel> lstAppointment = new List<AppointmentModel>();
            var getList = db.tblAppointments.ToList();
            if(getList != null)
            {
                foreach(var list in getList)
                {// here, add each row data in list obj
                    lstAppointment.Add(new AppointmentModel()
                    { //view table=db model table
                        Name = list.Name,
                        Email = list.Email,
                        City = list.City,
                        MobileNo = list.MobileNo,
                        AppointmentDate = list.AppointmentDate,
                        Gender = list.Gender,
                        Message = list.Message,
                        CreateDate = list.CreateDate,
                        UpdateDate = list.UpdateDate,
                        CreatedBy = list.CreatedBy,
                        UpdatedBy = list.UpdatedBy
                    });
                }
            }
            return lstAppointment;
        }
    }    
}