namespace AreaOfCircleGUI
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lbListOfCircles = new System.Windows.Forms.ListBox();
            this.btnAddCircle = new System.Windows.Forms.Button();
            this.tbR = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAreaCount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(32, 19);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(71, 20);
            this.tbX.TabIndex = 1;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(32, 41);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(71, 20);
            this.tbY.TabIndex = 2;
            // 
            // lbListOfCircles
            // 
            this.lbListOfCircles.FormattingEnabled = true;
            this.lbListOfCircles.Location = new System.Drawing.Point(133, 12);
            this.lbListOfCircles.Name = "lbListOfCircles";
            this.lbListOfCircles.Size = new System.Drawing.Size(82, 95);
            this.lbListOfCircles.TabIndex = 3;
            // 
            // btnAddCircle
            // 
            this.btnAddCircle.Location = new System.Drawing.Point(87, 90);
            this.btnAddCircle.Name = "btnAddCircle";
            this.btnAddCircle.Size = new System.Drawing.Size(40, 23);
            this.btnAddCircle.TabIndex = 4;
            this.btnAddCircle.Text = "Add";
            this.btnAddCircle.UseVisualStyleBackColor = true;
            this.btnAddCircle.Click += new System.EventHandler(this.btnAddCircle_Click);
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(29, 92);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(52, 20);
            this.tbR.TabIndex = 5;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 119);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(115, 46);
            this.tbResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 71);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Центр окружности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "R";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(133, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAreaCount
            // 
            this.btnAreaCount.Location = new System.Drawing.Point(133, 142);
            this.btnAreaCount.Name = "btnAreaCount";
            this.btnAreaCount.Size = new System.Drawing.Size(82, 23);
            this.btnAreaCount.TabIndex = 12;
            this.btnAreaCount.Text = "Count";
            this.btnAreaCount.UseVisualStyleBackColor = true;
            this.btnAreaCount.Click += new System.EventHandler(this.btnAreaCount_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 173);
            this.Controls.Add(this.btnAreaCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.btnAddCircle);
            this.Controls.Add(this.lbListOfCircles);
            this.Name = "mainForm";
            this.Text = "Площадь пересечения двух окружностей ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.ListBox lbListOfCircles;
        private System.Windows.Forms.Button btnAddCircle;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAreaCount;
    }
}

