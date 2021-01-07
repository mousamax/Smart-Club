
namespace GUIPROJECT
{
    partial class TurnInToMember
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
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.GtoM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.SystemColors.Window;
            this.Lname.Location = new System.Drawing.Point(212, 137);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(146, 22);
            this.Lname.TabIndex = 13;
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.SystemColors.Window;
            this.Fname.Location = new System.Drawing.Point(212, 61);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(146, 22);
            this.Fname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(60, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Second Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(60, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sex";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(60, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Age";
            // 
            // sex
            // 
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sex.Location = new System.Drawing.Point(212, 213);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(146, 24);
            this.sex.TabIndex = 15;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(212, 280);
            this.age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Size = new System.Drawing.Size(146, 22);
            this.age.TabIndex = 16;
            this.age.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GtoM
            // 
            this.GtoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GtoM.Location = new System.Drawing.Point(212, 431);
            this.GtoM.Name = "GtoM";
            this.GtoM.Size = new System.Drawing.Size(292, 68);
            this.GtoM.TabIndex = 17;
            this.GtoM.Text = "Request to become a Member";
            this.GtoM.UseVisualStyleBackColor = true;
            this.GtoM.Click += new System.EventHandler(this.GtoM_Click);
            // 
            // TurnInToMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(782, 563);
            this.Controls.Add(this.GtoM);
            this.Controls.Add(this.age);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "TurnInToMember";
            this.Text = "TurnInToMember";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Button GtoM;
    }
}