namespace Restore_Resx_Files_from_localizable
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
			this.RunBtn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SourcePathEdit = new System.Windows.Forms.TextBox();
			this.DestPathEdit = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SelectSourceBtn = new System.Windows.Forms.Button();
			this.SelectDestBtn = new System.Windows.Forms.Button();
			this.ResultBox = new System.Windows.Forms.RichTextBox();
			this.ResultGroupBox = new System.Windows.Forms.GroupBox();
			this.ParamsGroupBox = new System.Windows.Forms.GroupBox();
			this.ResultGroupBox.SuspendLayout();
			this.ParamsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// RunBtn
			// 
			this.RunBtn.Location = new System.Drawing.Point(53, 74);
			this.RunBtn.Name = "RunBtn";
			this.RunBtn.Size = new System.Drawing.Size(75, 23);
			this.RunBtn.TabIndex = 0;
			this.RunBtn.Text = "Run";
			this.RunBtn.UseVisualStyleBackColor = true;
			this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// SourcePathEdit
			// 
			this.SourcePathEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SourcePathEdit.Location = new System.Drawing.Point(53, 22);
			this.SourcePathEdit.Name = "SourcePathEdit";
			this.SourcePathEdit.Size = new System.Drawing.Size(650, 20);
			this.SourcePathEdit.TabIndex = 1;
			// 
			// DestPathEdit
			// 
			this.DestPathEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DestPathEdit.Location = new System.Drawing.Point(53, 48);
			this.DestPathEdit.Name = "DestPathEdit";
			this.DestPathEdit.Size = new System.Drawing.Size(650, 20);
			this.DestPathEdit.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "source";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "dest";
			// 
			// SelectSourceBtn
			// 
			this.SelectSourceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectSourceBtn.Location = new System.Drawing.Point(709, 20);
			this.SelectSourceBtn.Name = "SelectSourceBtn";
			this.SelectSourceBtn.Size = new System.Drawing.Size(75, 23);
			this.SelectSourceBtn.TabIndex = 5;
			this.SelectSourceBtn.Text = "...";
			this.SelectSourceBtn.UseVisualStyleBackColor = true;
			this.SelectSourceBtn.Click += new System.EventHandler(this.SelectSourceBtn_Click);
			// 
			// SelectDestBtn
			// 
			this.SelectDestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SelectDestBtn.Location = new System.Drawing.Point(709, 49);
			this.SelectDestBtn.Name = "SelectDestBtn";
			this.SelectDestBtn.Size = new System.Drawing.Size(75, 23);
			this.SelectDestBtn.TabIndex = 6;
			this.SelectDestBtn.Text = "...";
			this.SelectDestBtn.UseVisualStyleBackColor = true;
			this.SelectDestBtn.Click += new System.EventHandler(this.SelectDestBtn_Click);
			// 
			// ResultBox
			// 
			this.ResultBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResultBox.Location = new System.Drawing.Point(8, 21);
			this.ResultBox.Name = "ResultBox";
			this.ResultBox.Size = new System.Drawing.Size(784, 314);
			this.ResultBox.TabIndex = 7;
			this.ResultBox.Text = "";
			// 
			// ResultGroupBox
			// 
			this.ResultGroupBox.Controls.Add(this.ResultBox);
			this.ResultGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResultGroupBox.Location = new System.Drawing.Point(0, 107);
			this.ResultGroupBox.Name = "ResultGroupBox";
			this.ResultGroupBox.Padding = new System.Windows.Forms.Padding(8);
			this.ResultGroupBox.Size = new System.Drawing.Size(800, 343);
			this.ResultGroupBox.TabIndex = 8;
			this.ResultGroupBox.TabStop = false;
			this.ResultGroupBox.Text = "Results";
			// 
			// ParamsGroupBox
			// 
			this.ParamsGroupBox.Controls.Add(this.DestPathEdit);
			this.ParamsGroupBox.Controls.Add(this.RunBtn);
			this.ParamsGroupBox.Controls.Add(this.SelectDestBtn);
			this.ParamsGroupBox.Controls.Add(this.SourcePathEdit);
			this.ParamsGroupBox.Controls.Add(this.SelectSourceBtn);
			this.ParamsGroupBox.Controls.Add(this.label1);
			this.ParamsGroupBox.Controls.Add(this.label2);
			this.ParamsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ParamsGroupBox.Location = new System.Drawing.Point(0, 0);
			this.ParamsGroupBox.Name = "ParamsGroupBox";
			this.ParamsGroupBox.Size = new System.Drawing.Size(800, 107);
			this.ParamsGroupBox.TabIndex = 9;
			this.ParamsGroupBox.TabStop = false;
			this.ParamsGroupBox.Text = "Parameters";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ResultGroupBox);
			this.Controls.Add(this.ParamsGroupBox);
			this.Name = "Form1";
			this.Text = "-";
			this.ResultGroupBox.ResumeLayout(false);
			this.ParamsGroupBox.ResumeLayout(false);
			this.ParamsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button RunBtn;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox SourcePathEdit;
		private System.Windows.Forms.TextBox DestPathEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SelectSourceBtn;
		private System.Windows.Forms.Button SelectDestBtn;
		private System.Windows.Forms.RichTextBox ResultBox;
		private System.Windows.Forms.GroupBox ResultGroupBox;
		private System.Windows.Forms.GroupBox ParamsGroupBox;
	}
}

