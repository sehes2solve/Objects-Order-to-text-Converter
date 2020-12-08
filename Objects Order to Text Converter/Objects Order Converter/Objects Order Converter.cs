using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objects_Order_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Objects_Order_Methodes obj = new Objects_Order_Methodes();

        private void TXT_val_Enter(object sender, EventArgs e)
        {
            if (TXT_val.Text == "Order" && TXT_val.ForeColor == SystemColors.InactiveCaption)
            { TXT_val.Text = ""; TXT_val.ForeColor = SystemColors.ActiveCaptionText; }

        }

        private void TXT_lang_Enter(object sender, EventArgs e)
        {
            if (TXT_lang.Text == "Language" && TXT_lang.ForeColor == SystemColors.InactiveCaption)
            { TXT_lang.Text = ""; TXT_lang.ForeColor = SystemColors.ActiveCaptionText; }
        }

        private void TXT_obj_Enter(object sender, EventArgs e)
        {
            if (TXT_obj.Text == "Object" && TXT_obj.ForeColor == SystemColors.InactiveCaption)
            { TXT_obj.Text = ""; TXT_obj.ForeColor = SystemColors.ActiveCaptionText; }
        }

        private void TXT_val_Leave(object sender, EventArgs e)
        {
            if (TXT_val.Text == "" && TXT_val.ForeColor == SystemColors.ActiveCaptionText)
            { TXT_val.Text = "Order"; TXT_val.ForeColor = SystemColors.InactiveCaption; }
        }

        private void TXT_lang_Leave(object sender, EventArgs e)
        {
            if (TXT_lang.Text == "" && TXT_lang.ForeColor == SystemColors.ActiveCaptionText)
            { TXT_lang.Text = "Language"; TXT_lang.ForeColor = SystemColors.InactiveCaption; }
        }

        private void TXT_obj_Leave(object sender, EventArgs e)
        {
            if (TXT_obj.Text == "" && TXT_obj.ForeColor == SystemColors.ActiveCaptionText)
            { TXT_obj.Text = "Object"; TXT_obj.ForeColor = SystemColors.InactiveCaption; }
        }

        private void BTN_val_Click(object sender, EventArgs e)
        {
            int err_id; string err_message;
            if (TXT_val.Text == "Order" && TXT_val.ForeColor == SystemColors.InactiveCaption)
                TXT_val.Text = "";
            if (TXT_lang.Text == "Language" && TXT_lang.ForeColor == SystemColors.InactiveCaption)
                TXT_lang.Text = "";
            if (TXT_obj.Text == "Object" && TXT_obj.ForeColor == SystemColors.InactiveCaption)
                TXT_obj.Text = "";
            if (obj.Validation(TXT_val.Text, TXT_lang.Text, out err_id, out err_message))
                BTN_convert.Enabled = true;
            else
                LBL_result.Text = err_id + " : " + err_message;
            if (TXT_val.Text == "" && TXT_val.ForeColor == SystemColors.InactiveCaption)
                TXT_val.Text = "Order";
            if (TXT_lang.Text == "" && TXT_lang.ForeColor == SystemColors.InactiveCaption)
                TXT_lang.Text = "Language";
            if (TXT_obj.Text == "" && TXT_obj.ForeColor == SystemColors.InactiveCaption)
                TXT_obj.Text = "Object";

        }

        private void TXT_val_TextChanged(object sender, EventArgs e)
        {
            BTN_convert.Enabled = false;
        }

        private void TXT_lang_TextChanged(object sender, EventArgs e)
        {
            BTN_convert.Enabled = false;
        }

        private void BTN_convert_Click(object sender, EventArgs e)
        {
            if (TXT_val.Text == "Order" && TXT_val.ForeColor == SystemColors.InactiveCaption)
                TXT_val.Text = "";
            if (TXT_lang.Text == "Language" && TXT_lang.ForeColor == SystemColors.InactiveCaption)
                TXT_lang.Text = "";
            if (TXT_obj.Text == "Object" && TXT_obj.ForeColor == SystemColors.InactiveCaption)
                TXT_obj.Text = "";
            LBL_result.Text = obj.Objects_Order_Converter(TXT_val.Text, TXT_obj.Text, TXT_lang.Text);
            if (TXT_val.Text == "" && TXT_val.ForeColor == SystemColors.InactiveCaption)
                TXT_val.Text = "Order";
            if (TXT_lang.Text == "" && TXT_lang.ForeColor == SystemColors.InactiveCaption)
                TXT_lang.Text = "Language";
            if (TXT_obj.Text == "" && TXT_obj.ForeColor == SystemColors.InactiveCaption)
                TXT_obj.Text = "Object";
        }
    }
}
