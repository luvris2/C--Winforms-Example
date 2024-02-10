namespace C__Winform_StartUp_With_Window_Example
{
    partial class Form1
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
            btnStartUpOn = new Button();
            btnStartUpOff = new Button();
            SuspendLayout();
            // 
            // btnStartUpOn
            // 
            btnStartUpOn.Location = new Point(12, 12);
            btnStartUpOn.Name = "btnStartUpOn";
            btnStartUpOn.Size = new Size(154, 23);
            btnStartUpOn.TabIndex = 0;
            btnStartUpOn.Text = "윈도우 시작 시 자동 실행";
            btnStartUpOn.UseVisualStyleBackColor = true;
            btnStartUpOn.Click += btnStartUpOn_Click;
            // 
            // btnStartUpOff
            // 
            btnStartUpOff.Location = new Point(12, 41);
            btnStartUpOff.Name = "btnStartUpOff";
            btnStartUpOff.Size = new Size(154, 23);
            btnStartUpOff.TabIndex = 1;
            btnStartUpOff.Text = "자동 실행 하지 않음";
            btnStartUpOff.UseVisualStyleBackColor = true;
            btnStartUpOff.Click += btnStartUpOff_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(178, 72);
            Controls.Add(btnStartUpOff);
            Controls.Add(btnStartUpOn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartUpOn;
        private Button btnStartUpOff;
    }
}
