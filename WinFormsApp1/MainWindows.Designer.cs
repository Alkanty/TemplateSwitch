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
            textbox_Hostname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox_Version = new ComboBox();
            comboBox_Model = new ComboBox();
            comboBox_Constructor = new ComboBox();
            textVisualBox = new TextBox();
            button_debug = new Button();
            button_save = new Button();
            label_Path = new Label();
            ConfigurationPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button_NewTemp
            // 
            button_NewTemp.Location = new Point(6, 49);
            button_NewTemp.Margin = new Padding(2);
            button_NewTemp.Name = "button_NewTemp";
            button_NewTemp.Size = new Size(202, 34);
            button_NewTemp.TabIndex = 0;
            button_NewTemp.Text = "Nouveau Template";
            button_NewTemp.UseVisualStyleBackColor = true;
            button_NewTemp.Click += button1_Click;
            // 
            // buttonEdition
            // 
            buttonEdition.Location = new Point(331, 49);
            buttonEdition.Margin = new Padding(2);
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
            ConfigurationPanel.Margin = new Padding(2);
            ConfigurationPanel.Name = "ConfigurationPanel";
            ConfigurationPanel.Size = new Size(522, 584);
            ConfigurationPanel.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textbox_Hostname);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox_Version);
            groupBox1.Controls.Add(comboBox_Model);
            groupBox1.Controls.Add(comboBox_Constructor);
            groupBox1.Controls.Add(button_NewTemp);
            groupBox1.Controls.Add(buttonEdition);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(469, 539);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametres";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textbox_Hostname
            // 
            textbox_Hostname.Location = new Point(255, 265);
            textbox_Hostname.Name = "textbox_Hostname";
            textbox_Hostname.Size = new Size(188, 31);
            textbox_Hostname.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 268);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 8;
            label4.Text = "Host Name";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 189);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 7;
            label3.Text = "Version";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 147);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 6;
            label2.Text = "Modèle";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 104);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 5;
            label1.Text = "Constructeur";
            // 
            // comboBox_Version
            // 
            comboBox_Version.FormattingEnabled = true;
            comboBox_Version.Location = new Point(255, 186);
            comboBox_Version.Margin = new Padding(4);
            comboBox_Version.Name = "comboBox_Version";
            comboBox_Version.Size = new Size(188, 33);
            comboBox_Version.TabIndex = 4;
            comboBox_Version.SelectedIndexChanged += comboBox_Version_SelectedIndexChanged;
            // 
            // comboBox_Model
            // 
            comboBox_Model.FormattingEnabled = true;
            comboBox_Model.Location = new Point(255, 144);
            comboBox_Model.Margin = new Padding(4);
            comboBox_Model.Name = "comboBox_Model";
            comboBox_Model.Size = new Size(188, 33);
            comboBox_Model.TabIndex = 3;
            comboBox_Model.SelectedIndexChanged += comboBox_Model_SelectedIndexChanged;
            // 
            // comboBox_Constructor
            // 
            comboBox_Constructor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Constructor.FormattingEnabled = true;
            comboBox_Constructor.Location = new Point(255, 101);
            comboBox_Constructor.Margin = new Padding(4);
            comboBox_Constructor.Name = "comboBox_Constructor";
            comboBox_Constructor.Size = new Size(188, 33);
            comboBox_Constructor.TabIndex = 2;
            comboBox_Constructor.SelectedIndexChanged += comboBox_Constructor_SelectedIndexChanged;
            // 
            // textVisualBox
            // 
            textVisualBox.Location = new Point(632, 59);
            textVisualBox.Margin = new Padding(2);
            textVisualBox.Multiline = true;
            textVisualBox.Name = "textVisualBox";
            textVisualBox.ScrollBars = ScrollBars.Both;
            textVisualBox.Size = new Size(977, 643);
            textVisualBox.TabIndex = 3;
            textVisualBox.TextChanged += textBox1_TextChanged;
            // 
            // button_debug
            // 
            button_debug.Image = (Image)resources.GetObject("button_debug.Image");
            button_debug.Location = new Point(15, 678);
            button_debug.Margin = new Padding(4);
            button_debug.Name = "button_debug";
            button_debug.Size = new Size(40, 38);
            button_debug.TabIndex = 4;
            button_debug.UseVisualStyleBackColor = true;
            button_debug.Click += button_debug_Click;
            // 
            // button_save
            // 
            button_save.Image = Properties.Resources.diskette__2_;
            button_save.Location = new Point(1314, 13);
            button_save.Margin = new Padding(4);
            button_save.Name = "button_save";
            button_save.Size = new Size(40, 38);
            button_save.TabIndex = 5;
            button_save.UseVisualStyleBackColor = true;
            // 
            // label_Path
            // 
            label_Path.AutoSize = true;
            label_Path.Location = new Point(632, 32);
            label_Path.Name = "label_Path";
            label_Path.Size = new Size(90, 25);
            label_Path.TabIndex = 6;
            label_Path.Text = "label_Path";
            label_Path.Click += label5_Click;
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1676, 730);
            Controls.Add(label_Path);
            Controls.Add(button_save);
            Controls.Add(button_debug);
            Controls.Add(textVisualBox);
            Controls.Add(ConfigurationPanel);
            Margin = new Padding(2);
            Name = "MainWindows";
            Text = "(";
            Load += Form1_Load;
            ConfigurationPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox textbox_Hostname;
        private Button button_save;
        private Label label_Path;
    }
}
