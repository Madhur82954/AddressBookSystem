using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookSystem
{
    internal class AddressBookDatabase
    {
        public void createdatabase()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"data source=DESKTOP-SAGJTNV\SQLEXPRESS;initial catalog=master;integrated security=true");
                conn.Open();

                string query = "create database AddressBookDB;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static SqlConnection conn = new SqlConnection(@"data source=DESKTOP-SAGJTNV\SQLEXPRESS;initial catalog=AddressBookDB;integrated security=true");
        public static void createtable()
        {
            try
            {
                conn.Open();
                string query = "create table AddressBookData(Columns_Id int identity(1,1) Primary key,FirstName varchar(50),LastName varchar(50),Address varchar(100),city varchar(50),state varchar(50),Zip int,Phoneno varchar(50),Email varchar(100))";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("table created Succesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Insert()
        {
            try
            {
                Contact contact = new Contact();
                Console.WriteLine("Enter FirstName : ");
                contact.Firstname = Console.ReadLine();
                Console.WriteLine("Enter LastName : ");
                contact.Lastname = Console.ReadLine();
                Console.WriteLine("Enter Address : ");
                contact.Address = Console.ReadLine();
                Console.WriteLine("Enter City : ");
                contact.City = Console.ReadLine();
                Console.WriteLine("Enter State : ");
                contact.State = Console.ReadLine();
                Console.WriteLine("Enter Zip : ");
                contact.Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone : ");
                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Email : ");
                contact.Email = Console.ReadLine();
                conn.Open();
                string query = "insert into AddressBookData values('" + contact.Firstname + "','" + contact.Lastname + "','" + contact.Address + "','" + contact.City + "','" + contact.State + "'," + contact.Zip + ",'" + contact.PhoneNumber + "','" + contact.Email + "');";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Data Inserted Succesfully");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error while inserting Data"+e.Message);
            }
        }
    }
}
