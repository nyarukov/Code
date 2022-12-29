
namespace 基于Socket与PLC连接
{
    partial class Socket通讯
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
            this.Scoket = new System.Windows.Forms.TabControl();
            this.Socket = new System.Windows.Forms.TabPage();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Scoket.SuspendLayout();
            this.Socket.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scoket
            // 
            this.Scoket.Controls.Add(this.Socket);
            this.Scoket.Controls.Add(this.tabPage2);
            this.Scoket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scoket.Location = new System.Drawing.Point(0, 0);
            this.Scoket.Name = "Scoket";
            this.Scoket.SelectedIndex = 0;
            this.Scoket.Size = new System.Drawing.Size(900, 540);
            this.Scoket.TabIndex = 0;
            // 
            // Socket
            // 
            this.Socket.Controls.Add(this.btn_close);
            this.Socket.Controls.Add(this.btn_connect);
            this.Socket.Controls.Add(this.txt_Port);
            this.Socket.Controls.Add(this.label2);
            this.Socket.Controls.Add(this.txt_IP);
            this.Socket.Controls.Add(this.label1);
            this.Socket.Location = new System.Drawing.Point(4, 29);
            this.Socket.Name = "Socket";
            this.Socket.Padding = new System.Windows.Forms.Padding(3);
            this.Socket.Size = new System.Drawing.Size(892, 507);
            this.Socket.TabIndex = 0;
            this.Socket.Text = "                    ";
            this.Socket.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(768, 60);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 37);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "已断开";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(643, 60);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(96, 37);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "建立连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Font = new System.Drawing.Font("黑体", 11F);
            this.txt_Port.Location = new System.Drawing.Point(456, 66);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(155, 28);
            this.txt_Port.TabIndex = 3;
            this.txt_Port.Text = "102";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "PLC端口：";
            // 
            // txt_IP
            // 
            this.txt_IP.Font = new System.Drawing.Font("黑体", 11F);
            this.txt_IP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_IP.Location = new System.Drawing.Point(161, 66);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(155, 28);
            this.txt_IP.TabIndex = 1;
            this.txt_IP.Text = "192.168.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC-IP地址：";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Socket通讯
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.Scoket);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Socket通讯";
            this.RightToLeftLayout = true;
            this.Text = "Socket通讯";
            this.Scoket.ResumeLayout(false);
            this.Socket.ResumeLayout(false);
            this.Socket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Scoket;
        private System.Windows.Forms.TabPage Socket;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_close;
    }
}

