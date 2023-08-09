using GitHub.ExtentReportGenerate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.DataBaseTesting
{
    [TestClass]
    public class DataBaseConnection : ExtentReportUtility
    {
        // "jdbc:mysql://rmgtestingserver:3333/projects","root@%","root"
        //"Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost:3306;Database=projects;User=root;Password=root;"

        OdbcConnection odbcConnection;
        [TestMethod]
        [TestCategory("odbcConnection")]
        public void ConnectionTest()
        {
                                        // "jdbc:mysql://rmgtestingserver:3333/projects","root@%","                                               root"
            string connectionString = 
                "Driver={MySQL ODBC 8.1 Unicode Driver};" +
                "Server=rmgtestingserver:3333;" +
                "Database=projects;" +
                "User=root@%;" +
                "Password=root;";
            odbcConnection = new OdbcConnection(connectionString);
            string query = "select * from project;";
            odbcConnection.Open();
            OdbcCommand command = new OdbcCommand(query, odbcConnection);
            var tables=command.ExecuteReader();
            Console.WriteLine(tables.Read());

            while (tables.Read())
            {
                extentTest.Log(AventStack.ExtentReports.Status.Info,
                    $"{tables[0].ToString()}    " +
                    $"{tables[1].ToString()}     " +
                    $"{tables[2].ToString()}     " +
                    $"{tables[1].ToString()}");
                Console.WriteLine( tables[0].ToString()+$"    {tables[1].ToString()}     {tables[2].ToString()}     {tables[1].ToString()}");
            }
            odbcConnection.Close();
        }
    }
}
