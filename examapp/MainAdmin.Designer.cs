
namespace examapp
{
    partial class MainAdmin
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
            this.components = new System.ComponentModel.Container();
            this.btnAddInst = new System.Windows.Forms.Button();
            this.btnaddstu = new System.Windows.Forms.Button();
            this.examination_systemDataSet1 = new examapp.examination_systemDataSet1();
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorTableAdapter = new examapp.examination_systemDataSet1TableAdapters.instructorTableAdapter();
            this.dataGStudent = new System.Windows.Forms.DataGridView();
            this.dataG_course = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataG_inst = new System.Windows.Forms.DataGridView();
            this.btnaddCur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examination_systemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_inst)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddInst
            // 
            this.btnAddInst.Location = new System.Drawing.Point(43, 30);
            this.btnAddInst.Name = "btnAddInst";
            this.btnAddInst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddInst.Size = new System.Drawing.Size(157, 23);
            this.btnAddInst.TabIndex = 0;
            this.btnAddInst.Text = " Instructor";
            this.btnAddInst.UseVisualStyleBackColor = true;
            this.btnAddInst.Click += new System.EventHandler(this.btnAddInst_Click);
            // 
            // btnaddstu
            // 
            this.btnaddstu.Location = new System.Drawing.Point(43, 69);
            this.btnaddstu.Name = "btnaddstu";
            this.btnaddstu.Size = new System.Drawing.Size(157, 23);
            this.btnaddstu.TabIndex = 2;
            this.btnaddstu.Text = "student";
            this.btnaddstu.UseVisualStyleBackColor = true;
            this.btnaddstu.Click += new System.EventHandler(this.btnaddstu_Click);
            // 
            // examination_systemDataSet1
            // 
            this.examination_systemDataSet1.DataSetName = "examination_systemDataSet1";
            this.examination_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataMember = "instructor";
            this.instructorBindingSource.DataSource = this.examination_systemDataSet1;
            // 
            // instructorTableAdapter
            // 
            this.instructorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGStudent
            // 
            this.dataGStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGStudent.Location = new System.Drawing.Point(409, 168);
            this.dataGStudent.Name = "dataGStudent";
            this.dataGStudent.Size = new System.Drawing.Size(627, 104);
            this.dataGStudent.TabIndex = 12;
            this.dataGStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataG_course
            // 
            this.dataG_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_course.Location = new System.Drawing.Point(31, 168);
            this.dataG_course.Name = "dataG_course";
            this.dataG_course.Size = new System.Drawing.Size(346, 104);
            this.dataG_course.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Student list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Instructor list:";
            // 
            // dataG_inst
            // 
            this.dataG_inst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_inst.Location = new System.Drawing.Point(409, 20);
            this.dataG_inst.Name = "dataG_inst";
            this.dataG_inst.Size = new System.Drawing.Size(627, 132);
            this.dataG_inst.TabIndex = 11;
            // 
            // btnaddCur
            // 
            this.btnaddCur.Location = new System.Drawing.Point(45, 112);
            this.btnaddCur.Name = "btnaddCur";
            this.btnaddCur.Size = new System.Drawing.Size(155, 23);
            this.btnaddCur.TabIndex = 4;
            this.btnaddCur.Text = "Course";
            this.btnaddCur.UseVisualStyleBackColor = true;
            this.btnaddCur.Click += new System.EventHandler(this.btnaddCur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Course list:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(313, 363);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(536, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataG_course);
            this.Controls.Add(this.dataGStudent);
            this.Controls.Add(this.dataG_inst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaddCur);
            this.Controls.Add(this.btnaddstu);
            this.Controls.Add(this.btnAddInst);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            this.Load += new System.EventHandler(this.MainAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examination_systemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_inst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddInst;
        private System.Windows.Forms.Button btnaddstu;
        private examination_systemDataSet1 examination_systemDataSet1;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private examination_systemDataSet1TableAdapters.instructorTableAdapter instructorTableAdapter;
        private System.Windows.Forms.DataGridView dataGStudent;
        private System.Windows.Forms.DataGridView dataG_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataG_inst;
        private System.Windows.Forms.Button btnaddCur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}