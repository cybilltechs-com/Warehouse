using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarehouseManagementSystem.Models
{
    public class Admin
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
        public string Gender { get; set; }
        public long PhnoNo { get; set; }
        public DateTime DOB { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string PanCardNo { get; set; }
        public int ZipCode { get; set; }
        public DateTime LoginTime{get;set;}
        public DateTime LogOutTime { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn{ get; set; }
        public DateTime DeletedOn { get; set; }
        public Boolean LoginStatus { get; set; }
        public Boolean AccountStatus { get; set; }
        public string CreatedBy { get; set; }
        public List<Admin> AdminDetails{ get; set; }

    }
}