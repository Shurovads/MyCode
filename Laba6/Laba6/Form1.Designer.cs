namespace Laba6
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.richText = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.myPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portClient = new System.Windows.Forms.TextBox();
            this.PointcheckBox = new System.Windows.Forms.CheckBox();
            this.LinecheckBox = new System.Windows.Forms.CheckBox();
            this.TrakingcheckBox = new System.Windows.Forms.CheckBox();
            this.ClustercheckBox = new System.Windows.Forms.CheckBox();
            this.WallscheckBox = new System.Windows.Forms.CheckBox();
            this.txtStartIP = new System.Windows.Forms.TextBox();
            this.MyMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(528, 1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(567, 518);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // richText
            // 
            this.richText.FormattingEnabled = true;
            this.richText.ItemHeight = 16;
            this.richText.Location = new System.Drawing.Point(1, 1);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(231, 276);
            this.richText.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(238, 1);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(139, 276);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(383, 1);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(139, 276);
            this.listBox3.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1, 283);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 42);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(82, 283);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 42);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Stop";
            this.BtnSend.UseVisualStyleBackColor = true;
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(163, 283);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 42);
            this.PauseBtn.TabIndex = 6;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(3, 345);
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(124, 22);
            this.myPort.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "myPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "portClient";
            // 
            // portClient
            // 
            this.portClient.Location = new System.Drawing.Point(124, 385);
            this.portClient.Name = "portClient";
            this.portClient.Size = new System.Drawing.Size(100, 22);
            this.portClient.TabIndex = 11;
            // 
            // PointcheckBox
            // 
            this.PointcheckBox.AutoSize = true;
            this.PointcheckBox.Location = new System.Drawing.Point(8, 417);
            this.PointcheckBox.Name = "PointcheckBox";
            this.PointcheckBox.Size = new System.Drawing.Size(59, 20);
            this.PointcheckBox.TabIndex = 12;
            this.PointcheckBox.Text = "Point";
            this.PointcheckBox.UseVisualStyleBackColor = true;
            // 
            // LinecheckBox
            // 
            this.LinecheckBox.AutoSize = true;
            this.LinecheckBox.Location = new System.Drawing.Point(93, 417);
            this.LinecheckBox.Name = "LinecheckBox";
            this.LinecheckBox.Size = new System.Drawing.Size(54, 20);
            this.LinecheckBox.TabIndex = 13;
            this.LinecheckBox.Text = "Line";
            this.LinecheckBox.UseVisualStyleBackColor = true;
            // 
            // TrakingcheckBox
            // 
            this.TrakingcheckBox.AutoSize = true;
            this.TrakingcheckBox.Location = new System.Drawing.Point(163, 417);
            this.TrakingcheckBox.Name = "TrakingcheckBox";
            this.TrakingcheckBox.Size = new System.Drawing.Size(82, 20);
            this.TrakingcheckBox.TabIndex = 14;
            this.TrakingcheckBox.Text = "Tracking";
            this.TrakingcheckBox.UseVisualStyleBackColor = true;
            // 
            // ClustercheckBox
            // 
            this.ClustercheckBox.AutoSize = true;
            this.ClustercheckBox.Location = new System.Drawing.Point(8, 443);
            this.ClustercheckBox.Name = "ClustercheckBox";
            this.ClustercheckBox.Size = new System.Drawing.Size(70, 20);
            this.ClustercheckBox.TabIndex = 15;
            this.ClustercheckBox.Text = "Cluster";
            this.ClustercheckBox.UseVisualStyleBackColor = true;
            // 
            // WallscheckBox
            // 
            this.WallscheckBox.AutoSize = true;
            this.WallscheckBox.Location = new System.Drawing.Point(94, 443);
            this.WallscheckBox.Name = "WallscheckBox";
            this.WallscheckBox.Size = new System.Drawing.Size(63, 20);
            this.WallscheckBox.TabIndex = 16;
            this.WallscheckBox.Text = "Walls";
            this.WallscheckBox.UseVisualStyleBackColor = true;
            // 
            // txtStartIP
            // 
            this.txtStartIP.Location = new System.Drawing.Point(316, 401);
            this.txtStartIP.Name = "txtStartIP";
            this.txtStartIP.Size = new System.Drawing.Size(100, 22);
            this.txtStartIP.TabIndex = 17;
            // 
            // MyMessage
            // 
            this.MyMessage.Location = new System.Drawing.Point(316, 440);
            this.MyMessage.Name = "MyMessage";
            this.MyMessage.Size = new System.Drawing.Size(100, 22);
            this.MyMessage.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 521);
            this.Controls.Add(this.MyMessage);
            this.Controls.Add(this.txtStartIP);
            this.Controls.Add(this.WallscheckBox);
            this.Controls.Add(this.ClustercheckBox);
            this.Controls.Add(this.TrakingcheckBox);
            this.Controls.Add(this.LinecheckBox);
            this.Controls.Add(this.PointcheckBox);
            this.Controls.Add(this.portClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myPort);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "ShurovaDS_221-328";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ListBox richText;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.TextBox myPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portClient;
        private System.Windows.Forms.CheckBox PointcheckBox;
        private System.Windows.Forms.CheckBox LinecheckBox;
        private System.Windows.Forms.CheckBox TrakingcheckBox;
        private System.Windows.Forms.CheckBox ClustercheckBox;
        private System.Windows.Forms.CheckBox WallscheckBox;
        private System.Windows.Forms.TextBox txtStartIP;
        private System.Windows.Forms.TextBox MyMessage;
    }
}

