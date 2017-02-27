namespace shutdown_timer
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
            this.btnShutdown = new System.Windows.Forms.Button();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.btnAbort = new System.Windows.Forms.Button();
            this.lblShutdownTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.lblHour = new System.Windows.Forms.Label();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.lblMinute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShutdown
            // 
            this.btnShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShutdown.Location = new System.Drawing.Point(12, 167);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(155, 30);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // numDay
            // 
            this.numDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDay.Location = new System.Drawing.Point(104, 7);
            this.numDay.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(49, 35);
            this.numDay.TabIndex = 1;
            this.numDay.ValueChanged += new System.EventHandler(this.numDay_ValueChanged);
            // 
            // btnAbort
            // 
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbort.Location = new System.Drawing.Point(12, 203);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(155, 30);
            this.btnAbort.TabIndex = 0;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // lblShutdownTime
            // 
            this.lblShutdownTime.AutoSize = true;
            this.lblShutdownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShutdownTime.ForeColor = System.Drawing.Color.Red;
            this.lblShutdownTime.Location = new System.Drawing.Point(13, 135);
            this.lblShutdownTime.Name = "lblShutdownTime";
            this.lblShutdownTime.Size = new System.Drawing.Size(0, 20);
            this.lblShutdownTime.TabIndex = 2;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDay.Location = new System.Drawing.Point(12, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(54, 29);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "Day";
            // 
            // numHour
            // 
            this.numHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numHour.Location = new System.Drawing.Point(103, 50);
            this.numHour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(49, 35);
            this.numHour.TabIndex = 1;
            this.numHour.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numHour.ValueChanged += new System.EventHandler(this.numHour_ValueChanged);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHour.Location = new System.Drawing.Point(12, 52);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(65, 29);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Hour";
            // 
            // numMinute
            // 
            this.numMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numMinute.Location = new System.Drawing.Point(103, 91);
            this.numMinute.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(49, 35);
            this.numMinute.TabIndex = 1;
            this.numMinute.ValueChanged += new System.EventHandler(this.numMinute_ValueChanged);
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinute.Location = new System.Drawing.Point(12, 93);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(85, 29);
            this.lblMinute.TabIndex = 3;
            this.lblMinute.Text = "Minute";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 245);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.numMinute);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.lblShutdownTime);
            this.Controls.Add(this.numDay);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnShutdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shutdown Timer";
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label lblShutdownTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.Label lblMinute;
    }
}

