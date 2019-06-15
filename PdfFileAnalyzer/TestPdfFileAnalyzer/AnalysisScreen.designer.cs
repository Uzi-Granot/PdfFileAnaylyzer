namespace TestPdfFileAnalyzer
	{
	partial class AnalysisScreen
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
			this.ButtonsGroupBox = new System.Windows.Forms.GroupBox();
			this.ViewButton = new System.Windows.Forms.Button();
			this.SummaryButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.ButtonsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonsGroupBox
			// 
			this.ButtonsGroupBox.Controls.Add(this.ViewButton);
			this.ButtonsGroupBox.Controls.Add(this.SummaryButton);
			this.ButtonsGroupBox.Controls.Add(this.ExitButton);
			this.ButtonsGroupBox.Location = new System.Drawing.Point(140, 410);
			this.ButtonsGroupBox.Name = "ButtonsGroupBox";
			this.ButtonsGroupBox.Size = new System.Drawing.Size(375, 74);
			this.ButtonsGroupBox.TabIndex = 0;
			this.ButtonsGroupBox.TabStop = false;
			// 
			// ViewButton
			// 
			this.ViewButton.Location = new System.Drawing.Point(26, 22);
			this.ViewButton.Name = "ViewButton";
			this.ViewButton.Size = new System.Drawing.Size(88, 36);
			this.ViewButton.TabIndex = 0;
			this.ViewButton.Text = "View";
			this.ViewButton.UseVisualStyleBackColor = true;
			this.ViewButton.Click += new System.EventHandler(this.OnView);
			// 
			// SummaryButton
			// 
			this.SummaryButton.Location = new System.Drawing.Point(143, 22);
			this.SummaryButton.Name = "SummaryButton";
			this.SummaryButton.Size = new System.Drawing.Size(88, 36);
			this.SummaryButton.TabIndex = 1;
			this.SummaryButton.Text = "Summary";
			this.SummaryButton.UseVisualStyleBackColor = true;
			this.SummaryButton.Click += new System.EventHandler(this.OnSummary);
			// 
			// ExitButton
			// 
			this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ExitButton.Location = new System.Drawing.Point(260, 22);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(88, 36);
			this.ExitButton.TabIndex = 2;
			this.ExitButton.Text = "Close";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.OnExit);
			// 
			// PdfFileAnalyzer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(655, 508);
			this.Controls.Add(this.ButtonsGroupBox);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PdfFileAnalyzer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PDF File Analayzer";
			this.Load += new System.EventHandler(this.OnLoad);
			this.Resize += new System.EventHandler(this.OnResize);
			this.ButtonsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.GroupBox ButtonsGroupBox;
		private System.Windows.Forms.Button ViewButton;
		private System.Windows.Forms.Button SummaryButton;
		private System.Windows.Forms.Button ExitButton;
		}
	}
