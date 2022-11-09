using System.Data;
using System.Data.CData.QuickBooks;
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
                    SendQbXml(connection);



                    //using (IDataReader reader = SchemaCommand.ExecuteReader())
                    //{
                    //    var data = reader.GetSchemaTable();

                    //}                    ///
                    var accountsCommand = connection.CreateCommand();
                   
                    
                    
                    //Debug.WriteLine(accountsCommand.Parameters["@OutputRawResponse"].Value);
                    //accountsCommand.CommandText = $"EXECUTE SendQBXML";
                    //accountsCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    //var xml = File.ReadAllText("ConfigReport.xml");
                    //accountsCommand.Parameters.Add("@RawXML", DbType.String).Value = xml;

                    //QuickBooksParameter outparameter = new QuickBooksParameter("@OutputRawResponse", DbType.String);
                    //ReportType.Direction = ParameterDirection.Output;

                    //accountsCommand.Parameters.Add(ReportType);

                    ////QuickBooksParameter outparameter = accountsCommand.Parameters.Add("@OutputRawResponse", SqlDbType.Text);
                    ////outparameter.Direction = ParameterDirection.Output;
                    //int affected = accountsCommand.ExecuteNonQuery();

                    //var outvalue=  outparameter.Value.ToString();

                    //using (IDataReader reader = accountsCommand.ExecuteReader())
                    //{
                    //    var data = reader.GetSchemaTable();
                    //    while (reader.Read())
                    //    {

                    //        //read in data
                    //    }

                    //}
                    //SqlParameter outputIdParam = new SqlParameter("@ID", SqlDbType.Int)
                    //{
                    //    Direction = ParameterDirection.Output
                    //};

                    //QuickBooksDataReader rdr = accountsCommand.ExecuteReader();
                    //int currentRecord = 0;
                    //while (rdr.Read())
                    //{


                    //}
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
            var xml = File.ReadAllText("ConfigReport.xml");
            SchemaCommand.CommandText = $"EXECUTE SendQBXML @RawXML = '{xml}'";
            SchemaCommand.CommandType = System.Data.CommandType.Text;
            var affected = SchemaCommand.ExecuteNonQuery();
            var output=SchemaCommand.Parameters["OutputRawResponse"];

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