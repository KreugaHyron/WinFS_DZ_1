namespace WinFS_DZ_1
{
    partial class MyApplication
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
            ShowMessage = new Button();
            OpenNonModal = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ShowMessage
            // 
            ShowMessage.ForeColor = Color.Black;
            ShowMessage.Location = new Point(39, 148);
            ShowMessage.Name = "ShowMessage";
            ShowMessage.Size = new Size(75, 23);
            ShowMessage.TabIndex = 0;
            ShowMessage.Text = "btnShowMessage";
            ShowMessage.UseVisualStyleBackColor = true;
            ShowMessage.Click += ShowMessage_Click;
            // 
            // OpenNonModal
            // 
            OpenNonModal.ForeColor = Color.Black;
            OpenNonModal.Location = new Point(159, 148);
            OpenNonModal.Name = "OpenNonModal";
            OpenNonModal.Size = new Size(75, 23);
            OpenNonModal.TabIndex = 1;
            OpenNonModal.Text = "Немод.Вікно";
            OpenNonModal.UseVisualStyleBackColor = true;
            OpenNonModal.Click += OpenNonModal_Click;
            // 
            // button1
            // 
            button1.Location = new Point(276, 148);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MyApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(384, 261);
            Controls.Add(button1);
            Controls.Add(OpenNonModal);
            Controls.Add(ShowMessage);
            ForeColor = Color.LightGray;
            Name = "MyApplication";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ShowMessage;
        private Button OpenNonModal;
        private Button button1;
    }
}
