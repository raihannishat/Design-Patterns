using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Library
{
    public class SqlBuilder
    {
        public string GetInsertSql(object item)
        {
            var sql = new StringBuilder();
            
            var type = item.GetType();
            var tableName = type.Name;
            var columns = new Dictionary<string, object>();

            foreach (var prop in type.GetProperties())
            {
                columns.Add(prop.Name, prop.GetValue(item));
            }

            sql.Append($"INSERT INTO {tableName}");
            sql.Append($"(");

            foreach (var column in columns)
            {
                if (column.Key.Equals("time"))
                {
                    sql.Append($"{column.Key}");
                    break;
                }

                sql.Append($"{column.Key}, ");
            }

            sql.Append(") VALUES(");

            foreach (var value in columns)
            {
                if (value.Key.Equals("time"))
                {
                    sql.Append($"'{value.Value}'");
                    break;
                }

                sql.Append($"'{value.Value}', ");
            }

            sql.Append(");");

            return sql.ToString();
        }
    }
}
