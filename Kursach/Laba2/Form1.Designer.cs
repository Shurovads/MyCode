namespace Laba2
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
            this.txtStartIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.ListBox();
            this.myPort = new System.Windows.Forms.TextBox();
            this.portClient = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.Svetofor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sostoiania = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtStartIP
            // 
            this.txtStartIP.Location = new System.Drawing.Point(12, 18);
            this.txtStartIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStartIP.Name = "txtStartIP";
            this.txtStartIP.ReadOnly = true;
            this.txtStartIP.Size = new System.Drawing.Size(100, 22);
            this.txtStartIP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Message";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(159, 123);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 35);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // richText
            // 
            this.richText.FormattingEnabled = true;
            this.richText.ItemHeight = 16;
            this.richText.Location = new System.Drawing.Point(12, 170);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(338, 260);
            this.richText.TabIndex = 14;
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(12, 61);
            this.myPort.Name = "myPort";
            this.myPort.ReadOnly = true;
            this.myPort.Size = new System.Drawing.Size(100, 22);
            this.myPort.TabIndex = 15;
            this.myPort.Text = "7777";
            // 
            // portClient
            // 
            this.portClient.Location = new System.Drawing.Point(12, 105);
            this.portClient.Name = "portClient";
            this.portClient.ReadOnly = true;
            this.portClient.Size = new System.Drawing.Size(100, 22);
            this.portClient.TabIndex = 16;
            this.portClient.Text = "8888";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(159, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 34);
            this.btnConnect.TabIndex = 19;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Svetofor
            // 
            this.Svetofor.Location = new System.Drawing.Point(159, 74);
            this.Svetofor.Name = "Svetofor";
            this.Svetofor.Size = new System.Drawing.Size(101, 37);
            this.Svetofor.TabIndex = 20;
            this.Svetofor.Text = "Red";
            this.Svetofor.UseVisualStyleBackColor = true;
            this.Svetofor.Click += new System.EventHandler(this.Svetofor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "MyPort";
            // 
            // sostoiania
            // 
            this.sostoiania.FormattingEnabled = true;
            this.sostoiania.ItemHeight = 16;
            this.sostoiania.Location = new System.Drawing.Point(356, 10);
            this.sostoiania.Name = "sostoiania";
            this.sostoiania.Size = new System.Drawing.Size(445, 420);
            this.sostoiania.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 444);
            this.Controls.Add(this.sostoiania);
            this.Controls.Add(this.Svetofor);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portClient);
            this.Controls.Add(this.myPort);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartIP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ShurovaDS221-328";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStartIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ListBox richText;
        private System.Windows.Forms.TextBox myPort;
        private System.Windows.Forms.TextBox portClient;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Button Svetofor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox sostoiania;
    }
}

