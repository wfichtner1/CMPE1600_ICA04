namespace CMPE1600_ICA04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_AddButton = new System.Windows.Forms.Button();
            this.UI_DeleteButton = new System.Windows.Forms.Button();
            this.UI_LoadFileButton = new System.Windows.Forms.Button();
            this.UI_SaveFileButton = new System.Windows.Forms.Button();
            this.UI_InputBox = new System.Windows.Forms.TextBox();
            this.UI_ListBox = new System.Windows.Forms.ListBox();
            this.UI_TrackBar = new System.Windows.Forms.TrackBar();
            this.UI_SelectedLabel = new System.Windows.Forms.Label();
            this.UI_ListLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_AddButton
            // 
            this.UI_AddButton.Location = new System.Drawing.Point(12, 38);
            this.UI_AddButton.Name = "UI_AddButton";
            this.UI_AddButton.Size = new System.Drawing.Size(75, 23);
            this.UI_AddButton.TabIndex = 1;
            this.UI_AddButton.Text = "Add";
            this.UI_AddButton.UseVisualStyleBackColor = true;
            this.UI_AddButton.Click += new System.EventHandler(this.UI_AddButton_Click);
            // 
            // UI_DeleteButton
            // 
            this.UI_DeleteButton.Location = new System.Drawing.Point(12, 67);
            this.UI_DeleteButton.Name = "UI_DeleteButton";
            this.UI_DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.UI_DeleteButton.TabIndex = 2;
            this.UI_DeleteButton.Text = "Delete";
            this.UI_DeleteButton.UseVisualStyleBackColor = true;
            this.UI_DeleteButton.Click += new System.EventHandler(this.UI_DeleteButton_Click);
            // 
            // UI_LoadFileButton
            // 
            this.UI_LoadFileButton.Location = new System.Drawing.Point(12, 96);
            this.UI_LoadFileButton.Name = "UI_LoadFileButton";
            this.UI_LoadFileButton.Size = new System.Drawing.Size(75, 23);
            this.UI_LoadFileButton.TabIndex = 3;
            this.UI_LoadFileButton.Text = "Load File";
            this.UI_LoadFileButton.UseVisualStyleBackColor = true;
            this.UI_LoadFileButton.Click += new System.EventHandler(this.UI_LoadFileButton_Click);
            // 
            // UI_SaveFileButton
            // 
            this.UI_SaveFileButton.Location = new System.Drawing.Point(12, 125);
            this.UI_SaveFileButton.Name = "UI_SaveFileButton";
            this.UI_SaveFileButton.Size = new System.Drawing.Size(75, 23);
            this.UI_SaveFileButton.TabIndex = 4;
            this.UI_SaveFileButton.Text = "Save File";
            this.UI_SaveFileButton.UseVisualStyleBackColor = true;
            this.UI_SaveFileButton.Click += new System.EventHandler(this.UI_SaveFileButton_Click);
            // 
            // UI_InputBox
            // 
            this.UI_InputBox.Location = new System.Drawing.Point(12, 12);
            this.UI_InputBox.Name = "UI_InputBox";
            this.UI_InputBox.Size = new System.Drawing.Size(100, 20);
            this.UI_InputBox.TabIndex = 0;
            // 
            // UI_ListBox
            // 
            this.UI_ListBox.FormattingEnabled = true;
            this.UI_ListBox.Location = new System.Drawing.Point(118, 12);
            this.UI_ListBox.Name = "UI_ListBox";
            this.UI_ListBox.Size = new System.Drawing.Size(120, 95);
            this.UI_ListBox.TabIndex = 6;
            this.UI_ListBox.SelectedIndexChanged += new System.EventHandler(this.UI_ListBox_SelectedIndexChanged);
            // 
            // UI_TrackBar
            // 
            this.UI_TrackBar.Location = new System.Drawing.Point(244, 12);
            this.UI_TrackBar.Maximum = 0;
            this.UI_TrackBar.Name = "UI_TrackBar";
            this.UI_TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.UI_TrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_TrackBar.Size = new System.Drawing.Size(45, 109);
            this.UI_TrackBar.TabIndex = 5;
            this.UI_TrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // UI_SelectedLabel
            // 
            this.UI_SelectedLabel.AutoSize = true;
            this.UI_SelectedLabel.Location = new System.Drawing.Point(115, 135);
            this.UI_SelectedLabel.Name = "UI_SelectedLabel";
            this.UI_SelectedLabel.Size = new System.Drawing.Size(75, 13);
            this.UI_SelectedLabel.TabIndex = 7;
            this.UI_SelectedLabel.Text = "Selected Item:";
            // 
            // UI_ListLabel
            // 
            this.UI_ListLabel.AutoSize = true;
            this.UI_ListLabel.Location = new System.Drawing.Point(203, 135);
            this.UI_ListLabel.Name = "UI_ListLabel";
            this.UI_ListLabel.Size = new System.Drawing.Size(0, 13);
            this.UI_ListLabel.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files|*.txt";
            // 
            // Form1
            // 
            this.AcceptButton = this.UI_AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 181);
            this.Controls.Add(this.UI_ListLabel);
            this.Controls.Add(this.UI_SelectedLabel);
            this.Controls.Add(this.UI_TrackBar);
            this.Controls.Add(this.UI_ListBox);
            this.Controls.Add(this.UI_InputBox);
            this.Controls.Add(this.UI_SaveFileButton);
            this.Controls.Add(this.UI_LoadFileButton);
            this.Controls.Add(this.UI_DeleteButton);
            this.Controls.Add(this.UI_AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_AddButton;
        private System.Windows.Forms.Button UI_DeleteButton;
        private System.Windows.Forms.Button UI_LoadFileButton;
        private System.Windows.Forms.Button UI_SaveFileButton;
        private System.Windows.Forms.TextBox UI_InputBox;
        private System.Windows.Forms.ListBox UI_ListBox;
        private System.Windows.Forms.TrackBar UI_TrackBar;
        private System.Windows.Forms.Label UI_SelectedLabel;
        private System.Windows.Forms.Label UI_ListLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

