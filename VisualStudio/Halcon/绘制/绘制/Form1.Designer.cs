
namespace 绘制
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hWindow = new HalconDotNet.HWindowControl();
            this.btn_File = new System.Windows.Forms.Button();
            this.btn_readImage = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hWindow
            // 
            this.hWindow.BackColor = System.Drawing.Color.Black;
            this.hWindow.BorderColor = System.Drawing.Color.Black;
            this.hWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindow.Location = new System.Drawing.Point(13, 12);
            this.hWindow.Name = "hWindow";
            this.hWindow.Size = new System.Drawing.Size(892, 568);
            this.hWindow.TabIndex = 0;
            this.hWindow.WindowSize = new System.Drawing.Size(892, 568);
            // 
            // btn_File
            // 
            this.btn_File.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_File.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_File.Location = new System.Drawing.Point(1016, 32);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(113, 41);
            this.btn_File.TabIndex = 1;
            this.btn_File.Text = "选择";
            this.btn_File.UseVisualStyleBackColor = false;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // btn_readImage
            // 
            this.btn_readImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_readImage.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_readImage.Location = new System.Drawing.Point(1016, 100);
            this.btn_readImage.Name = "btn_readImage";
            this.btn_readImage.Size = new System.Drawing.Size(113, 41);
            this.btn_readImage.TabIndex = 2;
            this.btn_readImage.Text = "显示";
            this.btn_readImage.UseVisualStyleBackColor = false;
            this.btn_readImage.Click += new System.EventHandler(this.btn_readImage_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_line.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_line.Location = new System.Drawing.Point(1016, 168);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(113, 41);
            this.btn_line.TabIndex = 3;
            this.btn_line.Text = "直线";
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_rectangle.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_rectangle.Location = new System.Drawing.Point(1016, 236);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(113, 41);
            this.btn_rectangle.TabIndex = 4;
            this.btn_rectangle.Text = "矩形";
            this.btn_rectangle.UseVisualStyleBackColor = false;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Circle.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Circle.Location = new System.Drawing.Point(1016, 304);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(113, 41);
            this.btn_Circle.TabIndex = 5;
            this.btn_Circle.Text = "圆";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Exit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.Location = new System.Drawing.Point(1016, 372);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(113, 41);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "取消";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 592);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Circle);
            this.Controls.Add(this.btn_rectangle);
            this.Controls.Add(this.btn_line);
            this.Controls.Add(this.btn_readImage);
            this.Controls.Add(this.btn_File);
            this.Controls.Add(this.hWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl hWindow;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.Button btn_readImage;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Exit;
    }
}

