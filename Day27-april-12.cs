using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Dataa
{
     class Day27_April_12
    {
        public void create()
        {


            SqlConnection con = new SqlConnection("data source = GUNA; database = trail;user id =sa; password=p@ssw0rd");
            con.Open();
            SqlCommand cmd = new SqlCommand("create table Enrollment2 (sno int,age int,firstname varchar(20))", con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table Created");
            con.Close();


        }
        public void Insert()
        {
           SqlConnection con = new SqlConnection("data source = GUNA; database = trail;user id =sa; password=p@ssw0rd");
           string sqlqry = "insert Enrollment2 values(1,22 ,'Ammu')";
           SqlCommand cmd = new SqlCommand(sqlqry, con);
           con.Open();
           cmd.ExecuteNonQuery();
           con.Close();
           Console.WriteLine("row inserted");

        }

        public void update()
        {
            SqlConnection con = new SqlConnection("data source =GUNA ;database= Trail;user id = sa;password=p@ssw0rd");

            string sqlqry = "update Enrollment2 set firstname='biology' where Sno=1";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           Console.WriteLine("Row Updated");
        }

        public void delete()
        {
            SqlConnection con = new SqlConnection("data source =GUNA ;database= Trail;user id = sa;password=p@ssw0rd");

            string sqlqry = "delete Enrollment2 where Sno=1";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row Deleted");
        }
        public static void Main()
        {
            Day27_April_12 Eobj = new Day27_April_12();

            //Eobj.Insert();
            //Eobj.update();
            Eobj.delete();
        }

    }
}

