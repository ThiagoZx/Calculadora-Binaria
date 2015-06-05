namespace Binary_Calc
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
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Label();
            this.Sum_btn = new System.Windows.Forms.Button();
            this.Subtraction_btn = new System.Windows.Forms.Button();
            this.Division_btn = new System.Windows.Forms.Button();
            this.Multiplication_btn = new System.Windows.Forms.Button();
            this.ResultInform = new System.Windows.Forms.Label();
            this.ResultInform2 = new System.Windows.Forms.Label();
            this.BinResult = new System.Windows.Forms.Label();
            this.DecResult = new System.Windows.Forms.Label();
            this.Clean_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_00
            // 
            this.btn_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_00.Location = new System.Drawing.Point(114, 76);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(96, 83);
            this.btn_00.TabIndex = 0;
            this.btn_00.Text = "0";
            this.btn_00.UseVisualStyleBackColor = true;
            this.btn_00.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // btn_01
            // 
            this.btn_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_01.Location = new System.Drawing.Point(12, 76);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(96, 83);
            this.btn_01.TabIndex = 1;
            this.btn_01.Text = "1";
            this.btn_01.UseVisualStyleBackColor = true;
            this.btn_01.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(216, 76);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(96, 83);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.SystemColors.Window;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(13, 9);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(298, 65);
            this.Input.TabIndex = 3;
            this.Input.Text = "0";
            this.Input.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Sum_btn
            // 
            this.Sum_btn.Location = new System.Drawing.Point(2, 165);
            this.Sum_btn.Name = "Sum_btn";
            this.Sum_btn.Size = new System.Drawing.Size(75, 23);
            this.Sum_btn.TabIndex = 4;
            this.Sum_btn.Text = "+";
            this.Sum_btn.UseVisualStyleBackColor = true;
            this.Sum_btn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Subtraction_btn
            // 
            this.Subtraction_btn.Location = new System.Drawing.Point(83, 165);
            this.Subtraction_btn.Name = "Subtraction_btn";
            this.Subtraction_btn.Size = new System.Drawing.Size(75, 23);
            this.Subtraction_btn.TabIndex = 5;
            this.Subtraction_btn.Text = "-";
            this.Subtraction_btn.UseVisualStyleBackColor = true;
            this.Subtraction_btn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Division_btn
            // 
            this.Division_btn.Location = new System.Drawing.Point(164, 165);
            this.Division_btn.Name = "Division_btn";
            this.Division_btn.Size = new System.Drawing.Size(75, 23);
            this.Division_btn.TabIndex = 6;
            this.Division_btn.Text = "/";
            this.Division_btn.UseVisualStyleBackColor = true;
            this.Division_btn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Multiplication_btn
            // 
            this.Multiplication_btn.Location = new System.Drawing.Point(245, 165);
            this.Multiplication_btn.Name = "Multiplication_btn";
            this.Multiplication_btn.Size = new System.Drawing.Size(75, 23);
            this.Multiplication_btn.TabIndex = 7;
            this.Multiplication_btn.Text = "x";
            this.Multiplication_btn.UseVisualStyleBackColor = true;
            this.Multiplication_btn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // ResultInform
            // 
            this.ResultInform.AutoSize = true;
            this.ResultInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultInform.Location = new System.Drawing.Point(96, 197);
            this.ResultInform.Name = "ResultInform";
            this.ResultInform.Size = new System.Drawing.Size(136, 16);
            this.ResultInform.TabIndex = 8;
            this.ResultInform.Text = "Resultado em binário";
            // 
            // ResultInform2
            // 
            this.ResultInform2.AutoSize = true;
            this.ResultInform2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultInform2.Location = new System.Drawing.Point(93, 237);
            this.ResultInform2.Name = "ResultInform2";
            this.ResultInform2.Size = new System.Drawing.Size(143, 16);
            this.ResultInform2.TabIndex = 9;
            this.ResultInform2.Text = "Resultado em decimal";
            // 
            // BinResult
            // 
            this.BinResult.BackColor = System.Drawing.SystemColors.Window;
            this.BinResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BinResult.Location = new System.Drawing.Point(12, 213);
            this.BinResult.Name = "BinResult";
            this.BinResult.Size = new System.Drawing.Size(299, 23);
            this.BinResult.TabIndex = 10;
            this.BinResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecResult
            // 
            this.DecResult.BackColor = System.Drawing.SystemColors.Window;
            this.DecResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecResult.Location = new System.Drawing.Point(13, 253);
            this.DecResult.Name = "DecResult";
            this.DecResult.Size = new System.Drawing.Size(298, 23);
            this.DecResult.TabIndex = 11;
            this.DecResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clean_btn
            // 
            this.Clean_btn.Location = new System.Drawing.Point(83, 283);
            this.Clean_btn.Name = "Clean_btn";
            this.Clean_btn.Size = new System.Drawing.Size(156, 26);
            this.Clean_btn.TabIndex = 12;
            this.Clean_btn.Text = "Limpar";
            this.Clean_btn.UseVisualStyleBackColor = true;
            this.Clean_btn.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 317);
            this.Controls.Add(this.Clean_btn);
            this.Controls.Add(this.DecResult);
            this.Controls.Add(this.BinResult);
            this.Controls.Add(this.ResultInform2);
            this.Controls.Add(this.ResultInform);
            this.Controls.Add(this.Multiplication_btn);
            this.Controls.Add(this.Division_btn);
            this.Controls.Add(this.Subtraction_btn);
            this.Controls.Add(this.Sum_btn);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_01);
            this.Controls.Add(this.btn_00);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calculadora binária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Button Sum_btn;
        private System.Windows.Forms.Button Subtraction_btn;
        private System.Windows.Forms.Button Division_btn;
        private System.Windows.Forms.Button Multiplication_btn;
        private System.Windows.Forms.Label ResultInform;
        private System.Windows.Forms.Label ResultInform2;
        private System.Windows.Forms.Label BinResult;
        private System.Windows.Forms.Label DecResult;
        private System.Windows.Forms.Button Clean_btn;

    }
}

