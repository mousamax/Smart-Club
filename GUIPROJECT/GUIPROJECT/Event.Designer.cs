
namespace GUIPROJECT
{
    partial class Event
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eventname = new System.Windows.Forms.TextBox();
            this.eventplace = new System.Windows.Forms.TextBox();
            this.eventdate = new System.Windows.Forms.TextBox();
            this.eventfees = new System.Windows.Forms.TextBox();
            this.addevent = new System.Windows.Forms.Button();
            this.memberid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(56, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(56, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Event Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(56, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Event Place";
            // 
            // eventname
            // 
            this.eventname.BackColor = System.Drawing.SystemColors.Window;
            this.eventname.Location = new System.Drawing.Point(208, 51);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(146, 22);
            this.eventname.TabIndex = 6;
            // 
            // eventplace
            // 
            this.eventplace.BackColor = System.Drawing.SystemColors.Window;
            this.eventplace.Location = new System.Drawing.Point(208, 127);
            this.eventplace.Name = "eventplace";
            this.eventplace.Size = new System.Drawing.Size(146, 22);
            this.eventplace.TabIndex = 7;
            // 
            // eventdate
            // 
            this.eventdate.BackColor = System.Drawing.SystemColors.Window;
            this.eventdate.Location = new System.Drawing.Point(208, 200);
            this.eventdate.Name = "eventdate";
            this.eventdate.Size = new System.Drawing.Size(146, 22);
            this.eventdate.TabIndex = 8;
            this.eventdate.Text = "mm/dd/yy";
            // 
            // eventfees
            // 
            this.eventfees.BackColor = System.Drawing.SystemColors.Window;
            this.eventfees.Location = new System.Drawing.Point(208, 277);
            this.eventfees.Name = "eventfees";
            this.eventfees.Size = new System.Drawing.Size(146, 22);
            this.eventfees.TabIndex = 9;
            // 
            // addevent
            // 
            this.addevent.Location = new System.Drawing.Point(452, 130);
            this.addevent.Name = "addevent";
            this.addevent.Size = new System.Drawing.Size(168, 92);
            this.addevent.TabIndex = 10;
            this.addevent.Text = "Add Event";
            this.addevent.UseVisualStyleBackColor = true;
            this.addevent.Click += new System.EventHandler(this.addevent_Click);
            // 
            // memberid
            // 
            this.memberid.BackColor = System.Drawing.SystemColors.Window;
            this.memberid.Location = new System.Drawing.Point(208, 352);
            this.memberid.Name = "memberid";
            this.memberid.Size = new System.Drawing.Size(146, 22);
            this.memberid.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(56, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Member Id";
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(675, 563);
            this.Controls.Add(this.memberid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addevent);
            this.Controls.Add(this.eventfees);
            this.Controls.Add(this.eventdate);
            this.Controls.Add(this.eventplace);
            this.Controls.Add(this.eventname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Event";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventname;
        private System.Windows.Forms.TextBox eventplace;
        private System.Windows.Forms.TextBox eventdate;
        private System.Windows.Forms.TextBox eventfees;
        private System.Windows.Forms.Button addevent;
        private System.Windows.Forms.TextBox memberid;
        private System.Windows.Forms.Label label6;
    }
}