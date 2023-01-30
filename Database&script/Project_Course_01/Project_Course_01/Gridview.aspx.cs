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

    string constr = ConfigurationManager.ConnectionStrings["yiming1ConnectionString"].ConnectionString;
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
            using (SqlCommand cmd = new SqlCommand("uspGetAllCOURSEInfo"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        gvCOURSE.DataSource = dt;
                        gvCOURSE.DataBind();
                    }
                }
            }
        }
    }
    protected void OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        gvCOURSE.EditIndex = e.NewEditIndex;
        this.BindGrid();
    }
    protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = gvCOURSE.Rows[e.RowIndex];
        Decimal varCOURSE_ID = System.Convert.ToDecimal((row.FindControl("txtCOURSE_ID") as TextBox).Text);
        String varTITLE = System.Convert.ToString((row.FindControl("txtTITLE") as TextBox).Text);
        //        DateTime varCOURSE_EFF_DATE = System.Convert.ToDateTime((row.FindControl("txtCOURSE_EFF_DATE") as TextBox).Text);

        // CODE BELOW to be SUBSTITUTED for one generic line above if DATETIME field is nullable on web-page... 
        // Replaces null with low-date instead (later it will be cleaned-up back to null by T-SQL stored-procedure)...
        DateTime varCOURSE_EFF_DATE = System.Convert.ToDateTime("1 / 1 / 1753 12:00:00 AM");
        if ((row.FindControl("txtCOURSE_EFF_DATE") as TextBox).Text != "")
        {
            varCOURSE_EFF_DATE = System.Convert.ToDateTime((row.FindControl("txtCOURSE_EFF_DATE") as TextBox).Text);
        }
        //        END OF SUBSTITUTE CODE SECTION

        //      DateTime varCOURSE_EXP_DATE = System.Convert.ToDateTime((row.FindControl("txtCOURSE_EXP_DATE") as TextBox).Text);
        DateTime varCOURSE_EXP_DATE = System.Convert.ToDateTime("1 / 1 / 1753 12:00:00 AM");
        if ((row.FindControl("txtCOURSE_EXP_DATE") as TextBox).Text != "")
        {
            varCOURSE_EXP_DATE = System.Convert.ToDateTime((row.FindControl("txtCOURSE_EXP_DATE") as TextBox).Text);
        }
        Decimal varDURATION = System.Convert.ToDecimal((row.FindControl("txtDURATION") as TextBox).Text);
        Decimal varCOST = System.Convert.ToDecimal((row.FindControl("txtCOST") as TextBox).Text);
        //Decimal varSUBJECT_ID = System.Convert.ToDecimal((row.FindControl("txtSUBJECT_ID") as TextBox).Text);
        DateTime varUPDATE_TS = System.Convert.ToDateTime((row.FindControl("txtUPDATE_TS") as TextBox).Text);


        // CODE BELOW to be SUBSTITUTED for one generic line above if DATETIME field is nullable on web-page... 
        // Replaces null with low-date instead (later it will be cleaned-up back to null by T-SQL stored-procedure)...
        //       DateTime varDATE_RELEASED = System.Convert.ToDateTime("1 / 1 / 1753 12:00:00 AM");
        //        if ((row.FindControl("txtDATE_RELEASED") as TextBox).Text != "")
        //       {
        //          varDATE_RELEASED = System.Convert.ToDateTime((row.FindControl("txtDATE_RELEASED") as TextBox).Text);
        //      }
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("uspUpdateCOURSE_01"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //setting values for the procedure's input parameters
                cmd.Parameters.AddWithValue("@I_COURSE_ID", varCOURSE_ID);
                cmd.Parameters.AddWithValue("@I_TITLE", varTITLE);
                cmd.Parameters.AddWithValue("@I_COURSE_EFF_DATE", varCOURSE_EFF_DATE);
                cmd.Parameters.AddWithValue("@I_COURSE_EXP_DATE", varCOURSE_EXP_DATE);
                cmd.Parameters.AddWithValue("@I_DURATION", varDURATION);
                cmd.Parameters.AddWithValue("@I_COST", varCOST);
                //    cmd.Parameters.AddWithValue("@I_SUBJECT_ID", varSUBJECT_ID);
                cmd.Parameters.AddWithValue("@I_UPDATE_TS", varUPDATE_TS);

                //setting values for for the procedure's output parameters
                cmd.Parameters.Add("@RetCd1", SqlDbType.Decimal, 5);
                cmd.Parameters["@RetCd1"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@RetCd2", SqlDbType.Decimal, 5);
                cmd.Parameters["@RetCd2"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@RetCd3", SqlDbType.Decimal, 5);
                cmd.Parameters["@RetCd3"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@RetCd4", SqlDbType.Decimal, 5);
                cmd.Parameters["@RetCd4"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_TITLE", SqlDbType.VarChar, 30);
                cmd.Parameters["@O_TITLE"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_COURSE_EFF_DATE", SqlDbType.DateTime, 8);
                cmd.Parameters["@O_COURSE_EFF_DATE"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_COURSE_EXP_DATE", SqlDbType.DateTime, 8);
                cmd.Parameters["@O_COURSE_EXP_DATE"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_DURATION", SqlDbType.Decimal, 2);
                cmd.Parameters["@O_DURATION"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_COST", SqlDbType.Decimal, 5);
                cmd.Parameters["@O_COST"].Direction = ParameterDirection.Output;
                //          cmd.Parameters.Add("@O_SUBJECT_ID", SqlDbType.Decimal, 2);
                //        cmd.Parameters["@O_SUBJECT_ID"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@O_UPDATE_TS", SqlDbType.DateTime, 8);
                cmd.Parameters["@O_UPDATE_TS"].Direction = ParameterDirection.Output;

                //Optional substitution section follows...
                //                //cmd.Parameters.Add("@O_FFFFE", SqlDbType.Decimal, 6,2);
                //                SqlParameter I_param1 = new SqlParameter("@O_FFFFE", SqlDbType.Decimal);
                //                I_param1.Value = varFFFFE;
                //                I_param1.Precision = 6;
                //                I_param1.Scale = 2;
                //                cmd.Parameters.Add(I_param1);
                //                cmd.Parameters["@O_FFFFE"].Direction = ParameterDirection.Output;
                //Optional substitution section above is now ended...

                // cmd.Parameters.Add("@O_FFFFF", SqlDbType.SqlDTF, DSDSF);
                //cmd.Parameters["@O_FFFFF"].Direction = ParameterDirection.Output;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                if (cmd.Parameters["@RetCd1"].Value.ToString().CompareTo("0") == 0)
                {
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                    lblTITLE.Text = "TITLE:" + cmd.Parameters["@O_TITLE"].Value.ToString();
                    lblCOURSE_EFF_DATE.Text = "COURSE_EFF_DATE:" + cmd.Parameters["@O_COURSE_EFF_DATE"].Value.ToString();
                    lblCOURSE_EXP_DATE.Text = "COURSE_EXP_DATE:" + cmd.Parameters["@O_COURSE_EXP_DATE"].Value.ToString();
                    lblDURATION.Text = "DURATION:" + cmd.Parameters["@O_DURATION"].Value.ToString();
                    lblCOST.Text = "COST:" + cmd.Parameters["@O_COST"].Value.ToString();
                    //                lblSUBJECT_ID.Text = "SUBJECT_ID:" + cmd.Parameters["@O_SUBJECT_ID"].Value.ToString();
                    lblUPDATE_TS.Text = "UPDATE_TS:" + cmd.Parameters["@O_UPDATE_TS"].Value.ToString();
                    ;
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
        gvCOURSE.EditIndex = -1;
        this.BindGrid();
    }
    protected void OnRowCancelingEdit(object sender, EventArgs e)
    {
        gvCOURSE.EditIndex = -1;
        this.BindGrid();
    }
    protected void Search(object sender, EventArgs e)
    {

        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("uspReceiveCOURSEInfo"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@COURSE_ID", txtSearchCOURSE_ID.Text);
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        gvCOURSE.DataSource = dt;
                        gvCOURSE.DataBind();
                    }
                }
            }

        }

    }

    protected void Showall(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("uspGetAllCOURSEInfo"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        gvCOURSE.DataSource = dt;
                        gvCOURSE.DataBind();
                    }
                }
            }
        }
    }

}




