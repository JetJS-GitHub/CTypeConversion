namespace CTypeConversion
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButTestAlias = new System.Windows.Forms.Button();
            this.BtnAutoConversion = new System.Windows.Forms.Button();
            this.BtnCharConvesrsion = new System.Windows.Forms.Button();
            this.BtnTypeConversion = new System.Windows.Forms.Button();
            this.BtnStringConversion = new System.Windows.Forms.Button();
            this.BtnStringToCharArray = new System.Windows.Forms.Button();
            this.BtnStringToByteArray = new System.Windows.Forms.Button();
            this.BtnToBitArray = new System.Windows.Forms.Button();
            this.BtnToHex = new System.Windows.Forms.Button();
            this.DateTimeToLongInt = new System.Windows.Forms.Button();
            this.BtnDateTimeToString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(643, 248);
            this.textBox1.TabIndex = 1;
            // 
            // ButTestAlias
            // 
            this.ButTestAlias.Location = new System.Drawing.Point(708, 12);
            this.ButTestAlias.Name = "ButTestAlias";
            this.ButTestAlias.Size = new System.Drawing.Size(130, 38);
            this.ButTestAlias.TabIndex = 2;
            this.ButTestAlias.Text = "TestAlias";
            this.ButTestAlias.UseVisualStyleBackColor = true;
            this.ButTestAlias.Click += new System.EventHandler(this.ButTestAlias_Click);
            // 
            // BtnAutoConversion
            // 
            this.BtnAutoConversion.Location = new System.Drawing.Point(708, 72);
            this.BtnAutoConversion.Name = "BtnAutoConversion";
            this.BtnAutoConversion.Size = new System.Drawing.Size(130, 38);
            this.BtnAutoConversion.TabIndex = 3;
            this.BtnAutoConversion.Text = "Test隐式转换 ";
            this.BtnAutoConversion.UseVisualStyleBackColor = true;
            this.BtnAutoConversion.Click += new System.EventHandler(this.BtnAutoConversion_Click);
            // 
            // BtnCharConvesrsion
            // 
            this.BtnCharConvesrsion.Location = new System.Drawing.Point(708, 185);
            this.BtnCharConvesrsion.Name = "BtnCharConvesrsion";
            this.BtnCharConvesrsion.Size = new System.Drawing.Size(130, 38);
            this.BtnCharConvesrsion.TabIndex = 4;
            this.BtnCharConvesrsion.Text = "Test字符转换";
            this.BtnCharConvesrsion.UseVisualStyleBackColor = true;
            this.BtnCharConvesrsion.Click += new System.EventHandler(this.BtnCharConvesrsion_Click);
            // 
            // BtnTypeConversion
            // 
            this.BtnTypeConversion.Location = new System.Drawing.Point(708, 127);
            this.BtnTypeConversion.Name = "BtnTypeConversion";
            this.BtnTypeConversion.Size = new System.Drawing.Size(130, 38);
            this.BtnTypeConversion.TabIndex = 5;
            this.BtnTypeConversion.Text = "Test强制转换";
            this.BtnTypeConversion.UseVisualStyleBackColor = true;
            this.BtnTypeConversion.Click += new System.EventHandler(this.BtnTypeConversion_Click);
            // 
            // BtnStringConversion
            // 
            this.BtnStringConversion.Location = new System.Drawing.Point(686, 247);
            this.BtnStringConversion.Name = "BtnStringConversion";
            this.BtnStringConversion.Size = new System.Drawing.Size(193, 38);
            this.BtnStringConversion.TabIndex = 6;
            this.BtnStringConversion.Text = "字符串转换数字";
            this.BtnStringConversion.UseVisualStyleBackColor = true;
            this.BtnStringConversion.Click += new System.EventHandler(this.BtnStringConversion_Click);
            // 
            // BtnStringToCharArray
            // 
            this.BtnStringToCharArray.Location = new System.Drawing.Point(686, 306);
            this.BtnStringToCharArray.Name = "BtnStringToCharArray";
            this.BtnStringToCharArray.Size = new System.Drawing.Size(193, 38);
            this.BtnStringToCharArray.TabIndex = 7;
            this.BtnStringToCharArray.Text = "字符串转字符数组";
            this.BtnStringToCharArray.UseVisualStyleBackColor = true;
            this.BtnStringToCharArray.Click += new System.EventHandler(this.BtnStringToCharArray_Click);
            // 
            // BtnStringToByteArray
            // 
            this.BtnStringToByteArray.Location = new System.Drawing.Point(686, 362);
            this.BtnStringToByteArray.Name = "BtnStringToByteArray";
            this.BtnStringToByteArray.Size = new System.Drawing.Size(193, 38);
            this.BtnStringToByteArray.TabIndex = 8;
            this.BtnStringToByteArray.Text = "字符串转字节数组";
            this.BtnStringToByteArray.UseVisualStyleBackColor = true;
            this.BtnStringToByteArray.Click += new System.EventHandler(this.BtnStringToByteArray_Click);
            // 
            // BtnToBitArray
            // 
            this.BtnToBitArray.Location = new System.Drawing.Point(686, 421);
            this.BtnToBitArray.Name = "BtnToBitArray";
            this.BtnToBitArray.Size = new System.Drawing.Size(193, 38);
            this.BtnToBitArray.TabIndex = 9;
            this.BtnToBitArray.Text = "数值转字节数组";
            this.BtnToBitArray.UseVisualStyleBackColor = true;
            this.BtnToBitArray.Click += new System.EventHandler(this.BtnToBitArray_Click);
            // 
            // BtnToHex
            // 
            this.BtnToHex.Location = new System.Drawing.Point(686, 478);
            this.BtnToHex.Name = "BtnToHex";
            this.BtnToHex.Size = new System.Drawing.Size(193, 38);
            this.BtnToHex.TabIndex = 10;
            this.BtnToHex.Text = "数值转16进制数";
            this.BtnToHex.UseVisualStyleBackColor = true;
            this.BtnToHex.Click += new System.EventHandler(this.BtnToHex_Click);
            // 
            // DateTimeToLongInt
            // 
            this.DateTimeToLongInt.Location = new System.Drawing.Point(686, 536);
            this.DateTimeToLongInt.Name = "DateTimeToLongInt";
            this.DateTimeToLongInt.Size = new System.Drawing.Size(193, 38);
            this.DateTimeToLongInt.TabIndex = 11;
            this.DateTimeToLongInt.Text = "日期转长整形数据";
            this.DateTimeToLongInt.UseVisualStyleBackColor = true;
            this.DateTimeToLongInt.Click += new System.EventHandler(this.DateTimeToLongInt_Click);
            // 
            // BtnDateTimeToString
            // 
            this.BtnDateTimeToString.Location = new System.Drawing.Point(686, 592);
            this.BtnDateTimeToString.Name = "BtnDateTimeToString";
            this.BtnDateTimeToString.Size = new System.Drawing.Size(193, 38);
            this.BtnDateTimeToString.TabIndex = 12;
            this.BtnDateTimeToString.Text = "日期转字符串";
            this.BtnDateTimeToString.UseVisualStyleBackColor = true;
            this.BtnDateTimeToString.Click += new System.EventHandler(this.BtnDateTimeToString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 665);
            this.Controls.Add(this.BtnDateTimeToString);
            this.Controls.Add(this.DateTimeToLongInt);
            this.Controls.Add(this.BtnToHex);
            this.Controls.Add(this.BtnToBitArray);
            this.Controls.Add(this.BtnStringToByteArray);
            this.Controls.Add(this.BtnStringToCharArray);
            this.Controls.Add(this.BtnStringConversion);
            this.Controls.Add(this.BtnTypeConversion);
            this.Controls.Add(this.BtnCharConvesrsion);
            this.Controls.Add(this.BtnAutoConversion);
            this.Controls.Add(this.ButTestAlias);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButTestAlias;
        private System.Windows.Forms.Button BtnAutoConversion;
        private System.Windows.Forms.Button BtnCharConvesrsion;
        private System.Windows.Forms.Button BtnTypeConversion;
        private System.Windows.Forms.Button BtnStringConversion;
        private System.Windows.Forms.Button BtnStringToCharArray;
        private System.Windows.Forms.Button BtnStringToByteArray;
        private System.Windows.Forms.Button BtnToBitArray;
        private System.Windows.Forms.Button BtnToHex;
        private System.Windows.Forms.Button DateTimeToLongInt;
        private System.Windows.Forms.Button BtnDateTimeToString;
    }
}

