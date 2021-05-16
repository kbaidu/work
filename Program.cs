﻿using System;
using System.Data;
using Newtonsoft.Json;
using work.common;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(util.print());


            //序列化DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Age", Type.GetType("System.Int32"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Sex", Type.GetType("System.String"));
            dt.Columns.Add("IsMarry", Type.GetType("System.Boolean"));
            for (int i = 0; i < 4; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Age"] = i + 1;
                dr["Name"] = "Name" + i;
                dr["Sex"] = i % 2 == 0 ? "男" : "女";
                dr["IsMarry"] = i % 2 > 0 ? true : false;
                dt.Rows.Add(dr);
            }
            Console.WriteLine(JsonConvert.SerializeObject(dt));

        }
    }
}
