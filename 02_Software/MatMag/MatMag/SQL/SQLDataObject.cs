using MatMag.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatMag.SQL
{
    public class SQLDataObject
    {
        public SQLDataObject(string rowName, SQL_DATATYPE dataType, object value)
        {
            Value = value;
            DataType = dataType;
            RowName = rowName;
        }

        public string RowName { get; private set; }
        public object Value { get; private set; }
        public SQL_DATATYPE DataType { get; private set; }
    }







}
