namespace CalorieManager.Forms
{
	partial class UpdateDailyMealForm
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
			this.buttonNew = new System.Windows.Forms.Button();
			this.labelNewActivity = new System.Windows.Forms.Label();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// buttonNew
			// 
			this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonNew.Location = new System.Drawing.Point(166, 193);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(104, 47);
			this.buttonNew.TabIndex = 44;
			this.buttonNew.Text = "Update";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click_1);
			// 
			// labelNewActivity
			// 
			this.labelNewActivity.AutoSize = true;
			this.labelNewActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelNewActivity.Location = new System.Drawing.Point(183, 9);
			this.labelNewActivity.Name = "labelNewActivity";
			this.labelNewActivity.Size = new System.Drawing.Size(76, 31);
			this.labelNewActivity.TabIndex = 37;
			this.labelNewActivity.Text = "Meal";
			// 
			// comboBox
			// 
			this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(135, 92);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(169, 39);
			this.comboBox.TabIndex = 45;
			// 
			// UpdateDailyMealForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 301);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.labelNewActivity);
			this.Name = "UpdateDailyMealForm";
			this.Text = "UpdateDailyMealForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Label labelNewActivity;
		private System.Windows.Forms.ComboBox comboBox;
	}
}