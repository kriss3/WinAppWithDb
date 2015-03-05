namespace WinApp
{
	partial class MyForm
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
			this.btnGetConnString = new System.Windows.Forms.Button();
			this.nString = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGetConnString
			// 
			this.btnGetConnString.Location = new System.Drawing.Point(12, 12);
			this.btnGetConnString.Name = "btnGetConnString";
			this.btnGetConnString.Size = new System.Drawing.Size(161, 23);
			this.btnGetConnString.TabIndex = 0;
			this.btnGetConnString.Text = "Get ConnectionString";
			this.btnGetConnString.UseVisualStyleBackColor = true;
			this.btnGetConnString.Click += new System.EventHandler(this.btnGetConnString_Click);
			// 
			// nString
			// 
			this.nString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nString.Location = new System.Drawing.Point(12, 58);
			this.nString.Name = "nString";
			this.nString.Size = new System.Drawing.Size(100, 23);
			this.nString.TabIndex = 1;
			this.nString.Text = "My ConnString";
			this.nString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblStatus
			// 
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblStatus.Location = new System.Drawing.Point(12, 96);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(100, 23);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.Text = "Status";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 185);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.nString);
			this.Controls.Add(this.btnGetConnString);
			this.Name = "MyForm";
			this.Text = "My DB to SQL";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGetConnString;
		private System.Windows.Forms.Label nString;
		private System.Windows.Forms.Label lblStatus;
	}
}

