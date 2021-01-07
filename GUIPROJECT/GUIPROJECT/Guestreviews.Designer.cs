
namespace GUIPROJECT
{
    partial class Guestreviews
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reviews = new System.Windows.Forms.Button();
            this.reviewsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(22, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(748, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Click View Reviews Button to see Members Comments and Ratings";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // reviews
            // 
            this.reviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviews.Location = new System.Drawing.Point(300, 94);
            this.reviews.Name = "reviews";
            this.reviews.Size = new System.Drawing.Size(250, 38);
            this.reviews.TabIndex = 2;
            this.reviews.Text = "Show Review";
            this.reviews.UseVisualStyleBackColor = true;
            this.reviews.Click += new System.EventHandler(this.reviews_Click);
            // 
            // reviewsGridView
            // 
            this.reviewsGridView.AllowUserToAddRows = false;
            this.reviewsGridView.AllowUserToDeleteRows = false;
            this.reviewsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewsGridView.Location = new System.Drawing.Point(12, 163);
            this.reviewsGridView.Name = "reviewsGridView";
            this.reviewsGridView.ReadOnly = true;
            this.reviewsGridView.RowHeadersWidth = 51;
            this.reviewsGridView.RowTemplate.Height = 24;
            this.reviewsGridView.Size = new System.Drawing.Size(758, 388);
            this.reviewsGridView.TabIndex = 3;
            // 
            // Guestreviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(782, 563);
            this.Controls.Add(this.reviewsGridView);
            this.Controls.Add(this.reviews);
            this.Controls.Add(this.textBox1);
            this.Name = "Guestreviews";
            this.Text = "Guestreviews";
            ((System.ComponentModel.ISupportInitialize)(this.reviewsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button reviews;
        private System.Windows.Forms.DataGridView reviewsGridView;
    }
}