using System.Linq;


namespace ExtAssembly_48
{
    public class gRpcGenerateHelper
    {
        /// <summary>
        /// Генерация конвертеров между моделью EF и моделью gRpc
        /// </summary>
        /// <param name="context"></param>
        /// <param name="connStr"></param>
        public static void GenerateClassesMapper(object context, string connStr)
        {
            var tt = new TextTransformationProxy(context);

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
                        var maxLen = DbMsSqlMetadata.Columns.Where(c => c.TableName == table.Name).Max(c => c.Name.Length);

                        foreach (var column in DbMsSqlMetadata.Columns.Where(c => c.TableName == table.Name))
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
                        var maxLen = DbMsSqlMetadata.Columns.Where(c => c.TableName == table.Name).Max(c => c.Name.Length);

                        foreach (var column in DbMsSqlMetadata.Columns.Where(c => c.TableName == table.Name))
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

        /// <summary>
        /// Генерация proto файла с перечнем методов службы
        /// </summary>
        /// <param name="context"></param>
        /// <param name="connStr"></param>
        public static void GenerateGRpcServiceBody(object context, string connStr)
        {
            var tt = new TextTransformationProxy(context);

            DbMsSqlMetadata.Load(connStr);

            foreach (var table in DbMsSqlMetadata.Tables)
            {
                tt.WriteLine($"rpc Get{table.Name}List)RequestMsg) returns ({table.Name}ListResponse){{}}");
                tt.WriteLine("");
            }
        }

        /// <summary>
        /// Генерация proto файла со сообщениями
        /// </summary>
        /// <param name="context"></param>
        /// <param name="connStr"></param>
        public static void GenerateGRpcClasses(object context, string connStr)
        {
            var tt = new TextTransformationProxy(context);

            DbMsSqlMetadata.Load(connStr);

            foreach (var table in DbMsSqlMetadata.Tables)
            {
                tt.WriteLine($"message {table.Name} {{");
                tt.PushIndent("    ");
                {
                    var cn = 1;
                    foreach (var column in DbMsSqlMetadata.Columns.Where(c => c.TableName == table.Name))
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

        /// <summary>
        /// Генерация классов EF модели по табличкам
        /// </summary>
        /// <param name="context"></param>
        /// <param name="connStr"></param>
        public static void GenerateDbClasses(object context, string connStr)
        {
            var tt = new TextTransformationProxy(context);

            DbMsSqlMetadata.Load(connStr);

            foreach (var table in DbMsSqlMetadata.Tables)
            {
                tt.WriteLine($"[Table\"{table.Name}\", Schema = \"{table.Schema}\")]");
                tt.WriteLine($"public partial class {table.Name}");
                tt.WriteLine($"{{");
                tt.PushIndent("    ");
                {
                    foreach (var column in DbMsSqlMetadata.Columns.Where(c => c.TableName == table.Name))
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

        /// <summary>
        /// Соответствие типов CLR & gRpc
        /// </summary>
        /// <param name="clrDataType"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
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
        }

    }
}
