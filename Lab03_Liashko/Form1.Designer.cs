
namespace Lab03_Liashko
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_IN = new System.Windows.Forms.GroupBox();
            this.textBox_C_IN = new System.Windows.Forms.TextBox();
            this.textBox_Key_IN = new System.Windows.Forms.TextBox();
            this.textBox_P_IN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_OUT = new System.Windows.Forms.GroupBox();
            this.textBox_C_OUT = new System.Windows.Forms.TextBox();
            this.textBox_Key_OUT = new System.Windows.Forms.TextBox();
            this.textBox_P_OUT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.toolTip_HEX = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_IN.SuspendLayout();
            this.groupBox_OUT.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_IN
            // 
            this.groupBox_IN.Controls.Add(this.textBox_C_IN);
            this.groupBox_IN.Controls.Add(this.textBox_Key_IN);
            this.groupBox_IN.Controls.Add(this.textBox_P_IN);
            this.groupBox_IN.Controls.Add(this.label3);
            this.groupBox_IN.Controls.Add(this.label2);
            this.groupBox_IN.Controls.Add(this.label1);
            this.groupBox_IN.Location = new System.Drawing.Point(12, 12);
            this.groupBox_IN.Name = "groupBox_IN";
            this.groupBox_IN.Size = new System.Drawing.Size(200, 148);
            this.groupBox_IN.TabIndex = 0;
            this.groupBox_IN.TabStop = false;
            this.groupBox_IN.Text = "Зашифрування";
            // 
            // textBox_C_IN
            // 
            this.textBox_C_IN.Location = new System.Drawing.Point(83, 107);
            this.textBox_C_IN.Name = "textBox_C_IN";
            this.textBox_C_IN.Size = new System.Drawing.Size(100, 22);
            this.textBox_C_IN.TabIndex = 7;
            // 
            // textBox_Key_IN
            // 
            this.textBox_Key_IN.Location = new System.Drawing.Point(83, 70);
            this.textBox_Key_IN.Name = "textBox_Key_IN";
            this.textBox_Key_IN.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key_IN.TabIndex = 6;
            // 
            // textBox_P_IN
            // 
            this.textBox_P_IN.Location = new System.Drawing.Point(83, 28);
            this.textBox_P_IN.Name = "textBox_P_IN";
            this.textBox_P_IN.Size = new System.Drawing.Size(100, 22);
            this.textBox_P_IN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "C =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "P =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox_OUT
            // 
            this.groupBox_OUT.Controls.Add(this.textBox_C_OUT);
            this.groupBox_OUT.Controls.Add(this.textBox_Key_OUT);
            this.groupBox_OUT.Controls.Add(this.textBox_P_OUT);
            this.groupBox_OUT.Controls.Add(this.label6);
            this.groupBox_OUT.Controls.Add(this.label5);
            this.groupBox_OUT.Controls.Add(this.label4);
            this.groupBox_OUT.Location = new System.Drawing.Point(391, 12);
            this.groupBox_OUT.Name = "groupBox_OUT";
            this.groupBox_OUT.Size = new System.Drawing.Size(200, 148);
            this.groupBox_OUT.TabIndex = 1;
            this.groupBox_OUT.TabStop = false;
            this.groupBox_OUT.Text = "Розшифрування";
            // 
            // textBox_C_OUT
            // 
            this.textBox_C_OUT.Location = new System.Drawing.Point(15, 107);
            this.textBox_C_OUT.Name = "textBox_C_OUT";
            this.textBox_C_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_C_OUT.TabIndex = 6;
            // 
            // textBox_Key_OUT
            // 
            this.textBox_Key_OUT.Location = new System.Drawing.Point(15, 70);
            this.textBox_Key_OUT.Name = "textBox_Key_OUT";
            this.textBox_Key_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key_OUT.TabIndex = 6;
            // 
            // textBox_P_OUT
            // 
            this.textBox_P_OUT.Location = new System.Drawing.Point(15, 31);
            this.textBox_P_OUT.Name = "textBox_P_OUT";
            this.textBox_P_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_P_OUT.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "= C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "= Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "= P";
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(243, 12);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(101, 56);
            this.button_XOR.TabIndex = 2;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(243, 104);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(101, 56);
            this.button_clean.TabIndex = 3;
            this.button_clean.Text = "Прибрати";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_XOR);
            this.Controls.Add(this.groupBox_OUT);
            this.Controls.Add(this.groupBox_IN);
            this.Name = "Form1";
            this.Text = "XOR текст";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_IN.ResumeLayout(false);
            this.groupBox_IN.PerformLayout();
            this.groupBox_OUT.ResumeLayout(false);
            this.groupBox_OUT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_IN;
        private System.Windows.Forms.TextBox textBox_C_IN;
        private System.Windows.Forms.TextBox textBox_Key_IN;
        private System.Windows.Forms.TextBox textBox_P_IN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_OUT;
        private System.Windows.Forms.TextBox textBox_C_OUT;
        private System.Windows.Forms.TextBox textBox_Key_OUT;
        private System.Windows.Forms.TextBox textBox_P_OUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.ToolTip toolTip_HEX;
    }
}

