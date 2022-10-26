namespace WindowsFormsApp1
{
	partial class Exec2_Message
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.timeButton1 = new System.Windows.Forms.Button();
			this.timeLabel = new System.Windows.Forms.Label();
			this.timeButton2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timeButton1
			// 
			this.timeButton1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.timeButton1.Location = new System.Drawing.Point(101, 99);
			this.timeButton1.Name = "timeButton1";
			this.timeButton1.Size = new System.Drawing.Size(114, 38);
			this.timeButton1.TabIndex = 0;
			this.timeButton1.Text = "報時１";
			this.timeButton1.UseVisualStyleBackColor = true;
			this.timeButton1.Click += new System.EventHandler(this.timeButton1_Click);
			// 
			// timeLabel
			// 
			this.timeLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.timeLabel.Location = new System.Drawing.Point(12, 18);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(296, 68);
			this.timeLabel.TabIndex = 1;
			this.timeLabel.Text = "timeLabel";
			// 
			// timeButton2
			// 
			this.timeButton2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.timeButton2.Location = new System.Drawing.Point(101, 143);
			this.timeButton2.Name = "timeButton2";
			this.timeButton2.Size = new System.Drawing.Size(114, 38);
			this.timeButton2.TabIndex = 0;
			this.timeButton2.Text = "報時２";
			this.timeButton2.UseVisualStyleBackColor = true;
			this.timeButton2.Click += new System.EventHandler(this.timeButton2_Click);
			// 
			// Exec2_Message
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 249);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.timeButton2);
			this.Controls.Add(this.timeButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Exec2_Message";
			this.Text = "Exec2_Message";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button timeButton1;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Button timeButton2;
	}
}

