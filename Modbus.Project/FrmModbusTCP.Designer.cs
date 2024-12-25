﻿namespace Modbus.Project
{
    partial class FrmModbusTCP
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
            groupBox2 = new GroupBox();
            label13 = new Label();
            lst_info = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btn_Write = new Button();
            btn_Read = new Button();
            txt_WriteValue = new TextBox();
            label12 = new Label();
            cmb_DataType = new ComboBox();
            label11 = new Label();
            cmb_StoreArea = new ComboBox();
            txt_Length = new TextBox();
            label9 = new Label();
            txt_Start = new TextBox();
            label10 = new Label();
            label8 = new Label();
            txt_Slaveld = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btn_Disconnect = new Button();
            dtn_Connect = new Button();
            label5 = new Label();
            cmb_DataFormat = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            Txt_Port = new TextBox();
            txt_Address = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(lst_info);
            groupBox2.Controls.Add(btn_Write);
            groupBox2.Controls.Add(btn_Read);
            groupBox2.Controls.Add(txt_WriteValue);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(cmb_DataType);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cmb_StoreArea);
            groupBox2.Controls.Add(txt_Length);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_Start);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txt_Slaveld);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(45, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(888, 388);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "读写测试";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 196);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 17;
            label13.Text = "读取信息";
            // 
            // lst_info
            // 
            lst_info.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lst_info.Location = new Point(13, 219);
            lst_info.MultiSelect = false;
            lst_info.Name = "lst_info";
            lst_info.Size = new Size(830, 163);
            lst_info.TabIndex = 16;
            lst_info.UseCompatibleStateImageBehavior = false;
            lst_info.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "日期";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "信息内容";
            columnHeader2.Width = 600;
            // 
            // btn_Write
            // 
            btn_Write.Location = new Point(588, 147);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(94, 29);
            btn_Write.TabIndex = 15;
            btn_Write.Text = "写入";
            btn_Write.UseVisualStyleBackColor = true;
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(588, 102);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(94, 29);
            btn_Read.TabIndex = 14;
            btn_Read.Text = "读取";
            btn_Read.UseVisualStyleBackColor = true;
            // 
            // txt_WriteValue
            // 
            txt_WriteValue.Location = new Point(162, 153);
            txt_WriteValue.Name = "txt_WriteValue";
            txt_WriteValue.Size = new Size(361, 27);
            txt_WriteValue.TabIndex = 12;
            txt_WriteValue.Text = "1 1 1 1 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 160);
            label12.Name = "label12";
            label12.Size = new Size(143, 20);
            label12.TabIndex = 11;
            label12.Text = "写入数据(空格分隔):";
            // 
            // cmb_DataType
            // 
            cmb_DataType.FormattingEnabled = true;
            cmb_DataType.Location = new Point(603, 40);
            cmb_DataType.Name = "cmb_DataType";
            cmb_DataType.Size = new Size(151, 28);
            cmb_DataType.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(524, 48);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 9;
            label11.Text = "数据类型:";
            // 
            // cmb_StoreArea
            // 
            cmb_StoreArea.FormattingEnabled = true;
            cmb_StoreArea.Location = new Point(329, 41);
            cmb_StoreArea.Name = "cmb_StoreArea";
            cmb_StoreArea.Size = new Size(151, 28);
            cmb_StoreArea.TabIndex = 8;
            // 
            // txt_Length
            // 
            txt_Length.Location = new Point(344, 99);
            txt_Length.Name = "txt_Length";
            txt_Length.Size = new Size(125, 27);
            txt_Length.TabIndex = 7;
            txt_Length.Text = "10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(265, 106);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 6;
            label9.Text = "读取长度:";
            // 
            // txt_Start
            // 
            txt_Start.Location = new Point(92, 99);
            txt_Start.Name = "txt_Start";
            txt_Start.Size = new Size(125, 27);
            txt_Start.TabIndex = 5;
            txt_Start.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 106);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 4;
            label10.Text = "起站地址:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(265, 48);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 2;
            label8.Text = "存储区:";
            // 
            // txt_Slaveld
            // 
            txt_Slaveld.Location = new Point(92, 41);
            txt_Slaveld.Name = "txt_Slaveld";
            txt_Slaveld.Size = new Size(125, 27);
            txt_Slaveld.TabIndex = 1;
            txt_Slaveld.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 48);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "从站地址:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Address);
            groupBox1.Controls.Add(Txt_Port);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_Disconnect);
            groupBox1.Controls.Add(dtn_Connect);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmb_DataFormat);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(45, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 222);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "通信参数";
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Location = new Point(259, 176);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(94, 29);
            btn_Disconnect.TabIndex = 13;
            btn_Disconnect.Text = "断开连接";
            btn_Disconnect.UseVisualStyleBackColor = true;
            // 
            // dtn_Connect
            // 
            dtn_Connect.Location = new Point(66, 176);
            dtn_Connect.Name = "dtn_Connect";
            dtn_Connect.Size = new Size(94, 29);
            dtn_Connect.TabIndex = 12;
            dtn_Connect.Text = "建立连接";
            dtn_Connect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 62);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 11;
            label5.Text = "大小端";
            // 
            // cmb_DataFormat
            // 
            cmb_DataFormat.FormattingEnabled = true;
            cmb_DataFormat.Location = new Point(603, 59);
            cmb_DataFormat.Name = "cmb_DataFormat";
            cmb_DataFormat.Size = new Size(151, 28);
            cmb_DataFormat.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "IP地址:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 62);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 15;
            label2.Text = "端口号:";
            // 
            // Txt_Port
            // 
            Txt_Port.Location = new Point(330, 58);
            Txt_Port.Name = "Txt_Port";
            Txt_Port.Size = new Size(125, 27);
            Txt_Port.TabIndex = 16;
            Txt_Port.Text = "502";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(66, 56);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(125, 27);
            txt_Address.TabIndex = 17;
            txt_Address.Text = "127.0.0.1";
            // 
            // FrmModbusTCP
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 686);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmModbusTCP";
            Text = "FrmModbusTCP";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label13;
        private ListView lst_info;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btn_Write;
        private Button btn_Read;
        private TextBox txt_WriteValue;
        private Label label12;
        private ComboBox cmb_DataType;
        private Label label11;
        private ComboBox cmb_StoreArea;
        private TextBox txt_Length;
        private Label label9;
        private TextBox txt_Start;
        private Label label10;
        private Label label8;
        private TextBox txt_Slaveld;
        private Label label7;
        private GroupBox groupBox1;
        private Button btn_Disconnect;
        private Button dtn_Connect;
        private Label label5;
        private ComboBox cmb_DataFormat;
        private Label label1;
        private TextBox txt_Address;
        private TextBox Txt_Port;
        private Label label2;
    }
}