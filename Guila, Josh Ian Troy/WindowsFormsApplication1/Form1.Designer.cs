namespace WindowsFormsApplication1
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
            this.lb_calcu = new System.Windows.Forms.Label();
            this.lb_weight = new System.Windows.Forms.Label();
            this.lb_height = new System.Windows.Forms.Label();
            this.lb_bmi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_conv = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_calcu
            // 
            this.lb_calcu.AutoSize = true;
            this.lb_calcu.BackColor = System.Drawing.Color.Transparent;
            this.lb_calcu.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_calcu.Location = new System.Drawing.Point(199, 108);
            this.lb_calcu.Name = "lb_calcu";
            this.lb_calcu.Size = new System.Drawing.Size(238, 45);
            this.lb_calcu.TabIndex = 0;
            this.lb_calcu.Text = "BMI Calculator";
            // 
            // lb_weight
            // 
            this.lb_weight.AutoSize = true;
            this.lb_weight.BackColor = System.Drawing.Color.Transparent;
            this.lb_weight.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_weight.Location = new System.Drawing.Point(59, 223);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(205, 32);
            this.lb_weight.TabIndex = 1;
            this.lb_weight.Text = "Enter Weight (kg):";
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.BackColor = System.Drawing.Color.Transparent;
            this.lb_height.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_height.Location = new System.Drawing.Point(59, 348);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(199, 32);
            this.lb_height.TabIndex = 2;
            this.lb_height.Text = "Enter Height (m):";
            this.lb_height.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_bmi
            // 
            this.lb_bmi.AutoSize = true;
            this.lb_bmi.BackColor = System.Drawing.Color.Transparent;
            this.lb_bmi.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bmi.Location = new System.Drawing.Point(251, 517);
            this.lb_bmi.Name = "lb_bmi";
            this.lb_bmi.Size = new System.Drawing.Size(116, 32);
            this.lb_bmi.TabIndex = 3;
            this.lb_bmi.Text = "Your BMI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 223);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 348);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 32);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_conv
            // 
            this.btn_conv.BackColor = System.Drawing.Color.Transparent;
            this.btn_conv.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conv.Location = new System.Drawing.Point(392, 436);
            this.btn_conv.Name = "btn_conv";
            this.btn_conv.Size = new System.Drawing.Size(151, 40);
            this.btn_conv.TabIndex = 7;
            this.btn_conv.Text = "Convert";
            this.btn_conv.UseVisualStyleBackColor = false;
            this.btn_conv.Click += new System.EventHandler(this.btn_conv_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(179, 565);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(277, 36);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(651, 901);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_conv);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_bmi);
            this.Controls.Add(this.lb_height);
            this.Controls.Add(this.lb_weight);
            this.Controls.Add(this.lb_calcu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_calcu;
        private System.Windows.Forms.Label lb_weight;
        private System.Windows.Forms.Label lb_height;
        private System.Windows.Forms.Label lb_bmi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_conv;
        private System.Windows.Forms.TextBox textBox3;
    }
}

