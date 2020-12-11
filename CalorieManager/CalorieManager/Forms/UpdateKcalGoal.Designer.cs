
namespace CalorieManager.Forms
{
    partial class UpdateKcalGoal
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
            this.newKcalGoal = new System.Windows.Forms.TextBox();
            this.newKcalGoalValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nowy cel kalorii:";
            // 
            // newKcalGoal
            // 
            this.newKcalGoal.Location = new System.Drawing.Point(61, 94);
            this.newKcalGoal.Name = "newKcalGoal";
            this.newKcalGoal.Size = new System.Drawing.Size(109, 20);
            this.newKcalGoal.TabIndex = 1;
            // 
            // newKcalGoalValue
            // 
            this.newKcalGoalValue.Location = new System.Drawing.Point(80, 132);
            this.newKcalGoalValue.Name = "newKcalGoalValue";
            this.newKcalGoalValue.Size = new System.Drawing.Size(75, 23);
            this.newKcalGoalValue.TabIndex = 2;
            this.newKcalGoalValue.Text = "Zatwierdź";
            this.newKcalGoalValue.UseVisualStyleBackColor = true;
            this.newKcalGoalValue.Click += new System.EventHandler(this.newKcalGoalValue_Click);
            // 
            // UpdateKcalGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 216);
            this.Controls.Add(this.newKcalGoalValue);
            this.Controls.Add(this.newKcalGoal);
            this.Controls.Add(this.label1);
            this.Name = "UpdateKcalGoal";
            this.Text = "UpdateKcalGoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newKcalGoal;
        private System.Windows.Forms.Button newKcalGoalValue;
    }
}