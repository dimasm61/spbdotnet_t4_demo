using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtAssembly_48
{
    public static class DbMsSqlMetadata
    {
        public static List<Table> Tables = null;

        public static List<Column> Columns = null;

        public static void Load(string connStr)
        {
            using var conn = new SqlConnection(connStr);

            conn.Open();

            var tables = conn.GetSchema("Tables", new string[] { null, null, null, null });
            var columns = conn.GetSchema("Columns", new string[] { null, null, null });

            Tables = new List<Table>();
            Columns = new List<Column>();

            foreach (DataRow row in tables.Rows)
                Tables.Add(new Table(row));

            foreach (DataRow row in columns.Rows)
                Columns.Add(new Column(row));

        }

        public class Table
        {
            public string Schema;
            public string Name;

            public Table(DataRow row)
            {
                Schema = row["table_schema"].ToString();
                Name = row["table_name"].ToString();
            }
        }

        public class Column
        {
            public string Schema;
            public string Table;
            public string Name;
            public string DataType;

            public Column(DataRow row)
            {
                Schema = row["table_schema"].ToString();
                Table = row["table_name"].ToString();
                Name = row["column_name"].ToString();
                DataType = row["data_type"].ToString();
            }
        }
    }

    public static class ColumnExt
    {
        /// <summary>
        /// Получить тип данных .net
        /// </summary>
        public static string GetClrDataType(this DbMsSqlMetadata.Column column)
        {
            string result;
            switch (column.DataType)
            {
                case "image": result = "byte[]"; break;
                case "text": result = "string"; break;
                case "binary": result = "byte[]"; break;
                case "tinyint": result = "byte"; break;
                case "date": result = "DateTime"; break;
                case "time": result = "DateTime"; break;
                case "bit": result = "bool"; break;
                case "smallint": result = "short"; break;
                case "decimal": result = "decimal"; break;
                case "int": result = "int"; break;
                case "smalldatetime": result = "DateTime"; break;
                case "real": result = "float"; break;
                case "money": result = "decimal"; break;
                case "datetime": result = "DateTime"; break;
                case "float": result = "double"; break;
                case "numeric": result = "double"; break;
                case "smallmoney": result = "decimal"; break;
                case "datetime2": result = "DateTime"; break;
                case "bigint": result = "long"; break;
                case "varbinary": result = "byte[]"; break;
                case "timestamp": result = "byte[]"; break;
                case "sysname": result = "string"; break;
                case "nvarchar": result = "string"; break;
                case "varchar": result = "string"; break;
                case "ntext": result = "string"; break;
                case "uniqueidentifier": result = "Guid"; break;
                case "datetimeoffset": result = "DateTimeOffset"; break;
                case "sql_variant": result = "object"; break;
                case "xml": result = "string"; break;

                case "char": result = "string"; break;

                case "nchar": result = "string"; break;

                //hierarchyid
                //geometry
                //geography
                default: result = "byte[]"; break;
            }

            return result;
        }

        /// <summary>
        /// Получить название поля/свойства для класса .net - удаляем проблы и подчеркивания, и точки
        /// </summary>
        public static string GetClrFieldName(this DbMsSqlMetadata.Column column)
        {
            var result = column.Name.Replace(" ", "");

            result = result.Replace(".", "");

            result = (result == column.Table) ? $"{result}Data" : result;

            result = !Char.IsLetter(result.ToLower()[0]) ? $"Field{result}" : result;

            if (column.Name == "rowguid") return "Rowguid";

            return result;
        }

        /// <summary>
        /// Получить тип данных для описания gRpc сообщения
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public static string GetGRpcDataType(this DbMsSqlMetadata.Column column)
        {
            string result;
            switch (column.DataType)
            {
                case "image": result = "bytes"; break;
                case "text": result = "string"; break;
                case "binary": result = "bytes"; break;
                case "tinyint": result = "int32"; break;
                case "date": result = "google.protobuf.Timestamp"; break;
                case "time": result = "google.protobuf.Timestamp"; break;
                case "smalldatetime": result = "google.protobuf.Timestamp"; break;
                case "datetime": result = "google.protobuf.Timestamp"; break;
                case "datetime2": result = "google.protobuf.Timestamp"; break;
                case "datetimeoffset": result = "google.protobuf.Timestamp"; break;
                case "bit": result = "bool"; break;
                case "smallint": result = "int32"; break;
                case "decimal": result = "double"; break;
                case "int": result = "int32"; break;
                case "real": result = "float"; break;
                case "money": result = "double"; break;
                case "float": result = "double"; break;
                case "numeric": result = "double"; break;
                case "smallmoney": result = "double"; break;
                case "bigint": result = "int64"; break;
                case "varbinary": result = "bytes"; break;
                case "timestamp": result = "bytes"; break;
                case "sysname": result = "string"; break;
                case "nvarchar": result = "string"; break;
                case "varchar": result = "string"; break;
                case "ntext": result = "string"; break;
                case "uniqueidentifier": result = "string"; break;
                case "sql_variant": result = null; break;
                case "xml": result = "string"; break;
                case "char": result = "string"; break;
                case "nchar": result = "string"; break;

                //hierarchyid
                //geometry
                //geography
                default: result = null; break;
            }

            return result;
        }
    }
}
