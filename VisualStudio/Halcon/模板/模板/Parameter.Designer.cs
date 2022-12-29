
namespace 模板
{
    partial class Parameter
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
            this.ucDateTimeSelectPan21 = new HZH_Controls.Controls.UCDateTimeSelectPan2();
            this.SuspendLayout();
            // 
            // ucDateTimeSelectPan21
            // 
            this.ucDateTimeSelectPan21.BackColor = System.Drawing.Color.White;
            this.ucDateTimeSelectPan21.CurrentTime = new System.DateTime(2022, 5, 13, 18, 43, 18, 0);
            this.ucDateTimeSelectPan21.Location = new System.Drawing.Point(404, 151);
            this.ucDateTimeSelectPan21.Name = "ucDateTimeSelectPan21";
            this.ucDateTimeSelectPan21.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucDateTimeSelectPan21.Size = new System.Drawing.Size(240, 220);
            this.ucDateTimeSelectPan21.TabIndex = 0;
            this.ucDateTimeSelectPan21.TimeType = HZH_Controls.Controls.DateTimePickerType.DateTime;
            // 
            // parameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 522);
            this.Controls.Add(this.ucDateTimeSelectPan21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "parameter";
            this.Text = "parameter";
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCDateTimeSelectPan2 ucDateTimeSelectPan21;
    }
}