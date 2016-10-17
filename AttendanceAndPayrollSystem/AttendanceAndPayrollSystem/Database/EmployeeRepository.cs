using AttendanceAndPayrollSystem.Database.Models;
using Mirabeau.MsSql.Library;
using Mirabeau.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceAndPayrollSystem.Database
{
    public class EmployeeRepository : Db<int>
    {
        const string TableName = "Employees";

        public int Create(EmployeeModel model)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ConnectionString))
                {
                    // we need to open the connection
                    sqlConnection.Open();
                    using (var sqlTransaction = sqlConnection.BeginTransaction())
                    {
                        // sql insert template
                        var sql = $"INSERT INTO {TableName}(LastName, FirstName, MiddleName, Birthdate, Sex, Barangay, Street, City, Citizenship, Religion, CivilStatus)" +
                           $"VALUES (@lastName, @firstName, @middleName, @bday, @sex, @barangay, @street, @city, @citizenship, @religion, @civilStatus) {SelectScopeIdentitySql()}"; // this adds a select scope_identity() sql to the query to return the new ID

                        // generates an insert sql statement with the parameters
                        var insertSql = SqlDebugHelper.CreateExecutableSqlStatement(sql, CommandType.Text,
                                            new List<SqlParameter> {
                                            new SqlParameter("lastName", model.LastName),
                                            new SqlParameter("firstName", model.FirstName),
                                            new SqlParameter("middleName", model.MiddleName),
                                            new SqlParameter("bday", model.Birthdate),
                                            new SqlParameter("sex", model.Sex),
                                            new SqlParameter("barangay", model.Barangay),
                                            new SqlParameter("street", model.Street),
                                            new SqlParameter("city", model.City),
                                            new SqlParameter("citizenship", model.Citizenship),
                                            new SqlParameter("religion", model.Religion),
                                            new SqlParameter("civilStatus", model.CivilStatus),
                                        });

                        // returns the new ID
                        var id = DatabaseHelper.ExecuteScalar<int>(sqlTransaction, CommandType.Text, insertSql);

                        // INSERT TO ED ATTAINMENT


                        sqlTransaction.Commit();

                        return id;

                    }
                }
            }
            catch (Exception e)
            {
                // failed transaction
                return -1;
            }
        }

        public IList<EmployeeModel> Read()
        {
            using (DbDataReader dataReader = DatabaseHelper.ExecuteReader(ConnectionString, CommandType.Text,
                   $"SELECT * FROM {TableName}"))
            {
                var employees = new List<EmployeeModel>();
                while (dataReader.Read())
                {
                    employees.Add(new EmployeeModel
                    {
                        EmployeeId = dataReader["EmployeeId"].GetDbValueOrDefaultForValueType<int>(),
                        LastName = dataReader["LastName"].GetDbValueOrNullForReferenceType<string>(),
                        FirstName = dataReader["FirstName"].GetDbValueOrNullForReferenceType<string>(),
                        MiddleName = dataReader["MiddleName"].GetDbValueOrNullForReferenceType<string>(),
                        Birthdate = dataReader["Birthdate"].GetDbValueOrDefaultForValueType<DateTime>(),
                        Sex = dataReader["Sex"].GetDbValueOrNullForReferenceType<string>(),
                        Barangay = dataReader["Barangay"].GetDbValueOrNullForReferenceType<string>(),
                        Street = dataReader["Street"].GetDbValueOrNullForReferenceType<string>(),
                        City = dataReader["City"].GetDbValueOrNullForReferenceType<string>(),
                        Citizenship = dataReader["Citizenship"].GetDbValueOrNullForReferenceType<string>(),
                        Religion = dataReader["Religion"].GetDbValueOrNullForReferenceType<string>(),
                        CivilStatus = dataReader["CivilStatus"].GetDbValueOrNullForReferenceType<string>()
                    });
                }
                return employees;
            }
        }
    }
}
