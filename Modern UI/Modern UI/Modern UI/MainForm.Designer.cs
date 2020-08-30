namespace Modern_UI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.time_present = new System.Windows.Forms.Label();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_estimation = new System.Windows.Forms.Button();
            this.btn_vehicle = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // DateTimer
            // 
            this.DateTimer.Interval = 1000;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // time_present
            // 
            this.time_present.AutoSize = true;
            this.time_present.Location = new System.Drawing.Point(473, 8);
            this.time_present.Name = "time_present";
            this.time_present.Size = new System.Drawing.Size(46, 17);
            this.time_present.TabIndex = 1;
            this.time_present.Text = "label2";
            // 
            // btn_billing
            // 
            this.btn_billing.Location = new System.Drawing.Point(517, 269);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(140, 66);
            this.btn_billing.TabIndex = 8;
            this.btn_billing.Text = "Billing";
            this.btn_billing.UseVisualStyleBackColor = true;
            // 
            // btn_estimation
            // 
            this.btn_estimation.Location = new System.Drawing.Point(144, 269);
            this.btn_estimation.Name = "btn_estimation";
            this.btn_estimation.Size = new System.Drawing.Size(149, 66);
            this.btn_estimation.TabIndex = 7;
            this.btn_estimation.Text = "Estimation";
            this.btn_estimation.UseVisualStyleBackColor = true;
            // 
            // btn_vehicle
            // 
            this.btn_vehicle.Location = new System.Drawing.Point(517, 116);
            this.btn_vehicle.Name = "btn_vehicle";
            this.btn_vehicle.Size = new System.Drawing.Size(140, 73);
            this.btn_vehicle.TabIndex = 6;
            this.btn_vehicle.Text = "Vehicle";
            this.btn_vehicle.UseVisualStyleBackColor = true;
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(144, 116);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(149, 73);
            this.btn_customer.TabIndex = 5;
            this.btn_customer.Text = "Customer";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_billing);
            this.Controls.Add(this.btn_estimation);
            this.Controls.Add(this.btn_vehicle);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.time_present);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.Label time_present;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Button btn_estimation;
        private System.Windows.Forms.Button btn_vehicle;
        private System.Windows.Forms.Button btn_customer;
    }
}