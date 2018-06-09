using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this,GetType(),"mykey","myfunc();",true);
            var num1 = Convert.ToDouble(this.TextBox1.Text);
            var num2 = Convert.ToDouble(this.TextBox2.Text);

            var oper = Convert.ToInt32(this.DropDownList1.SelectedValue);
            var res = 0.0;

            switch (oper)
            {
                case 1:
                    res = num1 + num2;
                    break;
                case 2:
                    res = num1 - num2;
                    break;
                case 3:
                    res = num1 * num2;
                    break;
                case 4:
                    res = num1 / num2;
                    break;
                default:
                    res = 0;
                    break;
            }

            this.TextBox3.Text = res + "";


        }
    }
}