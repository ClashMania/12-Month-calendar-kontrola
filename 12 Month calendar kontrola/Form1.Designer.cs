namespace _12_Month_calendar_kontrola
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
            this.btn1 = new System.Windows.Forms.Button();
            this.mCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(148, 238);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(124, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Odaberite termin";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // mCalendar1
            // 
            this.mCalendar1.Location = new System.Drawing.Point(95, 64);
            this.mCalendar1.Name = "mCalendar1";
            this.mCalendar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 368);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.mCalendar1);
            this.Name = "Form1";
            this.Text = "Month Calendar Kontrola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.MonthCalendar mCalendar1;
    }
}

