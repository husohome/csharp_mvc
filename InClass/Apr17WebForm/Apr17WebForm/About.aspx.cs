using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Apr17WebForm
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            this.txtHeight.Text = "Please input height";
            this.txtWeight.Text = "Please input height";

        }

        protected void btnBMI_Click(object sender, EventArgs e)
        {
            var h = Double.Parse(this.txtHeight.Text)/100;
            var w = Double.Parse(this.txtWeight.Text);
            var bmi = w / (h * h);
            this.lblResult.Text = "" + bmi;

        }
    }
}