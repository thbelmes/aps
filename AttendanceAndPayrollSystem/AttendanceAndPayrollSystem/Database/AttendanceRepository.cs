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
    public class AttendanceRepository : Db<int>
    {
        const string TableName = "Attendance";

        public int TimeIn(AttendanceModel model)
        {
            try
            {
                using (var SqlConnection = new SqlConnection(ConnectionString))
                {
                    SqlConnection.Open();
                    using (var sqlTransaction = SqlConnection.BeginTransaction())
                    {
                        var sql = $"INSERT INTO {TableName}(EmployeeId,DateTimeIn)" +
                             $"VALUES(@EmployeeId,@DateTimeIn){SelectScopeIdentitySql()}";
                        var insertSql = SqlDebugHelper.CreateExecutableSqlStatement(sql, CommandType.Text,
                                               new List<SqlParameter> {
                                                    new SqlParameter("EmployeeId", model.EmployeeId),
                                                    new SqlParameter("DateTimeIn", model.DateTimeIn),
                                               });

                        var id = DatabaseHelper.ExecuteScalar<int>(sqlTransaction, CommandType.Text, insertSql);

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
        public int TimeOut(AttendanceModel model)
        {
            try
            {
                using (var SqlConnection = new SqlConnection(ConnectionString))
                {
                    SqlConnection.Open();
                    using (var sqlTransaction = SqlConnection.BeginTransaction())
                    {
                        var sql = $" INSERT INTO {TableName}(EmployeeId,DateTimeOut,RegularHoursRendered,OTHoursRendered)" +
                             $"VALUES(@EmployeeId,@DateTimeOut,@RegularHoursRendered,@OTHoursRendered){SelectScopeIdentitySql()}";
                        var insertSql = SqlDebugHelper.CreateExecutableSqlStatement(sql, CommandType.Text,
                                               new List<SqlParameter> {
                                                    new SqlParameter("EmployeeId", model.EmployeeId),
                                                    new SqlParameter("DateTimeOut", model.DateTimeOut),
                                                    new SqlParameter("RegularHoursRendered", model.RegularHoursRendered),
                                                    new SqlParameter("OTHoursRendered", model.OTHoursRendered),
                                               });

                        var id = DatabaseHelper.ExecuteScalar<int>(sqlTransaction, CommandType.Text, insertSql);

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

        public IList<AttendanceModel> ReadByEmployeeId(int employeeId)
        {
            using (DbDataReader dataReader = DatabaseHelper.ExecuteReader(ConnectionString, CommandType.Text,
                   $"SELECT * FROM {TableName} where employeeId = @empId", new SqlParameter("empId", employeeId)))
            {
                var attendances = new List<AttendanceModel>();
                while (dataReader.Read())
                {
                    attendances.Add(new AttendanceModel
                    {
                        EmployeeId = dataReader["EmployeeId"].GetDbValueOrDefaultForValueType<int>(),
                        AttendanceId = dataReader["AttendanceId"].GetDbValueOrDefaultForValueType<int>(),
                        DateTimeIn = dataReader["DateTimeIn "].GetDbValueOrDefaultForValueType<DateTime>(),
                        DateTimeOut = dataReader["DateTimeOut"].GetDbValueOrDefaultForValueType<DateTime>(),
                        RegularHoursRendered = dataReader["RegularHoursRendered"].GetDbValueOrDefaultForValueType<float>(),
                        OTHoursRendered = dataReader[" OTHoursRendered "].GetDbValueOrDefaultForValueType<float>(),
                    });
                }
                return attendances;
            }
        }
        public AttendanceModel GetLastRecord(int employeeId)
        {
            using (DbDataReader dataReader = DatabaseHelper.ExecuteReader(ConnectionString, CommandType.Text,
                   $"SELECT top 1 * FROM {TableName} where employeeId = @empId order by attendanceId desc", new SqlParameter("empId", employeeId)))
            {
                if (dataReader.HasRows == false)
                    return null;

                dataReader.Read();
                return new AttendanceModel
                {
                    EmployeeId = dataReader["EmployeeId"].GetDbValueOrDefaultForValueType<int>(),
                    AttendanceId = dataReader["AttendanceId"].GetDbValueOrDefaultForValueType<int>(),
                    DateTimeIn = dataReader["DateTimeIn"].GetDbValueForNullableValueType<DateTime>(),
                    DateTimeOut = dataReader["DateTimeOut"].GetDbValueForNullableValueType<DateTime>(),
                    RegularHoursRendered = dataReader["RegularHoursRendered"].GetDbValueForNullableValueType<double>(),
                    OTHoursRendered = dataReader["OTHoursRendered"].GetDbValueForNullableValueType<double>(),
                };

            }
        }

    }
}
