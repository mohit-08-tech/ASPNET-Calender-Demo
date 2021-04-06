using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPCalenderControlDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtText.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
           if(e.Day.IsToday)
            {
                e.Cell.BackColor = System.Drawing.Color.Aqua;
                e.Cell.ForeColor = System.Drawing.Color.White;
            }
           if(e.Day.IsWeekend)
            {
                e.Cell.BackColor = System.Drawing.Color.Orange;
                e.Cell.ForeColor = System.Drawing.Color.White;
            }
           if(e.Day.IsSelected)
            {
                e.Cell.BackColor = System.Drawing.Color.SeaGreen;
            }
        }
    }
}