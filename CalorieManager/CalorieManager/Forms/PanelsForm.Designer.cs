namespace CalorieManager.Forms
{
	partial class PanelsForm
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
			this.labelDate = new System.Windows.Forms.Label();
			this.buttonAddActivity = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.buttonAddMeal = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelDate.Location = new System.Drawing.Point(104, 71);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(44, 20);
			this.labelDate.TabIndex = 10;
			this.labelDate.Text = "Date";
			// 
			// buttonAddActivity
			// 
			this.buttonAddActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonAddActivity.Location = new System.Drawing.Point(30, 165);
			this.buttonAddActivity.Name = "buttonAddActivity";
			this.buttonAddActivity.Size = new System.Drawing.Size(102, 50);
			this.buttonAddActivity.TabIndex = 9;
			this.buttonAddActivity.Text = "Add Activity";
			this.buttonAddActivity.UseVisualStyleBackColor = true;
			this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(29, 94);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
			this.dateTimePicker1.TabIndex = 8;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// buttonAddMeal
			// 
			this.buttonAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonAddMeal.Location = new System.Drawing.Point(136, 165);
			this.buttonAddMeal.Name = "buttonAddMeal";
			this.buttonAddMeal.Size = new System.Drawing.Size(102, 50);
			this.buttonAddMeal.TabIndex = 7;
			this.buttonAddMeal.Text = "Add Meal";
			this.buttonAddMeal.UseVisualStyleBackColor = true;
			this.buttonAddMeal.Click += new System.EventHandler(this.buttonAddMeal_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Location = new System.Drawing.Point(280, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(406, 577);
			this.panel1.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Location = new System.Drawing.Point(709, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(406, 577);
			this.panel2.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(426, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 25);
			this.label1.TabIndex = 13;
			this.label1.Text = "Meals";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(858, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Activities";
			// 
			// PanelsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1144, 624);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.buttonAddActivity);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.buttonAddMeal);
			this.Name = "PanelsForm";
			this.Text = "dailySummaryForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Button buttonAddActivity;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button buttonAddMeal;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}