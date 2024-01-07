//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;
//using hospital.Models;
//using Microsoft.Data.SqlClient;

//namespace hospital.Models
//{
//    public class BookDb
//    {
//        SqlConnection con = new SqlConnection("Data Source=ANKITA\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
//        public string Saverecord(Book apo)
//        {
//            try
//            {

//                SqlCommand com = new SqlCommand("Sp_Booking_Add", con);
//                com.CommandType = CommandType.StoredProcedure;
//                com.Parameters.AddWithValue("@PatientName", apo.PatientName);
//                com.Parameters.AddWithValue("@PatientAge", apo.PatientAge);
//                com.Parameters.AddWithValue("@Pemail", apo.Pemail);
//                com.Parameters.AddWithValue("@Dname", apo.Dname);
//                com.Parameters.AddWithValue("@Cno", apo.Cno);
//                com.Parameters.AddWithValue("@ApDate", apo.ApDate);
//                con.Open();
//                com.ExecuteNonQuery();
//                con.Close();
//                return ("Ok");

//            }
//            catch (Exception ex)
//            {
//                if (con.State == ConnectionState.Open)
//                {
//                    con.Close();
//                }
//                return (ex.Message.ToString());
//            }


           


//        }
//    }
//}
