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
            label_Version = new Label();
            label_Modele = new Label();
            label_Constructeur = new Label();
            comboBox_Version = new ComboBox();
            comboBox_Model = new ComboBox();
            comboBox_Constructor = new ComboBox();
            textVisualBox = new TextBox();
            button_debug = new Button();
            button_Save = new Button();
            label_Path = new Label();
            checkBox1 = new CheckBox();
            tabControl_Parametre = new TabControl();
            tab_page_general = new TabPage();
            tabPage2 = new TabPage();
            button_Hostname = new Button();
            label_Hostname = new Label();
            textbox_Hostname = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ConfigurationPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl_Parametre.SuspendLayout();
            tab_page_general.SuspendLayout();
            tabPage2.SuspendLayout();
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
            ConfigurationPanel.Controls.Add(tabControl_Parametre);
            ConfigurationPanel.Controls.Add(groupBox1);
            ConfigurationPanel.Location = new Point(51, 59);
            ConfigurationPanel.Margin = new Padding(2);
            ConfigurationPanel.Name = "ConfigurationPanel";
            ConfigurationPanel.Size = new Size(522, 591);
            ConfigurationPanel.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_Version);
            groupBox1.Controls.Add(label_Modele);
            groupBox1.Controls.Add(label_Constructeur);
            groupBox1.Controls.Add(comboBox_Version);
            groupBox1.Controls.Add(comboBox_Model);
            groupBox1.Controls.Add(comboBox_Constructor);
            groupBox1.Controls.Add(button_NewTemp);
            groupBox1.Controls.Add(buttonEdition);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(469, 245);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametres";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label_Version
            // 
            label_Version.AutoSize = true;
            label_Version.Location = new Point(178, 189);
            label_Version.Margin = new Padding(2, 0, 2, 0);
            label_Version.Name = "label_Version";
            label_Version.Size = new Size(70, 25);
            label_Version.TabIndex = 7;
            label_Version.Text = "Version";
            // 
            // label_Modele
            // 
            label_Modele.AutoSize = true;
            label_Modele.Location = new Point(174, 148);
            label_Modele.Margin = new Padding(2, 0, 2, 0);
            label_Modele.Name = "label_Modele";
            label_Modele.Size = new Size(72, 25);
            label_Modele.TabIndex = 6;
            label_Modele.Text = "Modèle";
            // 
            // label_Constructeur
            // 
            label_Constructeur.AutoSize = true;
            label_Constructeur.Location = new Point(135, 104);
            label_Constructeur.Margin = new Padding(2, 0, 2, 0);
            label_Constructeur.Name = "label_Constructeur";
            label_Constructeur.Size = new Size(113, 25);
            label_Constructeur.TabIndex = 5;
            label_Constructeur.Text = "Constructeur";
            // 
            // comboBox_Version
            // 
            comboBox_Version.FormattingEnabled = true;
            comboBox_Version.Location = new Point(255, 186);
            comboBox_Version.Margin = new Padding(4, 4, 4, 4);
            comboBox_Version.Name = "comboBox_Version";
            comboBox_Version.Size = new Size(188, 33);
            comboBox_Version.TabIndex = 4;
            comboBox_Version.SelectedIndexChanged += comboBox_Version_SelectedIndexChanged;
            // 
            // comboBox_Model
            // 
            comboBox_Model.FormattingEnabled = true;
            comboBox_Model.Location = new Point(255, 144);
            comboBox_Model.Margin = new Padding(4, 4, 4, 4);
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
            comboBox_Constructor.Margin = new Padding(4, 4, 4, 4);
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
            textVisualBox.Size = new Size(976, 643);
            textVisualBox.TabIndex = 3;
            textVisualBox.TextChanged += textBox1_TextChanged;
            // 
            // button_debug
            // 
            button_debug.Image = (Image)resources.GetObject("button_debug.Image");
            button_debug.Location = new Point(15, 678);
            button_debug.Margin = new Padding(4, 4, 4, 4);
            button_debug.Name = "button_debug";
            button_debug.Size = new Size(40, 38);
            button_debug.TabIndex = 4;
            button_debug.UseVisualStyleBackColor = true;
            button_debug.Click += button_debug_Click;
            // 
            // button_Save
            // 
            button_Save.Image = Properties.Resources.diskette__2_;
            button_Save.Location = new Point(1616, 80);
            button_Save.Margin = new Padding(4, 4, 4, 4);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(40, 38);
            button_Save.TabIndex = 5;
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // label_Path
            // 
            label_Path.AutoSize = true;
            label_Path.Location = new Point(632, 32);
            label_Path.Margin = new Padding(2, 0, 2, 0);
            label_Path.Name = "label_Path";
            label_Path.Size = new Size(90, 25);
            label_Path.TabIndex = 6;
            label_Path.Text = "label_Path";
            label_Path.Click += label_Path_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(411, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tabControl_Parametre
            // 
            tabControl_Parametre.AccessibleName = "";
            tabControl_Parametre.Controls.Add(tab_page_general);
            tabControl_Parametre.Controls.Add(tabPage2);
            tabControl_Parametre.Location = new Point(18, 283);
            tabControl_Parametre.Name = "tabControl_Parametre";
            tabControl_Parametre.SelectedIndex = 0;
            tabControl_Parametre.Size = new Size(480, 283);
            tabControl_Parametre.TabIndex = 12;
            // 
            // tab_page_general
            // 
            tab_page_general.Controls.Add(button1);
            tab_page_general.Controls.Add(label1);
            tab_page_general.Controls.Add(textBox1);
            tab_page_general.Location = new Point(4, 34);
            tab_page_general.Name = "tab_page_general";
            tab_page_general.Padding = new Padding(3);
            tab_page_general.Size = new Size(472, 245);
            tab_page_general.TabIndex = 0;
            tab_page_general.Text = "General";
            tab_page_general.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button_Hostname);
            tabPage2.Controls.Add(label_Hostname);
            tabPage2.Controls.Add(textbox_Hostname);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(472, 161);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Hostname
            // 
            button_Hostname.Location = new Point(317, 18);
            button_Hostname.Margin = new Padding(4);
            button_Hostname.Name = "button_Hostname";
            button_Hostname.Size = new Size(51, 36);
            button_Hostname.TabIndex = 10;
            button_Hostname.Text = "button1";
            button_Hostname.UseVisualStyleBackColor = true;
            button_Hostname.Click += button_Hostname_Click;
            // 
            // label_Hostname
            // 
            label_Hostname.AutoSize = true;
            label_Hostname.Location = new Point(5, 23);
            label_Hostname.Margin = new Padding(2, 0, 2, 0);
            label_Hostname.Name = "label_Hostname";
            label_Hostname.Size = new Size(102, 25);
            label_Hostname.TabIndex = 8;
            label_Hostname.Text = "Host Name";
            // 
            // textbox_Hostname
            // 
            textbox_Hostname.Location = new Point(116, 20);
            textbox_Hostname.Margin = new Padding(2);
            textbox_Hostname.Name = "textbox_Hostname";
            textbox_Hostname.Size = new Size(188, 31);
            textbox_Hostname.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(382, 14);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(51, 36);
            button1.TabIndex = 13;
            button1.Text = "Press";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 11;
            label1.Text = "Host Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 17);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 31);
            textBox1.TabIndex = 12;
            // 
            // MainWindows
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1676, 730);
            Controls.Add(label_Path);
            Controls.Add(checkBox1);
            Controls.Add(button_Save);
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
            tabControl_Parametre.ResumeLayout(false);
            tab_page_general.ResumeLayout(false);
            tab_page_general.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Label label_Modele;
        private Label label_Constructeur;
        private Label label_Version;
        private Button button_Save;
        private Label label_Path;
        private CheckBox checkBox1;
        private TabControl tabControl_Parametre;
        private TabPage tab_page_general;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TabPage tabPage2;
        private Button button_Hostname;
        private Label label_Hostname;
        private TextBox textbox_Hostname;
    }
}
