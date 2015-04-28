namespace CrossBeam
{
    partial class APITest
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
            this.APIInitialise = new System.Windows.Forms.Button();
            this.GetMag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // APIInitialise
            // 
            this.APIInitialise.Location = new System.Drawing.Point(67, 43);
            this.APIInitialise.Name = "APIInitialise";
            this.APIInitialise.Size = new System.Drawing.Size(75, 23);
            this.APIInitialise.TabIndex = 0;
            this.APIInitialise.Text = "API ";
            this.APIInitialise.UseVisualStyleBackColor = true;
            this.APIInitialise.Click += new System.EventHandler(this.APIInitialise_Click);
            // 
            // GetMag
            // 
            this.GetMag.Location = new System.Drawing.Point(269, 42);
            this.GetMag.Name = "GetMag";
            this.GetMag.Size = new System.Drawing.Size(75, 23);
            this.GetMag.TabIndex = 1;
            this.GetMag.Text = "Read Mag";
            this.GetMag.UseVisualStyleBackColor = true;
            this.GetMag.Click += new System.EventHandler(this.GetMag_Click_1);
            // 
            // APITest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 643);
            this.Controls.Add(this.GetMag);
            this.Controls.Add(this.APIInitialise);
            this.MinimizeBox = false;
            this.Name = "APITest";
            this.Text = "API Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button APIInitialise;
        private System.Windows.Forms.Button GetMag;
    }
}

