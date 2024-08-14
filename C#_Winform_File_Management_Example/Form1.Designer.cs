namespace C__Winform_File_Management_Example
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
            txtOriginPath = new TextBox();
            lblOriginPath = new Label();
            btnRead = new Button();
            btnSave = new Button();
            btnCopy = new Button();
            btnMove = new Button();
            btnDelete = new Button();
            lblNewPath = new Label();
            txtNewPath = new TextBox();
            txtContent = new TextBox();
            SuspendLayout();
            // 
            // txtOriginPath
            // 
            txtOriginPath.Location = new Point(84, 12);
            txtOriginPath.Name = "txtOriginPath";
            txtOriginPath.Size = new Size(459, 23);
            txtOriginPath.TabIndex = 0;
            // 
            // lblOriginPath
            // 
            lblOriginPath.AutoSize = true;
            lblOriginPath.Location = new Point(12, 16);
            lblOriginPath.Name = "lblOriginPath";
            lblOriginPath.Size = new Size(66, 15);
            lblOriginPath.TabIndex = 1;
            lblOriginPath.Text = "파일 경로 :";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(549, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(125, 23);
            btnRead.TabIndex = 2;
            btnRead.Text = "파일 불러오기";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(549, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "파일 저장하기";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(549, 70);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(125, 23);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "새 경로에 파일 복사";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(549, 99);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(125, 23);
            btnMove.TabIndex = 5;
            btnMove.Text = "새 경로로 파일 이동";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(549, 128);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "파일 삭제하기";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblNewPath
            // 
            lblNewPath.AutoSize = true;
            lblNewPath.Location = new Point(24, 50);
            lblNewPath.Name = "lblNewPath";
            lblNewPath.Size = new Size(54, 15);
            lblNewPath.TabIndex = 7;
            lblNewPath.Text = "새 경로 :";
            // 
            // txtNewPath
            // 
            txtNewPath.Location = new Point(84, 46);
            txtNewPath.Name = "txtNewPath";
            txtNewPath.Size = new Size(459, 23);
            txtNewPath.TabIndex = 8;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 86);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(531, 232);
            txtContent.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 328);
            Controls.Add(txtContent);
            Controls.Add(txtNewPath);
            Controls.Add(lblNewPath);
            Controls.Add(btnDelete);
            Controls.Add(btnMove);
            Controls.Add(btnCopy);
            Controls.Add(btnSave);
            Controls.Add(btnRead);
            Controls.Add(lblOriginPath);
            Controls.Add(txtOriginPath);
            Name = "Form1";
            Text = "eunbyeol.co.kr";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOriginPath;
        private Label lblOriginPath;
        private Button btnRead;
        private Button btnSave;
        private Button btnCopy;
        private Button btnMove;
        private Button btnDelete;
        private Label lblNewPath;
        private TextBox txtNewPath;
        private TextBox txtContent;
    }
}
