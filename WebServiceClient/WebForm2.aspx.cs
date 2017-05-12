using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceClient
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference2.EmployeeServiceClient client = new ServiceReference2.EmployeeServiceClient();

            var result = client.getEmployeeById(1);
        }
    }
}