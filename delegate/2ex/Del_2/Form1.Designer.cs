﻿namespace Del2
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
            this.btn_Transparency = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Button();
            this.btn_text = new System.Windows.Forms.Button();
            this.btnSetOfActions = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Transparency
            // 
            this.btn_Transparency.Location = new System.Drawing.Point(10, 10);
            this.btn_Transparency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Transparency.Name = "btn_Transparency";
            this.btn_Transparency.Size = new System.Drawing.Size(83, 41);
            this.btn_Transparency.TabIndex = 0;
            this.btn_Transparency.Text = "Прозорість";
            this.btn_Transparency.UseVisualStyleBackColor = true;
            this.btn_Transparency.Click += new System.EventHandler(this.btn_Transparency_Click);
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(134, 10);
            this.background.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(83, 41);
            this.background.TabIndex = 1;
            this.background.Text = "Колір тла";
            this.background.UseVisualStyleBackColor = true;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // btn_text
            // 
            this.btn_text.Location = new System.Drawing.Point(254, 10);
            this.btn_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(77, 41);
            this.btn_text.TabIndex = 2;
            this.btn_text.Text = "HelloWorld";
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            // 
            // btnSetOfActions
            // 
            this.btnSetOfActions.Location = new System.Drawing.Point(50, 64);
            this.btnSetOfActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetOfActions.Name = "btnSetOfActions";
            this.btnSetOfActions.Size = new System.Drawing.Size(254, 93);
            this.btnSetOfActions.TabIndex = 3;
            this.btnSetOfActions.Text = "Супермегакнопка";
            this.btnSetOfActions.UseVisualStyleBackColor = true;
            this.btnSetOfActions.Click += new System.EventHandler(this.btnSetOfActions_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 161);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(246, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "\"супермегакнопка\" поглинає \"Прозорість\"";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 182);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(236, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "\"супермегакнопка\" поглинає \"Колір тла\"";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 203);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(241, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "\"супермегакнопка\" поглинає \"HelloWorld\"";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 295);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSetOfActions);
            this.Controls.Add(this.btn_text);
            this.Controls.Add(this.background);
            this.Controls.Add(this.btn_Transparency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Transparency;
        private System.Windows.Forms.Button background;
        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Button btnSetOfActions;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

