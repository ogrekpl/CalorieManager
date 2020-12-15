﻿
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
            this.newKcalGoalValue = new System.Windows.Forms.Button();
            this.newKcalGoal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.newKcalGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set new calories goal:";
            // 
            // newKcalGoalValue
            // 
            this.newKcalGoalValue.Location = new System.Drawing.Point(80, 132);
            this.newKcalGoalValue.Name = "newKcalGoalValue";
            this.newKcalGoalValue.Size = new System.Drawing.Size(75, 23);
            this.newKcalGoalValue.TabIndex = 2;
            this.newKcalGoalValue.Text = "Set";
            this.newKcalGoalValue.UseVisualStyleBackColor = true;
            this.newKcalGoalValue.Click += new System.EventHandler(this.newKcalGoalValue_Click);
            // 
            // newKcalGoal
            // 
            this.newKcalGoal.Location = new System.Drawing.Point(57, 90);
            this.newKcalGoal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.newKcalGoal.Name = "newKcalGoal";
            this.newKcalGoal.Size = new System.Drawing.Size(120, 20);
            this.newKcalGoal.TabIndex = 3;
            this.newKcalGoal.ValueChanged += new System.EventHandler(this.newKcalGoal_ValueChanged);
            // 
            // UpdateKcalGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 216);
            this.Controls.Add(this.newKcalGoal);
            this.Controls.Add(this.newKcalGoalValue);
            this.Controls.Add(this.label1);
            this.Name = "UpdateKcalGoal";
            this.Text = "Update Calories Goal";
            this.Load += new System.EventHandler(this.UpdateKcalGoal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newKcalGoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newKcalGoalValue;
        private System.Windows.Forms.NumericUpDown newKcalGoal;
    }
}