﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.CRUD
{
    public static class CRUD
    {
        public static OleDbConnection con = connection.mysqldb();
        public static OleDbCommand cmd = new OleDbCommand();
        public static OleDbDataAdapter da = new OleDbDataAdapter();
        public static DataTable dt = new DataTable();
        public static DataSet ds = new DataSet();
        public static int resultSQL;
        public static Image getIMG = null;

        public static bool RETRIEVESINGLE(string SQL)
        {
            con.Open();
            cmd = new OleDbCommand();
            {
                var withBlock = cmd;
                withBlock.Connection = con;
                withBlock.CommandText = SQL;
            }
            da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;

            }
        }
        public static bool RETRIEVEDTG(DataGridView DTG, string SQL)
        {
            con.Open();
            cmd = new OleDbCommand();
            {
                var withBlock = cmd;
                withBlock.Connection = con;
                withBlock.CommandText = SQL;
            }
            da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);

            {
                var withBlock = DTG;
                withBlock.DataSource = dt;
            }

            if (dt.Rows.Count > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;

            }
        }
        public static bool CUD(string sql)
        {
            con.Open();
            {
                var withBlock = cmd;
                withBlock.Connection = con;
                withBlock.CommandText = sql;
                resultSQL = withBlock.ExecuteNonQuery();
            }
            if (resultSQL > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
