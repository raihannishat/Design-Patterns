using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TodoList.Library
{
    public class SqlBuilder
    {
        private QueryBuilder sqlQuery = null;
        private Type type = null;
        private string tableName = null;
        private Dictionary<string, object> columns = null;

        public SqlBuilder()
        {
            sqlQuery = new QueryBuilder();
            columns = new Dictionary<string, object>();
        }

        public string GetInsertSql(object item)
        {
            type = item.GetType();
            tableName = type.Name;
            columns = GetColumns(item);
            sqlQuery.Add($"INSERT INTO {tableName}(");

            foreach (var column in columns)
            {
                if (column.Key == columns.Last().Key)
                {
                    sqlQuery.Add($"{column.Key}");
                    break;
                }

                sqlQuery.Add($"{column.Key}, ");
            }

            sqlQuery.Add(") VALUES(");

            foreach (var value in columns)
            {
                if (value.Value == columns.Last().Value)
                {
                    sqlQuery.Add($"'{value.Value}'");
                    break;
                }

                sqlQuery.Add($"'{value.Value}', ");
            }

            sqlQuery.Add(");");

            return sqlQuery.GetQuery();
        }

        public string GetDeleteSql(object item)
        {
            type = item.GetType();
            tableName = type.Name;
            columns = GetColumns(item);
            sqlQuery.Add($"DELETE FROM {tableName} WHERE ");

            foreach (var column in columns)
            {
                sqlQuery.Add($"{column.Key} = ");
                break;
            }

            foreach (var value in columns)
            {
                sqlQuery.Add($"'{value.Value}';");
                break;
            }

            return sqlQuery.GetQuery();
        }

        public string GetSelectSql(object item)
        {
            type = item.GetType();
            tableName = type.Name;
            columns = GetColumns(item);
            sqlQuery.Add($"SELECT * FROM [{tableName}];");

            return sqlQuery.GetQuery();
        }

        public string GetUpdateSql(object item)
        {
            type = item.GetType();
            tableName = type.Name;
            columns = GetColumns(item);
            sqlQuery.Add($"UPDATE {tableName} SET ");

            foreach (var column in columns)
            {
                if (column.Key == columns.First().Key)
                {
                    continue;
                }

                if (column.Value == columns.Last().Value)
                {
                    sqlQuery.Add($"{column.Key} = {column.Value} ");
                    break;
                }

                sqlQuery.Add($"{column.Key} = {column.Value}, ");               
            }

            sqlQuery.Add($"WHERE {columns.Keys.First()} = '{columns.Values.First()}';");

            return sqlQuery.GetQuery();
        }

        private Dictionary<string, object> GetColumns(object item)
        {
            sqlQuery.Remove();
            columns.Clear();

            foreach (var property in type.GetProperties())
            {
                if (property.GetValue(item) != null)
                {
                    columns.Add(property.Name, property.GetValue(item));
                }
            }

            return columns;
        }
    }
}
