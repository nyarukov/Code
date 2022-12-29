
namespace 模板
{
    partial class Visual
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
            this.hWindowControl = new HalconDotNet.HWindowControl();
            this.btn_Camera = new Sunny.UI.UIButton();
            this.btn_CameraStop = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // hWindowControl
            // 
            this.hWindowControl.BackColor = System.Drawing.Color.Black;
            this.hWindowControl.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl.Location = new System.Drawing.Point(200, 0);
            this.hWindowControl.Name = "hWindowControl";
            this.hWindowControl.Size = new System.Drawing.Size(430, 374);
            this.hWindowControl.TabIndex = 0;
            this.hWindowControl.WindowSize = new System.Drawing.Size(430, 374);
            // 
            // btn_Camera
            // 
            this.btn_Camera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Camera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Camera.Location = new System.Drawing.Point(698, 26);
            this.btn_Camera.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Camera.Name = "btn_Camera";
            this.btn_Camera.Size = new System.Drawing.Size(93, 29);
            this.btn_Camera.TabIndex = 1;
            this.btn_Camera.Text = "采集图像";
            this.btn_Camera.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Camera.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_Camera.Click += new System.EventHandler(this.btn_Camera_Click);
            // 
            // btn_CameraStop
            // 
            this.btn_CameraStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CameraStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CameraStop.Location = new System.Drawing.Point(698, 75);
            this.btn_CameraStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_CameraStop.Name = "btn_CameraStop";
            this.btn_CameraStop.Size = new System.Drawing.Size(93, 29);
            this.btn_CameraStop.TabIndex = 1;
            this.btn_CameraStop.Text = "停止采集";
            this.btn_CameraStop.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CameraStop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_CameraStop.Click += new System.EventHandler(this.btn_CameraStop_Click);
            // 
            // Visual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 522);
            this.Controls.Add(this.btn_CameraStop);
            this.Controls.Add(this.btn_Camera);
            this.Controls.Add(this.hWindowControl);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visual";
            this.Text = "visual";
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl;
        private Sunny.UI.UIButton btn_Camera;
        private Sunny.UI.UIButton btn_CameraStop;
    }
}