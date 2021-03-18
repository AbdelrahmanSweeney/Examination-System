
namespace examapp
{
    partial class MainStudent
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
            this.btnTakeExam = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.Location = new System.Drawing.Point(32, 81);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(155, 23);
            this.btnTakeExam.TabIndex = 4;
            this.btnTakeExam.Text = "Take Exam";
            this.btnTakeExam.UseVisualStyleBackColor = true;
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(32, 150);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(155, 23);
            this.btnGrade.TabIndex = 5;
            this.btnGrade.Text = "Show Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            // 
            // MainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnTakeExam);
            this.Name = "MainStudent";
            this.Text = "Student";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTakeExam;
        private System.Windows.Forms.Button btnGrade;
    }
}