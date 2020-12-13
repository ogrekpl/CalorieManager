namespace CalorieManager.Forms
{
	partial class AddMealForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelProteins = new System.Windows.Forms.Label();
            this.labelCarbohydrates = new System.Windows.Forms.Label();
            this.labelFats = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputCalories = new System.Windows.Forms.NumericUpDown();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.inputProteins = new System.Windows.Forms.NumericUpDown();
            this.inputCarbohydrates = new System.Windows.Forms.NumericUpDown();
            this.inputFats = new System.Windows.Forms.NumericUpDown();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputProteins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCarbohydrates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputFats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Meal";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(72, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 24);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(72, 115);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(104, 24);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCalories.Location = new System.Drawing.Point(72, 160);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(78, 24);
            this.labelCalories.TabIndex = 4;
            this.labelCalories.Text = "Calories";
            // 
            // labelProteins
            // 
            this.labelProteins.AutoSize = true;
            this.labelProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProteins.Location = new System.Drawing.Point(72, 211);
            this.labelProteins.Name = "labelProteins";
            this.labelProteins.Size = new System.Drawing.Size(78, 24);
            this.labelProteins.TabIndex = 5;
            this.labelProteins.Text = "Proteins";
            // 
            // labelCarbohydrates
            // 
            this.labelCarbohydrates.AutoSize = true;
            this.labelCarbohydrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCarbohydrates.Location = new System.Drawing.Point(72, 257);
            this.labelCarbohydrates.Name = "labelCarbohydrates";
            this.labelCarbohydrates.Size = new System.Drawing.Size(132, 24);
            this.labelCarbohydrates.TabIndex = 6;
            this.labelCarbohydrates.Text = "Carbohydrates";
            // 
            // labelFats
            // 
            this.labelFats.AutoSize = true;
            this.labelFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFats.Location = new System.Drawing.Point(72, 301);
            this.labelFats.Name = "labelFats";
            this.labelFats.Size = new System.Drawing.Size(45, 24);
            this.labelFats.TabIndex = 7;
            this.labelFats.Text = "Fats";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(316, 69);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(120, 20);
            this.inputName.TabIndex = 8;
            // 
            // inputCalories
            // 
            this.inputCalories.Location = new System.Drawing.Point(316, 166);
            this.inputCalories.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.inputCalories.Name = "inputCalories";
            this.inputCalories.Size = new System.Drawing.Size(120, 20);
            this.inputCalories.TabIndex = 9;
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(316, 115);
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(120, 20);
            this.inputDescription.TabIndex = 10;
            // 
            // inputProteins
            // 
            this.inputProteins.Location = new System.Drawing.Point(316, 217);
            this.inputProteins.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputProteins.Name = "inputProteins";
            this.inputProteins.Size = new System.Drawing.Size(120, 20);
            this.inputProteins.TabIndex = 11;
            // 
            // inputCarbohydrates
            // 
            this.inputCarbohydrates.Location = new System.Drawing.Point(316, 263);
            this.inputCarbohydrates.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputCarbohydrates.Name = "inputCarbohydrates";
            this.inputCarbohydrates.Size = new System.Drawing.Size(120, 20);
            this.inputCarbohydrates.TabIndex = 12;
            // 
            // inputFats
            // 
            this.inputFats.Location = new System.Drawing.Point(316, 307);
            this.inputFats.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inputFats.Name = "inputFats";
            this.inputFats.Size = new System.Drawing.Size(120, 20);
            this.inputFats.TabIndex = 13;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNew.Location = new System.Drawing.Point(213, 378);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(104, 47);
            this.buttonNew.TabIndex = 14;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // AddMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.inputFats);
            this.Controls.Add(this.inputCarbohydrates);
            this.Controls.Add(this.inputProteins);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.inputCalories);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelFats);
            this.Controls.Add(this.labelCarbohydrates);
            this.Controls.Add(this.labelProteins);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Name = "AddMealForm";
            this.Text = "Add Meal";
            this.Load += new System.EventHandler(this.AddMealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputProteins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCarbohydrates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputFats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelCalories;
		private System.Windows.Forms.Label labelProteins;
		private System.Windows.Forms.Label labelCarbohydrates;
		private System.Windows.Forms.Label labelFats;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.NumericUpDown inputCalories;
		private System.Windows.Forms.TextBox inputDescription;
		private System.Windows.Forms.NumericUpDown inputProteins;
		private System.Windows.Forms.NumericUpDown inputCarbohydrates;
		private System.Windows.Forms.NumericUpDown inputFats;
		private System.Windows.Forms.Button buttonNew;
	}
}