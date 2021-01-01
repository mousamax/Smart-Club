
namespace GUIPROJECT
{
    partial class Parking
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
            this.startdate = new System.Windows.Forms.TextBox();
            this.subfees = new System.Windows.Forms.TextBox();
            this.memberid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Subscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startdate
            // 
            this.startdate.BackColor = System.Drawing.SystemColors.Window;
            this.startdate.Location = new System.Drawing.Point(289, 203);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(146, 22);
            this.startdate.TabIndex = 14;
            this.startdate.Text = "mm/dd/yy";
            // 
            // subfees
            // 
            this.subfees.BackColor = System.Drawing.SystemColors.Window;
            this.subfees.Location = new System.Drawing.Point(289, 130);
            this.subfees.Name = "subfees";
            this.subfees.Size = new System.Drawing.Size(146, 22);
            this.subfees.TabIndex = 13;
            // 
            // memberid
            // 
            this.memberid.BackColor = System.Drawing.SystemColors.Window;
            this.memberid.Location = new System.Drawing.Point(289, 54);
            this.memberid.Name = "memberid";
            this.memberid.Size = new System.Drawing.Size(146, 22);
            this.memberid.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(56, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subscribtion fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(56, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Subscribtion Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Member Id";
            // 
            // enddate
            // 
            this.enddate.BackColor = System.Drawing.SystemColors.Window;
            this.enddate.Location = new System.Drawing.Point(289, 282);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(146, 22);
            this.enddate.TabIndex = 16;
            this.enddate.Text = "mm/dd/yy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(56, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Subscribtion End Date";
            // 
            // Subscribe
            // 
            this.Subscribe.Location = new System.Drawing.Point(247, 394);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Size = new System.Drawing.Size(157, 79);
            this.Subscribe.TabIndex = 17;
            this.Subscribe.Text = "Subscribe";
            this.Subscribe.UseVisualStyleBackColor = true;
            this.Subscribe.Click += new System.EventHandler(this.Subscribe_Click);
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(675, 563);
            this.Controls.Add(this.Subscribe);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.subfees);
            this.Controls.Add(this.memberid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Parking";
            this.Text = "Parking";
            this.Load += new System.EventHandler(this.Parking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startdate;
        private System.Windows.Forms.TextBox subfees;
        private System.Windows.Forms.TextBox memberid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enddate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Subscribe;
    }
}