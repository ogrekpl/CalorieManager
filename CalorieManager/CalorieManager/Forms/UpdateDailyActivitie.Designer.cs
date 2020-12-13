namespace CalorieManager.Forms
{
	partial class UpdateDailyActivitie
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
			this.inputDescription = new System.Windows.Forms.TextBox();
			this.inputCalories = new System.Windows.Forms.NumericUpDown();
			this.inputName = new System.Windows.Forms.TextBox();
			this.labelCalories = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelNewActivity = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inputCalories)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonNew
			// 
			this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonNew.Location = new System.Drawing.Point(166, 222);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(104, 47);
			this.buttonNew.TabIndex = 36;
			this.buttonNew.Text = "New";
			this.buttonNew.UseVisualStyleBackColor = true;
			// 
			// inputDescription
			// 
			this.inputDescription.Location = new System.Drawing.Point(288, 120);
			this.inputDescription.Name = "inputDescription";
			this.inputDescription.Size = new System.Drawing.Size(120, 20);
			this.inputDescription.TabIndex = 35;
			// 
			// inputCalories
			// 
			this.inputCalories.Location = new System.Drawing.Point(288, 171);
			this.inputCalories.Name = "inputCalories";
			this.inputCalories.Size = new System.Drawing.Size(120, 20);
			this.inputCalories.TabIndex = 34;
			// 
			// inputName
			// 
			this.inputName.Location = new System.Drawing.Point(288, 74);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(120, 20);
			this.inputName.TabIndex = 33;
			// 
			// labelCalories
			// 
			this.labelCalories.AutoSize = true;
			this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelCalories.Location = new System.Drawing.Point(44, 165);
			this.labelCalories.Name = "labelCalories";
			this.labelCalories.Size = new System.Drawing.Size(78, 24);
			this.labelCalories.TabIndex = 32;
			this.labelCalories.Text = "Calories";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelDescription.Location = new System.Drawing.Point(44, 120);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(104, 24);
			this.labelDescription.TabIndex = 31;
			this.labelDescription.Text = "Description";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelName.Location = new System.Drawing.Point(44, 74);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(61, 24);
			this.labelName.TabIndex = 30;
			this.labelName.Text = "Name";
			// 
			// labelNewActivity
			// 
			this.labelNewActivity.AutoSize = true;
			this.labelNewActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelNewActivity.Location = new System.Drawing.Point(129, 9);
			this.labelNewActivity.Name = "labelNewActivity";
			this.labelNewActivity.Size = new System.Drawing.Size(176, 31);
			this.labelNewActivity.TabIndex = 29;
			this.labelNewActivity.Text = "New Activity";
			// 
			// UpdateDailyActivitie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 301);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.inputDescription);
			this.Controls.Add(this.inputCalories);
			this.Controls.Add(this.inputName);
			this.Controls.Add(this.labelCalories);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelNewActivity);
			this.Name = "UpdateDailyActivitie";
			this.Text = "UpdateDailyActivitie";
			((System.ComponentModel.ISupportInitialize)(this.inputCalories)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.TextBox inputDescription;
		private System.Windows.Forms.NumericUpDown inputCalories;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.Label labelCalories;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelNewActivity;
	}
}