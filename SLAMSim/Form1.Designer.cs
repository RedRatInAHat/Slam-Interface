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
            this.button_camera_connection = new System.Windows.Forms.Button();
            this.rgb_pb = new System.Windows.Forms.PictureBox();
            this.depth_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth_pb)).BeginInit();
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
            // button_camera_connection
            // 
            this.button_camera_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_camera_connection.Location = new System.Drawing.Point(12, 360);
            this.button_camera_connection.Name = "button_camera_connection";
            this.button_camera_connection.Size = new System.Drawing.Size(133, 34);
            this.button_camera_connection.TabIndex = 3;
            this.button_camera_connection.Text = "Подключение камеры";
            this.button_camera_connection.UseVisualStyleBackColor = true;
            this.button_camera_connection.Click += new System.EventHandler(this.Button_camera_connection_Click);
            // 
            // rgb_pb
            // 
            this.rgb_pb.Location = new System.Drawing.Point(373, 12);
            this.rgb_pb.Name = "rgb_pb";
            this.rgb_pb.Size = new System.Drawing.Size(719, 618);
            this.rgb_pb.TabIndex = 4;
            this.rgb_pb.TabStop = false;
            // 
            // depth_pb
            // 
            this.depth_pb.Location = new System.Drawing.Point(12, 207);
            this.depth_pb.Name = "depth_pb";
            this.depth_pb.Size = new System.Drawing.Size(247, 147);
            this.depth_pb.TabIndex = 5;
            this.depth_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 642);
            this.Controls.Add(this.depth_pb);
            this.Controls.Add(this.rgb_pb);
            this.Controls.Add(this.button_camera_connection);
            this.Controls.Add(this.button_stop_VREP);
            this.Controls.Add(this.Temp_richBox);
            this.Controls.Add(this.button_start_VREP);
            this.Name = "Form1";
            this.Text = "VREP Sim";
            ((System.ComponentModel.ISupportInitialize)(this.rgb_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start_VREP;
        private System.Windows.Forms.RichTextBox Temp_richBox;
        private System.Windows.Forms.Button button_stop_VREP;
        private System.Windows.Forms.Button button_camera_connection;
        private System.Windows.Forms.PictureBox rgb_pb;
        private System.Windows.Forms.PictureBox depth_pb;
    }
}

