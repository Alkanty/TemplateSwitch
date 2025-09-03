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
            button_NewTemp = new Button();
            buttonEdition = new Button();
            ConfigurationPanel = new Panel();
            groupBox1 = new GroupBox();
            textVisualBox = new TextBox();
            ConfigurationPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_NewTemp
            // 
            button_NewTemp.Location = new Point(6, 49);
            button_NewTemp.Name = "button_NewTemp";
            button_NewTemp.Size = new Size(202, 34);
            button_NewTemp.TabIndex = 0;
            button_NewTemp.Text = "Nouveau Template";
            button_NewTemp.UseVisualStyleBackColor = true;
            button_NewTemp.Click += button1_Click;
            // 
            // buttonEdition
            // 
            buttonEdition.Location = new Point(228, 49);
            buttonEdition.Name = "buttonEdition";
            buttonEdition.Size = new Size(112, 34);
            buttonEdition.TabIndex = 1;
            buttonEdition.Text = "Editer";
            buttonEdition.UseVisualStyleBackColor = true;
            buttonEdition.Click += button2_Click;
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
            groupBox1.Controls.Add(button_NewTemp);
            groupBox1.Controls.Add(buttonEdition);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 244);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametres";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textVisualBox
            // 
            textVisualBox.Location = new Point(802, 80);
            textVisualBox.Multiline = true;
            textVisualBox.Name = "textVisualBox";
            textVisualBox.ReadOnly = true;
            textVisualBox.ScrollBars = ScrollBars.Both;
            textVisualBox.Size = new Size(825, 570);
            textVisualBox.TabIndex = 3;
            textVisualBox.TextChanged += textBox1_TextChanged;
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1676, 730);
            Controls.Add(textVisualBox);
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

        private Button button_NewTemp;
        private Button buttonEdition;
        private Panel ConfigurationPanel;
        private GroupBox groupBox1;
        private TextBox textVisualBox;
    }
}
