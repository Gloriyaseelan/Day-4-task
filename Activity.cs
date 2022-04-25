using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace simpleactivity
{
    class Activity
    {
       
            public string cusName { get; private set; }
            public string gender { get; set; }
            public string DOB { get; set; }
            public string Contactno { get; set; }
            public string emailid { get; set; }
            public string cityname { get; set; }
            public void Insert(string cusName,string gender ,string DOB,string contactno ,string emailID ,string cityname )
            {
                SqlConnection con = new SqlConnection("data source=GUNA; database=master;user id=sa; password=p@ssw0rd");
                string sqlqry = "insert cusList values('" + cusName + "','" + gender + "','" + DOB + "','" + Contactno + "','" + emailid + "','" + cityname + "')";
                SqlCommand cmd = new SqlCommand(sqlqry, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("customerID:" + dr[0] + "cusName:" + dr[1] + "gender:" + dr[2] + "DOB:" + dr[3] + "Contactno:" + dr[4] + "emailID:" + dr[5] + "cityname:" + dr[6]);
                }
                con.Close();
                Console.WriteLine("Details inserted");
                Console.Read();
            }
            public void checking(string Name)
            {
                SqlConnection con = new SqlConnection("data source=GUNA; database=master;user id=sa; password=p@ssw0rd");
                string sqlqry = "select cusName,gender,DOB,Contactno,emailid,cityname from cusList where cusName='" + Name + "'";
                SqlCommand cmd = new SqlCommand(sqlqry, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("customerID:" + dr[0] + "   " + "gender:" + dr[1] + "   " + "DOB:" + dr[2] + "    " + "contactno:" + dr[3] + "   " + "emailID:" + dr[4] + "   " + "cityname:" + dr[5]);
                }
                Console.Read();
                con.Close();
            }

        //internal void Insert(string cusName, string gender, string dOB, string emailID, string contactno, string cityname)
        //{
        //    throw new NotImplementedException();
        //}
    }
        class productTable
        {
            public void Calci()
            {
                SqlConnection con = new SqlConnection("data source=GUNA; database=master;user id=sa; password=p@ssw0rd");
                SqlCommand cmd = new SqlCommand("select * from prodList", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Console.WriteLine(" productID: " + dr[0] + " prodName : " + dr[1] + "price : " + dr[2]);
                }
                Console.WriteLine("Enter the Id ");
                int productID = Convert.ToInt32(Console.Read());
                switch (productID)
                {
                    case 200:

                        Console.WriteLine("Hide And Seek");
                        Console.WriteLine("Enter Quantity");
                        int Quantity = Convert.ToInt32(Console.ReadLine());
                        SqlConnection con1 = new SqlConnection("data source=GUNA; database=master;user id=sa; password=p@ssw0rd");
                        SqlCommand cmd1 = new SqlCommand("select price* " + Quantity + " from ProdList where productID = " + productID + "", con1);
                        con1.Open();
                        cmd1.ExecuteNonQuery();
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        while (dr1.Read())
                        {
                            int Tot = Convert.ToInt32(dr1[0]);
                            Console.WriteLine("Amt" + Tot);
                        }
                        con1.Close();
                        break;

                    case 201:

                        Console.WriteLine("Happy Happy");
                    Console.WriteLine("Enter Quantity");
                    int Quantity2 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con2 = new SqlConnection("data source=GUNA; database=master;user id=sa; password=p@ssw0rd");
                    SqlCommand cmd2 = new SqlCommand("select price* " + Quantity2 + " from ProdList where productID = " + productID + "", con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        int Tot = Convert.ToInt32(dr2[0]);
                        Console.WriteLine("Amt" + Tot);
                    }
                    con2.Close();
                    break;

                case 202:

                    Console.WriteLine("Little Hearts");
                    Console.WriteLine("Enter Quantity");
                    int Quantity3 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con3 = new SqlConnection("data source=GUNA; database=master;user id=sa; password=p@ssw0rd");
                    SqlCommand cmd3 = new SqlCommand("select price* " + Quantity3 + " from ProdList where productID = " + productID + "", con3);
                    con3.Open();
                    cmd3.ExecuteNonQuery();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        int Tot = Convert.ToInt32(dr3[0]);
                        Console.WriteLine("Amt" + Tot);
                    }
                    con3.Close();
                    break;

                case 203:

                    Console.WriteLine("Oreo");
                    Console.WriteLine("Enter Quantity");
                    int Quantity4 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con4 = new SqlConnection("data source=GUNA; database=master;user id=sa; password=p@ssw0rd");
                    SqlCommand cmd4 = new SqlCommand("select price* " + Quantity4 + " from ProdList where productID = " + productID + "", con4);
                    con4.Open();
                    cmd4.ExecuteNonQuery();
                    SqlDataReader dr4 = cmd4.ExecuteReader();
                    while (dr4.Read())
                    {
                        int Tot = Convert.ToInt32(dr4[0]);
                        Console.WriteLine("Amt" + Tot);
                    }
                    con4.Close();
                    break;
                }
            }
        //public static void  Main()
        //{
        //    productTable obj1 = new productTable();
        //    obj1.Calci();

        //}
        }
    class Rest
    {
        SqlConnection con = new SqlConnection("data source=GUNA; database=master;user id=sa; password=p@ssw0rd");

        public static string Yes { get; private set; }

        public static void Main()
        {
            
            //Console.WriteLine("Are you an old costomer(Yes/No)?");
            //string Youranswer = Console.ReadLine();
            //if (Youranswer == Yes)
            //{
                Activity obj = new Activity();
                Console.WriteLine("enter Namee:");
                string Name = Console.ReadLine();
                obj.checking(Name);
            //}
            //else
            //{
            //Activity obj2 = new Activity();
            Console.WriteLine("enter name");
            string cusName = Console.ReadLine();
            Console.WriteLine("enter gender");
            string gender = Console.ReadLine();
            Console.WriteLine("enter dob");
            string DOB = Console.ReadLine();
            Console.WriteLine("enter emailid");
            string emailID = Console.ReadLine();
            Console.WriteLine("enter contact");
            string contactno = Console.ReadLine();
            Console.WriteLine("1.chennai" + "  " + "2.Madurai" + "  " + "3.Tuticorin" + "  " + "4.Trivandrum");
            Console.WriteLine("choose city ");
            string cityname = Console.ReadLine();
            obj.Insert(cusName, gender, DOB, emailID, contactno, cityname);
            //}
            productTable obj1 = new productTable();
            obj1.Calci();










        }

    }

}

