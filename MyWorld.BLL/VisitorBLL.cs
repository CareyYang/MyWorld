using System.Text;

namespace MyWorld.BLL
{
    public class VisitorBLL: BaseBLL
    {
        public int VerifyUser(string openId)
        {
            StringBuilder strWhere = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(openId))
            {
                strWhere.Append(" WeChat_Id='" + openId + "'");
            }
            else
            {
                return -1;
            }
            return visitorDAL.VerifyUser(strWhere.ToString());
        }
    }
}
