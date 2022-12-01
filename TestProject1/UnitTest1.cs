using System.Data;
using System.Data.CData.QuickBooks;
using System.Data.Common;
using System.Diagnostics;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void Test1()

        {

            //TODO test https://developer.intuit.com/app/developer/qbdesktop/docs/api-reference/qbdesktop/generaldetailreportquery

            //HACk https://cdn.cdata.com/help/RQH/ado/pg_exec.htm
            var CompanyFile = "C:\\Users\\User\\Desktop\\exe logistics incTesting\\exe lines incTesting.qbw";
            using (QuickBooksConnection connection = new QuickBooksConnection(new QuickBooksConnectionStringBuilder() { CompanyFile = CompanyFile, PoolWaitTime = 600 }))
            {


                try
                {

                    connection.Open();

                    //CreateCustomerSchema(connection);
                    //CreateReportSchema(connection);
                    //CreateReportSchema1(connection);
                    //SendQbXml(connection);
                    //SendQbXml1(connection);
                    SendQbXml2(connection);


                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Read Exception");
                    Debug.WriteLine(ex.Message);
                }

            }
            Assert.Pass();
        }
        void CreateReportSchema(QuickBooksConnection connection)
        {
            ///get schema
            var SchemaCommand = connection.CreateCommand();
            SchemaCommand.CommandText = $"EXECUTE CreateReportSchema";
            SchemaCommand.CommandType = System.Data.CommandType.StoredProcedure;

            QuickBooksParameter ReportType = new QuickBooksParameter("@ReportType", DbType.String);
            ReportType.Direction = ParameterDirection.Output;
            ReportType.Value = "BALANCESHEETSTANDARD";
            SchemaCommand.Parameters.Add(ReportType);
            var Reader = SchemaCommand.ExecuteReader();
            var SchemaTable = Reader.GetSchemaTable();
            //var affectedschema = SchemaCommand.ExecuteNonQuery();
        }
        void CreateReportSchema1(QuickBooksConnection connection)
        {
            ///get schema
            var SchemaCommand = connection.CreateCommand();
            SchemaCommand.CommandText = $"EXECUTE CreateReportSchema @ReportType = 'BALANCESHEETSTANDARD'";
            SchemaCommand.CommandType = System.Data.CommandType.Text;
            var Reader= SchemaCommand.ExecuteReader();
            var SchemaTable= Reader.GetSchemaTable();
            SchemaTable.WriteXml("BALANCESHEETSTANDARD.xml");
            //var affectedschema = SchemaCommand.ExecuteNonQuery();
        }
        void SendQbXml(QuickBooksConnection connection)
        {
            ///get schema
            var SchemaCommand = connection.CreateCommand();
            //var xml = File.ReadAllText("ConfigReport.xml");

            
            //Link for the examplehttps://stackoverflow.com/questions/22615711/qbxml-can-i-get-the-balance-sheet-or-do-i-have-to-calculate-it
            var xml = File.ReadAllText("newBalancesheet.xml");
            SchemaCommand.CommandText = $"EXECUTE SendQBXML @RawXML = '{xml}'";
            SchemaCommand.CommandType = System.Data.CommandType.Text;
            QuickBooksParameter OutputRawResponse = new QuickBooksParameter("@OutputRawResponse", DbType.String);
            OutputRawResponse.Direction = ParameterDirection.Output;
            SchemaCommand.Parameters.Add(OutputRawResponse);

            var affected = SchemaCommand.ExecuteNonQuery();
            var output=SchemaCommand.Parameters["@OutputRawResponse"];

            //Debug.WriteLine(accountsCommand.Parameters["@OutputRawResponse"].Value);
            //accountsCommand.CommandText = $"EXECUTE SendQBXML";
            //accountsCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //var xml = File.ReadAllText("ConfigReport.xml");
            //accountsCommand.Parameters.Add("@RawXML", DbType.String).Value = xml;
            //var affectedschema = SchemaCommand.ExecuteNonQuery();
        }
        void SendQbXml1(QuickBooksConnection connection)
        {
            ///get schema
            var SchemaCommand = connection.CreateCommand();
            //var xml = File.ReadAllText("ConfigReport.xml");


            //Link for the examplehttps://stackoverflow.com/questions/22615711/qbxml-can-i-get-the-balance-sheet-or-do-i-have-to-calculate-it
            var xml = File.ReadAllText("newBalancesheet.xml");
            SchemaCommand.CommandText = $"EXECUTE SendQBXML @RawXML = '{xml}', @OutputRawResponse=''";
            SchemaCommand.CommandType = System.Data.CommandType.Text;
            //QuickBooksParameter OutputRawResponse = new QuickBooksParameter("@OutputRawResponse", DbType.String);
            //OutputRawResponse.Direction = ParameterDirection.Output;
            //SchemaCommand.Parameters.Add(OutputRawResponse);

            //var affected = SchemaCommand.ExecuteNonQuery();
            using (IDataReader reader = SchemaCommand.ExecuteReader())
            {

             
                var data = reader.GetSchemaTable();
                DataTable table = new DataTable();
                table.Load(reader);
                table.WriteXml("BalancesheetSp.xml");
            }

            var output = SchemaCommand.Parameters["@OutputRawResponse"];

            //Debug.WriteLine(accountsCommand.Parameters["@OutputRawResponse"].Value);
            //accountsCommand.CommandText = $"EXECUTE SendQBXML";
            //accountsCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //var xml = File.ReadAllText("ConfigReport.xml");
            //accountsCommand.Parameters.Add("@RawXML", DbType.String).Value = xml;
            //var affectedschema = SchemaCommand.ExecuteNonQuery();
        }
        void SendQbXml2(QuickBooksConnection connection)
        {
            ///get schema
            var SchemaCommand = connection.CreateCommand();
            //var xml = File.ReadAllText("ConfigReport.xml");


            //Link for the examplehttps://stackoverflow.com/questions/22615711/qbxml-can-i-get-the-balance-sheet-or-do-i-have-to-calculate-it
            var xml = File.ReadAllText("newBalancesheet.xml");
            SchemaCommand.CommandText = $"EXECUTE SendQBXML @RawXML = '{xml}'";
            SchemaCommand.CommandType = System.Data.CommandType.StoredProcedure;
            QuickBooksParameter OutputRawResponse = new QuickBooksParameter("OutputRawResponse", DbType.String);
            OutputRawResponse.Direction = ParameterDirection.Output;
            SchemaCommand.Parameters.Add(OutputRawResponse);

            SchemaCommand.ExecuteNonQuery();
            var output = SchemaCommand.Parameters["OutputRawResponse"];


            //Debug.WriteLine(accountsCommand.Parameters["@OutputRawResponse"].Value);
            //accountsCommand.CommandText = $"EXECUTE SendQBXML";
            //accountsCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //var xml = File.ReadAllText("ConfigReport.xml");
            //accountsCommand.Parameters.Add("@RawXML", DbType.String).Value = xml;
            //var affectedschema = SchemaCommand.ExecuteNonQuery();
        }
        private static void CreateCustomerSchema(QuickBooksConnection connection)
        {
            var SelectCustomersCommand = connection.CreateCommand();
            SelectCustomersCommand.CommandText = "Select * from CUSTOMERS";


            using (IDataReader reader = SelectCustomersCommand.ExecuteReader())
            {
                var data = reader.GetSchemaTable();

            }
        }
    }
}