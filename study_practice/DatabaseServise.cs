using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace study_practice
{
    public class DatabaseService
    {
        private readonly string _connectionString = "Data Source=results.db;Version=3;";

        public DatabaseService()
        {
            CreateTableIfNotExists();
        }

        private void CreateTableIfNotExists()
        {
            using var con = new SQLiteConnection(_connectionString);
            con.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS Results (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        X0 REAL,
                        Y0 REAL,
                        C REAL,
                        R REAL,
                        Direction TEXT,
                        Area REAL,
                        Method TEXT
                       );";
            using var cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public void InsertResult(double x0, double y0, double c, double r, string direction, double area, string method)
        {
            using var con = new SQLiteConnection(_connectionString);
            con.Open();

            string sql = "INSERT INTO Results (X0, Y0, C, R, Direction, Area, Method) VALUES (@x0, @y0, @c, @r, @direction, @area, @method)";
            using var cmd = new SQLiteCommand(sql, con);

            cmd.Parameters.AddWithValue("@x0", x0);
            cmd.Parameters.AddWithValue("@y0", y0);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@r", r);
            cmd.Parameters.AddWithValue("@direction", direction);
            cmd.Parameters.AddWithValue("@area", area);
            cmd.Parameters.AddWithValue("@method", method);

            cmd.ExecuteNonQuery();
        }

        public SQLiteDataAdapter GetAllResultsAdapter()
        {
            var con = new SQLiteConnection(_connectionString);
            con.Open();

            string sql = "SELECT * FROM Results";
            var adapter = new SQLiteDataAdapter(sql, con);

            return adapter;
        }

        public void ClearHistory()
        {
            using var con = new SQLiteConnection(_connectionString);
            con.Open();

            string sql = "DELETE FROM Results";
            using var cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("История успешно очищена!");            
        }

        public DataTable GetResults()
        {
            using var con = new SQLiteConnection(_connectionString);
            con.Open();

            string sql = "SELECT * FROM Results";
            using var cmd = new SQLiteCommand(sql, con);
            using var adapter = new SQLiteDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}