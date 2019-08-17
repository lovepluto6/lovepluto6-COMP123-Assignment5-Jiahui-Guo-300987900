namespace COMP123_Jiahui_Guo_Assignment5_300987900
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.orderyourcompanylabel = new System.Windows.Forms.Label();
            this.StartFormPictureBox = new System.Windows.Forms.PictureBox();
            this.StartNeworderbutton = new System.Windows.Forms.Button();
            this.opensavebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orderyourcompanylabel
            // 
            this.orderyourcompanylabel.AutoSize = true;
            this.orderyourcompanylabel.Location = new System.Drawing.Point(101, 22);
            this.orderyourcompanylabel.Name = "orderyourcompanylabel";
            this.orderyourcompanylabel.Size = new System.Drawing.Size(362, 28);
            this.orderyourcompanylabel.TabIndex = 0;
            this.orderyourcompanylabel.Text = "Order Your Company Today!";
            // 
            // StartFormPictureBox
            // 
            this.StartFormPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StartFormPictureBox.Image")));
            this.StartFormPictureBox.Location = new System.Drawing.Point(89, 53);
            this.StartFormPictureBox.Name = "StartFormPictureBox";
            this.StartFormPictureBox.Size = new System.Drawing.Size(400, 350);
            this.StartFormPictureBox.TabIndex = 1;
            this.StartFormPictureBox.TabStop = false;
            // 
            // StartNeworderbutton
            // 
            this.StartNeworderbutton.Location = new System.Drawing.Point(89, 409);
            this.StartNeworderbutton.Name = "StartNeworderbutton";
            this.StartNeworderbutton.Size = new System.Drawing.Size(400, 41);
            this.StartNeworderbutton.TabIndex = 2;
            this.StartNeworderbutton.Text = "Start a New Order";
            this.StartNeworderbutton.UseVisualStyleBackColor = true;
            this.StartNeworderbutton.Click += new System.EventHandler(this.StartNeworderbutton_Click);
            // 
            // opensavebutton
            // 
            this.opensavebutton.Location = new System.Drawing.Point(89, 456);
            this.opensavebutton.Name = "opensavebutton";
            this.opensavebutton.Size = new System.Drawing.Size(400, 41);
            this.opensavebutton.TabIndex = 3;
            this.opensavebutton.Text = "Open a Saved Order";
            this.opensavebutton.UseVisualStyleBackColor = true;
            this.opensavebutton.Click += new System.EventHandler(this.opensavebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(89, 503);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(400, 41);
            this.Exitbutton.TabIndex = 4;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.ControlBox = false;
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.opensavebutton);
            this.Controls.Add(this.StartNeworderbutton);
            this.Controls.Add(this.StartFormPictureBox);
            this.Controls.Add(this.orderyourcompanylabel);
            this.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderyourcompanylabel;
        private System.Windows.Forms.PictureBox StartFormPictureBox;
        private System.Windows.Forms.Button StartNeworderbutton;
        private System.Windows.Forms.Button opensavebutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}