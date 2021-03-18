
namespace examapp
{
    partial class Form_Course
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
            this.btndeletetopic = new System.Windows.Forms.Button();
            this.dataGtopic = new System.Windows.Forms.DataGridView();
            this.addtopic = new System.Windows.Forms.Button();
            this.dataG_course = new System.Windows.Forms.DataGridView();
            this.btndeletecourse = new System.Windows.Forms.Button();
            this.btnaddCur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdatecur = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGtopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_course)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeletetopic
            // 
            this.btndeletetopic.Location = new System.Drawing.Point(3, 223);
            this.btndeletetopic.Name = "btndeletetopic";
            this.btndeletetopic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndeletetopic.Size = new System.Drawing.Size(165, 23);
            this.btndeletetopic.TabIndex = 25;
            this.btndeletetopic.Text = "Delete Topic";
            this.btndeletetopic.UseVisualStyleBackColor = true;
            this.btndeletetopic.Click += new System.EventHandler(this.btndeletetopic_Click);
            // 
            // dataGtopic
            // 
            this.dataGtopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGtopic.Location = new System.Drawing.Point(377, 156);
            this.dataGtopic.Name = "dataGtopic";
            this.dataGtopic.Size = new System.Drawing.Size(388, 104);
            this.dataGtopic.TabIndex = 24;
            // 
            // addtopic
            // 
            this.addtopic.Location = new System.Drawing.Point(5, 180);
            this.addtopic.Name = "addtopic";
            this.addtopic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addtopic.Size = new System.Drawing.Size(165, 23);
            this.addtopic.TabIndex = 23;
            this.addtopic.Text = "Add Topic";
            this.addtopic.UseVisualStyleBackColor = true;
            this.addtopic.Click += new System.EventHandler(this.addtopic_Click);
            // 
            // dataG_course
            // 
            this.dataG_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_course.Location = new System.Drawing.Point(377, 33);
            this.dataG_course.Name = "dataG_course";
            this.dataG_course.Size = new System.Drawing.Size(388, 104);
            this.dataG_course.TabIndex = 22;
            // 
            // btndeletecourse
            // 
            this.btndeletecourse.Location = new System.Drawing.Point(5, 84);
            this.btndeletecourse.Name = "btndeletecourse";
            this.btndeletecourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndeletecourse.Size = new System.Drawing.Size(165, 23);
            this.btndeletecourse.TabIndex = 21;
            this.btndeletecourse.Text = "Delete Course";
            this.btndeletecourse.UseVisualStyleBackColor = true;
            this.btndeletecourse.Click += new System.EventHandler(this.btndeletecourse_Click);
            // 
            // btnaddCur
            // 
            this.btnaddCur.Location = new System.Drawing.Point(5, 33);
            this.btnaddCur.Name = "btnaddCur";
            this.btnaddCur.Size = new System.Drawing.Size(163, 23);
            this.btnaddCur.TabIndex = 20;
            this.btnaddCur.Text = "Add Course";
            this.btnaddCur.UseVisualStyleBackColor = true;
            this.btnaddCur.Click += new System.EventHandler(this.btnaddCur_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 303);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdatecur
            // 
            this.btnupdatecur.Location = new System.Drawing.Point(3, 141);
            this.btnupdatecur.Name = "btnupdatecur";
            this.btnupdatecur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdatecur.Size = new System.Drawing.Size(165, 23);
            this.btnupdatecur.TabIndex = 27;
            this.btnupdatecur.Text = "Update Course";
            this.btnupdatecur.UseVisualStyleBackColor = true;
            this.btnupdatecur.Click += new System.EventHandler(this.btnupdatecur_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(165, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update Topic";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnupdatecur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndeletetopic);
            this.Controls.Add(this.dataGtopic);
            this.Controls.Add(this.addtopic);
            this.Controls.Add(this.dataG_course);
            this.Controls.Add(this.btndeletecourse);
            this.Controls.Add(this.btnaddCur);
            this.Name = "Form_Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGtopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndeletetopic;
        private System.Windows.Forms.DataGridView dataGtopic;
        private System.Windows.Forms.Button addtopic;
        private System.Windows.Forms.DataGridView dataG_course;
        private System.Windows.Forms.Button btndeletecourse;
        private System.Windows.Forms.Button btnaddCur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnupdatecur;
        private System.Windows.Forms.Button btnUpdate;
    }
}