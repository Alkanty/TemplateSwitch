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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            button_NewTemp = new Button();
            buttonEdition = new Button();
            ConfigurationPanel = new Panel();
            groupBox1 = new GroupBox();
            comboBox_Version = new ComboBox();
            comboBox_Model = new ComboBox();
            comboBox_Constructor = new ComboBox();
            textVisualBox = new TextBox();
            button_debug = new Button();
            ConfigurationPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_NewTemp
            // 
            button_NewTemp.Location = new Point(5, 39);
            button_NewTemp.Margin = new Padding(2);
            button_NewTemp.Name = "button_NewTemp";
            button_NewTemp.Size = new Size(162, 27);
            button_NewTemp.TabIndex = 0;
            button_NewTemp.Text = "Nouveau Template";
            button_NewTemp.UseVisualStyleBackColor = true;
            button_NewTemp.Click += button1_Click;
            // 
            // buttonEdition
            // 
            buttonEdition.Location = new Point(265, 39);
            buttonEdition.Margin = new Padding(2);
            buttonEdition.Name = "buttonEdition";
            buttonEdition.Size = new Size(90, 27);
            buttonEdition.TabIndex = 1;
            buttonEdition.Text = "Editer";
            buttonEdition.UseVisualStyleBackColor = true;
            buttonEdition.Click += button2_Click;
            // 
            // ConfigurationPanel
            // 
            ConfigurationPanel.Controls.Add(groupBox1);
            ConfigurationPanel.Location = new Point(41, 47);
            ConfigurationPanel.Margin = new Padding(2);
            ConfigurationPanel.Name = "ConfigurationPanel";
            ConfigurationPanel.Size = new Size(418, 259);
            ConfigurationPanel.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_Version);
            groupBox1.Controls.Add(comboBox_Model);
            groupBox1.Controls.Add(comboBox_Constructor);
            groupBox1.Controls.Add(button_NewTemp);
            groupBox1.Controls.Add(buttonEdition);
            groupBox1.Location = new Point(10, 17);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(375, 193);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametres";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox_Version
            // 
            comboBox_Version.FormattingEnabled = true;
            comboBox_Version.Location = new Point(204, 149);
            comboBox_Version.Name = "comboBox_Version";
            comboBox_Version.Size = new Size(151, 28);
            comboBox_Version.TabIndex = 4;
            comboBox_Version.Text = "Version";
            comboBox_Version.SelectedIndexChanged += comboBox_Version_SelectedIndexChanged;
            // 
            // comboBox_Model
            // 
            comboBox_Model.FormattingEnabled = true;
            comboBox_Model.Location = new Point(204, 115);
            comboBox_Model.Name = "comboBox_Model";
            comboBox_Model.Size = new Size(151, 28);
            comboBox_Model.TabIndex = 3;
            comboBox_Model.Text = "Modèle";
            comboBox_Model.SelectedIndexChanged += comboBox_Model_SelectedIndexChanged;
            // 
            // comboBox_Constructor
            // 
            comboBox_Constructor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Constructor.FormattingEnabled = true;
            comboBox_Constructor.Location = new Point(204, 81);
            comboBox_Constructor.Name = "comboBox_Constructor";
            comboBox_Constructor.Size = new Size(151, 28);
            comboBox_Constructor.TabIndex = 2;
            comboBox_Constructor.SelectedIndexChanged += comboBox_Constructor_SelectedIndexChanged;
            // 
            // textVisualBox
            // 
            textVisualBox.Location = new Point(630, 64);
            textVisualBox.Margin = new Padding(2);
            textVisualBox.Multiline = true;
            textVisualBox.Name = "textVisualBox";
            textVisualBox.ReadOnly = true;
            textVisualBox.ScrollBars = ScrollBars.Both;
            textVisualBox.Size = new Size(661, 457);
            textVisualBox.TabIndex = 3;
            textVisualBox.TextChanged += textBox1_TextChanged;
            // 
            // button_debug
            // 
            button_debug.Image = (Image)resources.GetObject("button_debug.Image");
            button_debug.Location = new Point(12, 542);
            button_debug.Name = "button_debug";
            button_debug.Size = new Size(32, 30);
            button_debug.TabIndex = 4;
            button_debug.UseVisualStyleBackColor = true;
            button_debug.Click += button_debug_Click;
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 584);
            Controls.Add(button_debug);
            Controls.Add(textVisualBox);
            Controls.Add(ConfigurationPanel);
            Margin = new Padding(2);
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
        private ComboBox comboBox_Version;
        private ComboBox comboBox_Model;
        private ComboBox comboBox_Constructor;
        private Button button_debug;
    }
}
