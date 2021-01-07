
namespace GUIPROJECT
{
    partial class UpdateEndmembership
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
            this.Extendmembership = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Terminatemembership = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Extendmembership
            // 
            this.Extendmembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extendmembership.Location = new System.Drawing.Point(267, 223);
            this.Extendmembership.Name = "Extendmembership";
            this.Extendmembership.Size = new System.Drawing.Size(236, 78);
            this.Extendmembership.TabIndex = 0;
            this.Extendmembership.Text = "Extend Membership";
            this.Extendmembership.UseVisualStyleBackColor = true;
            this.Extendmembership.Click += new System.EventHandler(this.Extendmembership_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(777, 77);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "If you Clicked Extend Membership Button this means that you will request to exten" +
    "d your membership for another year \r\n";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(12, 153);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(451, 35);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Note: Extention payment will be required";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(12, 345);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(740, 77);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "If you Clicked TerminateMembership Button this means that you will Terminate your" +
    " membership immediately\r\n";
            // 
            // Terminatemembership
            // 
            this.Terminatemembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminatemembership.Location = new System.Drawing.Point(267, 445);
            this.Terminatemembership.Name = "Terminatemembership";
            this.Terminatemembership.Size = new System.Drawing.Size(236, 78);
            this.Terminatemembership.TabIndex = 5;
            this.Terminatemembership.Text = "Terminate Membership";
            this.Terminatemembership.UseVisualStyleBackColor = true;
            this.Terminatemembership.Click += new System.EventHandler(this.Terminatemembership_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(137, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "End date of Membership";
            // 
            // enddate
            // 
            this.enddate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.enddate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.ForeColor = System.Drawing.Color.Chartreuse;
            this.enddate.Location = new System.Drawing.Point(433, 21);
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            this.enddate.Size = new System.Drawing.Size(168, 27);
            this.enddate.TabIndex = 7;
            // 
            // UpdateEndmembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(782, 563);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Terminatemembership);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Extendmembership);
            this.Name = "UpdateEndmembership";
            this.Text = "UpdateEndmembership";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Extendmembership;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Terminatemembership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enddate;
    }
}