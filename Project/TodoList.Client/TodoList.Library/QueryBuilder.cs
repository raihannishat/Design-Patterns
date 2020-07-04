using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Remove()
        {
            _query = null;
        }

        public string GetQuery()
        {
            return _query;
        }
    }
}
