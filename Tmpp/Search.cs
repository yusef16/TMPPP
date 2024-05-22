using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;


namespace Tmpp
{
    //Template pattern
    public abstract class SearchTemplate
    {
        public DataTable Search(string query, string connectionString , List<string>date)
        {
            Get_connectionString(connectionString,date);
            PerformSearch(query);
            

            return ProcessResults();
        }

        protected abstract void Get_connectionString(string connectionString, List<string> date);
        protected abstract DataTable PerformSearch(string query);
        protected abstract DataTable ProcessResults();
    }



    public class NameSearch : SearchTemplate
    {

        private string con;
        string nume;
        string prenume;
        DataTable dt = new DataTable();

        protected override void Get_connectionString(string connectionString, List<string> date)
        {
            con = connectionString;
            this.nume = date[0];
            this.prenume = date[1];
        }

        protected override DataTable PerformSearch(string query)
        {
           
            using (SqlConnection connection = new SqlConnection(con))
            {
                
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Nume", nume);
                    command.Parameters.AddWithValue("@Prenume", prenume);

                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dt = dataTable;
                        
                    }
                }

            }
            return dt;
        }

        protected override DataTable ProcessResults()
        {
            return dt;
        }
    }

    public class CoachSearch : SearchTemplate
    {

        private string con;
        string nume;
        string prenume;
        DataTable dt = new DataTable();

        protected override void Get_connectionString(string connectionString, List<string> date)
        {
            con = connectionString;
            this.nume = date[0];
            this.prenume = date[1];
        }

        protected override DataTable PerformSearch(string query)
        {

            using (SqlConnection connection = new SqlConnection(con))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Nume", nume);
                    command.Parameters.AddWithValue("@Prenume", prenume);


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dt = dataTable;

                    }
                }

            }
            return dt;
        }

        protected override DataTable ProcessResults()
        {
            return dt;
        }
    }





    public class MembershipSearch : SearchTemplate
    {

        private string con;
        string tip;
        DataTable dt = new DataTable();

        protected override void Get_connectionString(string connectionString, List<string> date)
        {
            con = connectionString;
            this.tip = date[0];
            
        }

        protected override DataTable PerformSearch(string query)
        {

            using (SqlConnection connection = new SqlConnection(con))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@tip", tip);
                    


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dt = dataTable;

                    }
                }

            }
            return dt;
        }

        protected override DataTable ProcessResults()
        {
            return dt;
        }
    }




    /* class main
     {
         public void ExecuteSearch()
         {
             SearchTemplate search = new NameSearch();
             search.Search("John Doe");

             search = new MembershipTypeSearch();
             search.Search("Full-Time");
         }

     }*/



}