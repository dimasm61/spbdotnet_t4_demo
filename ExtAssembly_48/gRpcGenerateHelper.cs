using EnvDTE;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtAssembly_48
{
    public class gRpcGenerateHelper
    {
        public static void GenerateClassesMapper(TextTransformation tt, string connStr)
        {
            DbMsSqlMetadata.Load(connStr);

            tt.WriteLine($"public static class MyConverter");
            tt.WriteLine($"{{");
            tt.PushIndent("    ");
            {
                foreach (var table in DbMsSqlMetadata.Tables)
                {
                    tt.WriteLine($"public static void CopyFrom(this DbModel.{table.Name} dest, Model.{table.Name} source)");
                    tt.WriteLine($"{{");
                    tt.PushIndent("    ");
                    {
                        var maxLen = DbMsSqlMetadata.Columns.Where(c => c.Table == table.Name).Max(c => c.Name.Length);

                        foreach (var column in DbMsSqlMetadata.Columns.Where(c => c.Table == table.Name))
                        {
                            var clrFieldName = column.GetClrFieldName();
                            var clrType = column.GetClrDataType();
                            var gRpcType = column.GetGRpcDataType();

                            tt.WriteLine($"dest.{clrFieldName} = {GetCastToGRpcTypeString(clrType, clrFieldName)};");
                        }
                    }
                    tt.PopIndent();
                    tt.WriteLine($"}}");
                    tt.WriteLine("");
                }

                tt.WriteLine("/////////////////////////////////////");
                foreach (var table in DbMsSqlMetadata.Tables)
                {
                    tt.WriteLine($"public static void CopyFrom(this Model.{table.Name} dest, DbModel.{table.Name} source)");
                    tt.WriteLine($"{{");
                    tt.PushIndent("    ");
                    {
                        var maxLen = DbMsSqlMetadata.Columns.Where(c => c.Table == table.Name).Max(c => c.Name.Length);

                        foreach (var column in DbMsSqlMetadata.Columns.Where(c => c.Table == table.Name))
                        {
                            var clrFieldName = column.GetClrFieldName();
                            var clrType = column.GetClrDataType();
                            var gRpcType = column.GetGRpcDataType();

                            tt.WriteLine($"dest.{clrFieldName} = {GetCastToDbTypeString(clrType, clrFieldName)};");
                        }
                    }
                    tt.PopIndent();
                    tt.WriteLine($"}}");
                    tt.WriteLine("");
                }

                tt.WriteLine("/////////////////////////////////////");

            }// static class
            tt.PopIndent();
            tt.WriteLine($"}}");
        }

        public static void GenerateGRpcServiceBody(TextTransformation tt, string connStr)
        {
            DbMsSqlMetadata.Load(connStr);

            foreach (var table in DbMsSqlMetadata.Tables)
            {
                tt.WriteLine($"rpc Get{table.Name}List)RequestMsg) returns ({table.Name}ListResponse){{}}");
                tt.WriteLine("");
            }
        }

        public static void GenerateGRpcClasses(TextTransformation tt, string connStr)
        {
            DbMsSqlMetadata.Load(connStr);

            foreach (var table in DbMsSqlMetadata.Tables)
            {
                tt.WriteLine($"message {table.Name} {{");
                tt.PushIndent("    ");
                {
                    var cn = 1;
                    foreach (var column in DbMsSqlMetadata.Columns.Where(c => c.Table == table.Name))
                    {
                        var clrFieldName = column.GetClrFieldName();
                        var clrType = column.GetClrDataType();
                        var gRpcType = column.GetGRpcDataType();

                        tt.WriteLine($"{gRpcType} {clrFieldName} = {cn};");

                        cn++;
                    }
                }
                tt.PopIndent();
                tt.WriteLine($"}}");
                tt.WriteLine("");
            }

            tt.WriteLine("/////////////////////////////////////");
            foreach (var table in DbMsSqlMetadata.Tables)
            {
                tt.WriteLine($"message {table.Name}ListResponse {{");
                tt.WriteLine($"    repeated {table.Name} {table.Name}List = 1;");
                tt.WriteLine($"}}");
                tt.WriteLine("");
            }
        }

        public static void GenerateDbClasses(TextTransformation tt, string connStr)
        {
            DbMsSqlMetadata.Load(connStr);

            foreach (var table in DbMsSqlMetadata.Tables)
            {
                tt.WriteLine($"[Table\"{table.Name}\", Schema = \"{table.Schema}\")]");
                tt.WriteLine($"public partial class {table.Name}");
                tt.WriteLine($"{{");
                tt.PushIndent("    ");
                {
                    foreach (var column in DbMsSqlMetadata.Columns.Where(c => c.Table == table.Name))
                    {
                        var clrFieldName = column.GetClrFieldName();
                        var clrType = column.GetClrDataType();
                        var gRpcType = column.GetGRpcDataType();

                        tt.WriteLine($"[Column(name: \"{column.Name}\")]");
                        tt.WriteLine($"public {clrType} {clrFieldName} {{ get; set; }}");
                    }
                }
                tt.PopIndent();
                tt.WriteLine($"}}");
                tt.WriteLine("");
            }
        }

        private static string GetCastToDbTypeString(string clrDataType, string fieldName)
        {
            switch (clrDataType)
            {
                case "DateTime": return $"Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.{fieldName})";
                case "Guid": return $" source.{fieldName}.ToString()";
                case "byte[]": return $"Google.Protobuf.ByteString.CopyFrom(source.{fieldName})";
                case "decimal": return $"(double)source.{fieldName}";
                default: return $"source.{fieldName}";
            }
            return fieldName;
        }

        private static string GetCastToGRpcTypeString(string clrDataType, string fieldName)
        {
            switch (clrDataType)
            {
                case "DateTime": return $"source.{fieldName}.ToDateTime()";
                case "Guid": return $" Guid.Parse(source.{fieldName})";
                case "byte[]": return $"source.{fieldName}.ToByteArray()";
                case "byte": return $"(byte)source.{fieldName}";
                case "short": return $"(short)source.{fieldName}";
                case "decimal": return $"(decimal)source.{fieldName}";
                default: return $"source.{fieldName}";
            }
            return fieldName;
        }

    }
}
