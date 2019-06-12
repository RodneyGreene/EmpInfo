using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpInfo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropList.SelectedIndex != 0)
            {
                LblResult.Text = DropList.SelectedValue;
            }
            else
            {
                LblResult.Text = "Please, choose a city.";
            }
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {

            if (TxtName.Text != "" && DropList.SelectedIndex != 0)
            {
                LblFullResult.Text = $"{TxtName.Text} lives in {LblResult.Text}";

                if (RdoMarketing.Checked)
                {
                    LblFullResult.Text += $" and works in {RdoMarketing.Text}";
                }
                else if (RdoAccounting.Checked)
                {
                    LblFullResult.Text += $" and works in {RdoAccounting.Text}";
                }
                else if (RdoLegal.Checked)
                {
                    LblFullResult.Text += $" and works in {RdoLegal.Text}";
                }

                if (!ChkBABS.Checked && !ChkMA.Checked && !ChkPHD.Checked)
                {
                    LblFullResult.Text += " without a degree.";
                }
                else if (ChkBABS.Checked && !ChkMA.Checked && !ChkPHD.Checked) //BABS
                {
                    LblFullResult.Text += $" with a {ChkBABS.Text}.";
                }
                else if (!ChkBABS.Checked && ChkMA.Checked && !ChkPHD.Checked) //MA
                {
                    LblFullResult.Text += $" with a {ChkMA.Text}.";
                }
                else if (!ChkBABS.Checked && !ChkMA.Checked && ChkPHD.Checked) //PHD
                {
                    LblFullResult.Text += $" with a {ChkPHD.Text}.";
                }
                else if (ChkBABS.Checked && ChkMA.Checked && !ChkPHD.Checked) //BABS + MA
                {
                    LblFullResult.Text += $" with a {ChkBABS.Text} and {ChkMA.Text}.";
                }
                else if (!ChkBABS.Checked && ChkMA.Checked && ChkPHD.Checked) //MA + PHD
                {
                    LblFullResult.Text += $" with a {ChkMA.Text} and {ChkPHD.Text}.";
                }
                else if (ChkBABS.Checked && !ChkMA.Checked && ChkPHD.Checked) //BABS + PHD
                {
                    LblFullResult.Text += $" with a {ChkBABS.Text} and {ChkPHD.Text}.";
                }
                else if (ChkBABS.Checked && ChkMA.Checked && ChkPHD.Checked) //BABS + MA + PHD
                {
                    LblFullResult.Text += $" with a {ChkBABS.Text}, {ChkMA.Text} and {ChkPHD.Text}.";
                }
            }
            else
            {
                LblFullResult.Text = "Please, complete the required fields.";
            }
        }

        protected void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}