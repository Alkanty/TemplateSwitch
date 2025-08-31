namespace WinFormsApp1
{
    partial class MainWindows
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            ConfigurationPanel = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ConfigurationPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 49);
            button1.Name = "button1";
            button1.Size = new Size(202, 34);
            button1.TabIndex = 0;
            button1.Text = "Nouveau Template";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(228, 49);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Editer";
            button2.UseVisualStyleBackColor = true;
            // 
            // ConfigurationPanel
            // 
            ConfigurationPanel.Controls.Add(groupBox1);
            ConfigurationPanel.Location = new Point(51, 59);
            ConfigurationPanel.Name = "ConfigurationPanel";
            ConfigurationPanel.Size = new Size(522, 324);
            ConfigurationPanel.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 244);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametres";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(791, 59);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(825, 570);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1676, 730);
            Controls.Add(textBox1);
            Controls.Add(ConfigurationPanel);
            Name = "MainWindows";
            Text = "TemplateSwitch";
            Load += Form1_Load;
            ConfigurationPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel ConfigurationPanel;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}
