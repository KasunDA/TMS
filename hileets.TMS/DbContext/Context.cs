using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using hileets.TMS.Models;
using hileets.TMS.Models.Structs;

namespace hileets.TMS.DbContext
{
    public sealed class Context
    {
        enum DML { insert, update, delete}
        class ChangeLog
        {
            public string ClassName { get; set; }
            public int PrimaryKey { get; set; }
            public DML Action { get; set; }
            public string PropertyName { get; set; }
            public string OldValue { get; set; }
            public string NewValue { get; set; }
            
        }
        public static string connectionString = @"Provider=SQLNCLI11;Server=tms.ccat8rjbt2ex.us-east-2.rds.amazonaws.com;Database=tmsdb;Uid=tms;
Pwd=hileetstms";
        //public OleDbConnection connection = new OleDbConnection(connectionString);
        public static Context _context = new Context();
        public ObservableCollection<Customer> Customers = new ObservableCollection<Customer>();
        
        public List<Admin> Admins = new List<Admin>();
        public List<Booking> Bookings = new List<Booking>();
		public List<Station> Stations = new List<Station>();
		public List<Route> Routes = new List<Route>();
        public List<Bus> Buses = new List<Bus>();
		public List<Conductor> Conductors = new List<Conductor>();

        //private List<ChangeLog> Changes = new List<ChangeLog>();

        static Context(){}
        private Context(){
            Customers.CollectionChanged += Customers_CollectionChanged;
        }

        private void Customers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //switch (e.Action)
            //{
            //    case NotifyCollectionChangedAction.Add:
            //        //Console.WriteLine(e.NewItems[0].GetType());
            //        foreach (Customer item in e.NewItems)
            //        {
            //            Changes.Add(new ChangeLog()
            //            {
            //                ClassName = item.GetType().ToString(),
            //                PrimaryKey = item.Id || 0,

            //            });
            //        }
            //        break;
            //}
        }

        public static OleDbConnection Connection
        {
            get
            {
                return new OleDbConnection(connectionString);
            }
        }

        public static object Insert(string CommandText)
        {
            OleDbCommand command = new OleDbCommand(CommandText);
            command.Connection = Connection;
            Connection.Open();
            return "Connected";
            //try
            //{
            //    return command.ExecuteNonQuery();
            //}catch(Exception e)
            //{
            //    Console.WriteLine();
            //}
        }

        public static Context Instance
        {
            get
            {
                
                    //               // The insertSQL string contains a SQL statement that
                    //               // inserts a new row in the source table.
                    //               var sql = @"INSERT INTO [dbo].[Person]
                    //      ([FullName]
                    //      ,[PhoneNo]
                    //      ,[Gender])
                    //VALUES
                    //      ('Saiem Saeed', '03135536246', 0);";
                    //               OleDbCommand command = new OleDbCommand(sql);

                    //               // Set the Connection to the new OleDbConnection.
                    //               //command.Connection = connection;

                    //               // Open the connection and execute the insert command.
                    //               try
                    //               {
                    //                   connection.Open();
                    //                   Console.WriteLine("Connected to Database!");
                    //                   //command.ExecuteNonQuery();
                    //               }
                    //               catch (Exception ex)
                    //               {
                    //                   Console.WriteLine(ex.Message);
                    //               }
                    //               // The connection is automatically closed when the
                    //               // code exits the using block
                return _context;
            }
        }
    }
}
