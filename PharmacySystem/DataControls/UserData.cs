﻿using PharmacySystem.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacySystem.DataControls
{
    class UserData
    {
        private static SqlConnection sqlConnection()
        {
            const string str = "server=DESKTOP-HS1LAF8\\SQLEXPRESS;database=PharmacySystem;UID=sa;password=P@ss0wrd";
            SqlConnection con = new SqlConnection(str);
            return con;
        }
        static public List<User> AdminList()
        {
            List<User> users = new List<User>();
            User user = null;
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"select * from users where isAdmin=1", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                user = new User();
                user.Id = rdr.GetInt32(0);
                user.Name = rdr.GetString(1);
                user.IsAdmin = rdr.GetBoolean(3);
                users.Add(user);
            }
            con.Close();
            return users;
        }
        static public List<User> EmployList()
        {
            List<User> users = new List<User>();
            User user = null;
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"select * from users where isAdmin=0", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                user = new User();
                user.Id = rdr.GetInt32(0);
                user.Name = rdr.GetString(1);
                user.IsAdmin = rdr.GetBoolean(3);
                users.Add(user);
            }
            con.Close();
            return users;
        }
        static public User IsUserExist(string UserName,string Password)
        {
            User user = null;
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand ($"select * from users where userName='{UserName}' and userPassword='{Password}'",con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read()) 
            { 
                user = new User();
                user.Id = rdr.GetInt32(0);
                user.Name = rdr.GetString(1);
                user.IsAdmin = rdr.GetBoolean(3);
            }
            con.Close();
            return user;
        }
        static public bool AddUser(string UserName,string Password,bool IsAdmin) 
        {
            User user = IsUserExist(UserName,Password);
            if (user == null) 
            {
                SqlConnection con = sqlConnection();
                SqlCommand cmd = new SqlCommand($"insert into users (userName,userPassword,isAdmin) values ('{UserName}','{Password}',{Convert.ToInt32(IsAdmin)})", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        static public void DeleteUser(int Id) 
        {
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"DELETE FROM users WHERE id={Id};", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        static public void ChangeUserAccess(int Id,bool admin)
        {
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"update users set isAdmin={Convert.ToInt32(admin)} where id={Id}", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        static public User GetUser(int Id)
        {
            User user = null;
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"select * from users where id={Id}", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                user = new User();
                user.Id = rdr.GetInt32(0);
                user.Name = rdr.GetString(1);
                user.IsAdmin = rdr.GetBoolean(3);
            }
            con.Close();
            return user;
        }
    }
}
