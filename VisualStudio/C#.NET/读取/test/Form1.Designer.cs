
namespace test
{
    partial class fa
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_Connect = new System.Windows.Forms.TextBox();
            this.btn_MD100 = new System.Windows.Forms.Button();
            this.txt_MD100 = new System.Windows.Forms.TextBox();
            this.txt_MD100_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_real_out = new System.Windows.Forms.TextBox();
            this.txt_real_in = new System.Windows.Forms.TextBox();
            this.btn_real = new System.Windows.Forms.Button();
            this.btn_real_in = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_write = new System.Windows.Forms.Button();
            this.txt_write_out = new System.Windows.Forms.TextBox();
            this.txt_Write_in = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Connect.Location = new System.Drawing.Point(284, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(124, 35);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "建立连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.Location = new System.Drawing.Point(442, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(124, 35);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "断开连接";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_Connect
            // 
            this.txt_Connect.Location = new System.Drawing.Point(183, 16);
            this.txt_Connect.Multiline = true;
            this.txt_Connect.Name = "txt_Connect";
            this.txt_Connect.Size = new System.Drawing.Size(78, 27);
            this.txt_Connect.TabIndex = 2;
            this.txt_Connect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_MD100
            // 
            this.btn_MD100.FlatAppearance.BorderSize = 0;
            this.btn_MD100.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MD100.Location = new System.Drawing.Point(207, 122);
            this.btn_MD100.Name = "btn_MD100";
            this.btn_MD100.Size = new System.Drawing.Size(112, 56);
            this.btn_MD100.TabIndex = 3;
            this.btn_MD100.Text = "读取";
            this.btn_MD100.UseVisualStyleBackColor = true;
            this.btn_MD100.Click += new System.EventHandler(this.btn_MD100_Click);
            // 
            // txt_MD100
            // 
            this.txt_MD100.Location = new System.Drawing.Point(72, 122);
            this.txt_MD100.Name = "txt_MD100";
            this.txt_MD100.Size = new System.Drawing.Size(67, 25);
            this.txt_MD100.TabIndex = 4;
            this.txt_MD100.Text = "MD114";
            this.txt_MD100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_MD100_out
            // 
            this.txt_MD100_out.Location = new System.Drawing.Point(72, 153);
            this.txt_MD100_out.Name = "txt_MD100_out";
            this.txt_MD100_out.Size = new System.Drawing.Size(67, 25);
            this.txt_MD100_out.TabIndex = 5;
            this.txt_MD100_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Tag = "";
            this.label1.Text = "整型读取";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 10;
            this.label2.Tag = "";
            this.label2.Text = "浮点型读取";
            // 
            // txt_real_out
            // 
            this.txt_real_out.Location = new System.Drawing.Point(424, 153);
            this.txt_real_out.Name = "txt_real_out";
            this.txt_real_out.Size = new System.Drawing.Size(67, 25);
            this.txt_real_out.TabIndex = 9;
            this.txt_real_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_real_in
            // 
            this.txt_real_in.Location = new System.Drawing.Point(424, 122);
            this.txt_real_in.Name = "txt_real_in";
            this.txt_real_in.Size = new System.Drawing.Size(67, 25);
            this.txt_real_in.TabIndex = 8;
            this.txt_real_in.Text = "MD100";
            this.txt_real_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_real
            // 
            this.btn_real.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_real.Location = new System.Drawing.Point(559, 122);
            this.btn_real.Name = "btn_real";
            this.btn_real.Size = new System.Drawing.Size(112, 56);
            this.btn_real.TabIndex = 7;
            this.btn_real.Text = "读取";
            this.btn_real.UseVisualStyleBackColor = true;
            this.btn_real.Click += new System.EventHandler(this.btn_real_Click);
            // 
            // btn_real_in
            // 
            this.btn_real_in.FlatAppearance.BorderSize = 0;
            this.btn_real_in.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_real_in.Location = new System.Drawing.Point(122, 272);
            this.btn_real_in.Name = "btn_real_in";
            this.btn_real_in.Size = new System.Drawing.Size(112, 56);
            this.btn_real_in.TabIndex = 11;
            this.btn_real_in.Text = "读取";
            this.btn_real_in.UseVisualStyleBackColor = true;
            this.btn_real_in.Click += new System.EventHandler(this.btn_real_in_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 12;
            this.label3.Tag = "";
            this.label3.Text = "混合读取";
            // 
            // btn_write
            // 
            this.btn_write.FlatAppearance.BorderSize = 0;
            this.btn_write.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_write.Location = new System.Drawing.Point(559, 272);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(112, 56);
            this.btn_write.TabIndex = 13;
            this.btn_write.Text = "写入";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // txt_write_out
            // 
            this.txt_write_out.Location = new System.Drawing.Point(442, 303);
            this.txt_write_out.Name = "txt_write_out";
            this.txt_write_out.Size = new System.Drawing.Size(67, 25);
            this.txt_write_out.TabIndex = 15;
            this.txt_write_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Write_in
            // 
            this.txt_Write_in.Location = new System.Drawing.Point(442, 272);
            this.txt_Write_in.Name = "txt_Write_in";
            this.txt_Write_in.Size = new System.Drawing.Size(67, 25);
            this.txt_Write_in.TabIndex = 14;
            this.txt_Write_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_write_out);
            this.Controls.Add(this.txt_Write_in);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_real_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_real_out);
            this.Controls.Add(this.txt_real_in);
            this.Controls.Add(this.btn_real);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MD100_out);
            this.Controls.Add(this.txt_MD100);
            this.Controls.Add(this.btn_MD100);
            this.Controls.Add(this.txt_Connect);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Connect);
            this.Name = "fa";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txt_Connect;
        private System.Windows.Forms.Button btn_MD100;
        private System.Windows.Forms.TextBox txt_MD100;
        private System.Windows.Forms.TextBox txt_MD100_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_real_out;
        private System.Windows.Forms.TextBox txt_real_in;
        private System.Windows.Forms.Button btn_real;
        private System.Windows.Forms.Button btn_real_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.TextBox txt_write_out;
        private System.Windows.Forms.TextBox txt_Write_in;
    }
}

