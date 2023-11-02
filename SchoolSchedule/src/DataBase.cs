using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSchedule.src {
    class SchoolDataBase {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=fozasu64Postgre;Database=SchoolSchedule";

        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        NpgsqlCommand? cmd;
        public string GetConnectionString() { return connectionString; }
        public void OpenConnection() {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
        }
        public void CloseConnection() {
            if (connection.State == ConnectionState.Open) {
                connection.Close();
            }
        }

        public DataTable Request(string sql) {
            DataTable dataTable = new();
            OpenConnection();
            cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);


            CloseConnection();
            return dataTable;
        }
        private int AddItem(string sqlRequest, string[] parametrs, object[] values) {
            if (parametrs.Length != values.Length) {
                throw new NpgsqlException($"Параметры и значения не равны " +
                                            $"\nparametrs - {parametrs.Length}" +
                                            $"\nvalues - {values.Length}");
            }
            OpenConnection();

            string sql = sqlRequest;

            cmd = new NpgsqlCommand(sql, connection);
            if (( values.Length > 0 ) && ( parametrs.Length > 0 )) {
                for (int i = 0; i < parametrs.Length; i++) {
                    cmd.Parameters.AddWithValue(parametrs[i], values[i]);
                }
            }
            int rowsAffected = cmd.ExecuteNonQuery();
            CloseConnection();
            return rowsAffected;


        }
        public int AddTeacher(string name, string surname, string patronymic = "") {
            string[] parametrs = { "name", "surname", "patronymic" };
            object[] values = { name, surname, patronymic };
            return AddItem("INSERT INTO teacher (name, surname, patronymic) VALUES (@name, @surname, @patronymic)", parametrs, values);
        }
        public int AddSubject(string name) {
            string[] parametrs = { "name" };
            object[] values = { name };
            return AddItem("INSERT INTO subject (name) VALUES (@name)", parametrs, values);
        }

        public int AddClass(byte year, char letter) {
            string[] parametrs = { "year", "letter" };
            object[] values = { year, letter };
            return AddItem("INSERT INTO schoolclass (year, letter) VALUES (@year, @letter)", parametrs, values);
        }


    }
}
