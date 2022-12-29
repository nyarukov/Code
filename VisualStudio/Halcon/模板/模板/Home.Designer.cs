
namespace 模板
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpolice = new Sunny.UI.UIButton();
            this.btnparameter = new Sunny.UI.UIButton();
            this.btnvisual = new Sunny.UI.UIButton();
            this.btnhome = new Sunny.UI.UIButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Mainpancel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnpolice);
            this.panel1.Controls.Add(this.btnparameter);
            this.panel1.Controls.Add(this.btnvisual);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Location = new System.Drawing.Point(-2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnpolice
            // 
            this.btnpolice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpolice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnpolice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnpolice.Location = new System.Drawing.Point(387, 11);
            this.btnpolice.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnpolice.Name = "btnpolice";
            this.btnpolice.Radius = 6;
            this.btnpolice.ShowFocusColor = true;
            this.btnpolice.ShowFocusLine = true;
            this.btnpolice.Size = new System.Drawing.Size(86, 34);
            this.btnpolice.Style = Sunny.UI.UIStyle.Custom;
            this.btnpolice.TabIndex = 1;
            this.btnpolice.Text = "报警";
            this.btnpolice.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnpolice.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnpolice.Click += new System.EventHandler(this.btn_police_Click);
            // 
            // btnparameter
            // 
            this.btnparameter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnparameter.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnparameter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnparameter.Location = new System.Drawing.Point(264, 11);
            this.btnparameter.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnparameter.Name = "btnparameter";
            this.btnparameter.Radius = 6;
            this.btnparameter.ShowFocusColor = true;
            this.btnparameter.ShowFocusLine = true;
            this.btnparameter.Size = new System.Drawing.Size(86, 34);
            this.btnparameter.Style = Sunny.UI.UIStyle.Custom;
            this.btnparameter.TabIndex = 1;
            this.btnparameter.Text = "参数";
            this.btnparameter.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnparameter.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnparameter.Click += new System.EventHandler(this.btn_parameter_Click);
            // 
            // btnvisual
            // 
            this.btnvisual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvisual.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnvisual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnvisual.Location = new System.Drawing.Point(141, 11);
            this.btnvisual.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnvisual.Name = "btnvisual";
            this.btnvisual.Radius = 6;
            this.btnvisual.ShowFocusColor = true;
            this.btnvisual.ShowFocusLine = true;
            this.btnvisual.Size = new System.Drawing.Size(86, 34);
            this.btnvisual.Style = Sunny.UI.UIStyle.Custom;
            this.btnvisual.TabIndex = 1;
            this.btnvisual.Text = "视觉";
            this.btnvisual.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnvisual.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnvisual.Click += new System.EventHandler(this.btn_visual_Click);
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnhome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnhome.Location = new System.Drawing.Point(18, 11);
            this.btnhome.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnhome.Name = "btnhome";
            this.btnhome.Radius = 6;
            this.btnhome.ShowFocusColor = true;
            this.btnhome.ShowFocusLine = true;
            this.btnhome.Size = new System.Drawing.Size(86, 34);
            this.btnhome.Style = Sunny.UI.UIStyle.Custom;
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "主页";
            this.btnhome.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnhome.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnhome.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1040, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 20);
            this.toolStripStatusLabel1.Text = "2022  5-11  18:35";
            // 
            // Mainpancel
            // 
            this.Mainpancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mainpancel.Location = new System.Drawing.Point(-2, 94);
            this.Mainpancel.Name = "Mainpancel";
            this.Mainpancel.Size = new System.Drawing.Size(1049, 522);
            this.Mainpancel.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1040, 641);
            this.Controls.Add(this.Mainpancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.RectColor = System.Drawing.Color.PaleTurquoise;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "视觉检测";
            this.TitleColor = System.Drawing.Color.LightSkyBlue;
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Sunny.UI.UIButton btnpolice;
        private Sunny.UI.UIButton btnparameter;
        private Sunny.UI.UIButton btnvisual;
        private Sunny.UI.UIButton btnhome;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel Mainpancel;
    }
}

