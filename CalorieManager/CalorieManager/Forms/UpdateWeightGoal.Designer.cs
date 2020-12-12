
namespace CalorieManager.Forms
{
    partial class UpdateWeightGoal
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
			this.newWeightGoalValue = new System.Windows.Forms.Button();
			this.newWeightGoal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// newWeightGoalValue
			// 
			this.newWeightGoalValue.Location = new System.Drawing.Point(85, 130);
			this.newWeightGoalValue.Name = "newWeightGoalValue";
			this.newWeightGoalValue.Size = new System.Drawing.Size(75, 23);
			this.newWeightGoalValue.TabIndex = 5;
			this.newWeightGoalValue.Text = "Set";
			this.newWeightGoalValue.UseVisualStyleBackColor = true;
			this.newWeightGoalValue.Click += new System.EventHandler(this.newWeightGoalValue_Click);
			// 
			// newWeightGoal
			// 
			this.newWeightGoal.Location = new System.Drawing.Point(66, 92);
			this.newWeightGoal.Name = "newWeightGoal";
			this.newWeightGoal.Size = new System.Drawing.Size(109, 20);
			this.newWeightGoal.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(28, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Set new weight goal:";
			// 
			// UpdateWeightGoal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(238, 216);
			this.Controls.Add(this.newWeightGoalValue);
			this.Controls.Add(this.newWeightGoal);
			this.Controls.Add(this.label1);
			this.Name = "UpdateWeightGoal";
			this.Text = "Update Weight Goal";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newWeightGoalValue;
        private System.Windows.Forms.TextBox newWeightGoal;
        private System.Windows.Forms.Label label1;
	}
}