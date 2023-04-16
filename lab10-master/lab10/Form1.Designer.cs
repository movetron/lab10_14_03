namespace lab10_14_03
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
        /// <param name="dispos">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool dispos)
        {
            if (dispos && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(dispos);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArray = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(113, 52);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(553, 172);
            this.txtArray.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(566, 317);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 31);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Вычислить";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Button btnCalc;
    }
}

