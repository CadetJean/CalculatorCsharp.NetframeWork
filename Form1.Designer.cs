
namespace simpleCalculate1
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
            this.numOne = new System.Windows.Forms.TextBox();
            this.numTwo = new System.Windows.Forms.TextBox();
            this.txtOperand = new System.Windows.Forms.TextBox();
            this.txtResultOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalculate = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numOne
            // 
            this.numOne.Location = new System.Drawing.Point(236, 69);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(100, 20);
            this.numOne.TabIndex = 0;
            // 
            // numTwo
            // 
            this.numTwo.Location = new System.Drawing.Point(236, 133);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(100, 20);
            this.numTwo.TabIndex = 1;
            // 
            // txtOperand
            // 
            this.txtOperand.Location = new System.Drawing.Point(236, 199);
            this.txtOperand.Name = "txtOperand";
            this.txtOperand.Size = new System.Drawing.Size(100, 20);
            this.txtOperand.TabIndex = 2;
            // 
            // txtResultOne
            // 
            this.txtResultOne.Location = new System.Drawing.Point(236, 268);
            this.txtResultOne.Name = "txtResultOne";
            this.txtResultOne.ReadOnly = true;
            this.txtResultOne.Size = new System.Drawing.Size(100, 20);
            this.txtResultOne.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entter Operand (+,-,*,/)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // txtCalculate
            // 
            this.txtCalculate.Location = new System.Drawing.Point(421, 69);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.Size = new System.Drawing.Size(75, 23);
            this.txtCalculate.TabIndex = 8;
            this.txtCalculate.Text = "Calculate";
            this.txtCalculate.UseVisualStyleBackColor = true;
            this.txtCalculate.Click += new System.EventHandler(this.txtCalculate_Click);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(249, 352);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(75, 23);
            this.txtClear.TabIndex = 9;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(42, 352);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 23);
            this.txtExit.TabIndex = 10;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.txtExit;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.txtCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultOne);
            this.Controls.Add(this.txtOperand);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numOne);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.txtCalculate_Click);
            this.Click += new System.EventHandler(this.txtClear_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numOne;
        private System.Windows.Forms.TextBox numTwo;
        private System.Windows.Forms.TextBox txtOperand;
        private System.Windows.Forms.TextBox txtResultOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtCalculate;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.Button txtExit;
    }
}

