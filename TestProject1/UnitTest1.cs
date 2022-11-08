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

                    var accountsCommand = connection.CreateCommand();

                    var SelectCustomersCommand = connection.CreateCommand();
                    SelectCustomersCommand.CommandText = "Select * from CUSTOMERS";


                    using (IDataReader reader = SelectCustomersCommand.ExecuteReader())
                    {
                        var data = reader.GetSchemaTable();
                        //while (reader.Read())
                        //{

                        //    //read in data
                        //}

                        accountsCommand.CommandText = $"EXECUTE SendQBXML";
                        accountsCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        var xml = File.ReadAllText("ConfigReport.xml");
                        accountsCommand.Parameters.Add("@RawXML", DbType.String).Value = xml;

                        QuickBooksParameter outparameter = new QuickBooksParameter("@OutputRawResponse", DbType.String);
                        outparameter.Direction = ParameterDirection.Output;

                        accountsCommand.Parameters.Add(outparameter);

                        //QuickBooksParameter outparameter = accountsCommand.Parameters.Add("@OutputRawResponse", SqlDbType.Text);
                        //outparameter.Direction = ParameterDirection.Output;
                        int affected = accountsCommand.ExecuteNonQuery();

                        Debug.WriteLine(accountsCommand.Parameters["@OutputRawResponse"].Value);
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
                }
                catch (Exception ex)
                {

                    Debug.WriteLine("Read Exception");
                    Debug.WriteLine(ex.Message);
                }

            }
            Assert.Pass();
        }
    }
}