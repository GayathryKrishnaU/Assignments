namespace disconnectedexample
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
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdated = new System.Windows.Forms.Button();
            this.btnxml = new System.Windows.Forms.Button();
            this.dgselect = new System.Windows.Forms.DataGridView();
            this.lbxml = new System.Windows.Forms.ListBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btncallid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgselect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(384, 60);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "SELECT";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdated
            // 
            this.btnupdated.Location = new System.Drawing.Point(516, 60);
            this.btnupdated.Name = "btnupdated";
            this.btnupdated.Size = new System.Drawing.Size(82, 23);
            this.btnupdated.TabIndex = 1;
            this.btnupdated.Text = "UPDATE";
            this.btnupdated.UseVisualStyleBackColor = true;
            this.btnupdated.Click += new System.EventHandler(this.btnupdated_Click);
            // 
            // btnxml
            // 
            this.btnxml.Location = new System.Drawing.Point(669, 60);
            this.btnxml.Name = "btnxml";
            this.btnxml.Size = new System.Drawing.Size(123, 23);
            this.btnxml.TabIndex = 2;
            this.btnxml.Text = "SHOW XML";
            this.btnxml.UseVisualStyleBackColor = true;
            this.btnxml.Click += new System.EventHandler(this.btnxml_Click);
            // 
            // dgselect
            // 
            this.dgselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgselect.Location = new System.Drawing.Point(384, 203);
            this.dgselect.Name = "dgselect";
            this.dgselect.Size = new System.Drawing.Size(398, 150);
            this.dgselect.TabIndex = 3;
            // 
            // lbxml
            // 
            this.lbxml.FormattingEnabled = true;
            this.lbxml.ItemHeight = 18;
            this.lbxml.Location = new System.Drawing.Point(872, 62);
            this.lbxml.Name = "lbxml";
            this.lbxml.Size = new System.Drawing.Size(205, 184);
            this.lbxml.TabIndex = 4;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(448, 143);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(61, 18);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "Enter ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(587, 137);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 24);
            this.txtid.TabIndex = 6;
            // 
            // btncallid
            // 
            this.btncallid.Location = new System.Drawing.Point(741, 137);
            this.btncallid.Name = "btncallid";
            this.btncallid.Size = new System.Drawing.Size(75, 23);
            this.btncallid.TabIndex = 7;
            this.btncallid.Text = "Call SP";
            this.btncallid.UseVisualStyleBackColor = true;
            this.btncallid.Click += new System.EventHandler(this.btncallid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1419, 640);
            this.Controls.Add(this.btncallid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbxml);
            this.Controls.Add(this.dgselect);
            this.Controls.Add(this.btnxml);
            this.Controls.Add(this.btnupdated);
            this.Controls.Add(this.btnselect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgselect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdated;
        private System.Windows.Forms.Button btnxml;
        private System.Windows.Forms.DataGridView dgselect;
        private System.Windows.Forms.ListBox lbxml;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btncallid;
    }
}

