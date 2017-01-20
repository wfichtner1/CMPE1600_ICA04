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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.UI_SelectedLabel = new System.Windows.Forms.Label();
            this.UI_ListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_AddButton
            // 
            this.UI_AddButton.Location = new System.Drawing.Point(12, 38);
            this.UI_AddButton.Name = "UI_AddButton";
            this.UI_AddButton.Size = new System.Drawing.Size(75, 23);
            this.UI_AddButton.TabIndex = 0;
            this.UI_AddButton.Text = "Add";
            this.UI_AddButton.UseVisualStyleBackColor = true;
            // 
            // UI_DeleteButton
            // 
            this.UI_DeleteButton.Location = new System.Drawing.Point(12, 67);
            this.UI_DeleteButton.Name = "UI_DeleteButton";
            this.UI_DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.UI_DeleteButton.TabIndex = 1;
            this.UI_DeleteButton.Text = "Delete";
            this.UI_DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UI_LoadFileButton
            // 
            this.UI_LoadFileButton.Location = new System.Drawing.Point(12, 96);
            this.UI_LoadFileButton.Name = "UI_LoadFileButton";
            this.UI_LoadFileButton.Size = new System.Drawing.Size(75, 23);
            this.UI_LoadFileButton.TabIndex = 2;
            this.UI_LoadFileButton.Text = "Load File";
            this.UI_LoadFileButton.UseVisualStyleBackColor = true;
            // 
            // UI_SaveFileButton
            // 
            this.UI_SaveFileButton.Location = new System.Drawing.Point(12, 125);
            this.UI_SaveFileButton.Name = "UI_SaveFileButton";
            this.UI_SaveFileButton.Size = new System.Drawing.Size(75, 23);
            this.UI_SaveFileButton.TabIndex = 3;
            this.UI_SaveFileButton.Text = "Save File";
            this.UI_SaveFileButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(118, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(244, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 109);
            this.trackBar1.TabIndex = 6;
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
            this.UI_ListLabel.Size = new System.Drawing.Size(35, 13);
            this.UI_ListLabel.TabIndex = 8;
            this.UI_ListLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 181);
            this.Controls.Add(this.UI_ListLabel);
            this.Controls.Add(this.UI_SelectedLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UI_SaveFileButton);
            this.Controls.Add(this.UI_LoadFileButton);
            this.Controls.Add(this.UI_DeleteButton);
            this.Controls.Add(this.UI_AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_AddButton;
        private System.Windows.Forms.Button UI_DeleteButton;
        private System.Windows.Forms.Button UI_LoadFileButton;
        private System.Windows.Forms.Button UI_SaveFileButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label UI_SelectedLabel;
        private System.Windows.Forms.Label UI_ListLabel;
    }
}

