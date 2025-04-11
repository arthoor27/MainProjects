namespace Ritard_Calculator
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
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(303, 127);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(115, 58);
            this.btnMultiplication.TabIndex = 1;
            this.btnMultiplication.Text = "Multiplication";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(24, 127);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(115, 58);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter The Fitse Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(20, 82);
            this.lblText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(206, 20);
            this.lblText2.TabIndex = 5;
            this.lblText2.Text = "Enter The Second Number :";
            this.lblText2.Click += new System.EventHandler(this.lblText2_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(170, 127);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(109, 58);
            this.btnSubtraction.TabIndex = 8;
            this.btnSubtraction.Text = "Subtraction";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(447, 127);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(110, 58);
            this.btnDivision.TabIndex = 9;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(245, 79);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(312, 26);
            this.txtNum2.TabIndex = 10;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(245, 40);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(312, 26);
            this.txtNum1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 203);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMultiplication);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Absolute Calculator(REAL)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
    }
}

