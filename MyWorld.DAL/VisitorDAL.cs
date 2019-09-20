using MyWorld.Model;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MyWorld.DAL
{
    public class VisitorDAL:BaseDAL
    {
        /// <summary>
        /// 验证是否存在该用户
        /// </summary>
        public int VerifyUser(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Tb_Visitor ");

            if (!string.IsNullOrWhiteSpace(strWhere))
            {
                strSql.Append(" where " + strWhere);
            }

            bool flag = DbHelperSQL.Exists(conn_MyWorld, strSql.ToString());
            if (flag)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        public int EditUserInfo(VisitorModel model)
        {
            //if (VerifyUser(" UserName='" + model.UserName + "' AND ID<> " + model.ID) == 1)
            //{
            //    return -1;
            //}
            //else
            //{
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update Sys_User set ");
                strSql.Append("UserName=@UserName,");
                strSql.Append("Pwd=@Pwd,");
                strSql.Append("Phone=@Phone,");
                strSql.Append("Email=@Email,");
                strSql.Append("RealName=@RealName,");
                strSql.Append("Flag=@Flag,");
                strSql.Append("UpdateDate=@UpdateDate");
                strSql.Append(" where ID=@ID");
                SqlParameter[] parameters = {
                    new SqlParameter("@VisitorName", SqlDbType.VarChar,50),
                    new SqlParameter("@VisitorIPAddress", SqlDbType.VarChar,50),
                    new SqlParameter("@VisitorBrower", SqlDbType.VarChar,100),
                    new SqlParameter("@Email", SqlDbType.VarChar,100),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
                parameters[0].Value = model.VisitorName;
                parameters[1].Value = model.VisitorIPAddress;
                parameters[2].Value = model.VisitorBrower;
                parameters[3].Value = model.Remark;
                parameters[4].Value = model.Id;

                int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
                return rows;
            //}
        }

        /// <summary>
        /// 添加访问信息
        /// </summary>
        public int AddVisitorInfo(VisitorModel model)
        {
            //if (VerifyUser(" UserName='" + model.UserName + "' AND ID<> " + model.ID) == 1)
            //{
            //    return -1;
            //}
            //else
            //{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_User set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("Pwd=@Pwd,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Email=@Email,");
            strSql.Append("RealName=@RealName,");
            strSql.Append("Flag=@Flag,");
            strSql.Append("UpdateDate=@UpdateDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@VisitorName", SqlDbType.VarChar,50),
                    new SqlParameter("@VisitorIPAddress", SqlDbType.VarChar,50),
                    new SqlParameter("@VisitorBrower", SqlDbType.VarChar,100),
                    new SqlParameter("@Email", SqlDbType.VarChar,100),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.VisitorName;
            parameters[1].Value = model.VisitorIPAddress;
            parameters[2].Value = model.VisitorBrower;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            return rows;
            //}
        }
    }
}
