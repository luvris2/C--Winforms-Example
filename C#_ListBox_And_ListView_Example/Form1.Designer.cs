namespace C__ListBox_And_ListView_Example
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
            listBox1 = new ListBox();
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            lblListBox = new Label();
            groupBox1 = new GroupBox();
            radioTile = new RadioButton();
            radioDetail = new RadioButton();
            radioList = new RadioButton();
            radioIconS = new RadioButton();
            radioIconL = new RadioButton();
            lblListView = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(222, 124);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(283, 28);
            listView1.Name = "listView1";
            listView1.Size = new Size(237, 142);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "ListBox";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "ListView";
            // 
            // lblListBox
            // 
            lblListBox.AutoSize = true;
            lblListBox.Location = new Point(12, 155);
            lblListBox.Name = "lblListBox";
            lblListBox.Size = new Size(147, 15);
            lblListBox.TabIndex = 4;
            lblListBox.Text = "리스트박스에서 항목 선택";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioTile);
            groupBox1.Controls.Add(radioDetail);
            groupBox1.Controls.Add(radioList);
            groupBox1.Controls.Add(radioIconS);
            groupBox1.Controls.Add(radioIconL);
            groupBox1.Location = new Point(526, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(106, 156);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "보기";
            // 
            // radioTile
            // 
            radioTile.AutoSize = true;
            radioTile.Location = new Point(6, 122);
            radioTile.Name = "radioTile";
            radioTile.Size = new Size(49, 19);
            radioTile.TabIndex = 4;
            radioTile.TabStop = true;
            radioTile.Text = "타일";
            radioTile.UseVisualStyleBackColor = true;
            radioTile.CheckedChanged += radioTile_CheckedChanged;
            // 
            // radioDetail
            // 
            radioDetail.AutoSize = true;
            radioDetail.Location = new Point(6, 97);
            radioDetail.Name = "radioDetail";
            radioDetail.Size = new Size(61, 19);
            radioDetail.TabIndex = 3;
            radioDetail.TabStop = true;
            radioDetail.Text = "자세히";
            radioDetail.UseVisualStyleBackColor = true;
            radioDetail.CheckedChanged += radioDetail_CheckedChanged;
            // 
            // radioList
            // 
            radioList.AutoSize = true;
            radioList.Location = new Point(6, 72);
            radioList.Name = "radioList";
            radioList.Size = new Size(61, 19);
            radioList.TabIndex = 2;
            radioList.TabStop = true;
            radioList.Text = "리스트";
            radioList.UseVisualStyleBackColor = true;
            radioList.CheckedChanged += radioList_CheckedChanged;
            // 
            // radioIconS
            // 
            radioIconS.AutoSize = true;
            radioIconS.Location = new Point(6, 47);
            radioIconS.Name = "radioIconS";
            radioIconS.Size = new Size(89, 19);
            radioIconS.TabIndex = 1;
            radioIconS.TabStop = true;
            radioIconS.Text = "작은 아이콘";
            radioIconS.UseVisualStyleBackColor = true;
            radioIconS.CheckedChanged += radioIconS_CheckedChanged;
            // 
            // radioIconL
            // 
            radioIconL.AutoSize = true;
            radioIconL.Location = new Point(6, 22);
            radioIconL.Name = "radioIconL";
            radioIconL.Size = new Size(77, 19);
            radioIconL.TabIndex = 0;
            radioIconL.TabStop = true;
            radioIconL.Text = "큰 아이콘";
            radioIconL.UseVisualStyleBackColor = true;
            radioIconL.CheckedChanged += radioIconL_CheckedChanged;
            // 
            // lblListView
            // 
            lblListView.AutoSize = true;
            lblListView.Location = new Point(283, 175);
            lblListView.Name = "lblListView";
            lblListView.Size = new Size(135, 15);
            lblListView.TabIndex = 7;
            lblListView.Text = "리스트뷰에서 항목 선택";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 200);
            Controls.Add(lblListView);
            Controls.Add(groupBox1);
            Controls.Add(lblListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label lblListBox;
        private GroupBox groupBox1;
        private RadioButton radioIconS;
        private RadioButton radioIconL;
        private RadioButton radioTile;
        private RadioButton radioDetail;
        private RadioButton radioList;
        private Label lblListView;
    }
}