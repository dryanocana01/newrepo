namespace chap1test2
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
            this.digit1 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.asterisk = new System.Windows.Forms.Button();
            this.slash = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.openP = new System.Windows.Forms.Button();
            this.closeP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1.Location = new System.Drawing.Point(126, 237);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(39, 40);
            this.digit1.TabIndex = 0;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.digit1_Click);
            // 
            // digit0
            // 
            this.digit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit0.Location = new System.Drawing.Point(81, 237);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(39, 40);
            this.digit0.TabIndex = 1;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.digit0_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 68);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter an expression";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(217, 237);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(39, 40);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(262, 237);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(39, 40);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // asterisk
            // 
            this.asterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asterisk.Location = new System.Drawing.Point(217, 283);
            this.asterisk.Name = "asterisk";
            this.asterisk.Size = new System.Drawing.Size(39, 40);
            this.asterisk.TabIndex = 5;
            this.asterisk.Text = "*";
            this.asterisk.UseVisualStyleBackColor = true;
            this.asterisk.Click += new System.EventHandler(this.asterisk_Click);
            // 
            // slash
            // 
            this.slash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slash.Location = new System.Drawing.Point(262, 283);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(39, 40);
            this.slash.TabIndex = 6;
            this.slash.Text = "/";
            this.slash.UseVisualStyleBackColor = true;
            this.slash.Click += new System.EventHandler(this.slash_Click);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(307, 260);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(39, 40);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "=>";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Operations";
            // 
            // decimalPoint
            // 
            this.decimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalPoint.Location = new System.Drawing.Point(105, 283);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(39, 40);
            this.decimalPoint.TabIndex = 11;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = true;
            this.decimalPoint.Click += new System.EventHandler(this.decimalPoint_Click);
            // 
            // openP
            // 
            this.openP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openP.Location = new System.Drawing.Point(217, 329);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(39, 40);
            this.openP.TabIndex = 12;
            this.openP.Text = "(";
            this.openP.UseVisualStyleBackColor = true;
            this.openP.Click += new System.EventHandler(this.openP_Click);
            // 
            // closeP
            // 
            this.closeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeP.Location = new System.Drawing.Point(262, 329);
            this.closeP.Name = "closeP";
            this.closeP.Size = new System.Drawing.Size(39, 40);
            this.closeP.TabIndex = 13;
            this.closeP.Text = ")";
            this.closeP.UseVisualStyleBackColor = true;
            this.closeP.Click += new System.EventHandler(this.closeP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.closeP);
            this.Controls.Add(this.openP);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.asterisk);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.DoubleClick += new System.EventHandler(this.form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button asterisk;
        private System.Windows.Forms.Button slash;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button openP;
        private System.Windows.Forms.Button closeP;
    }
}

