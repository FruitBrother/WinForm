namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelinfo = new System.Windows.Forms.Label();
            this.sidtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidcheck = new System.Windows.Forms.CheckBox();
            this.snamecheck = new System.Windows.Forms.CheckBox();
            this.snametext = new System.Windows.Forms.TextBox();
            this.sagecheck = new System.Windows.Forms.CheckBox();
            this.sagetext1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sagetext2 = new System.Windows.Forms.TextBox();
            this.ssexcheck = new System.Windows.Forms.CheckBox();
            this.ssextext = new System.Windows.Forms.TextBox();
            this.sclasscheck = new System.Windows.Forms.CheckBox();
            this.sclasstext = new System.Windows.Forms.TextBox();
            this.sdeptcheck = new System.Windows.Forms.CheckBox();
            this.sdepttext = new System.Windows.Forms.TextBox();
            this.saddrcheck = new System.Windows.Forms.CheckBox();
            this.saddrtext = new System.Windows.Forms.TextBox();
            this.sqloutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Location = new System.Drawing.Point(12, 9);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(29, 12);
            this.labelinfo.TabIndex = 0;
            this.labelinfo.Text = "info";
            // 
            // sidtext
            // 
            this.sidtext.Location = new System.Drawing.Point(69, 40);
            this.sidtext.Name = "sidtext";
            this.sidtext.Size = new System.Drawing.Size(199, 21);
            this.sidtext.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(708, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 184);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(827, 213);
            this.dataGridView1.TabIndex = 3;
            // 
            // sidcheck
            // 
            this.sidcheck.AutoSize = true;
            this.sidcheck.Location = new System.Drawing.Point(14, 42);
            this.sidcheck.Name = "sidcheck";
            this.sidcheck.Size = new System.Drawing.Size(48, 16);
            this.sidcheck.TabIndex = 4;
            this.sidcheck.Text = "学号";
            this.sidcheck.UseVisualStyleBackColor = true;
            // 
            // snamecheck
            // 
            this.snamecheck.AutoSize = true;
            this.snamecheck.Location = new System.Drawing.Point(14, 82);
            this.snamecheck.Name = "snamecheck";
            this.snamecheck.Size = new System.Drawing.Size(48, 16);
            this.snamecheck.TabIndex = 5;
            this.snamecheck.Text = "姓名";
            this.snamecheck.UseVisualStyleBackColor = true;
            // 
            // snametext
            // 
            this.snametext.Location = new System.Drawing.Point(69, 80);
            this.snametext.Name = "snametext";
            this.snametext.Size = new System.Drawing.Size(199, 21);
            this.snametext.TabIndex = 6;
            // 
            // sagecheck
            // 
            this.sagecheck.AutoSize = true;
            this.sagecheck.Location = new System.Drawing.Point(14, 121);
            this.sagecheck.Name = "sagecheck";
            this.sagecheck.Size = new System.Drawing.Size(48, 16);
            this.sagecheck.TabIndex = 7;
            this.sagecheck.Text = "年龄";
            this.sagecheck.UseVisualStyleBackColor = true;
            // 
            // sagetext1
            // 
            this.sagetext1.Location = new System.Drawing.Point(88, 119);
            this.sagetext1.Name = "sagetext1";
            this.sagetext1.Size = new System.Drawing.Size(62, 21);
            this.sagetext1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "自";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "到";
            // 
            // sagetext2
            // 
            this.sagetext2.Location = new System.Drawing.Point(206, 119);
            this.sagetext2.Name = "sagetext2";
            this.sagetext2.Size = new System.Drawing.Size(62, 21);
            this.sagetext2.TabIndex = 11;
            // 
            // ssexcheck
            // 
            this.ssexcheck.AutoSize = true;
            this.ssexcheck.Location = new System.Drawing.Point(14, 158);
            this.ssexcheck.Name = "ssexcheck";
            this.ssexcheck.Size = new System.Drawing.Size(48, 16);
            this.ssexcheck.TabIndex = 12;
            this.ssexcheck.Text = "性别";
            this.ssexcheck.UseVisualStyleBackColor = true;
            // 
            // ssextext
            // 
            this.ssextext.Location = new System.Drawing.Point(69, 152);
            this.ssextext.Name = "ssextext";
            this.ssextext.Size = new System.Drawing.Size(81, 21);
            this.ssextext.TabIndex = 13;
            // 
            // sclasscheck
            // 
            this.sclasscheck.AutoSize = true;
            this.sclasscheck.Location = new System.Drawing.Point(327, 41);
            this.sclasscheck.Name = "sclasscheck";
            this.sclasscheck.Size = new System.Drawing.Size(48, 16);
            this.sclasscheck.TabIndex = 14;
            this.sclasscheck.Text = "班级";
            this.sclasscheck.UseVisualStyleBackColor = true;
            // 
            // sclasstext
            // 
            this.sclasstext.Location = new System.Drawing.Point(382, 40);
            this.sclasstext.Name = "sclasstext";
            this.sclasstext.Size = new System.Drawing.Size(100, 21);
            this.sclasstext.TabIndex = 15;
            // 
            // sdeptcheck
            // 
            this.sdeptcheck.AutoSize = true;
            this.sdeptcheck.Location = new System.Drawing.Point(327, 82);
            this.sdeptcheck.Name = "sdeptcheck";
            this.sdeptcheck.Size = new System.Drawing.Size(36, 16);
            this.sdeptcheck.TabIndex = 16;
            this.sdeptcheck.Text = "系";
            this.sdeptcheck.UseVisualStyleBackColor = true;
            // 
            // sdepttext
            // 
            this.sdepttext.Location = new System.Drawing.Point(382, 77);
            this.sdepttext.Name = "sdepttext";
            this.sdepttext.Size = new System.Drawing.Size(100, 21);
            this.sdepttext.TabIndex = 17;
            // 
            // saddrcheck
            // 
            this.saddrcheck.AutoSize = true;
            this.saddrcheck.Location = new System.Drawing.Point(327, 121);
            this.saddrcheck.Name = "saddrcheck";
            this.saddrcheck.Size = new System.Drawing.Size(48, 16);
            this.saddrcheck.TabIndex = 18;
            this.saddrcheck.Text = "地址";
            this.saddrcheck.UseVisualStyleBackColor = true;
            // 
            // saddrtext
            // 
            this.saddrtext.Location = new System.Drawing.Point(382, 119);
            this.saddrtext.Name = "saddrtext";
            this.saddrtext.Size = new System.Drawing.Size(100, 21);
            this.saddrtext.TabIndex = 19;
            // 
            // sqloutput
            // 
            this.sqloutput.Location = new System.Drawing.Point(69, 179);
            this.sqloutput.Multiline = true;
            this.sqloutput.Name = "sqloutput";
            this.sqloutput.Size = new System.Drawing.Size(413, 63);
            this.sqloutput.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 473);
            this.Controls.Add(this.sqloutput);
            this.Controls.Add(this.saddrtext);
            this.Controls.Add(this.saddrcheck);
            this.Controls.Add(this.sdepttext);
            this.Controls.Add(this.sdeptcheck);
            this.Controls.Add(this.sclasstext);
            this.Controls.Add(this.sclasscheck);
            this.Controls.Add(this.ssextext);
            this.Controls.Add(this.ssexcheck);
            this.Controls.Add(this.sagetext2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sagetext1);
            this.Controls.Add(this.sagecheck);
            this.Controls.Add(this.snametext);
            this.Controls.Add(this.snamecheck);
            this.Controls.Add(this.sidcheck);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sidtext);
            this.Controls.Add(this.labelinfo);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.TextBox sidtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox sidcheck;
        private System.Windows.Forms.CheckBox snamecheck;
        private System.Windows.Forms.TextBox snametext;
        private System.Windows.Forms.CheckBox sagecheck;
        private System.Windows.Forms.TextBox sagetext1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sagetext2;
        private System.Windows.Forms.CheckBox ssexcheck;
        private System.Windows.Forms.TextBox ssextext;
        private System.Windows.Forms.CheckBox sclasscheck;
        private System.Windows.Forms.TextBox sclasstext;
        private System.Windows.Forms.CheckBox sdeptcheck;
        private System.Windows.Forms.TextBox sdepttext;
        private System.Windows.Forms.CheckBox saddrcheck;
        private System.Windows.Forms.TextBox saddrtext;
        private System.Windows.Forms.TextBox sqloutput;
    }
}

