
namespace 按钮封装
{
    partial class UBlower
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.btn_start = new HZH_Controls.Controls.UCBtnExt();
            this.Image_Blower = new HZH_Controls.Controls.UCBlower();
            this.SuspendLayout();
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "停止";
            this.ucBtnExt1.ConerRadius = 12;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(3, 72);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(99, 41);
            this.ucBtnExt1.TabIndex = 5;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucBtnExt1.TipsText = "";
            this.ucBtnExt1.BtnClick += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.White;
            this.btn_start.BtnBackColor = System.Drawing.Color.White;
            this.btn_start.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.BtnForeColor = System.Drawing.Color.White;
            this.btn_start.BtnText = "启动";
            this.btn_start.ConerRadius = 12;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.EnabledMouseEffect = false;
            this.btn_start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_start.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_start.IsRadius = true;
            this.btn_start.IsShowRect = true;
            this.btn_start.IsShowTips = false;
            this.btn_start.Location = new System.Drawing.Point(3, 3);
            this.btn_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_start.Name = "btn_start";
            this.btn_start.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_start.RectWidth = 1;
            this.btn_start.Size = new System.Drawing.Size(99, 41);
            this.btn_start.TabIndex = 4;
            this.btn_start.TabStop = false;
            this.btn_start.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_start.TipsText = "";
            this.btn_start.BtnClick += new System.EventHandler(this.btn_start_BtnClick);
            // 
            // Image_Blower
            // 
            this.Image_Blower.BlowerColor = System.Drawing.Color.Gray;
            this.Image_Blower.EntranceDirection = HZH_Controls.Controls.BlowerEntranceDirection.None;
            this.Image_Blower.ExitDirection = HZH_Controls.Controls.BlowerExitDirection.Right;
            this.Image_Blower.FanColor = System.Drawing.Color.Blue;
            this.Image_Blower.Location = new System.Drawing.Point(139, 3);
            this.Image_Blower.Name = "Image_Blower";
            this.Image_Blower.Size = new System.Drawing.Size(91, 101);
            this.Image_Blower.TabIndex = 3;
            this.Image_Blower.TurnAround = HZH_Controls.Controls.TurnAround.None;
            this.Image_Blower.TurnSpeed = 100;
            // 
            // UBlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucBtnExt1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.Image_Blower);
            this.Name = "UBlower";
            this.Size = new System.Drawing.Size(345, 255);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnExt btn_start;
        private HZH_Controls.Controls.UCBlower Image_Blower;
    }
}
