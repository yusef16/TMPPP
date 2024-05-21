using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using ClosedXML.Excel;
using OfficeOpenXml;

namespace Tmpp
{
    //Adapter
    public interface ITableAdapter
    {
        void ConvertTableToExcel(string tableName, string excelFilePath);
    }



    public class SqlTableAdapter : ITableAdapter
    {
        private readonly string _connectionString;

        public SqlTableAdapter(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void ConvertTableToExcel(string tableName, string excelFilePath)
        {
            DataTable dataTable = GetTableData(tableName);
            WriteToExcel(dataTable, excelFilePath);
        }

        private DataTable GetTableData(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName}";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }



        private void WriteToExcel(DataTable dataTable, string excelFilePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(dataTable, "Sheet1");
                workbook.SaveAs(excelFilePath);
            }
        }
    }

  
   }