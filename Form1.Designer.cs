
namespace GitHub_Badge_Generator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.message = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.badgeLink = new System.Windows.Forms.Label();
			this.badgeDisplay = new System.Windows.Forms.WebBrowser();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.message);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 125);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(104, 90);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(370, 27);
			this.comboBox1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Roboto", 10F);
			this.label3.Location = new System.Drawing.Point(11, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Badge Color:";
			// 
			// message
			// 
			this.message.Location = new System.Drawing.Point(113, 57);
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(361, 27);
			this.message.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto", 10F);
			this.label2.Location = new System.Drawing.Point(11, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Message Text:";
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(91, 24);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(383, 27);
			this.label.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 10F);
			this.label1.Location = new System.Drawing.Point(11, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Label Text:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(480, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "Generate Badge";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// badgeLink
			// 
			this.badgeLink.Font = new System.Drawing.Font("Roboto", 12F);
			this.badgeLink.Location = new System.Drawing.Point(12, 188);
			this.badgeLink.Name = "badgeLink";
			this.badgeLink.Size = new System.Drawing.Size(480, 38);
			this.badgeLink.TabIndex = 3;
			this.badgeLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.badgeLink.Click += new System.EventHandler(this.badgeLink_Click);
			// 
			// badgeDisplay
			// 
			this.badgeDisplay.AllowWebBrowserDrop = false;
			this.badgeDisplay.IsWebBrowserContextMenuEnabled = false;
			this.badgeDisplay.Location = new System.Drawing.Point(12, 229);
			this.badgeDisplay.MinimumSize = new System.Drawing.Size(20, 20);
			this.badgeDisplay.Name = "badgeDisplay";
			this.badgeDisplay.ScriptErrorsSuppressed = true;
			this.badgeDisplay.ScrollBarsEnabled = false;
			this.badgeDisplay.Size = new System.Drawing.Size(480, 29);
			this.badgeDisplay.TabIndex = 4;
			this.badgeDisplay.WebBrowserShortcutsEnabled = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 270);
			this.Controls.Add(this.badgeDisplay);
			this.Controls.Add(this.badgeLink);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GitHub Badge Generator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox label;
		private System.Windows.Forms.TextBox message;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label badgeLink;
		private System.Windows.Forms.WebBrowser badgeDisplay;
	}
}

