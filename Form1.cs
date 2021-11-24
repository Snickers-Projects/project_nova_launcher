using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project_Nova_Launcher;

namespace Project_Nova_Launcher
{
    public partial class Form1 : Form
    {
        private string Game;
        private string OriginalUserID        = "";
        private string OriginalUsername      = "";
        private string SingleplayerExec      = "";
        private string MultiplayerExec       = "";
        private string SpecialExec           = "";
        private string CoopExec              = "";
        private string SelectedPlaylist      = "Current (Don't change)";
        private string AyriaID               = "";
        private string PlaylistExtension     = ".aggr";
        private string CurrentPlaylist       = "Unknown";
        private string current_playlist_file = "";
        private string game_arch             = "Unknown";
        private string xlabsExec             = "Unknown";
        private string xlabsGameExe          = "";

        static Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            precheck();

            if (File.Exists("Ayria\\Assets\\Platformwrapper\\UserID.txt"))
            {
                var idtext = "Ayria\\Assets\\Platformwrapper\\UserID.txt";
                OriginalUserID = File.ReadLines(idtext).First();
            }
            else
            {
                comboBoxID.Enabled = false;
            }

            if (File.Exists("Ayria\\Assets\\Platformwrapper\\Username.txt"))
            {
                var nametext = "Ayria\\Assets\\Platformwrapper\\Username.txt";
                textBoxName.Text = File.ReadLines(nametext).First();
                OriginalUsername = textBoxName.Text;
            }
            else
            {
                textBoxName.Enabled = false;
            }

            Helpers helperClass = new Helpers();
            this.Game = helperClass.DetectGame();

            textBoxDetails.Text = Game;

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            updateButtons();
            GetPlaylistName();

            if(AyriaID.Length > 0)
            {
                if (!Directory.Exists(@"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\Server\"))
                {
                    MessageBox.Show(Game+ " and Ayria were detected but the server files for your game aren't available in your Ayria folder, expecting ID: " + AyriaID+". You should reinstall Project Nova");
                    //Environment.Exit(0);
                }

                current_playlist_file = @"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\Server\selected_playlist.txt";
                get_current_playlist();
            }

            get_playlists();

            // Get a list of ID's from the folders
            string[] id_directories = Directory.GetDirectories(@"Ayria\Assets\Alwaysoffline\" + AyriaID);
            int i = 0;
            bool ID_exists = false;
            foreach (string filePath in id_directories)
            {
                var dirName = new DirectoryInfo(filePath).Name;

                if (dirName.StartsWith("1100001"))
                {

                    comboBoxID.Items.Add(dirName.Substring(dirName.Length - 8));
                    if (dirName.Substring(dirName.Length - 8) == OriginalUserID)
                    {
                        comboBoxID.SelectedIndex = i;
                        ID_exists = true;
                    }
                        
                }
                i++;
            }
            if (!ID_exists)
            {
                comboBoxID.Items.Add(OriginalUserID);
                comboBoxID.Text = OriginalUserID;
            }

            // Check to see if both profiles exist, if not, disable the xlabs buttons
            var profile_id = comboBoxID.Text.PadLeft(8, '0');
            var novaidfoldername = "1100001" + comboBoxID.Text.Substring(profile_id.Length - 8);
            if (!File.Exists(@"players2\user\mpdata") || !File.Exists(@"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\" + novaidfoldername + @"\mpdata"))
            {
                buttonProfileCopyLabsToAyria.Enabled = false;
            }


            // Check for xlabs .exe and load controls for it.
            xlabs_init();
        }

        private void precheck()
        {

            if(!Directory.Exists("Ayria"))
            {
                MessageBox.Show("Please make sure the Ayria folder is in your game folder");
                Environment.Exit(0);
            }

            this.comboBoxID.KeyPress += new KeyPressEventHandler(comboBoxID_KeyPress);

        }

        private void buttonSingleplayer_Click(object sender, EventArgs e)
        {
            save_all();

            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Ayria\\Injector"+game_arch+".exe");
            p.StartInfo.Arguments = SingleplayerExec;

            p.Start();
            Environment.Exit(0);
        }

        private void textBoxDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != '\b' && !((c <= 0x66 && c >= 61) || (c <= 0x46 && c >= 0x41) || (c >= 0x30 && c <= 0x39)))
            {
                e.Handled = true;
            }

            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.KeyChar -= (char)32;
        }

        private void updateButtons()
        {
            if (Game != "Unknown/Unsupported")
            {
                this.Text                   = Game;
                labelAyria.Visible          = true;
                buttonClearUnneeded.Visible = true;
            }

            //################## Call of Duty Modern Warfare 3 ##################\\
            if (Game == "Call of Duty Modern Warfare 3")
            {
                game_arch = "32";
                AyriaID = "18409";
                linkAriaID.Text = "18409";
                if (File.Exists("iw5sp.exe"))
                {
                    SingleplayerExec = "iw5sp.exe";
                    buttonSingleplayer.Visible = true;
                }
                if (File.Exists("iw5mp.exe"))
                {
                    MultiplayerExec = "iw5mp.exe";
                    buttonMultiplayer.Visible = true;
                }
            }
            //################## Call of Duty Ghosts ##################\\
            if (Game == "Call of Duty Ghosts")
            {
                game_arch = "64";
                AyriaID = "5344";
                linkAriaID.Text = "5344";
                if (File.Exists("iw6sp64_ship.exe"))
                {
                    SingleplayerExec = "iw6sp64_ship.exe";
                    buttonSingleplayer.Visible = true;
                }
                if (File.Exists("iw6mp64_ship.exe"))
                {
                    MultiplayerExec = "iw6mp64_ship.exe";
                    buttonMultiplayer.Visible = true;
                }
            }
            //################## Call of Duty Advanced Warfare ##################\\
            if (Game == "Call of Duty Advanced Warfare")
            {
                game_arch = "64";
                AyriaID = "5416";
                linkAriaID.Text = "5416";
                if (File.Exists("s1_sp64_ship.exe"))
                {
                    SingleplayerExec = "s1_sp64_ship.exe";
                    buttonSingleplayer.Visible = true;
                }
                if (File.Exists("s1_mp64_ship.exe"))
                {
                    MultiplayerExec = "s1_mp64_ship.exe";
                    SpecialExec     = "s1_mp64_ship.exe +zombiesMode 1";
                    CoopExec        = "s1_mp64_ship.exe +survival 1";
                    buttonMultiplayer.Visible = true;
                    buttonSpecial1.Visible    = true;
                    buttonSpecial1.Text       = "Exo Zombies";
                    buttonCoop.Visible        = true;
                    buttonCoop.Text = "Exo Survival";
                }
            }
            //################## Call of Duty Black Ops ##################\\
            if (Game == "Call of Duty Black Ops")
            {
                game_arch = "32";
                AyriaID = "1004";
                linkAriaID.Text = "1004";
                if (File.Exists("blackops.exe"))
                {
                    SingleplayerExec = "blackops.exe";
                    buttonSingleplayer.Visible = true;
                }
                if (File.Exists("blackopsmp.exe"))
                {
                    MultiplayerExec = "blackopsmp.exe";
                    buttonMultiplayer.Visible = true;
                }
            }
            //################## Call of Duty Black Ops 2 ##################\\
            if (Game == "Call of Duty Black Ops 2")
            {
                game_arch = "32";
                AyriaID = "18397";
                linkAriaID.Text = "18397";
                if (File.Exists("t6sp.exe"))
                {
                    SingleplayerExec = "t6sp.exe";
                    buttonSingleplayer.Visible = true;
                }
                if (File.Exists("t6zm.exe"))
                {
                    SpecialExec = "t6zm.exe";
                    buttonSpecial1.Visible = true;
                    buttonSpecial1.Text = "Zombies";
                }

                if (File.Exists("t6mp.exe"))
                {
                    MultiplayerExec = "t6mp.exe";
                    buttonMultiplayer.Visible = true;
                }
            }
            //################## Call of Duty Modern Warfare Remastered ##################\\
            if (Game == "Call of Duty Modern Warfare Remastered")
            {
                game_arch = "64";
                AyriaID = "5636";
                linkAriaID.Text = "5636";
                if (File.Exists("h1_sp64_ship.exe"))
                {
                    SingleplayerExec = "h1_sp64_ship.exe";
                    buttonSingleplayer.Visible = true;
                }
                if (File.Exists("h1_mp64_ship.exe"))
                {
                    MultiplayerExec = "h1_mp64_ship.exe";
                    buttonMultiplayer.Visible = true;
                }
            }
            //################## Blur ##################\\
            if (Game == "Blur")
            {
                game_arch = "32";
                AyriaID = "5275";
                linkAriaID.Text = "5275";
                if (File.Exists("blur.exe"))
                {
                    SingleplayerExec = "blur.exe";
                    buttonSingleplayer.Visible = true;
                }
            }

            if (game_arch == "32") textBoxArch.Text = "32 bit";
            if (game_arch == "64") textBoxArch.Text = "64 bit";
        }

        private void buttonMultiplayer_Click(object sender, EventArgs e)
        {
            save_all();

            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Ayria\\Injector" + game_arch + ".exe");
            p.StartInfo.Arguments = MultiplayerExec;

            p.Start();
            Environment.Exit(0);
        }

        private void buttonSpecial1_Click(object sender, EventArgs e)
        {
            save_all();

            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Ayria\\Injector" + game_arch + ".exe");
            p.StartInfo.Arguments = SpecialExec;

            p.Start();
            Environment.Exit(0);
        }

        private void buttonCoop_Click(object sender, EventArgs e)
        {
            save_all();

            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = Path.GetFullPath("Ayria\\Injector" + game_arch + ".exe");
            p.StartInfo.Arguments = CoopExec;

            p.Start();
            Environment.Exit(0);
        }

        private void linkProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://projectnova.us/");
        }

        private void linkForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://projectnova.us/community/");
        }

        private void get_playlists()
        {
            string playlist_directory    = "Playlists";

            comboBox1.SelectedIndex = 0;

            if (Directory.Exists(playlist_directory) && !IsDirectoryEmpty(playlist_directory))
            {                
                textBoxNoPlaylist.Visible          = false;
                buttonCreatePlaylistFolder.Visible = false;
                labelPlaylist.Visible              = true;
                comboBox1.Visible                  = true;
                buttomPlaylistUpdate.Visible       = true;

                textBoxCurrentPlaylist.Visible = true;
                labelSelectedPlaylist.Visible = true;
                
                comboBox1.Items.Clear();
                comboBox1.Items.Add(SelectedPlaylist);
                comboBox1.SelectedIndex = 0;

                string[] playlist_files = Directory.GetFiles(playlist_directory);
                foreach (string filePath in playlist_files)
                {
                    if(Path.GetExtension(filePath) == PlaylistExtension)
                    {
                        comboBox1.Items.Add(Path.GetFileNameWithoutExtension(filePath));
                    }
                }
            }
            else
            {
                // Hide playlist controls
                labelPlaylist.Visible              = false;
                comboBox1.Visible                  = false;
                textBoxNoPlaylist.Visible          = true;
                buttonCreatePlaylistFolder.Visible = true;
                buttomPlaylistUpdate.Visible       = false;

                textBoxCurrentPlaylist.Visible = false;
                labelSelectedPlaylist.Visible = false;
            }
        }

        private void get_current_playlist()
        {
            if (!Directory.Exists(@"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\Server\"))
            {
                buttonClearUnneeded.Visible = false;
                return;
            }

            if (File.Exists(current_playlist_file))
            {
                if(File.ReadLines(current_playlist_file).Count() > 0)
                {
                    CurrentPlaylist = File.ReadLines(current_playlist_file).First();
                }
            }
            else
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(current_playlist_file))
                {
                    sw.WriteLine(CurrentPlaylist);
                    sw.Close();
                }
            }

            textBoxCurrentPlaylist.Text = CurrentPlaylist;
        }

        private void save_current_playlist()
        {
            // Save playlist value to file
            File.WriteAllText(current_playlist_file, SelectedPlaylist);
        }

        private void save_all()
        {
            // Save the User ID
            var IdfileName = @"Ayria\Assets\Platformwrapper\UserID.txt";
            if (File.Exists(IdfileName))
            {
                string Idlines = File.ReadAllText(IdfileName);
                Idlines.Replace("\r", "");
                File.WriteAllText(IdfileName, comboBoxID.Text.PadLeft(8, '0'));
            }

            // Save the Username
            var NamefileName = @"Ayria\Assets\Platformwrapper\Username.txt";
            if (File.Exists(NamefileName))
            {
                string Namelines = File.ReadAllText(NamefileName);
                Namelines.Replace("\r", "");
                File.WriteAllText(NamefileName, textBoxName.Text);
            }

            // Update Playlist
            if(SelectedPlaylist != "Current (Don't change)")
            {
                string playlistName        = GetPlaylistName();
                string playlistReplaceName = SelectedPlaylist + PlaylistExtension;

                if (File.Exists(@"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\Server\" + playlistName))
                    File.Delete(@"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\Server\" + playlistName);

                File.Copy(@"Playlists\"+playlistReplaceName, @"Ayria\Assets\Alwaysoffline\"+ AyriaID + @"\Server\" + playlistName);

                save_current_playlist();
            }

        }

        public bool IsDirectoryEmpty(string path)
        {
            IEnumerable<string> items = Directory.EnumerateFileSystemEntries(path);
            using (IEnumerator<string> en = items.GetEnumerator())
            {
                return !en.MoveNext();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            object selectedItem = cmb.SelectedItem;
            if(selectedItem != null)
            {
                SelectedPlaylist = selectedItem.ToString();
            }

        }

        private void labelPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void labelAyria_Click(object sender, EventArgs e)
        {

        }

        private void tabPageMain_Click(object sender, EventArgs e)
        {

        }

        private void linkAriaID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(AyriaID.Length > 0)
            {
                string AyriaFolder = Path.GetFullPath(@"Ayria\Assets\Alwaysoffline\" + AyriaID);
                AyriaFolder = AddQuotesIfRequired(AyriaFolder);
                Process.Start(AyriaFolder);
            }
        }

        public string AddQuotesIfRequired(string path)
        {
            return !string.IsNullOrWhiteSpace(path) ?
                path.Contains(" ") && (!path.StartsWith("\"") && !path.EndsWith("\"")) ?
                    "\"" + path + "\"" : path :
                    string.Empty;
        }

        private void buttonClearUnneeded_Click(object sender, EventArgs e)
        {
            if (AyriaID.Length > 0 && game_arch != "Unknown")
            {
                var confirmResult = MessageBox.Show("Are you sure you want to clear all Ayria content not used by "+ Game+ Environment.NewLine+ Environment.NewLine +
                    "This action cannot be undone so only do this if the info in the launcher appears correct.",
                                     "Clear Ayria content?",
                                     MessageBoxButtons.YesNo);

                if (confirmResult != DialogResult.Yes) return;

                // Remove other game files in Ayria
                string ayria_directory = @"Ayria\Assets\Alwaysoffline\";
                string[] ayria_folders = Directory.GetDirectories(ayria_directory);
                
                foreach (string folder in ayria_folders)
                {
                    var dirName = new DirectoryInfo(folder).Name;
                    if (dirName != AyriaID)
                    {
                        string folderpath = AddQuotesIfRequired(folder).Replace(@"\", @"\\");
                        Directory.Delete(folderpath, true);
                    }
                }

                // Remove architecture files not used by current game
                if (game_arch == "32")
                {
                    File.Delete("Ayria\\Injector64.exe");
                    File.Delete("Ayria\\Bootstrapper64.dll");
                }

                if (game_arch == "64")
                {
                    File.Delete("Ayria\\Injector32.exe");
                    File.Delete("Ayria\\Bootstrapper32.dll");
                }

                // Delete plugin files that aren't used by the current architecture
                string plugin_directory = @"Ayria\Plugins\";
                string[] plugin_folder = Directory.GetFiles(plugin_directory);
                foreach (string plugin_file in plugin_folder)
                {

                    var pluginName = new DirectoryInfo(plugin_file).Name;
                    if (pluginName.Substring(pluginName.Length - 2) != game_arch)
                    {
                        string filepath = AddQuotesIfRequired(plugin_file).Replace(@"\", @"\\");
                        File.Delete(filepath);
                    }
                }

                // Clear logs
                DirectoryInfo logs_directory = new DirectoryInfo(@"Ayria\Logs\");

                foreach (FileInfo file in logs_directory.GetFiles())
                {
                    file.Delete();
                }
            }
        }

        private void buttonCreatePlaylistFolder_Click(object sender, EventArgs e)
        {
            // Create the playlists folder
            if(!Directory.Exists("Playlists")) Directory.CreateDirectory("Playlists");

            // Copy in Playlist
            if (IsDirectoryEmpty("Playlists") && AyriaID.Length > 0 && GetPlaylistName().Length > 0)
            {
                string playlistName = GetPlaylistName();
                string playlistReplaceName = "Original Playlist" + PlaylistExtension;
                if(!File.Exists(@"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\Server\" + playlistName))
                {
                    MessageBox.Show("Cannot find the original playlist, expecting : " + @"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\Server\" + playlistName);
                    return;
                }
                if (!File.Exists(@"Playlists\" + playlistReplaceName))
                    File.Copy(@"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\Server\" + playlistName, @"Playlists\" + playlistReplaceName);
            }

            get_playlists();
        }

        private string GetPlaylistName()
        {
            if (AyriaID == "1004")
            {
                PlaylistExtension = ".info";
                return "mp_playlists_shipRetail_release.info";
            }
            if (AyriaID == "5275") return "";
            if (AyriaID == "5344") return "playlists_tu14.aggr";
            if (AyriaID == "5416") return "playlists_tu22.aggr";
            if (AyriaID == "5512") return "";
            if (AyriaID == "5636") return "playlists_tu1.aggr";
            if (AyriaID == "18397")
            {
                PlaylistExtension = ".wad";
                return "online_tu17_mp_english.wad"; // online_tu17_mp_english.wad
            }
            if (AyriaID == "18409") return "playlists_tu21.aggr";

            return "";
        }

        private void buttomPlaylistUpdate_Click(object sender, EventArgs e)
        {
            get_playlists();
        }

        private void textBoxCurrentPlaylist_TextChanged(object sender, EventArgs e)
        {

        }

        private void xlabs_init()
        {
            buttonXlabSingleplayer.Visible = false;
            buttonXlabsMultiplayer.Visible = false;
            buttonXlabsSpecial.Visible     = false;
            buttonXlabsCoop.Visible        = false;
            buttonXlabsLauncher.Visible    = false;
            buttonXlabsOpenFolder.Visible  = false;

            if (File.Exists("xlabs.exe")) // New launcher
            {
                xlabsExec = "xlabs.exe";

                if (Game == "Call of Duty Ghosts")           xlabsGameExe = "iw6x.exe";
                if (Game == "Call of Duty Advanced Warfare") xlabsGameExe = "s1x.exe";

                buttonXlabsLauncher.Visible = true;
            }

            if (File.Exists("s1x.exe")) // Call of Duty Advanced Warfare
            {
                xlabsExec = "s1x.exe";

                buttonXlabsLauncher.Visible    = true;
                buttonXlabSingleplayer.Visible = true;
                buttonXlabsMultiplayer.Visible = true;
                buttonXlabsSpecial.Visible     = true;
                buttonXlabsCoop.Visible        = true;
            }

            if (File.Exists("iw6x.exe")) // Call of Duty Ghosts
            {
                xlabsExec = "iw6x.exe";

                buttonXlabsLauncher.Visible    = true;
                buttonXlabSingleplayer.Visible = true;
                buttonXlabsMultiplayer.Visible = true;
            }

            string localapppath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (Directory.Exists(localapppath+"\\xlabs"))
            {
                buttonXlabsOpenFolder.Visible = true;
            }

            if (xlabsExec == "Unknown")
            {
                tabControlMain.TabPages.Remove(tabPageXlabs);
            }


        }

        private void buttonXlabSingleplayer_Click(object sender, EventArgs e)
        {
            save_all();

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath(xlabsExec);
            p.StartInfo.Arguments = "-singleplayer";

            p.Start();
            Environment.Exit(0);
        }

        private void buttonXlabsMultiplayer_Click(object sender, EventArgs e)
        {
            save_all();

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath(xlabsExec);
            p.StartInfo.Arguments = "-multiplayer";

            p.Start();
            Environment.Exit(0);
        }

        private void buttonXlabsSpecial_Click(object sender, EventArgs e)
        {
            save_all();

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath(xlabsExec);
            p.StartInfo.Arguments = "-zombies";

            p.Start();
            Environment.Exit(0);
        }

        private void buttonXlabsCoop_Click(object sender, EventArgs e)
        {
            save_all();

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath(xlabsExec);
            p.StartInfo.Arguments = "-survival";

            p.Start();
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://xlabs.dev/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = GetRandomHexNumber(8);
            comboBoxID.Text = ID;
        }

        public static string GetRandomHexNumber(int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check to see if both profiles exist, if not, disable the xlabs buttons

            buttonProfileCopyLabsToAyria.Enabled = true;
            buttonProfileCopyNovaXlabs.Enabled   = true;
            var profile_id = comboBoxID.Text.PadLeft(8, '0');

            var novaidfoldername = "1100001" + comboBoxID.Text.Substring(profile_id.Length - 8);
            if (!File.Exists(@"players2\user\mpdata") || !File.Exists(@"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\" + novaidfoldername + @"\mpdata"))
            {
                buttonProfileCopyLabsToAyria.Enabled = false;
                buttonProfileCopyNovaXlabs.Enabled   = false;
            }
        }

        private void buttonProfileCopyLabsToAyria_Click(object sender, EventArgs e)
        {
            var profile_id = comboBoxID.Text.PadLeft(8, '0');
            var novaidfoldername = "1100001" + comboBoxID.Text.Substring(profile_id.Length - 8);

            var novampdata = @"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\" + novaidfoldername + @"\mpdata";
            var novampdata2 = @"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\" + novaidfoldername + @"\mpdata2";
            var novampdataex = @"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\" + novaidfoldername + @"\mpdataex";

            var confirmResult = MessageBox.Show("Copy your xlabs profile your Ayria ("+novaidfoldername+ ") profile ?",
                "Update Nova Profile?",
                MessageBoxButtons.YesNo);

            if (confirmResult != DialogResult.Yes) return;

            if (File.Exists(novampdata))
            {
                File.Delete(novampdata);
                File.Copy(@"players2\user\mpdata", novampdata);
            }

            if (File.Exists(novampdata2))
            {
                File.Delete(novampdata2);
                File.Copy(@"players2\user\mpdata2", novampdata2);
            }

            if (File.Exists(novampdataex))
            {
                File.Delete(novampdataex);
                File.Copy(@"players2\user\mpdataex", novampdataex);
            }
        }

        private void buttonProfileCopyNovaXlabs_Click(object sender, EventArgs e)
        {
            var profile_id = comboBoxID.Text.PadLeft(8, '0');
            var novaidfoldername = "1100001" + comboBoxID.Text.Substring(profile_id.Length - 8);

            var novampdata = @"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\" + novaidfoldername + @"\mpdata";
            var novampdata2 = @"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\" + novaidfoldername + @"\mpdata2";
            var novampdataex = @"Ayria\Assets\Alwaysoffline\" + AyriaID + @"\" + novaidfoldername + @"\mpdataex";

            var confirmResult = MessageBox.Show("Copy your Ayria profile (" + novaidfoldername + ") to X Labs?",
                "Update Nova Profile?",
                MessageBoxButtons.YesNo);


            if (File.Exists(@"players2\user\mpdata"))
            {
                File.Delete(@"players2\user\mpdata");
                File.Copy(novampdata, @"players2\user\mpdata");
            }

            if (File.Exists(@"players2\user\mpdata2"))
            {
                File.Delete(@"players2\user\mpdata2");
                File.Copy(novampdata2, @"players2\user\mpdata2");
            }

            if (File.Exists(@"players2\user\mpdataex"))
            {
                File.Delete(@"players2\user\mpdataex");
                File.Copy(novampdataex, @"players2\user\mpdataex");
            }
        }

        private void buttonXlabsLauncher_Click(object sender, EventArgs e)
        {
            save_all();
            //set GAME_EXE =% localappdata %\xlabs\data\iw6x\iw6x.exe
            //Process.Start(Path.GetFullPath(xlabsExec));
           // Environment.Exit(0);

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath(xlabsExec);
            //if(xlabsGameExe == "iw6x.exe") p.StartInfo.Arguments = "start %localappdata%\\xlabs\\data\\iw6x\\iw6x.exe";
            //if(xlabsGameExe == "s1x.exe")  p.StartInfo.Arguments = "start %localappdata%\\xlabs\\data\\s1x\\s1x.exe";

            p.Start();
            Environment.Exit(0);
        }

        private void buttonXlabsOpenFolder_Click(object sender, EventArgs e)
        {
            string localapppath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            Process.Start(new ProcessStartInfo()
            {
                FileName = localapppath+"\\xlabs",
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }
}
