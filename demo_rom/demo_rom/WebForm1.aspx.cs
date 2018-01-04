using Chloe;
using Chloe.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
namespace demo_rom
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IDbContext context = new MsSqlContext(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            IQuery<T_Course> q = context.Query<T_Course>();
            var one= q.Where(a => a.ID > 0).FirstOrDefault();

        }
    }
}