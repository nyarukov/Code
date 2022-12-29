
namespace 区域提取
{
    partial class form
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
            this.file_open = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.La_FilePath = new System.Windows.Forms.Label();
            this.btn_draw = new System.Windows.Forms.Button();
            this.File_writ = new System.Windows.Forms.Button();
            this.hWindowControl2 = new HalconDotNet.HWindowControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // file_open
            // 
            this.file_open.BackColor = System.Drawing.Color.LightSkyBlue;
            this.file_open.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.file_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.file_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.file_open.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.file_open.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.file_open.Location = new System.Drawing.Point(793, 27);
            this.file_open.Name = "file_open";
            this.file_open.Size = new System.Drawing.Size(156, 52);
            this.file_open.TabIndex = 1;
            this.file_open.Text = "选择文件";
            this.file_open.UseVisualStyleBackColor = false;
            this.file_open.Click += new System.EventHandler(this.File_open_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.La_FilePath);
            this.panel1.Location = new System.Drawing.Point(784, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 186);
            this.panel1.TabIndex = 4;
            // 
            // La_FilePath
            // 
            this.La_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.La_FilePath.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.La_FilePath.Location = new System.Drawing.Point(-2, 0);
            this.La_FilePath.Name = "La_FilePath";
            this.La_FilePath.Size = new System.Drawing.Size(200, 23);
            this.La_FilePath.TabIndex = 0;
            this.La_FilePath.Text = "Path";
            this.La_FilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_draw
            // 
            this.btn_draw.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_draw.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btn_draw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_draw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_draw.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_draw.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_draw.Location = new System.Drawing.Point(793, 103);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(156, 52);
            this.btn_draw.TabIndex = 5;
            this.btn_draw.Text = "选择区域";
            this.btn_draw.UseVisualStyleBackColor = false;
            // 
            // File_writ
            // 
            this.File_writ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.File_writ.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.File_writ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.File_writ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.File_writ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.File_writ.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.File_writ.Location = new System.Drawing.Point(793, 181);
            this.File_writ.Name = "File_writ";
            this.File_writ.Size = new System.Drawing.Size(156, 52);
            this.File_writ.TabIndex = 6;
            this.File_writ.Text = "保存文件";
            this.File_writ.UseVisualStyleBackColor = false;
            // 
            // hWindowControl2
            // 
            this.hWindowControl2.BackColor = System.Drawing.Color.Black;
            this.hWindowControl2.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl2.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl2.Location = new System.Drawing.Point(41, 27);
            this.hWindowControl2.Name = "hWindowControl2";
            this.hWindowControl2.Size = new System.Drawing.Size(631, 516);
            this.hWindowControl2.TabIndex = 8;
            this.hWindowControl2.WindowSize = new System.Drawing.Size(631, 516);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 572);
            this.Controls.Add(this.hWindowControl2);
            this.Controls.Add(this.File_writ);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.file_open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form";
            this.Text = "区域提取";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button file_open;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label La_FilePath;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Button File_writ;
        private HalconDotNet.HWindowControl hWindowControl2;
    }
}

