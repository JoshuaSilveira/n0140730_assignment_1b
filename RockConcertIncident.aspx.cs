using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n0140730_assignment_1b
{
    public partial class RockConcertIncident : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                String reporterName = reporter_name.Text;
                String reporterPhone = reporter_phone.Text;
                int affectedCount = Convert.ToInt32(affected_count.Text);
                String incidentDate = incident_date.Text;
                String incidentTime = incident_time.Text;
                String incidentDescription = incident_description_textarea.Text;

                confirmbox.InnerHtml = "Thank you for filling out an incident report: <br>";

                confirmbox.InnerHtml += "Reporter Name: " + reporterName + "<br>";
                confirmbox.InnerHtml += "Reporter Phone number: " + reporterPhone + "<br>";
                confirmbox.InnerHtml += "Affected Count: " + affectedCount + "<br>";
                confirmbox.InnerHtml += "Incident occured on: " + incidentDate + "<br>";
                confirmbox.InnerHtml += "At approx.: " + incidentTime + "<br>";
                confirmbox.InnerHtml += "Decription: " + incidentDescription + "<br>";

                if (incidentDescription.ToLower().Contains("urgent"))
                {
                    confirmbox.InnerHtml += ("Urgent Attention Required");
                }
                else if (incidentDescription.ToLower().Contains("resolved"))
                {
                    confirmbox.InnerHtml += ("Incident Resolved");
                }
                else
                {
                    confirmbox.InnerHtml += ("Pending Investigation");
                }
            }
        }
    }
}