namespace DBFirstExample
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
            this.components = new System.ComponentModel.Container();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbid = new System.Windows.Forms.ComboBox();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblsp = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.tRainingdbDataSet = new DBFirstExample.TRainingdbDataSet();
            this.registerShoppingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerShoppingTableAdapter = new DBFirstExample.TRainingdbDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.btnsp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRainingdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(841, 243);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 37;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(841, 211);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            // 
            // cbid
            // 
            this.cbid.DataSource = this.registerShoppingBindingSource;
            this.cbid.DisplayMember = "Name";
            this.cbid.FormattingEnabled = true;
            this.cbid.Location = new System.Drawing.Point(465, 35);
            this.cbid.Name = "cbid";
            this.cbid.Size = new System.Drawing.Size(121, 21);
            this.cbid.TabIndex = 35;
            this.cbid.ValueMember = "Id";
            // 
            // lbselect
            // 
            this.lbselect.DataSource = this.registerShoppingBindingSource1;
            this.lbselect.DisplayMember = "Name";
            this.lbselect.FormattingEnabled = true;
            this.lbselect.Location = new System.Drawing.Point(672, 68);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(120, 199);
            this.lbselect.TabIndex = 34;
            this.lbselect.ValueMember = "Id";
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(841, 165);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 33;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(841, 104);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 32;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(465, 393);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(142, 20);
            this.txtpassword.TabIndex = 31;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(465, 333);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(55, 17);
            this.cbcod.TabIndex = 30;
            this.cbcod.Text = "COD?";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "Apparels",
            "Dresses",
            "Jwellery",
            "Shoes",
            "Watches",
            "Perfumes",
            "Mobiles",
            "Groceries"});
            this.clbshop.Location = new System.Drawing.Point(465, 237);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(120, 79);
            this.clbshop.TabIndex = 29;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(556, 183);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(45, 17);
            this.rbpaid.TabIndex = 28;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(465, 185);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(43, 17);
            this.rbfree.TabIndex = 27;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(465, 125);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(121, 21);
            this.cbgender.TabIndex = 26;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(465, 68);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(142, 20);
            this.txtname.TabIndex = 25;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(240, 393);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(81, 13);
            this.lblpassword.TabIndex = 24;
            this.lblpassword.Text = "Enter Password";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(240, 337);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(118, 13);
            this.lblcod.TabIndex = 23;
            this.lblcod.Text = "Prefer Cash on Delivery";
            // 
            // lblsp
            // 
            this.lblsp.AutoSize = true;
            this.lblsp.Location = new System.Drawing.Point(240, 237);
            this.lblsp.Name = "lblsp";
            this.lblsp.Size = new System.Drawing.Size(140, 13);
            this.lblsp.TabIndex = 22;
            this.lblsp.Text = "Select Shopping Preference";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(240, 185);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(97, 13);
            this.lblmembership.TabIndex = 21;
            this.lblmembership.Text = "Select Membership";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(240, 125);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(75, 13);
            this.lblgender.TabIndex = 20;
            this.lblgender.Text = "Select Gender";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(240, 76);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(63, 13);
            this.lblname.TabIndex = 19;
            this.lblname.Text = "Enter Name";
            // 
            // tRainingdbDataSet
            // 
            this.tRainingdbDataSet.DataSetName = "TRainingdbDataSet";
            this.tRainingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerShoppingBindingSource1
            // 
            this.registerShoppingBindingSource1.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource1.DataSource = this.tRainingdbDataSet;
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // btnsp
            // 
            this.btnsp.Location = new System.Drawing.Point(841, 284);
            this.btnsp.Name = "btnsp";
            this.btnsp.Size = new System.Drawing.Size(75, 23);
            this.btnsp.TabIndex = 38;
            this.btnsp.Text = "CALL SP";
            this.btnsp.UseVisualStyleBackColor = true;
            this.btnsp.Click += new System.EventHandler(this.btnsp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 448);
            this.Controls.Add(this.btnsp);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbid);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblsp);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRainingdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private System.Windows.Forms.ComboBox cbid;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblsp;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblname;
        #endregion

        private TRainingdbDataSet tRainingdbDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource1;
        private TRainingdbDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.Button btnsp;
    }
}