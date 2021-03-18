
namespace examapp
{
    partial class MainInstructor
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
            this.btnGenerteExam = new System.Windows.Forms.Button();
            this.btnaddstu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerteExam
            // 
            this.btnGenerteExam.Location = new System.Drawing.Point(37, 126);
            this.btnGenerteExam.Name = "btnGenerteExam";
            this.btnGenerteExam.Size = new System.Drawing.Size(155, 23);
            this.btnGenerteExam.TabIndex = 5;
            this.btnGenerteExam.Text = "Generte Exam";
            this.btnGenerteExam.UseVisualStyleBackColor = true;
            // 
            // btnaddstu
            // 
            this.btnaddstu.Location = new System.Drawing.Point(35, 60);
            this.btnaddstu.Name = "btnaddstu";
            this.btnaddstu.Size = new System.Drawing.Size(157, 23);
            this.btnaddstu.TabIndex = 4;
            this.btnaddstu.Text = "Add student";
            this.btnaddstu.UseVisualStyleBackColor = true;
            this.btnaddstu.Click += new System.EventHandler(this.btnaddstu_Click);
            // 
            // MainInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerteExam);
            this.Controls.Add(this.btnaddstu);
            this.Name = "MainInstructor";
            this.Text = "Instructor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerteExam;
        private System.Windows.Forms.Button btnaddstu;
    }
}