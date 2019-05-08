namespace MPC_HC_GET_TRACK_NAME
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonApply = new System.Windows.Forms.Button();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonState = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.textBoxReplace1 = new System.Windows.Forms.TextBox();
            this.checkBoxReplace = new System.Windows.Forms.CheckBox();
            this.textBoxReplace2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(221, 141);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "20"});
            this.comboBoxInterval.Location = new System.Drawing.Point(104, 12);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(192, 21);
            this.comboBoxInterval.TabIndex = 1;
            this.comboBoxInterval.Text = "1";
            this.comboBoxInterval.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(12, 15);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(79, 13);
            this.labelInterval.TabIndex = 2;
            this.labelInterval.Text = "Update interval";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 42);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Items.AddRange(new object[] {
            "13579",
            "13580",
            "13581",
            "13582",
            "13583",
            "13584",
            "13585"});
            this.comboBoxPort.Location = new System.Drawing.Point(104, 39);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(192, 21);
            this.comboBoxPort.TabIndex = 5;
            this.comboBoxPort.Text = "13579";
            this.comboBoxPort.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // buttonState
            // 
            this.buttonState.Location = new System.Drawing.Point(12, 141);
            this.buttonState.Name = "buttonState";
            this.buttonState.Size = new System.Drawing.Size(75, 23);
            this.buttonState.TabIndex = 6;
            this.buttonState.Text = "Disabled";
            this.buttonState.UseVisualStyleBackColor = true;
            this.buttonState.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxSpace
            // 
            this.checkBoxSpace.AutoSize = true;
            this.checkBoxSpace.Location = new System.Drawing.Point(139, 66);
            this.checkBoxSpace.Name = "checkBoxSpace";
            this.checkBoxSpace.Size = new System.Drawing.Size(157, 17);
            this.checkBoxSpace.TabIndex = 7;
            this.checkBoxSpace.Text = "Add space after track name";
            this.checkBoxSpace.UseVisualStyleBackColor = true;
            // 
            // textBoxReplace1
            // 
            this.textBoxReplace1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReplace1.Location = new System.Drawing.Point(104, 89);
            this.textBoxReplace1.Name = "textBoxReplace1";
            this.textBoxReplace1.Size = new System.Drawing.Size(192, 20);
            this.textBoxReplace1.TabIndex = 8;
            // 
            // checkBoxReplace
            // 
            this.checkBoxReplace.AutoSize = true;
            this.checkBoxReplace.Location = new System.Drawing.Point(12, 91);
            this.checkBoxReplace.Name = "checkBoxReplace";
            this.checkBoxReplace.Size = new System.Drawing.Size(66, 17);
            this.checkBoxReplace.TabIndex = 9;
            this.checkBoxReplace.Text = "Replace";
            this.checkBoxReplace.UseVisualStyleBackColor = true;
            // 
            // textBoxReplace2
            // 
            this.textBoxReplace2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReplace2.Location = new System.Drawing.Point(104, 115);
            this.textBoxReplace2.Name = "textBoxReplace2";
            this.textBoxReplace2.Size = new System.Drawing.Size(192, 20);
            this.textBoxReplace2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 172);
            this.Controls.Add(this.textBoxReplace2);
            this.Controls.Add(this.checkBoxReplace);
            this.Controls.Add(this.textBoxReplace1);
            this.Controls.Add(this.checkBoxSpace);
            this.Controls.Add(this.buttonState);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.comboBoxInterval);
            this.Controls.Add(this.buttonApply);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MPC-HC GTM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.TextBox textBoxReplace1;
        private System.Windows.Forms.CheckBox checkBoxReplace;
        private System.Windows.Forms.TextBox textBoxReplace2;
    }
}

