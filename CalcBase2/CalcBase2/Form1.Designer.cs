namespace CalcBase2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CE_btn = new System.Windows.Forms.Button();
            this.C_btn = new System.Windows.Forms.Button();
            this.plus_minus_btn = new System.Windows.Forms.Button();
            this.sqrt_btn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CE_btn
            // 
            this.CE_btn.Location = new System.Drawing.Point(55, 51);
            this.CE_btn.Name = "CE_btn";
            this.CE_btn.Size = new System.Drawing.Size(36, 36);
            this.CE_btn.TabIndex = 2;
            this.CE_btn.Text = "CE";
            this.CE_btn.UseVisualStyleBackColor = true;
            // 
            // C_btn
            // 
            this.C_btn.Location = new System.Drawing.Point(97, 51);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(36, 36);
            this.C_btn.TabIndex = 3;
            this.C_btn.Text = "C";
            this.C_btn.UseVisualStyleBackColor = true;
            // 
            // plus_minus_btn
            // 
            this.plus_minus_btn.Location = new System.Drawing.Point(139, 51);
            this.plus_minus_btn.Name = "plus_minus_btn";
            this.plus_minus_btn.Size = new System.Drawing.Size(36, 36);
            this.plus_minus_btn.TabIndex = 4;
            this.plus_minus_btn.Text = "+/-";
            this.plus_minus_btn.UseVisualStyleBackColor = true;
            // 
            // sqrt_btn
            // 
            this.sqrt_btn.Location = new System.Drawing.Point(181, 51);
            this.sqrt_btn.Name = "sqrt_btn";
            this.sqrt_btn.Size = new System.Drawing.Size(36, 36);
            this.sqrt_btn.TabIndex = 5;
            this.sqrt_btn.Text = "√";
            this.sqrt_btn.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(181, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 36);
            this.button6.TabIndex = 10;
            this.button6.Text = "%";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(139, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 36);
            this.button7.TabIndex = 9;
            this.button7.Text = "/";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.op_clicked);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(97, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 36);
            this.button8.TabIndex = 8;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(55, 93);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 36);
            this.button9.TabIndex = 7;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(13, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 36);
            this.button10.TabIndex = 6;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(181, 135);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 36);
            this.button11.TabIndex = 15;
            this.button11.Text = "1/x";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(139, 135);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 36);
            this.button12.TabIndex = 14;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.op_clicked);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(97, 135);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(36, 36);
            this.button13.TabIndex = 13;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(55, 135);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 36);
            this.button14.TabIndex = 12;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(13, 135);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(36, 36);
            this.button15.TabIndex = 11;
            this.button15.Text = "4";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(139, 177);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(36, 36);
            this.button17.TabIndex = 19;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.op_clicked);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(97, 177);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 36);
            this.button18.TabIndex = 18;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(55, 177);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(36, 36);
            this.button19.TabIndex = 17;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(13, 177);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(36, 36);
            this.button20.TabIndex = 16;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.number_cliecked);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(181, 177);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(36, 78);
            this.button21.TabIndex = 25;
            this.button21.Text = "=";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.op_clicked);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(139, 219);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(36, 36);
            this.button22.TabIndex = 24;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.op_clicked);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(97, 219);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(36, 36);
            this.button23.TabIndex = 23;
            this.button23.Text = ",";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(13, 219);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(78, 36);
            this.button25.TabIndex = 21;
            this.button25.Text = "0";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.number_cliecked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 273);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.sqrt_btn);
            this.Controls.Add(this.plus_minus_btn);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.CE_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CE_btn;
        private System.Windows.Forms.Button C_btn;
        private System.Windows.Forms.Button plus_minus_btn;
        private System.Windows.Forms.Button sqrt_btn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
    }
}

