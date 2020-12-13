namespace CalorieManager.Controls
{
	partial class MealControl
	{
		/// <summary> 
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod wygenerowany przez Projektanta składników

		/// <summary> 
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.button2 = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.labelCalories = new System.Windows.Forms.Label();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelCaloriesText = new System.Windows.Forms.Label();
			this.labelDescriptionText = new System.Windows.Forms.Label();
			this.labelNameText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(231, 160);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 47);
			this.button2.TabIndex = 17;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonEdit.Location = new System.Drawing.Point(64, 160);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(107, 47);
			this.buttonEdit.TabIndex = 16;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// labelCalories
			// 
			this.labelCalories.AutoSize = true;
			this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelCalories.Location = new System.Drawing.Point(204, 99);
			this.labelCalories.Name = "labelCalories";
			this.labelCalories.Size = new System.Drawing.Size(91, 25);
			this.labelCalories.TabIndex = 15;
			this.labelCalories.Text = "Calories";
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelDescription.Location = new System.Drawing.Point(204, 64);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(120, 25);
			this.labelDescription.TabIndex = 14;
			this.labelDescription.Text = "Description";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelName.Location = new System.Drawing.Point(204, 30);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(68, 25);
			this.labelName.TabIndex = 13;
			this.labelName.Text = "Name";
			// 
			// labelCaloriesText
			// 
			this.labelCaloriesText.AutoSize = true;
			this.labelCaloriesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelCaloriesText.Location = new System.Drawing.Point(39, 99);
			this.labelCaloriesText.Name = "labelCaloriesText";
			this.labelCaloriesText.Size = new System.Drawing.Size(91, 25);
			this.labelCaloriesText.TabIndex = 12;
			this.labelCaloriesText.Text = "Calories";
			// 
			// labelDescriptionText
			// 
			this.labelDescriptionText.AutoSize = true;
			this.labelDescriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelDescriptionText.Location = new System.Drawing.Point(39, 64);
			this.labelDescriptionText.Name = "labelDescriptionText";
			this.labelDescriptionText.Size = new System.Drawing.Size(120, 25);
			this.labelDescriptionText.TabIndex = 11;
			this.labelDescriptionText.Text = "Description";
			// 
			// labelNameText
			// 
			this.labelNameText.AutoSize = true;
			this.labelNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelNameText.Location = new System.Drawing.Point(39, 30);
			this.labelNameText.Name = "labelNameText";
			this.labelNameText.Size = new System.Drawing.Size(68, 25);
			this.labelNameText.TabIndex = 10;
			this.labelNameText.Text = "Name";
			// 
			// MealControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.labelCalories);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelCaloriesText);
			this.Controls.Add(this.labelDescriptionText);
			this.Controls.Add(this.labelNameText);
			this.Name = "MealControl";
			this.Size = new System.Drawing.Size(372, 225);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Label labelCalories;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelCaloriesText;
		private System.Windows.Forms.Label labelDescriptionText;
		private System.Windows.Forms.Label labelNameText;
	}
}
