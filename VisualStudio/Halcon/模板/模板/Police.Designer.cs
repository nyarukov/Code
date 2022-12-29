
namespace 模板
{
    partial class Police
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
            this.ucKeyBorderAll1 = new HZH_Controls.Controls.UCKeyBorderAll();
            this.SuspendLayout();
            // 
            // ucKeyBorderAll1
            // 
            this.ucKeyBorderAll1.BackColor = System.Drawing.Color.White;
            this.ucKeyBorderAll1.CharType = HZH_Controls.Controls.KeyBorderCharType.CHAR;
            this.ucKeyBorderAll1.Location = new System.Drawing.Point(189, 125);
            this.ucKeyBorderAll1.Margin = new System.Windows.Forms.Padding(0);
            this.ucKeyBorderAll1.Name = "ucKeyBorderAll1";
            this.ucKeyBorderAll1.Size = new System.Drawing.Size(671, 273);
            this.ucKeyBorderAll1.TabIndex = 0;
            // 
            // police
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 522);
            this.Controls.Add(this.ucKeyBorderAll1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "police";
            this.Text = "police";
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCKeyBorderAll ucKeyBorderAll1;
    }
}