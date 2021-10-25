
namespace FolderPermissionsExporter
{
	partial class MainForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonSelectFolder = new System.Windows.Forms.Button();
			this.labelSelectedFolder = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(226, 34);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.PlaceholderText = " domain\\username";
			this.textBox1.Size = new System.Drawing.Size(330, 27);
			this.textBox1.TabIndex = 0;
			this.textBox1.Visible = false;
			// 
			// buttonSelectFolder
			// 
			this.buttonSelectFolder.Location = new System.Drawing.Point(13, 14);
			this.buttonSelectFolder.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSelectFolder.Name = "buttonSelectFolder";
			this.buttonSelectFolder.Size = new System.Drawing.Size(205, 47);
			this.buttonSelectFolder.TabIndex = 1;
			this.buttonSelectFolder.Text = "Select Folder to Scan";
			this.buttonSelectFolder.UseVisualStyleBackColor = true;
			this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
			// 
			// labelSelectedFolder
			// 
			this.labelSelectedFolder.AutoSize = true;
			this.labelSelectedFolder.Location = new System.Drawing.Point(13, 65);
			this.labelSelectedFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelSelectedFolder.Name = "labelSelectedFolder";
			this.labelSelectedFolder.Size = new System.Drawing.Size(168, 18);
			this.labelSelectedFolder.TabIndex = 2;
			this.labelSelectedFolder.Text = "labelSelectedFolder";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(225, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Credentials: (None = Current User)";
			this.label1.Visible = false;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(13, 103);
			this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(101, 18);
			this.labelStatus.TabIndex = 2;
			this.labelStatus.Text = "labelStatus";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 134);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.labelSelectedFolder);
			this.Controls.Add(this.buttonSelectFolder);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonSelectFolder;
		private System.Windows.Forms.Label labelSelectedFolder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelStatus;
	}
}

