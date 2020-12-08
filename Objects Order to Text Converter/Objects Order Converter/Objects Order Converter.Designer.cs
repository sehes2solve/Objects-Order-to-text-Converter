namespace Objects_Order_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_val = new System.Windows.Forms.Button();
            this.BTN_convert = new System.Windows.Forms.Button();
            this.LBL_result = new System.Windows.Forms.Label();
            this.TXT_val = new System.Windows.Forms.TextBox();
            this.TXT_obj = new System.Windows.Forms.TextBox();
            this.TXT_lang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_val
            // 
            this.BTN_val.Location = new System.Drawing.Point(471, 8);
            this.BTN_val.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_val.Name = "BTN_val";
            this.BTN_val.Size = new System.Drawing.Size(112, 34);
            this.BTN_val.TabIndex = 0;
            this.BTN_val.Text = "Validation";
            this.BTN_val.UseVisualStyleBackColor = true;
            this.BTN_val.Click += new System.EventHandler(this.BTN_val_Click);
            // 
            // BTN_convert
            // 
            this.BTN_convert.Enabled = false;
            this.BTN_convert.Location = new System.Drawing.Point(591, 8);
            this.BTN_convert.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_convert.Name = "BTN_convert";
            this.BTN_convert.Size = new System.Drawing.Size(112, 34);
            this.BTN_convert.TabIndex = 1;
            this.BTN_convert.Text = "Convert";
            this.BTN_convert.UseVisualStyleBackColor = true;
            this.BTN_convert.Click += new System.EventHandler(this.BTN_convert_Click);
            // 
            // LBL_result
            // 
            this.LBL_result.AutoSize = true;
            this.LBL_result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_result.Location = new System.Drawing.Point(9, 59);
            this.LBL_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_result.Name = "LBL_result";
            this.LBL_result.Size = new System.Drawing.Size(57, 21);
            this.LBL_result.TabIndex = 2;
            this.LBL_result.Text = "Result";
            // 
            // TXT_val
            // 
            this.TXT_val.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_val.Location = new System.Drawing.Point(13, 13);
            this.TXT_val.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_val.Name = "TXT_val";
            this.TXT_val.Size = new System.Drawing.Size(245, 26);
            this.TXT_val.TabIndex = 3;
            this.TXT_val.Text = "Order";
            this.TXT_val.TextChanged += new System.EventHandler(this.TXT_val_TextChanged);
            this.TXT_val.Enter += new System.EventHandler(this.TXT_val_Enter);
            this.TXT_val.Leave += new System.EventHandler(this.TXT_val_Leave);
            // 
            // TXT_obj
            // 
            this.TXT_obj.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_obj.Location = new System.Drawing.Point(341, 13);
            this.TXT_obj.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_obj.Name = "TXT_obj";
            this.TXT_obj.Size = new System.Drawing.Size(122, 26);
            this.TXT_obj.TabIndex = 4;
            this.TXT_obj.Text = "Object";
            this.TXT_obj.Enter += new System.EventHandler(this.TXT_obj_Enter);
            this.TXT_obj.Leave += new System.EventHandler(this.TXT_obj_Leave);
            // 
            // TXT_lang
            // 
            this.TXT_lang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TXT_lang.Location = new System.Drawing.Point(266, 13);
            this.TXT_lang.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_lang.Name = "TXT_lang";
            this.TXT_lang.Size = new System.Drawing.Size(67, 26);
            this.TXT_lang.TabIndex = 5;
            this.TXT_lang.Text = "Language";
            this.TXT_lang.TextChanged += new System.EventHandler(this.TXT_lang_TextChanged);
            this.TXT_lang.Enter += new System.EventHandler(this.TXT_lang_Enter);
            this.TXT_lang.Leave += new System.EventHandler(this.TXT_lang_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(712, 89);
            this.Controls.Add(this.TXT_lang);
            this.Controls.Add(this.TXT_obj);
            this.Controls.Add(this.TXT_val);
            this.Controls.Add(this.LBL_result);
            this.Controls.Add(this.BTN_convert);
            this.Controls.Add(this.BTN_val);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Objects Order Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_val;
        private System.Windows.Forms.Button BTN_convert;
        private System.Windows.Forms.Label LBL_result;
        private System.Windows.Forms.TextBox TXT_val;
        private System.Windows.Forms.TextBox TXT_obj;
        private System.Windows.Forms.TextBox TXT_lang;
    }
}

