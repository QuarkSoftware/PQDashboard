using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GSF.Configuration;
using GSF.Data;
using GSF.Data.Model;
using openXDA.Model;

public partial class ChannelDataCompleteness : System.Web.UI.Page
{
    public String postedDate = "";
    public String postedMeterId = "";
    public String postedMeterName = "";
    public String postedEventId = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["eventId"] != null)
            {
                postedEventId = Request["eventId"];

                using (AdoDataConnection connection = new AdoDataConnection("systemSettings"))
                {
                    try
                    {

                        MeterDataQualitySummary theevent = (new TableOperations<MeterDataQualitySummary>(connection)).QueryRecordWhere("ID = {0}", Convert.ToInt32(postedEventId));

                        postedDate = theevent.Date.ToShortDateString();
                        postedMeterId = theevent.MeterID.ToString();
                        postedMeterName = connection.ExecuteScalar<string>("SELECT Name From Meter WHERE ID = {0}", theevent.MeterID);
                    }

                    catch (Exception ex)
                    {
                        postedDate = "";
                        postedEventId = "";
                        postedMeterId = "";
                        postedMeterName = "";
                    }
                    finally
                    {

                    }
                }
            }
        }
    }
}