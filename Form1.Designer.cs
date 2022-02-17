namespace Project_Nova_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSingleplayer = new System.Windows.Forms.Button();
            this.buttonMultiplayer = new System.Windows.Forms.Button();
            this.buttonSpecial1 = new System.Windows.Forms.Button();
            this.buttonCoop = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.buttonIdGenerate = new System.Windows.Forms.Button();
            this.textBoxArch = new System.Windows.Forms.TextBox();
            this.labelArch = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkAriaID = new System.Windows.Forms.LinkLabel();
            this.labelAyria = new System.Windows.Forms.Label();
            this.linkForum = new System.Windows.Forms.LinkLabel();
            this.linkProject = new System.Windows.Forms.LinkLabel();
            this.buttonClearUnneeded = new System.Windows.Forms.Button();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.tabPagePlaylistGeneral = new System.Windows.Forms.TabPage();
            this.labelSelectedPlaylist = new System.Windows.Forms.Label();
            this.textBoxCurrentPlaylist = new System.Windows.Forms.TextBox();
            this.buttomPlaylistUpdate = new System.Windows.Forms.Button();
            this.labelPlaylist = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonCreatePlaylistFolder = new System.Windows.Forms.Button();
            this.textBoxNoPlaylist = new System.Windows.Forms.TextBox();
            this.tabPageXlabs = new System.Windows.Forms.TabPage();
            this.buttonXlabsOpenFolder = new System.Windows.Forms.Button();
            this.textBoxProfileDetails = new System.Windows.Forms.TextBox();
            this.buttonProfileCopyLabsToAyria = new System.Windows.Forms.Button();
            this.buttonProfileCopyNovaXlabs = new System.Windows.Forms.Button();
            this.buttonXlabsLauncher = new System.Windows.Forms.Button();
            this.buttonXlabsCoop = new System.Windows.Forms.Button();
            this.buttonXlabsSpecial = new System.Windows.Forms.Button();
            this.buttonXlabsMultiplayer = new System.Windows.Forms.Button();
            this.buttonXlabSingleplayer = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPagePlaylistGeneral.SuspendLayout();
            this.tabPageXlabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Player Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(245, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID:";
            this.labelId.Click += new System.EventHandler(this.labelId_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(88, 14);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonSingleplayer
            // 
            this.buttonSingleplayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSingleplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingleplayer.Location = new System.Drawing.Point(354, 12);
            this.buttonSingleplayer.Name = "buttonSingleplayer";
            this.buttonSingleplayer.Size = new System.Drawing.Size(108, 23);
            this.buttonSingleplayer.TabIndex = 4;
            this.buttonSingleplayer.Text = "Singleplayer";
            this.buttonSingleplayer.UseVisualStyleBackColor = false;
            this.buttonSingleplayer.Visible = false;
            this.buttonSingleplayer.Click += new System.EventHandler(this.buttonSingleplayer_Click);
            // 
            // buttonMultiplayer
            // 
            this.buttonMultiplayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplayer.Location = new System.Drawing.Point(12, 12);
            this.buttonMultiplayer.Name = "buttonMultiplayer";
            this.buttonMultiplayer.Size = new System.Drawing.Size(108, 23);
            this.buttonMultiplayer.TabIndex = 5;
            this.buttonMultiplayer.Text = "Multiplayer";
            this.buttonMultiplayer.UseVisualStyleBackColor = false;
            this.buttonMultiplayer.Visible = false;
            this.buttonMultiplayer.Click += new System.EventHandler(this.buttonMultiplayer_Click);
            // 
            // buttonSpecial1
            // 
            this.buttonSpecial1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSpecial1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpecial1.Location = new System.Drawing.Point(126, 12);
            this.buttonSpecial1.Name = "buttonSpecial1";
            this.buttonSpecial1.Size = new System.Drawing.Size(108, 23);
            this.buttonSpecial1.TabIndex = 6;
            this.buttonSpecial1.Text = "Zombies";
            this.buttonSpecial1.UseVisualStyleBackColor = false;
            this.buttonSpecial1.Visible = false;
            this.buttonSpecial1.Click += new System.EventHandler(this.buttonSpecial1_Click);
            // 
            // buttonCoop
            // 
            this.buttonCoop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCoop.Location = new System.Drawing.Point(240, 12);
            this.buttonCoop.Name = "buttonCoop";
            this.buttonCoop.Size = new System.Drawing.Size(108, 23);
            this.buttonCoop.TabIndex = 7;
            this.buttonCoop.Text = "Co-operative";
            this.buttonCoop.UseVisualStyleBackColor = false;
            this.buttonCoop.Visible = false;
            this.buttonCoop.Click += new System.EventHandler(this.buttonCoop_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPagePlaylistGeneral);
            this.tabControlMain.Controls.Add(this.tabPageXlabs);
            this.tabControlMain.Location = new System.Drawing.Point(12, 41);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(450, 306);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.comboBoxID);
            this.tabPageMain.Controls.Add(this.buttonIdGenerate);
            this.tabPageMain.Controls.Add(this.textBoxArch);
            this.tabPageMain.Controls.Add(this.labelArch);
            this.tabPageMain.Controls.Add(this.labelVersion);
            this.tabPageMain.Controls.Add(this.linkAriaID);
            this.tabPageMain.Controls.Add(this.labelAyria);
            this.tabPageMain.Controls.Add(this.linkForum);
            this.tabPageMain.Controls.Add(this.linkProject);
            this.tabPageMain.Controls.Add(this.buttonClearUnneeded);
            this.tabPageMain.Controls.Add(this.textBoxDetails);
            this.tabPageMain.Controls.Add(this.labelName);
            this.tabPageMain.Controls.Add(this.textBoxName);
            this.tabPageMain.Controls.Add(this.labelId);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(442, 280);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Nova Options";
            this.tabPageMain.UseVisualStyleBackColor = true;
            this.tabPageMain.Click += new System.EventHandler(this.tabPageMain_Click);
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(272, 14);
            this.comboBoxID.MaxDropDownItems = 50;
            this.comboBoxID.MaxLength = 8;
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(87, 21);
            this.comboBoxID.TabIndex = 16;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // buttonIdGenerate
            // 
            this.buttonIdGenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonIdGenerate.Location = new System.Drawing.Point(365, 13);
            this.buttonIdGenerate.Name = "buttonIdGenerate";
            this.buttonIdGenerate.Size = new System.Drawing.Size(66, 23);
            this.buttonIdGenerate.TabIndex = 15;
            this.buttonIdGenerate.Text = "Generate";
            this.buttonIdGenerate.UseVisualStyleBackColor = true;
            this.buttonIdGenerate.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxArch
            // 
            this.textBoxArch.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxArch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxArch.Location = new System.Drawing.Point(273, 90);
            this.textBoxArch.Name = "textBoxArch";
            this.textBoxArch.ReadOnly = true;
            this.textBoxArch.Size = new System.Drawing.Size(100, 13);
            this.textBoxArch.TabIndex = 13;
            this.textBoxArch.Text = "Unknown";
            // 
            // labelArch
            // 
            this.labelArch.AutoSize = true;
            this.labelArch.Location = new System.Drawing.Point(169, 90);
            this.labelArch.Name = "labelArch";
            this.labelArch.Size = new System.Drawing.Size(98, 13);
            this.labelArch.TabIndex = 12;
            this.labelArch.Text = "Game Architecture:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(371, 251);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 11;
            this.labelVersion.Text = "Version: 2.4";
            // 
            // linkAriaID
            // 
            this.linkAriaID.AutoSize = true;
            this.linkAriaID.Location = new System.Drawing.Point(270, 54);
            this.linkAriaID.Name = "linkAriaID";
            this.linkAriaID.Size = new System.Drawing.Size(0, 13);
            this.linkAriaID.TabIndex = 10;
            this.linkAriaID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAriaID_LinkClicked);
            // 
            // labelAyria
            // 
            this.labelAyria.AutoSize = true;
            this.labelAyria.Location = new System.Drawing.Point(186, 54);
            this.labelAyria.Name = "labelAyria";
            this.labelAyria.Size = new System.Drawing.Size(78, 13);
            this.labelAyria.TabIndex = 9;
            this.labelAyria.Text = "Ayria Game ID:";
            this.labelAyria.Visible = false;
            this.labelAyria.Click += new System.EventHandler(this.labelAyria_Click);
            // 
            // linkForum
            // 
            this.linkForum.AutoSize = true;
            this.linkForum.Location = new System.Drawing.Point(90, 251);
            this.linkForum.Name = "linkForum";
            this.linkForum.Size = new System.Drawing.Size(36, 13);
            this.linkForum.TabIndex = 7;
            this.linkForum.TabStop = true;
            this.linkForum.Text = "Forum";
            this.linkForum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForum_LinkClicked);
            // 
            // linkProject
            // 
            this.linkProject.AutoSize = true;
            this.linkProject.Location = new System.Drawing.Point(15, 251);
            this.linkProject.Name = "linkProject";
            this.linkProject.Size = new System.Drawing.Size(69, 13);
            this.linkProject.TabIndex = 6;
            this.linkProject.TabStop = true;
            this.linkProject.Text = "Project Nova";
            this.linkProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProject_LinkClicked);
            // 
            // buttonClearUnneeded
            // 
            this.buttonClearUnneeded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearUnneeded.Location = new System.Drawing.Point(18, 212);
            this.buttonClearUnneeded.Name = "buttonClearUnneeded";
            this.buttonClearUnneeded.Size = new System.Drawing.Size(140, 23);
            this.buttonClearUnneeded.TabIndex = 5;
            this.buttonClearUnneeded.Text = "Delete Unused Ayria Files";
            this.buttonClearUnneeded.UseVisualStyleBackColor = true;
            this.buttonClearUnneeded.Visible = false;
            this.buttonClearUnneeded.Click += new System.EventHandler(this.buttonClearUnneeded_Click);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetails.Location = new System.Drawing.Point(18, 54);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(162, 14);
            this.textBoxDetails.TabIndex = 4;
            this.textBoxDetails.Text = "Unknown Game";
            this.textBoxDetails.TextChanged += new System.EventHandler(this.textBoxDetails_TextChanged);
            // 
            // tabPagePlaylistGeneral
            // 
            this.tabPagePlaylistGeneral.Controls.Add(this.labelSelectedPlaylist);
            this.tabPagePlaylistGeneral.Controls.Add(this.textBoxCurrentPlaylist);
            this.tabPagePlaylistGeneral.Controls.Add(this.buttomPlaylistUpdate);
            this.tabPagePlaylistGeneral.Controls.Add(this.labelPlaylist);
            this.tabPagePlaylistGeneral.Controls.Add(this.comboBox1);
            this.tabPagePlaylistGeneral.Controls.Add(this.buttonCreatePlaylistFolder);
            this.tabPagePlaylistGeneral.Controls.Add(this.textBoxNoPlaylist);
            this.tabPagePlaylistGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlaylistGeneral.Name = "tabPagePlaylistGeneral";
            this.tabPagePlaylistGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaylistGeneral.Size = new System.Drawing.Size(442, 280);
            this.tabPagePlaylistGeneral.TabIndex = 1;
            this.tabPagePlaylistGeneral.Text = "Playlist Options";
            this.tabPagePlaylistGeneral.UseVisualStyleBackColor = true;
            // 
            // labelSelectedPlaylist
            // 
            this.labelSelectedPlaylist.AutoSize = true;
            this.labelSelectedPlaylist.Location = new System.Drawing.Point(15, 23);
            this.labelSelectedPlaylist.Name = "labelSelectedPlaylist";
            this.labelSelectedPlaylist.Size = new System.Drawing.Size(79, 13);
            this.labelSelectedPlaylist.TabIndex = 6;
            this.labelSelectedPlaylist.Text = "Current Playlist:";
            // 
            // textBoxCurrentPlaylist
            // 
            this.textBoxCurrentPlaylist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCurrentPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentPlaylist.Location = new System.Drawing.Point(97, 23);
            this.textBoxCurrentPlaylist.Name = "textBoxCurrentPlaylist";
            this.textBoxCurrentPlaylist.ReadOnly = true;
            this.textBoxCurrentPlaylist.Size = new System.Drawing.Size(213, 13);
            this.textBoxCurrentPlaylist.TabIndex = 5;
            this.textBoxCurrentPlaylist.Text = "Unknown";
            this.textBoxCurrentPlaylist.TextChanged += new System.EventHandler(this.textBoxCurrentPlaylist_TextChanged);
            // 
            // buttomPlaylistUpdate
            // 
            this.buttomPlaylistUpdate.Location = new System.Drawing.Point(316, 46);
            this.buttomPlaylistUpdate.Name = "buttomPlaylistUpdate";
            this.buttomPlaylistUpdate.Size = new System.Drawing.Size(89, 23);
            this.buttomPlaylistUpdate.TabIndex = 4;
            this.buttomPlaylistUpdate.Text = "Refresh";
            this.buttomPlaylistUpdate.UseVisualStyleBackColor = true;
            this.buttomPlaylistUpdate.Click += new System.EventHandler(this.buttomPlaylistUpdate_Click);
            // 
            // labelPlaylist
            // 
            this.labelPlaylist.AutoSize = true;
            this.labelPlaylist.Location = new System.Drawing.Point(12, 51);
            this.labelPlaylist.Name = "labelPlaylist";
            this.labelPlaylist.Size = new System.Drawing.Size(82, 13);
            this.labelPlaylist.TabIndex = 1;
            this.labelPlaylist.Text = "Change Playlist:";
            this.labelPlaylist.Click += new System.EventHandler(this.labelPlaylist_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Current (Don\'t change)"});
            this.comboBox1.Location = new System.Drawing.Point(97, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonCreatePlaylistFolder
            // 
            this.buttonCreatePlaylistFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreatePlaylistFolder.Location = new System.Drawing.Point(22, 241);
            this.buttonCreatePlaylistFolder.Name = "buttonCreatePlaylistFolder";
            this.buttonCreatePlaylistFolder.Size = new System.Drawing.Size(398, 23);
            this.buttonCreatePlaylistFolder.TabIndex = 3;
            this.buttonCreatePlaylistFolder.Text = "Create \"Playlists\" folder and copy in current playlist";
            this.buttonCreatePlaylistFolder.UseVisualStyleBackColor = true;
            this.buttonCreatePlaylistFolder.Click += new System.EventHandler(this.buttonCreatePlaylistFolder_Click);
            // 
            // textBoxNoPlaylist
            // 
            this.textBoxNoPlaylist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNoPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoPlaylist.Location = new System.Drawing.Point(22, 20);
            this.textBoxNoPlaylist.Multiline = true;
            this.textBoxNoPlaylist.Name = "textBoxNoPlaylist";
            this.textBoxNoPlaylist.ReadOnly = true;
            this.textBoxNoPlaylist.Size = new System.Drawing.Size(398, 215);
            this.textBoxNoPlaylist.TabIndex = 2;
            this.textBoxNoPlaylist.Text = resources.GetString("textBoxNoPlaylist.Text");
            // 
            // tabPageXlabs
            // 
            this.tabPageXlabs.Controls.Add(this.buttonXlabsOpenFolder);
            this.tabPageXlabs.Controls.Add(this.textBoxProfileDetails);
            this.tabPageXlabs.Controls.Add(this.buttonProfileCopyLabsToAyria);
            this.tabPageXlabs.Controls.Add(this.buttonProfileCopyNovaXlabs);
            this.tabPageXlabs.Controls.Add(this.buttonXlabsLauncher);
            this.tabPageXlabs.Controls.Add(this.buttonXlabsCoop);
            this.tabPageXlabs.Controls.Add(this.buttonXlabsSpecial);
            this.tabPageXlabs.Controls.Add(this.buttonXlabsMultiplayer);
            this.tabPageXlabs.Controls.Add(this.buttonXlabSingleplayer);
            this.tabPageXlabs.Controls.Add(this.linkLabel1);
            this.tabPageXlabs.Location = new System.Drawing.Point(4, 22);
            this.tabPageXlabs.Name = "tabPageXlabs";
            this.tabPageXlabs.Size = new System.Drawing.Size(442, 280);
            this.tabPageXlabs.TabIndex = 2;
            this.tabPageXlabs.Text = "X Labs Control";
            this.tabPageXlabs.UseVisualStyleBackColor = true;
            // 
            // buttonXlabsOpenFolder
            // 
            this.buttonXlabsOpenFolder.Location = new System.Drawing.Point(281, 246);
            this.buttonXlabsOpenFolder.Name = "buttonXlabsOpenFolder";
            this.buttonXlabsOpenFolder.Size = new System.Drawing.Size(145, 23);
            this.buttonXlabsOpenFolder.TabIndex = 9;
            this.buttonXlabsOpenFolder.Text = "Open X Labs Local Folder";
            this.buttonXlabsOpenFolder.UseVisualStyleBackColor = true;
            this.buttonXlabsOpenFolder.Click += new System.EventHandler(this.buttonXlabsOpenFolder_Click);
            // 
            // textBoxProfileDetails
            // 
            this.textBoxProfileDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxProfileDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProfileDetails.Location = new System.Drawing.Point(16, 141);
            this.textBoxProfileDetails.Multiline = true;
            this.textBoxProfileDetails.Name = "textBoxProfileDetails";
            this.textBoxProfileDetails.ReadOnly = true;
            this.textBoxProfileDetails.Size = new System.Drawing.Size(410, 53);
            this.textBoxProfileDetails.TabIndex = 8;
            this.textBoxProfileDetails.Text = resources.GetString("textBoxProfileDetails.Text");
            // 
            // buttonProfileCopyLabsToAyria
            // 
            this.buttonProfileCopyLabsToAyria.Location = new System.Drawing.Point(16, 200);
            this.buttonProfileCopyLabsToAyria.Name = "buttonProfileCopyLabsToAyria";
            this.buttonProfileCopyLabsToAyria.Size = new System.Drawing.Size(202, 23);
            this.buttonProfileCopyLabsToAyria.TabIndex = 7;
            this.buttonProfileCopyLabsToAyria.Text = "Copy X Labs Profile to Nova";
            this.buttonProfileCopyLabsToAyria.UseVisualStyleBackColor = true;
            this.buttonProfileCopyLabsToAyria.Click += new System.EventHandler(this.buttonProfileCopyLabsToAyria_Click);
            // 
            // buttonProfileCopyNovaXlabs
            // 
            this.buttonProfileCopyNovaXlabs.Location = new System.Drawing.Point(224, 200);
            this.buttonProfileCopyNovaXlabs.Name = "buttonProfileCopyNovaXlabs";
            this.buttonProfileCopyNovaXlabs.Size = new System.Drawing.Size(202, 23);
            this.buttonProfileCopyNovaXlabs.TabIndex = 6;
            this.buttonProfileCopyNovaXlabs.Text = "Copy Nova Profile to X Labs";
            this.buttonProfileCopyNovaXlabs.UseVisualStyleBackColor = true;
            this.buttonProfileCopyNovaXlabs.Click += new System.EventHandler(this.buttonProfileCopyNovaXlabs_Click);
            // 
            // buttonXlabsLauncher
            // 
            this.buttonXlabsLauncher.Location = new System.Drawing.Point(16, 19);
            this.buttonXlabsLauncher.Name = "buttonXlabsLauncher";
            this.buttonXlabsLauncher.Size = new System.Drawing.Size(410, 41);
            this.buttonXlabsLauncher.TabIndex = 5;
            this.buttonXlabsLauncher.Text = "Open Launcher";
            this.buttonXlabsLauncher.UseVisualStyleBackColor = true;
            this.buttonXlabsLauncher.Click += new System.EventHandler(this.buttonXlabsLauncher_Click);
            // 
            // buttonXlabsCoop
            // 
            this.buttonXlabsCoop.Location = new System.Drawing.Point(224, 66);
            this.buttonXlabsCoop.Name = "buttonXlabsCoop";
            this.buttonXlabsCoop.Size = new System.Drawing.Size(98, 33);
            this.buttonXlabsCoop.TabIndex = 4;
            this.buttonXlabsCoop.Text = "Survival";
            this.buttonXlabsCoop.UseVisualStyleBackColor = true;
            this.buttonXlabsCoop.Click += new System.EventHandler(this.buttonXlabsCoop_Click);
            // 
            // buttonXlabsSpecial
            // 
            this.buttonXlabsSpecial.Location = new System.Drawing.Point(120, 66);
            this.buttonXlabsSpecial.Name = "buttonXlabsSpecial";
            this.buttonXlabsSpecial.Size = new System.Drawing.Size(98, 33);
            this.buttonXlabsSpecial.TabIndex = 3;
            this.buttonXlabsSpecial.Text = "Zombies";
            this.buttonXlabsSpecial.UseVisualStyleBackColor = true;
            this.buttonXlabsSpecial.Click += new System.EventHandler(this.buttonXlabsSpecial_Click);
            // 
            // buttonXlabsMultiplayer
            // 
            this.buttonXlabsMultiplayer.Location = new System.Drawing.Point(16, 66);
            this.buttonXlabsMultiplayer.Name = "buttonXlabsMultiplayer";
            this.buttonXlabsMultiplayer.Size = new System.Drawing.Size(98, 33);
            this.buttonXlabsMultiplayer.TabIndex = 2;
            this.buttonXlabsMultiplayer.Text = "Multiplayer";
            this.buttonXlabsMultiplayer.UseVisualStyleBackColor = true;
            this.buttonXlabsMultiplayer.Click += new System.EventHandler(this.buttonXlabsMultiplayer_Click);
            // 
            // buttonXlabSingleplayer
            // 
            this.buttonXlabSingleplayer.Location = new System.Drawing.Point(328, 66);
            this.buttonXlabSingleplayer.Name = "buttonXlabSingleplayer";
            this.buttonXlabSingleplayer.Size = new System.Drawing.Size(98, 33);
            this.buttonXlabSingleplayer.TabIndex = 1;
            this.buttonXlabSingleplayer.Text = "Singleplayer";
            this.buttonXlabSingleplayer.UseVisualStyleBackColor = true;
            this.buttonXlabSingleplayer.Click += new System.EventHandler(this.buttonXlabSingleplayer_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(17, 251);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X Labs Website";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(88)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(477, 363);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonCoop);
            this.Controls.Add(this.buttonSpecial1);
            this.Controls.Add(this.buttonMultiplayer);
            this.Controls.Add(this.buttonSingleplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Nova Launcher";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPagePlaylistGeneral.ResumeLayout(false);
            this.tabPagePlaylistGeneral.PerformLayout();
            this.tabPageXlabs.ResumeLayout(false);
            this.tabPageXlabs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSingleplayer;
        private System.Windows.Forms.Button buttonMultiplayer;
        private System.Windows.Forms.Button buttonSpecial1;
        private System.Windows.Forms.Button buttonCoop;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.LinkLabel linkForum;
        private System.Windows.Forms.LinkLabel linkProject;
        private System.Windows.Forms.Button buttonClearUnneeded;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.TabPage tabPagePlaylistGeneral;
        private System.Windows.Forms.Label labelPlaylist;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxNoPlaylist;
        private System.Windows.Forms.Label labelAyria;
        private System.Windows.Forms.LinkLabel linkAriaID;
        private System.Windows.Forms.Button buttonCreatePlaylistFolder;
        private System.Windows.Forms.Button buttomPlaylistUpdate;
        private System.Windows.Forms.Label labelSelectedPlaylist;
        private System.Windows.Forms.TextBox textBoxCurrentPlaylist;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxArch;
        private System.Windows.Forms.Label labelArch;
        private System.Windows.Forms.TabPage tabPageXlabs;
        private System.Windows.Forms.Button buttonXlabsLauncher;
        private System.Windows.Forms.Button buttonXlabsCoop;
        private System.Windows.Forms.Button buttonXlabsSpecial;
        private System.Windows.Forms.Button buttonXlabsMultiplayer;
        private System.Windows.Forms.Button buttonXlabSingleplayer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonProfileCopyLabsToAyria;
        private System.Windows.Forms.Button buttonProfileCopyNovaXlabs;
        private System.Windows.Forms.Button buttonIdGenerate;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.TextBox textBoxProfileDetails;
        private System.Windows.Forms.Button buttonXlabsOpenFolder;
    }
}

