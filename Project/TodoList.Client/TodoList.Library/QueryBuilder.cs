using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Library
{
    public class QueryBuilder
    {
        private string _query;

        public void Add(string value)
        {
            _query = _query + value;
        }

        public string GetQuery()
        {
            return _query;
        }
    }
}
