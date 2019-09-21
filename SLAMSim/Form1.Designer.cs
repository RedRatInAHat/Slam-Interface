namespace SLAMSim
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
            this.button_start_VREP = new System.Windows.Forms.Button();
            this.Temp_richBox = new System.Windows.Forms.RichTextBox();
            this.button_stop_VREP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start_VREP
            // 
            this.button_start_VREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start_VREP.Location = new System.Drawing.Point(12, 22);
            this.button_start_VREP.Name = "button_start_VREP";
            this.button_start_VREP.Size = new System.Drawing.Size(131, 34);
            this.button_start_VREP.TabIndex = 0;
            this.button_start_VREP.Text = "Start VREP";
            this.button_start_VREP.UseVisualStyleBackColor = true;
            this.button_start_VREP.Click += new System.EventHandler(this.Button_start_VREP_Click);
            // 
            // Temp_richBox
            // 
            this.Temp_richBox.Location = new System.Drawing.Point(12, 111);
            this.Temp_richBox.Name = "Temp_richBox";
            this.Temp_richBox.Size = new System.Drawing.Size(355, 94);
            this.Temp_richBox.TabIndex = 1;
            this.Temp_richBox.Text = "";
            // 
            // button_stop_VREP
            // 
            this.button_stop_VREP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop_VREP.Location = new System.Drawing.Point(12, 62);
            this.button_stop_VREP.Name = "button_stop_VREP";
            this.button_stop_VREP.Size = new System.Drawing.Size(131, 34);
            this.button_stop_VREP.TabIndex = 2;
            this.button_stop_VREP.Text = "Stop VREP";
            this.button_stop_VREP.UseVisualStyleBackColor = true;
            this.button_stop_VREP.Click += new System.EventHandler(this.Button_stop_VREP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 433);
            this.Controls.Add(this.button_stop_VREP);
            this.Controls.Add(this.Temp_richBox);
            this.Controls.Add(this.button_start_VREP);
            this.Name = "Form1";
            this.Text = "VREP Sim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start_VREP;
        private System.Windows.Forms.RichTextBox Temp_richBox;
        private System.Windows.Forms.Button button_stop_VREP;
    }
}

