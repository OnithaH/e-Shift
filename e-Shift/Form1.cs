using e_Shift.Database;
using System.Data;

namespace e_Shift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TestDatabaseConnection()
        {
            string testResults = "=== DATABASE CONNECTION TEST ===\n\n";

            try
            {
                // Test 1: Connection Test
                testResults += "1. Testing Connection...\n";
                bool isConnected = DatabaseConnection.TestConnection();
                testResults += $"   Result: {(isConnected ? "✅ SUCCESS" : "❌ FAILED")}\n\n";

                if (isConnected)
                {
                    // Test 2: Get Connection String
                    testResults += "2. Testing Get Connection String...\n";
                    string connStr = DatabaseConnection.GetConnectionString();
                    testResults += $"   Result: {(!string.IsNullOrEmpty(connStr) ? "✅ SUCCESS" : "❌ FAILED")}\n";
                    testResults += $"   Connection String: {connStr}\n\n";

                    // Test 3: Execute Scalar Query
                    testResults += "3. Testing Scalar Query (Count tables)...\n";
                    try
                    {
                        object result = DatabaseConnection.ExecuteScalar(
                            "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'");

                        if (result != null)
                        {
                            testResults += $"   Result: ✅ SUCCESS\n";
                            testResults += $"   Tables found: {result}\n\n";
                        }
                        else
                        {
                            testResults += "   Result: ❌ FAILED (null result)\n\n";
                        }
                    }
                    catch (Exception ex)
                    {
                        testResults += $"   Result: ❌ FAILED\n   Error: {ex.Message}\n\n";
                    }

                    // Test 4: Fill DataTable
                    testResults += "4. Testing DataTable Fill (List tables)...\n";
                    try
                    {
                        DataTable dt = DatabaseConnection.FillDataTable(
                            "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_NAME");

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            testResults += $"   Result: ✅ SUCCESS\n";
                            testResults += $"   Tables loaded: {dt.Rows.Count}\n";
                            testResults += "   Table names:\n";

                            foreach (DataRow row in dt.Rows)
                            {
                                testResults += $"   - {row["TABLE_NAME"]}\n";
                            }
                            testResults += "\n";
                        }
                        else
                        {
                            testResults += "   Result: ❌ FAILED (no tables found)\n\n";
                        }
                    }
                    catch (Exception ex)
                    {
                        testResults += $"   Result: ❌ FAILED\n   Error: {ex.Message}\n\n";
                    }

                    // Test 5: Test specific eShift tables
                    testResults += "5. Testing eShift Tables...\n";
                    string[] expectedTables = { "Customers", "Admins", "Jobs", "Loads", "Products" };

                    foreach (string tableName in expectedTables)
                    {
                        try
                        {
                            object count = DatabaseConnection.ExecuteScalar($"SELECT COUNT(*) FROM {tableName}");
                            testResults += $"   {tableName}: ✅ EXISTS ({count} records)\n";
                        }
                        catch (Exception ex)
                        {
                            testResults += $"   {tableName}: ❌ NOT FOUND ({ex.Message})\n";
                        }
                    }
                    testResults += "\n";

                    // Test 6: Test ExecuteNonQuery (safe operation)
                    testResults += "6. Testing ExecuteNonQuery (Update operation)...\n";
                    try
                    {
                        int affectedRows = DatabaseConnection.ExecuteNonQuery(
                            "UPDATE Admins SET ModifiedDate = @ModifiedDate WHERE AdminID = 1",
                            new Microsoft.Data.SqlClient.SqlParameter[] {
                                new Microsoft.Data.SqlClient.SqlParameter("@ModifiedDate", DateTime.Now)
                            });

                        testResults += $"   Result: ✅ SUCCESS\n";
                        testResults += $"   Rows affected: {affectedRows}\n\n";
                    }
                    catch (Exception ex)
                    {
                        testResults += $"   Result: ❌ FAILED\n   Error: {ex.Message}\n\n";
                    }
                }

                testResults += "=== TEST COMPLETED ===\n";
                testResults += $"Overall Status: {(isConnected ? "✅ DATABASE READY" : "❌ DATABASE ISSUES")}";

            }
            catch (Exception ex)
            {
                testResults += $"CRITICAL ERROR: {ex.Message}\n";
                testResults += $"Stack Trace: {ex.StackTrace}";
            }

            // Display results in a message box and console
            MessageBox.Show(testResults, "Database Connection Test Results",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            Console.WriteLine(testResults);
        }
    }
}

