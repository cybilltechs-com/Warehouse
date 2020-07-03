using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WarehouseManagementSystem.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace WarehouseManagementSystem.DataAccessLayer
{
    public class DataAccessCredentials
    {
        public List<Admin> LoginCheck(string uid, string email, string password, string logintype)
        {
            DataSet ds;
            SqlDataAdapter da;
            List<Admin> objAdmin = null;
            List<Supplier> objSupp = null;
            List<SubIncharge> objSubIn = null;
            SqlCommand cmd;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Warehouse"].ConnectionString))
            {
                

                    if (logintype == "Admin")
                    {
                    try
                    {
                        cmd = new SqlCommand("CheckLogin", conn);
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                        }

                        cmd.Parameters.AddWithValue("@UserId", uid);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@UserType", logintype);
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds);
                        objAdmin = new List<Admin>();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            Admin admin = new Admin
                            {
                                UserId = Convert.ToInt32(ds.Tables[0].Rows[i]["UserId"].ToString()),
                                UserName = ds.Tables[0].Rows[i]["UserName"].ToString(),
                                FullName = ds.Tables[0].Rows[i]["FullName"].ToString(),
                                Password = ds.Tables[0].Rows[i]["LastName"].ToString(),
                                Email = ds.Tables[0].Rows[i]["EmailId"].ToString(),
                                ProfileImage = ds.Tables[0].Rows[i]["Address"].ToString(),
                                Gender = ds.Tables[0].Rows[i]["Gender"].ToString(),
                                PhnoNo = Convert.ToInt64(ds.Tables[0].Rows[i]["PhnoNo"].ToString()),
                                PanCardNo = ds.Tables[0].Rows[i]["PanCardNo"].ToString(),
                                DOB = Convert.ToDateTime(ds.Tables[0].Rows[i]["DOB"].ToString()),
                                AddressLine1 = ds.Tables[0].Rows[i]["AddressLine1"].ToString(),
                                AddressLine2 = ds.Tables[0].Rows[i]["AddressLine2"].ToString(),
                                Country = ds.Tables[0].Rows[i]["Country"].ToString(),
                                State = ds.Tables[0].Rows[i]["State"].ToString(),
                                District = ds.Tables[0].Rows[0]["District"].ToString(),
                                ZipCode = Convert.ToInt32(ds.Tables[0].Rows[0]["ZipCode"].ToString()),
                                CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString(),
                                CreatedOn = Convert.ToDateTime(ds.Tables[0].Rows[0]["CreatedOn"].ToString()),
                                DeletedOn = Convert.ToDateTime(ds.Tables[0].Rows[0]["DeletedOn"].ToString()),
                                UpdatedOn = Convert.ToDateTime(ds.Tables[0].Rows[0]["UpdatedOn"].ToString()),
                                AccountStatus = Convert.ToBoolean(ds.Tables[0].Rows[0]["AccountStatus"].ToString()),
                                LoginStatus = Convert.ToBoolean(ds.Tables[0].Rows[0]["LoginStatus"].ToString()),
                                LoginTime = Convert.ToDateTime(ds.Tables[0].Rows[0]["LoginTime"].ToString()),
                                LogOutTime = Convert.ToDateTime(ds.Tables[0].Rows[0]["LogOutTime"].ToString())
                            };
                            objAdmin.Add(admin);
                        }
                        return objAdmin;
                    }
                   
                    catch
                    {
                        return objAdmin;
                    }
                    finally
                    {
                        conn.Close();
                    }

                    }
              
            }
            return objAdmin;
        }
    }
}