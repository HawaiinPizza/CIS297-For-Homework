namespace god_damn_it_all_to_hifil
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
            this.Income = new System.Windows.Forms.TextBox();
            this.Detuctions = new System.Windows.Forms.TextBox();
            this.Sumbit = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(84, 58);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(213, 20);
            this.Income.TabIndex = 0;
            this.Income.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Detuctions
            // 
            this.Detuctions.Location = new System.Drawing.Point(84, 106);
            this.Detuctions.Name = "Detuctions";
            this.Detuctions.Size = new System.Drawing.Size(213, 20);
            this.Detuctions.TabIndex = 1;
            // 
            // Sumbit
            // 
            this.Sumbit.Location = new System.Drawing.Point(420, 58);
            this.Sumbit.Name = "Sumbit";
            this.Sumbit.Size = new System.Drawing.Size(299, 68);
            this.Sumbit.TabIndex = 2;
            this.Sumbit.Text = "Sumbit Taxes(if dectuion is empty than assume it\'s 12200)";
            this.Sumbit.UseVisualStyleBackColor = true;
            this.Sumbit.Click += new System.EventHandler(this.Sumbit_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(191, 213);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(438, 178);
            this.Output.TabIndex = 3;
            this.Output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detuctions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Sumbit);
            this.Controls.Add(this.Detuctions);
            this.Controls.Add(this.Income);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Income;
        private System.Windows.Forms.TextBox Detuctions;
        private System.Windows.Forms.Button Sumbit;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

