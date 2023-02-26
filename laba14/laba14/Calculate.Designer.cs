namespace laba14
{
    partial class Calculate
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.collectionFunction = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radians = new System.Windows.Forms.RadioButton();
            this.degrees = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.TextBox();
            this.endValue = new System.Windows.Forms.TextBox();
            this.startValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buildAGraph = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор функции";
            // 
            // collectionFunction
            // 
            this.collectionFunction.FormattingEnabled = true;
            this.collectionFunction.Items.AddRange(new object[] {
            "Cos(ax) * e^x",
            "-Cos(ax) * e^x",
            "-Sin(ax) * e^x"});
            this.collectionFunction.Location = new System.Drawing.Point(50, 73);
            this.collectionFunction.Name = "collectionFunction";
            this.collectionFunction.Size = new System.Drawing.Size(178, 21);
            this.collectionFunction.TabIndex = 1;
            this.collectionFunction.Text = "Cos(ax) * e^x";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radians);
            this.groupBox1.Controls.Add(this.degrees);
            this.groupBox1.Location = new System.Drawing.Point(50, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Единицы измерения";
            // 
            // radians
            // 
            this.radians.AutoSize = true;
            this.radians.Location = new System.Drawing.Point(22, 74);
            this.radians.Name = "radians";
            this.radians.Size = new System.Drawing.Size(70, 17);
            this.radians.TabIndex = 1;
            this.radians.TabStop = true;
            this.radians.Text = "Радианы";
            this.radians.UseVisualStyleBackColor = true;
            this.radians.CheckedChanged += new System.EventHandler(this.degrees_CheckedChanged);
            // 
            // degrees
            // 
            this.degrees.AutoSize = true;
            this.degrees.Location = new System.Drawing.Point(22, 40);
            this.degrees.Name = "degrees";
            this.degrees.Size = new System.Drawing.Size(68, 17);
            this.degrees.TabIndex = 0;
            this.degrees.TabStop = true;
            this.degrees.Text = "Градусы";
            this.degrees.UseVisualStyleBackColor = true;
            this.degrees.CheckedChanged += new System.EventHandler(this.degrees_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aValue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.step);
            this.groupBox2.Controls.Add(this.endValue);
            this.groupBox2.Controls.Add(this.startValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(50, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 217);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // aValue
            // 
            this.aValue.Location = new System.Drawing.Point(138, 149);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(48, 20);
            this.aValue.TabIndex = 10;
            this.aValue.TextChanged += new System.EventHandler(this.startValue_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Значение a:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pi";
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(138, 113);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(48, 20);
            this.step.TabIndex = 5;
            this.step.TextChanged += new System.EventHandler(this.startValue_TextChanged);
            // 
            // endValue
            // 
            this.endValue.Location = new System.Drawing.Point(138, 79);
            this.endValue.Name = "endValue";
            this.endValue.Size = new System.Drawing.Size(48, 20);
            this.endValue.TabIndex = 4;
            this.endValue.TextChanged += new System.EventHandler(this.startValue_TextChanged);
            // 
            // startValue
            // 
            this.startValue.Location = new System.Drawing.Point(138, 43);
            this.startValue.Name = "startValue";
            this.startValue.Size = new System.Drawing.Size(48, 20);
            this.startValue.TabIndex = 3;
            this.startValue.TextChanged += new System.EventHandler(this.startValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Шаг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Конечное значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Начальное значение";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(669, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(209, 582);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // buildAGraph
            // 
            this.buildAGraph.Location = new System.Drawing.Point(50, 561);
            this.buildAGraph.Name = "buildAGraph";
            this.buildAGraph.Size = new System.Drawing.Size(267, 49);
            this.buildAGraph.TabIndex = 5;
            this.buildAGraph.Text = "Вычислить";
            this.buildAGraph.UseVisualStyleBackColor = true;
            this.buildAGraph.Click += new System.EventHandler(this.buildAGraph_Click);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 637);
            this.Controls.Add(this.buildAGraph);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.collectionFunction);
            this.Controls.Add(this.label1);
            this.Name = "Calculate";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox collectionFunction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radians;
        private System.Windows.Forms.RadioButton degrees;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox step;
        private System.Windows.Forms.TextBox endValue;
        private System.Windows.Forms.TextBox startValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buildAGraph;
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.Label label8;
    }
}

