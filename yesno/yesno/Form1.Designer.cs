namespace yesno
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
            this.label1 = new System.Windows.Forms.Label();
            this.btGetAnswer = new System.Windows.Forms.Button();
            this.btAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Should I go to the university today?";
            // 
            // btGetAnswer
            // 
            this.btGetAnswer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btGetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGetAnswer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btGetAnswer.Location = new System.Drawing.Point(248, 94);
            this.btGetAnswer.Name = "btGetAnswer";
            this.btGetAnswer.Size = new System.Drawing.Size(140, 54);
            this.btGetAnswer.TabIndex = 1;
            this.btGetAnswer.Text = "answer";
            this.btGetAnswer.UseVisualStyleBackColor = false;
            this.btGetAnswer.Click += new System.EventHandler(this.btGetAnswer_Click);
            // 
            // btAnswer
            // 
            this.btAnswer.BackColor = System.Drawing.Color.Aquamarine;
            this.btAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnswer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAnswer.Location = new System.Drawing.Point(222, 189);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(193, 102);
            this.btAnswer.TabIndex = 2;
            this.btAnswer.Text = "null";
            this.btAnswer.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 318);
            this.Controls.Add(this.btAnswer);
            this.Controls.Add(this.btGetAnswer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGetAnswer;
        private System.Windows.Forms.Button btAnswer;
    }
}

