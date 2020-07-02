using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoList.Library
{
    public class SqlBuilder
    {
        public string GetInsertSql(object item)
        {
            var sql = new QueryBuilder();

            var type = item.GetType();
            var tableName = type.Name;
            var columns = new Dictionary<string, object>();

            foreach (var property in type.GetProperties())
            {
                if (property.GetValue(item) != null)
                {
                    columns.Add(property.Name, property.GetValue(item));
                }
            }

            sql.Add($"INSERT INTO {tableName}");
            sql.Add($"(");

            foreach (var column in columns)
            {
                if (column.Key == columns.Last().Key)
                {
                    sql.Add($"{column.Key}");
                    break;
                }

                sql.Add($"{column.Key}, ");
            }

            sql.Add(") VALUES(");

            foreach (var value in columns)
            {
                if (value.Value == columns.Last().Value)
                {
                    sql.Add($"'{value.Value}'");
                    break;
                }

                sql.Add($"'{value.Value}', ");
            }

            sql.Add(");");

            return sql.GetQuery();
        }
    }
}
