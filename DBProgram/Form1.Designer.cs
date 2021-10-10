
namespace DBProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonComboBoxCalculate = new System.Windows.Forms.Button();
            this.comboBoxComboCalc_operater = new System.Windows.Forms.ComboBox();
            this.textBoxComboCalc_result = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_oper2 = new System.Windows.Forms.TextBox();
            this.textBoxComboCalc_oper1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonCalc_2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCalc_1 = new System.Windows.Forms.RadioButton();
            this.buttonRadioCalculate = new System.Windows.Forms.Button();
            this.textBoxRadioCalc_result = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_oper2 = new System.Windows.Forms.TextBox();
            this.textBoxRadioCalc_oper1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonComboBoxCalculate);
            this.groupBox1.Controls.Add(this.comboBoxComboCalc_operater);
            this.groupBox1.Controls.Add(this.textBoxComboCalc_result);
            this.groupBox1.Controls.Add(this.textBoxComboCalc_oper2);
            this.groupBox1.Controls.Add(this.textBoxComboCalc_oper1);
            this.groupBox1.Location = new System.Drawing.Point(30, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox Calculator";
            // 
            // buttonComboBoxCalculate
            // 
            this.buttonComboBoxCalculate.Location = new System.Drawing.Point(414, 39);
            this.buttonComboBoxCalculate.Name = "buttonComboBoxCalculate";
            this.buttonComboBoxCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonComboBoxCalculate.TabIndex = 1;
            this.buttonComboBoxCalculate.Text = "Calculate";
            this.buttonComboBoxCalculate.UseVisualStyleBackColor = true;
            this.buttonComboBoxCalculate.Click += new System.EventHandler(this.buttonComboBoxCalculate_Click);
            // 
            // comboBoxComboCalc_operater
            // 
            this.comboBoxComboCalc_operater.FormattingEnabled = true;
            this.comboBoxComboCalc_operater.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxComboCalc_operater.Location = new System.Drawing.Point(152, 39);
            this.comboBoxComboCalc_operater.Name = "comboBoxComboCalc_operater";
            this.comboBoxComboCalc_operater.Size = new System.Drawing.Size(102, 23);
            this.comboBoxComboCalc_operater.TabIndex = 3;
            // 
            // textBoxComboCalc_result
            // 
            this.textBoxComboCalc_result.Location = new System.Drawing.Point(514, 39);
            this.textBoxComboCalc_result.Name = "textBoxComboCalc_result";
            this.textBoxComboCalc_result.Size = new System.Drawing.Size(100, 23);
            this.textBoxComboCalc_result.TabIndex = 2;
            // 
            // textBoxComboCalc_oper2
            // 
            this.textBoxComboCalc_oper2.Location = new System.Drawing.Point(288, 39);
            this.textBoxComboCalc_oper2.Name = "textBoxComboCalc_oper2";
            this.textBoxComboCalc_oper2.Size = new System.Drawing.Size(100, 23);
            this.textBoxComboCalc_oper2.TabIndex = 1;
            // 
            // textBoxComboCalc_oper1
            // 
            this.textBoxComboCalc_oper1.Location = new System.Drawing.Point(20, 39);
            this.textBoxComboCalc_oper1.Name = "textBoxComboCalc_oper1";
            this.textBoxComboCalc_oper1.Size = new System.Drawing.Size(100, 23);
            this.textBoxComboCalc_oper1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonCalc_2);
            this.groupBox2.Controls.Add(this.radioButtonCalc_1);
            this.groupBox2.Controls.Add(this.buttonRadioCalculate);
            this.groupBox2.Controls.Add(this.textBoxRadioCalc_result);
            this.groupBox2.Controls.Add(this.textBoxRadioCalc_oper2);
            this.groupBox2.Controls.Add(this.textBoxRadioCalc_oper1);
            this.groupBox2.Location = new System.Drawing.Point(30, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Radio button Calculator";
            // 
            // radioButtonCalc_2
            // 
            this.radioButtonCalc_2.AutoSize = true;
            this.radioButtonCalc_2.Location = new System.Drawing.Point(179, 65);
            this.radioButtonCalc_2.Name = "radioButtonCalc_2";
            this.radioButtonCalc_2.Size = new System.Drawing.Size(30, 19);
            this.radioButtonCalc_2.TabIndex = 6;
            this.radioButtonCalc_2.TabStop = true;
            this.radioButtonCalc_2.Text = "-";
            this.radioButtonCalc_2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCalc_1
            // 
            this.radioButtonCalc_1.AutoSize = true;
            this.radioButtonCalc_1.Location = new System.Drawing.Point(179, 31);
            this.radioButtonCalc_1.Name = "radioButtonCalc_1";
            this.radioButtonCalc_1.Size = new System.Drawing.Size(33, 19);
            this.radioButtonCalc_1.TabIndex = 5;
            this.radioButtonCalc_1.TabStop = true;
            this.radioButtonCalc_1.Text = "+";
            this.radioButtonCalc_1.UseVisualStyleBackColor = true;
            
            // 
            // buttonRadioCalculate
            // 
            this.buttonRadioCalculate.Location = new System.Drawing.Point(414, 48);
            this.buttonRadioCalculate.Name = "buttonRadioCalculate";
            this.buttonRadioCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonRadioCalculate.TabIndex = 4;
            this.buttonRadioCalculate.Text = "Calculate";
            this.buttonRadioCalculate.UseVisualStyleBackColor = true;
            this.buttonRadioCalculate.Click += new System.EventHandler(this.buttonRadioCalculate_Click);
            // 
            // textBoxRadioCalc_result
            // 
            this.textBoxRadioCalc_result.Location = new System.Drawing.Point(514, 49);
            this.textBoxRadioCalc_result.Name = "textBoxRadioCalc_result";
            this.textBoxRadioCalc_result.Size = new System.Drawing.Size(100, 23);
            this.textBoxRadioCalc_result.TabIndex = 4;
            // 
            // textBoxRadioCalc_oper2
            // 
            this.textBoxRadioCalc_oper2.Location = new System.Drawing.Point(288, 49);
            this.textBoxRadioCalc_oper2.Name = "textBoxRadioCalc_oper2";
            this.textBoxRadioCalc_oper2.Size = new System.Drawing.Size(100, 23);
            this.textBoxRadioCalc_oper2.TabIndex = 4;
            // 
            // textBoxRadioCalc_oper1
            // 
            this.textBoxRadioCalc_oper1.Location = new System.Drawing.Point(20, 49);
            this.textBoxRadioCalc_oper1.Name = "textBoxRadioCalc_oper1";
            this.textBoxRadioCalc_oper1.Size = new System.Drawing.Size(100, 23);
            this.textBoxRadioCalc_oper1.TabIndex = 4;
            this.textBoxRadioCalc_oper1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonComboBoxCalculate;
        private System.Windows.Forms.ComboBox comboBoxComboCalc_operater;
        private System.Windows.Forms.TextBox textBoxComboCalc_result;
        private System.Windows.Forms.TextBox textBoxComboCalc_oper2;
        private System.Windows.Forms.TextBox textBoxComboCalc_oper1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRadioCalculate;
        private System.Windows.Forms.TextBox textBoxRadioCalc_result;
        private System.Windows.Forms.TextBox textBoxRadioCalc_oper2;
        private System.Windows.Forms.TextBox textBoxRadioCalc_oper1;
        private System.Windows.Forms.RadioButton radioButtonCalc_2;
        private System.Windows.Forms.RadioButton radioButtonCalc_1;
    }
}

