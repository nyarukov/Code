
namespace 按钮封装
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
            this.uBlower2 = new 按钮封装.UBlower();
            this.uBlower1 = new 按钮封装.UBlower();
            this.uBlower3 = new 按钮封装.UBlower();
            this.uBlower4 = new 按钮封装.UBlower();
            this.SuspendLayout();
            // 
            // uBlower2
            // 
            this.uBlower2.In_start = "M20.0";
            this.uBlower2.In_stop = "M20.1";
            this.uBlower2.Location = new System.Drawing.Point(12, 30);
            this.uBlower2.Name = "uBlower2";
            this.uBlower2.out_address = "M20.2";
            this.uBlower2.Size = new System.Drawing.Size(345, 255);
            this.uBlower2.start = false;
            this.uBlower2.TabIndex = 6;
            this.uBlower2.StartClick += new System.EventHandler(this.uBlower2_StartClick);
            this.uBlower2.StopCilck += new System.EventHandler(this.uBlower2_StopCilck);
            // 
            // uBlower1
            // 
            this.uBlower1.In_start = "M20.3";
            this.uBlower1.In_stop = "M20.4";
            this.uBlower1.Location = new System.Drawing.Point(486, 30);
            this.uBlower1.Name = "uBlower1";
            this.uBlower1.out_address = "M20.5";
            this.uBlower1.Size = new System.Drawing.Size(345, 255);
            this.uBlower1.start = false;
            this.uBlower1.TabIndex = 6;
            this.uBlower1.StartClick += new System.EventHandler(this.uBlower2_StartClick);
            this.uBlower1.StopCilck += new System.EventHandler(this.uBlower2_StopCilck);
            // 
            // uBlower3
            // 
            this.uBlower3.In_start = "M20.6";
            this.uBlower3.In_stop = "M20.7";
            this.uBlower3.Location = new System.Drawing.Point(42, 261);
            this.uBlower3.Name = "uBlower3";
            this.uBlower3.out_address = "M21.0";
            this.uBlower3.Size = new System.Drawing.Size(345, 255);
            this.uBlower3.start = false;
            this.uBlower3.TabIndex = 6;
            this.uBlower3.StartClick += new System.EventHandler(this.uBlower2_StartClick);
            this.uBlower3.StopCilck += new System.EventHandler(this.uBlower2_StopCilck);
            // 
            // uBlower4
            // 
            this.uBlower4.In_start = "M21.1";
            this.uBlower4.In_stop = "M21.2";
            this.uBlower4.Location = new System.Drawing.Point(474, 214);
            this.uBlower4.Name = "uBlower4";
            this.uBlower4.out_address = "M21.3";
            this.uBlower4.Size = new System.Drawing.Size(345, 255);
            this.uBlower4.start = false;
            this.uBlower4.TabIndex = 6;
            this.uBlower4.StartClick += new System.EventHandler(this.uBlower2_StartClick);
            this.uBlower4.StopCilck += new System.EventHandler(this.uBlower2_StopCilck);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(927, 578);
            this.Controls.Add(this.uBlower4);
            this.Controls.Add(this.uBlower3);
            this.Controls.Add(this.uBlower1);
            this.Controls.Add(this.uBlower2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UBlower uBlower2;
        private UBlower uBlower1;
        private UBlower uBlower3;
        private UBlower uBlower4;
    }
}

