﻿using PharmacySystem.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacySystem.DataControls
{
    public class MedisineData
    {
        private static SqlConnection sqlConnection()
        {
            const string str = "server=DESKTOP-HS1LAF8\\SQLEXPRESS;database=PharmacySystem;UID=sa;password=P@ss0wrd";
            SqlConnection con = new SqlConnection(str);
            return con;
        }
        public static List<Medicine> ScientificResearch(string Name)
        {
            List<Medicine> list = new List<Medicine>();
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"select * from medicine where ScientificName='{Name}'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Medicine med = new Medicine();
                med.Id = Convert.ToInt32(rdr.GetValue(0));
                med.ScientificName = rdr.GetString(1);
                med.BrandName = rdr.GetString(2);
                med.Price = Convert.ToDouble(rdr.GetValue(3));
                med.NumberInStore = Convert.ToInt32(rdr.GetValue(4));
                med.Type = rdr.GetString(5);
                med.setPoint(Convert.ToInt32(rdr.GetValue(6)),Convert.ToInt32(rdr.GetValue(7)));
                med.Dose =Convert.ToDouble(rdr.GetValue(8));
                list.Add(med);
            }
            con.Close();
            return list;
        }
        public static List<Medicine> BrandResearch(string Name)
        {
            List<Medicine> list = new List<Medicine>();
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"select * from medicine where BrandName='{Name}'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Medicine med = new Medicine();
                med.Id = rdr.GetInt32(0);
                med.ScientificName = rdr.GetString(1);
                med.BrandName = rdr.GetString(2);
                med.Price = Convert.ToDouble( rdr.GetValue(3));
                med.NumberInStore = Convert.ToInt32(rdr.GetValue(4));
                med.Type = rdr.GetString(5);
                med.setPoint(Convert.ToInt32(rdr.GetValue(6)), Convert.ToInt32(rdr.GetValue(7)));
                med.Dose = Convert.ToDouble(rdr.GetValue(8));
                list.Add(med);
            }
            con.Close();
            return list;
        }
        public static List<Medicine> EmptyMedicines()
        {
            List<Medicine> list = new List<Medicine>();
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"select * from medicine where NumberInStore=0", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Medicine med = new Medicine();
                med.Id = rdr.GetInt32(0);
                med.ScientificName = rdr.GetString(1);
                med.BrandName = rdr.GetString(2);
                med.Price =Convert.ToDouble( rdr.GetValue(3));
                med.NumberInStore =Convert.ToInt32(rdr.GetValue(4));
                med.Type = rdr.GetString(5);
                med.setPoint(Convert.ToInt32(rdr.GetValue(6)), Convert.ToInt32(rdr.GetValue(7)));
                med.Dose =Convert.ToDouble( rdr.GetValue(8));
                list.Add(med);
            }
            con.Close();
            return list;
        }
        public static bool AddMid(Medicine medicine)
        {
            List<Medicine> list = new List<Medicine>();
            SqlConnection con = sqlConnection();
            SqlCommand cmd = new SqlCommand($"select * from medicine where BrandName='{medicine.BrandName}' and ScientificName='{medicine.ScientificName}' and Dose='{medicine.Dose}'  ", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Medicine med = new Medicine();
                med.Id = rdr.GetInt32(0);
                med.ScientificName = rdr.GetString(1);
                med.BrandName = rdr.GetString(2);
                med.Price = Convert.ToDouble(rdr.GetValue(3));
                med.NumberInStore = Convert.ToInt32( rdr.GetValue(4));
                med.Type = rdr.GetString(5);
                med.setPoint(Convert.ToInt32( rdr.GetValue(6)), Convert.ToInt32(rdr.GetValue(7)));
                list.Add(med);
            }
            con.Close();
            if (list.Count > 0) 
            {
                return false;
            }
            else
            {
                string Add = "insert into medicine(ScientificName,BrandName,Price,NumberInStore,MidType,XPoint,YPoint,Dose) "
                    + $"values ('{medicine.ScientificName}','{medicine.BrandName}',{medicine.Price},{medicine.NumberInStore},'{medicine.Type}',{medicine.RCPoint.X},{medicine.RCPoint.Y},{medicine.Dose});";
                cmd = new SqlCommand(Add, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
    }
}
