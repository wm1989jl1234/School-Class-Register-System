using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Gridview : System.Web.UI.Page
{

    string constr = ConfigurationManager.ConnectionStrings["UUUUUConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.BindGrid();
        }
        Panel1.Visible = false;
        Panel2.Visible = false;
    }
    private void BindGrid()
    {
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("uspGetAllTTTTTInfo"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        gvTTTTT.DataSource = dt;
                        gvTTTTT.DataBind();
                    }
                }
            }
        }
    }
    protected void OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        gvTTTTT.EditIndex = e.NewEditIndex;
        this.BindGrid();
    }
    protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = gvTTTTT.Rows[e.RowIndex];
        PKDT varPKPKPKPKPK = System.Convert.ToPKDT((row.FindControl("txtPKPKPKPKPK") as TextBox).Text);
        DTDT1 varFFFF1 = System.Convert.ToDTDT1((row.FindControl("txtFFFF1") as TextBox).Text);
        DTDT2 varFFFF2 = System.Convert.ToDTDT2((row.FindControl("txtFFFF2") as TextBox).Text);
        DTDT3 varFFFF3 = System.Convert.ToDTDT3((row.FindControl("txtFFFF3") as TextBox).Text);
        DTDT4 varFFFF4 = System.Convert.ToDTDT4((row.FindControl("txtFFFF4") as TextBox).Text);
        DTDT5 varFFFF5 = System.Convert.ToDTDT5((row.FindControl("txtFFFF5") as TextBox).Text);
        DTDT6 varFFFF6 = System.Convert.ToDTDT6((row.FindControl("txtFFFF6") as TextBox).Text);
        DTDT7 varFFFF7 = System.Convert.ToDTDT7((row.FindControl("txtFFFF7") as TextBox).Text);
        DTDT8 varFFFF8 = System.Convert.ToDTDT8((row.FindControl("txtFFFF8") as TextBox).Text);
        DTDT9 varFFFF9 = System.Convert.ToDTDT9((row.FindControl("txtFFFF9") as TextBox).Text);
        DTDTA varFFFFA = System.Convert.ToDTDTA((row.FindControl("txtFFFFA") as TextBox).Text);
        DTDTB varFFFFB = System.Convert.ToDTDTB((row.FindControl("txtFFFFB") as TextBox).Text);
        DTDTC varFFFFC = System.Convert.ToDTDTC((row.FindControl("txtFFFFC") as TextBox).Text);
        DTDTD varFFFFD = System.Convert.ToDTDTD((row.FindControl("txtFFFFD") as TextBox).Text);
        DTDTE varFFFFE = System.Convert.ToDTDTE((row.FindControl("txtFFFFE") as TextBox).Text);
        DTDTF varFFFFF = System.Convert.ToDTDTF((row.FindControl("txtFFFFF") as TextBox).Text);
	// CODE BELOW to be SUBSTITUTED for one generic line above if DATETIME field is nullable on web-page... 
            // Replaces null with low-date instead (later it will be cleaned-up back to null by T-SQL stored-procedure)...
//            DateTime varFFFFF = System.Convert.ToDateTime("1 / 1 / 1753 12:00:00 AM");
//            if ((row.FindControl("txtFFFFF") as TextBox).Text != "")
//            {
//                varFFFFF = System.Convert.ToDateTime((row.FindControl("txtFFFFF") as TextBox).Text);
//            }
        // END OF SUBSTITUTE CODE SECTION
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("uspUpdateTTTTT_01"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //setting values for the procedure's input parameters
                cmd.Parameters.AddWithValue("@I_PKPKPKPKPK", varPKPKPKPKPK);
                cmd.Parameters.AddWithValue("@I_FFFF1", varFFFF1);
                cmd.Parameters.AddWithValue("@I_FFFF2", varFFFF2);
                cmd.Parameters.AddWithValue("@I_FFFF3", varFFFF3);
                cmd.Parameters.AddWithValue("@I_FFFF4", varFFFF4);
                cmd.Parameters.AddWithValue("@I_FFFF5", varFFFF5);
                cmd.Parameters.AddWithValue("@I_FFFF6", varFFFF6);
                cmd.Parameters.AddWithValue("@I_FFFF7", varFFFF7);
                cmd.Parameters.AddWithValue("@I_FFFF8", varFFFF8);
                cmd.Parameters.AddWithValue("@I_FFFF9", varFFFF9);
                cmd.Parameters.AddWithValue("@I_FFFFA", varFFFFA);
                cmd.Parameters.AddWithValue("@I_FFFFB", varFFFFB);
                cmd.Parameters.AddWithValue("@I_FFFFC", varFFFFC);
                cmd.Parameters.AddWithValue("@I_FFFFD", varFFFFD);
                cmd.Parameters.AddWithValue("@I_FFFFE", varFFFFE);
                cmd.Parameters.AddWithValue("@I_FFFFF", varFFFFF);
                //setting values for for the procedure's output parameters
                cmd.Parameters.Add("@RetCd1", SqlDbType.Decimal, 5);
                cmd.Parameters["@RetCd1"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@RetCd2", SqlDbType.Decimal, 5);
                cmd.Parameters["@RetCd2"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@RetCd3", SqlDbType.Decimal, 5);
                cmd.Parameters["@RetCd3"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@RetCd4", SqlDbType.Decimal, 5);
                cmd.Parameters["@RetCd4"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF1", SqlDbType.SqlDT1, DSDS1);
                cmd.Parameters["@O_FFFF1"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF2", SqlDbType.SqlDT2, DSDS2);
                cmd.Parameters["@O_FFFF2"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF3", SqlDbType.SqlDT3, DSDS3);
                cmd.Parameters["@O_FFFF3"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF4", SqlDbType.SqlDT4, DSDS4);
                cmd.Parameters["@O_FFFF4"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF5", SqlDbType.SqlDT5, DSDS5);
                cmd.Parameters["@O_FFFF5"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF6", SqlDbType.SqlDT6, DSDS6);
                cmd.Parameters["@O_FFFF6"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF7", SqlDbType.SqlDT7, DSDS7);
                cmd.Parameters["@O_FFFF7"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF8", SqlDbType.SqlDT8, DSDS8);
                cmd.Parameters["@O_FFFF8"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFF9", SqlDbType.SqlDT9, DSDS9);
                cmd.Parameters["@O_FFFF9"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFFA", SqlDbType.SqlDTA, DSDSA);
                cmd.Parameters["@O_FFFFA"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFFB", SqlDbType.SqlDTB, DSDSB);
                cmd.Parameters["@O_FFFFB"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFFC", SqlDbType.SqlDTC, DSDSC);
                cmd.Parameters["@O_FFFFC"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFFD", SqlDbType.SqlDTD, DSDSD);
                cmd.Parameters["@O_FFFFD"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_FFFFE", SqlDbType.SqlDTE, DSDSE);
                cmd.Parameters["@O_FFFFE"].Direction = ParameterDirection.Output;

//Optional substitution section follows...
//                //cmd.Parameters.Add("@O_FFFFE", SqlDbType.Decimal, 6,2);
//                SqlParameter I_param1 = new SqlParameter("@O_FFFFE", SqlDbType.Decimal);
//                I_param1.Value = varFFFFE;
//                I_param1.Precision = 6;
//                I_param1.Scale = 2;
//                cmd.Parameters.Add(I_param1);
//                cmd.Parameters["@O_FFFFE"].Direction = ParameterDirection.Output;
//Optional substitution section above is now ended...

                cmd.Parameters.Add("@O_FFFFF", SqlDbType.SqlDTF, DSDSF);
                cmd.Parameters["@O_FFFFF"].Direction = ParameterDirection.Output;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                if (cmd.Parameters["@RetCd1"].Value.ToString().CompareTo("0") == 0)
                {
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                    lblFFFF1.Text = "FFFF1:" + cmd.Parameters["@O_FFFF1"].Value.ToString();
                    lblFFFF2.Text = "FFFF2:" + cmd.Parameters["@O_FFFF2"].Value.ToString();
                    lblFFFF3.Text = "FFFF3:" + cmd.Parameters["@O_FFFF3"].Value.ToString();
                    lblFFFF4.Text = "FFFF4:" + cmd.Parameters["@O_FFFF4"].Value.ToString();
                    lblFFFF5.Text = "FFFF5:" + cmd.Parameters["@O_FFFF5"].Value.ToString();
                    lblFFFF6.Text = "FFFF6:" + cmd.Parameters["@O_FFFF6"].Value.ToString();
                    lblFFFF7.Text = "FFFF7:" + cmd.Parameters["@O_FFFF7"].Value.ToString();
                    lblFFFF8.Text = "FFFF8:" + cmd.Parameters["@O_FFFF8"].Value.ToString();
                    lblFFFF9.Text = "FFFF9:" + cmd.Parameters["@O_FFFF9"].Value.ToString();
                    lblFFFFA.Text = "FFFFA:" + cmd.Parameters["@O_FFFFA"].Value.ToString();
                    lblFFFFB.Text = "FFFFB:" + cmd.Parameters["@O_FFFFB"].Value.ToString();
                    lblFFFFC.Text = "FFFFC:" + cmd.Parameters["@O_FFFFC"].Value.ToString();
                    lblFFFFD.Text = "FFFFD:" + cmd.Parameters["@O_FFFFD"].Value.ToString();
                    lblFFFFE.Text = "FFFFE:" + cmd.Parameters["@O_FFFFE"].Value.ToString();
                    lblFFFFF.Text = "FFFFF:" + cmd.Parameters["@O_FFFFF"].Value.ToString();
                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    if (cmd.Parameters["@RetCd1"].Value.ToString().CompareTo("0") != 0)
                    {
                        using (SqlConnection con1 = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd1 = new SqlCommand("usp_Get_Message"))
                            {
                                using (SqlDataAdapter da1 = new SqlDataAdapter())
                                {
                                    cmd1.Connection = con1;
                                    con1.Open();
                                    cmd1.CommandType = CommandType.StoredProcedure;
                                    cmd1.Parameters.AddWithValue("@MESSAGE_ID", System.Convert.ToDecimal(cmd.Parameters["@RetCd1"].Value.ToString()));
                                    cmd1.Parameters.Add("@MESSAGE_TYPE", SqlDbType.VarChar, 1);
                                    cmd1.Parameters["@MESSAGE_TYPE"].Direction = ParameterDirection.Output;
                                    cmd1.Parameters.Add("@MESSAGE_TEXT", SqlDbType.NVarChar, 150);
                                    cmd1.Parameters["@MESSAGE_TEXT"].Direction = ParameterDirection.Output;
                                    da1.SelectCommand = cmd1;
                                    cmd1.ExecuteNonQuery();
                                    con1.Close();
                                    lblcd1.Text = "Return code 1:->Message ID: " + cmd.Parameters["@RetCd1"].Value.ToString() + "; Message type: " + cmd1.Parameters["@MESSAGE_TYPE"].Value.ToString() + ";Message text: " + cmd1.Parameters["@MESSAGE_TEXT"].Value.ToString();

                                }
                            }
                        }
                    }
                    if (cmd.Parameters["@RetCd2"].Value.ToString().CompareTo("0") != 0)
                    {

                        using (SqlConnection con2 = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd2 = new SqlCommand("usp_Get_Message"))
                            {
                                using (SqlDataAdapter da2 = new SqlDataAdapter())
                                {
                                    cmd2.Connection = con2;
                                    con2.Open();
                                    cmd2.CommandType = CommandType.StoredProcedure;
                                    cmd2.Parameters.AddWithValue("@MESSAGE_ID", System.Convert.ToDecimal(cmd.Parameters["@RetCd2"].Value.ToString()));
                                    cmd2.Parameters.Add("@MESSAGE_TYPE", SqlDbType.VarChar, 1);
                                    cmd2.Parameters["@MESSAGE_TYPE"].Direction = ParameterDirection.Output;
                                    cmd2.Parameters.Add("@MESSAGE_TEXT", SqlDbType.NVarChar, 150);
                                    cmd2.Parameters["@MESSAGE_TEXT"].Direction = ParameterDirection.Output;
                                    da2.SelectCommand = cmd2;
                                    cmd2.ExecuteNonQuery();
                                    con2.Close();
                                    lblcd2.Text = "Return code 2:->Message ID: " + cmd.Parameters["@RetCd2"].Value.ToString() + "; Message type: " + cmd2.Parameters["@MESSAGE_TYPE"].Value.ToString() + ";Message text: " + cmd2.Parameters["@MESSAGE_TEXT"].Value.ToString();

                                }
                            }
                        }

                    }
                    if (cmd.Parameters["@RetCd3"].Value.ToString().CompareTo("0") != 0)
                    {

                        using (SqlConnection con3 = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd3 = new SqlCommand("usp_Get_Message"))
                            {
                                using (SqlDataAdapter da3 = new SqlDataAdapter())
                                {
                                    cmd3.Connection = con3;
                                    con3.Open();
                                    cmd3.CommandType = CommandType.StoredProcedure;
                                    cmd3.Parameters.AddWithValue("@MESSAGE_ID", System.Convert.ToDecimal(cmd.Parameters["@RetCd3"].Value.ToString()));
                                    cmd3.Parameters.Add("@MESSAGE_TYPE", SqlDbType.VarChar, 1);
                                    cmd3.Parameters["@MESSAGE_TYPE"].Direction = ParameterDirection.Output;
                                    cmd3.Parameters.Add("@MESSAGE_TEXT", SqlDbType.NVarChar, 150);
                                    cmd3.Parameters["@MESSAGE_TEXT"].Direction = ParameterDirection.Output;
                                    da3.SelectCommand = cmd3;
                                    cmd3.ExecuteNonQuery();
                                    con3.Close();
                                    lblcd3.Text = "Return code 3:->Message ID: " + cmd.Parameters["@RetCd3"].Value.ToString() + "; Message type: " + cmd3.Parameters["@MESSAGE_TYPE"].Value.ToString() + ";Message text: " + cmd3.Parameters["@MESSAGE_TEXT"].Value.ToString();

                                }
                            }
                        }

                    }
                    if (cmd.Parameters["@RetCd4"].Value.ToString().CompareTo("0") != 0)
                    {

                        using (SqlConnection con4 = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd4 = new SqlCommand("usp_Get_Message"))
                            {
                                using (SqlDataAdapter da4 = new SqlDataAdapter())
                                {
                                    cmd4.Connection = con4;
                                    con4.Open();
                                    cmd4.CommandType = CommandType.StoredProcedure;
                                    cmd4.Parameters.AddWithValue("@MESSAGE_ID", System.Convert.ToDecimal(cmd.Parameters["@RetCd4"].Value.ToString()));
                                    cmd4.Parameters.Add("@MESSAGE_TYPE", SqlDbType.VarChar, 1);
                                    cmd4.Parameters["@MESSAGE_TYPE"].Direction = ParameterDirection.Output;
                                    cmd4.Parameters.Add("@MESSAGE_TEXT", SqlDbType.NVarChar, 150);
                                    cmd4.Parameters["@MESSAGE_TEXT"].Direction = ParameterDirection.Output;
                                    da4.SelectCommand = cmd4;
                                    cmd4.ExecuteNonQuery();
                                    con4.Close();
                                    lblcd4.Text = "Return code 4:->Message ID: " + cmd.Parameters["@RetCd4"].Value.ToString() + "; Message type: " + cmd4.Parameters["@MESSAGE_TYPE"].Value.ToString() + ";Message text: " + cmd4.Parameters["@MESSAGE_TEXT"].Value.ToString();

                                }
                            }
                        }

                    }
                }
            }
        }
        gvTTTTT.EditIndex = -1;
        this.BindGrid();
    }
    protected void OnRowCancelingEdit(object sender, EventArgs e)
    {
        gvTTTTT.EditIndex = -1;
        this.BindGrid();
    }
    protected void Search(object sender, EventArgs e)
    {

        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("uspReceiveTTTTTInfo"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PKPKPKPKPK", txtSearchPKPKPKPKPK.Text);
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        gvTTTTT.DataSource = dt;
                        gvTTTTT.DataBind();
                    }
                }
            }

        }

    }

    protected void Showall(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("uspGetAllTTTTTInfo"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        gvTTTTT.DataSource = dt;
                        gvTTTTT.DataBind();
                    }
                }
            }
        }
    }

}