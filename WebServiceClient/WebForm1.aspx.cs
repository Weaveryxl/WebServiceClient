using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Remember to add service reference, we defined it in other web service program, update service reference
            //Declare clients 
            ServiceReference1.WebService1SoapClient client1 = new ServiceReference1.WebService1SoapClient();

            ServiceReference2.EmployeeServiceClient client2 = new ServiceReference2.EmployeeServiceClient();


            //var message = client1.HelloWorld();
            //var message2 = client1.GetTestMessage("fafefaa");

            //using methods, remember to add marks like [DataMember] to these methods
            var StringRes = client2.getStringById(1);
            var emp = client2.getEmployeeById(1);

            Response.Write(StringRes);
            //Print the properties in basic types, not in user defined type like Employee
            Response.Write(emp.EmpName);

            //Response.Write(message);
            //Response.Write(message2);
        }
    }
}