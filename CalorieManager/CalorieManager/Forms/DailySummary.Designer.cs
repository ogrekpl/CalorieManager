
namespace CalorieManager.Forms
{
    partial class DailySummary
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
            this.DailySummaryTitle = new System.Windows.Forms.Label();
            this.DailySummaryCalories = new System.Windows.Forms.Label();
            this.DailySummaryDailyActivities = new System.Windows.Forms.Label();
            this.DailySummaryScore = new System.Windows.Forms.Label();
            this.DailySummaryCommentTitle = new System.Windows.Forms.Label();
            this.DailySummaryCommentValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DailySummaryTitle
            // 
            this.DailySummaryTitle.AutoSize = true;
            this.DailySummaryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailySummaryTitle.Location = new System.Drawing.Point(78, 28);
            this.DailySummaryTitle.Name = "DailySummaryTitle";
            this.DailySummaryTitle.Size = new System.Drawing.Size(991, 76);
            this.DailySummaryTitle.TabIndex = 0;
            this.DailySummaryTitle.Text = "Summmary for date: 12.12.2020";
            this.DailySummaryTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DailySummaryCalories
            // 
            this.DailySummaryCalories.AutoSize = true;
            this.DailySummaryCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailySummaryCalories.Location = new System.Drawing.Point(306, 190);
            this.DailySummaryCalories.Name = "DailySummaryCalories";
            this.DailySummaryCalories.Size = new System.Drawing.Size(516, 39);
            this.DailySummaryCalories.TabIndex = 1;
            this.DailySummaryCalories.Text = "You ate meals at value 2000 kcal";
            this.DailySummaryCalories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DailySummaryDailyActivities
            // 
            this.DailySummaryDailyActivities.AutoSize = true;
            this.DailySummaryDailyActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailySummaryDailyActivities.Location = new System.Drawing.Point(192, 272);
            this.DailySummaryDailyActivities.Name = "DailySummaryDailyActivities";
            this.DailySummaryDailyActivities.Size = new System.Drawing.Size(732, 39);
            this.DailySummaryDailyActivities.TabIndex = 2;
            this.DailySummaryDailyActivities.Text = "During your actvities you have burned 500 kcal ";
            this.DailySummaryDailyActivities.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DailySummaryDailyActivities.Click += new System.EventHandler(this.DailySummaryDailyActivities_Click);
            // 
            // DailySummaryScore
            // 
            this.DailySummaryScore.AutoSize = true;
            this.DailySummaryScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailySummaryScore.Location = new System.Drawing.Point(192, 352);
            this.DailySummaryScore.Name = "DailySummaryScore";
            this.DailySummaryScore.Size = new System.Drawing.Size(750, 39);
            this.DailySummaryScore.TabIndex = 3;
            this.DailySummaryScore.Text = "Your daily score is 2000 from declared 2000 kcal";
            this.DailySummaryScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DailySummaryCommentTitle
            // 
            this.DailySummaryCommentTitle.AutoSize = true;
            this.DailySummaryCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailySummaryCommentTitle.Location = new System.Drawing.Point(486, 445);
            this.DailySummaryCommentTitle.Name = "DailySummaryCommentTitle";
            this.DailySummaryCommentTitle.Size = new System.Drawing.Size(164, 29);
            this.DailySummaryCommentTitle.TabIndex = 4;
            this.DailySummaryCommentTitle.Text = "Our comment:";
            this.DailySummaryCommentTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DailySummaryCommentValue
            // 
            this.DailySummaryCommentValue.AutoSize = true;
            this.DailySummaryCommentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DailySummaryCommentValue.Location = new System.Drawing.Point(328, 486);
            this.DailySummaryCommentValue.Name = "DailySummaryCommentValue";
            this.DailySummaryCommentValue.Size = new System.Drawing.Size(509, 29);
            this.DailySummaryCommentValue.TabIndex = 5;
            this.DailySummaryCommentValue.Text = "Super, you\'ve reached your daily calories goal!";
            this.DailySummaryCommentValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DailySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 624);
            this.Controls.Add(this.DailySummaryCommentValue);
            this.Controls.Add(this.DailySummaryCommentTitle);
            this.Controls.Add(this.DailySummaryScore);
            this.Controls.Add(this.DailySummaryDailyActivities);
            this.Controls.Add(this.DailySummaryCalories);
            this.Controls.Add(this.DailySummaryTitle);
            this.Name = "DailySummary";
            this.Text = "DailySummary";
            this.Load += new System.EventHandler(this.DailySummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DailySummaryTitle;
        private System.Windows.Forms.Label DailySummaryCalories;
        private System.Windows.Forms.Label DailySummaryDailyActivities;
        private System.Windows.Forms.Label DailySummaryScore;
        private System.Windows.Forms.Label DailySummaryCommentTitle;
        private System.Windows.Forms.Label DailySummaryCommentValue;
    }
}