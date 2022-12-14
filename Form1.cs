using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

// <@@@> and </@@@> mean the beginning and the end of
// code parts that are used for debugging/troubleshooting
// purposes. "@@@" at the beginning of a message also means
// that it's temporary for testing.

namespace stac
{
    public partial class Stac : Form
    {
        // This list contains the paths to all of the executables to be launched at Windows' startup.
        public List<string> started_progs = new List<string>();
        public List<string> runBtn_startingProgs = new List<string>();
        public List<string> args = new List<string>();

        string homePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).ToString();
        string latestProfile = "";

        public Stac()
        {
            InitializeComponent();

            // Autostarting Stac          
            try
            {
                RegisterInStartup(true);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Stac", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Code ran at startup         
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                args.Add(arg);               
            }

            StartupReadLatestProfileIni();

            if(args.Contains("--startup"))
            {
                StartProgs();
                Environment.Exit(0);
            }

            else
            {
                return;
            }
        }

        public async void SetLatestProfileIni()
        {
            using (TextWriter tw = new StreamWriter(new FileStream(homePath + "\\Stac\\stac.ini", FileMode.Create), System.Text.Encoding.UTF8))
            {
                await tw.WriteLineAsync("latestProfile=" + latestProfile);
            }
        }

        public void StartupReadLatestProfileIni()
        {                      
            if (Directory.Exists(homePath + "\\Stac"))
            {
                string iniDir = homePath + "\\Stac\\stac.ini";
                if(File.Exists(iniDir))
                {
                    string[] lines = File.ReadAllLines(iniDir);

                    foreach (string line in lines)
                    {
                        if (line.StartsWith("latestProfile="))
                        {
                            string[] parts = line.Split('=');
                            latestProfile = line;

                            // add profile content to listView
                            try
                            {
                                string readPath = latestProfile;
                                readPath = latestProfile.Replace("latestProfile=", "");
                                string[] lines_ = File.ReadAllLines(readPath);
                                foreach (string l in lines_)
                                {
                                    string[] parts_ = l.Split('\t');
                                    ListViewItem item = new ListViewItem(parts_[0]);
                                    item.SubItems.Add(parts_[1]);
                                    startedProgsList.Items.Add(item);

                                    string startup_added_item = parts_[1].ToString();

                                    started_progs.Add(startup_added_item);
                                }
                            }

                            catch(Exception e)
                            {
                                string readPath = latestProfile;
                                readPath = latestProfile.Replace("latestProfile=", "");

                                MessageBox.Show("Your latest profile wasn't found at path " + readPath, "Stac", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                
                else
                {
                    //MessageBox.Show("The profile file couldn't be loaded, so you can't automatically see the list of the programs in your profile. Please make sure you didn't mess with the config files!", "Stac", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            {
                Directory.CreateDirectory(homePath + "\\Stac");

                string iniDir = homePath + "\\Stac";
                if (File.Exists(iniDir))
                {
                    string[] lines = File.ReadAllLines(iniDir);

                    foreach (string line in lines)
                    {
                        if (line.StartsWith("latestProfile="))
                        {
                            string[] parts = line.Split('=');
                            MessageBox.Show(parts.ToString());
                            latestProfile = line;
                        }
                    }
                }

                else
                {
                    //MessageBox.Show("The profile file couldn't be loaded, so you can't automatically see the list of the programs in your profile. Please make sure you didn't mess with the config files!", "Stac", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void openExeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openExeDlg = new OpenFileDialog();

            openExeDlg.Title = "Open .exe file";
            openExeDlg.InitialDirectory = @"c:\";
            openExeDlg.Filter = "Executables (*.exe)|*.exe";
            openExeDlg.FilterIndex = 2;
            openExeDlg.RestoreDirectory = true;

            if (openExeDlg.ShowDialog() == DialogResult.OK)
            {
                foreach(string f in openExeDlg.FileNames)
                {
                    FileInfo fi = new FileInfo(f);
                    ListViewItem item = new ListViewItem(fi.Name);
                    item.SubItems.Add(fi.FullName);
                    startedProgsList.Items.Add(item);

                    started_progs.Add(openExeDlg.FileName);
                }       
            }
        }

        private void openProfileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openProfileDlg = new OpenFileDialog();

            openProfileDlg.Title = "Open .stac profile file";
            openProfileDlg.InitialDirectory = @"c:\";
            openProfileDlg.Filter = "Stac profile files (*.stac)|*.stac";
            openProfileDlg.FilterIndex = 2;
            openProfileDlg.RestoreDirectory = true;

            if (openProfileDlg.ShowDialog() == DialogResult.OK)
            {
                startedProgsList.Items.Clear();
                started_progs.Clear();

                latestProfile = openProfileDlg.FileNames[0];
                SetLatestProfileIni();

                string f = openProfileDlg.FileNames[0];
                string[] lines = File.ReadAllLines(f);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('\t');
                    ListViewItem item = new ListViewItem(parts[0]);
                    item.SubItems.Add(parts[1]);
                    startedProgsList.Items.Add(item);

                    started_progs.Add(parts[1]);
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (startedProgsList.SelectedItems.Count > 0)
                    startedProgsList.Items.Remove(startedProgsList.SelectedItems[0]);
                    started_progs.Remove(startedProgsList.SelectedItems[0].ToString());
            }
            
            catch(Exception exc)
            {
                return;
            }
            
        }

        private async void expBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog exportProfileDlg = new SaveFileDialog() { Filter = "Stac Saves|*.stac", ValidateNames = true })
            {
                if(exportProfileDlg.ShowDialog() == DialogResult.OK)
                {
                    using(TextWriter tw = new StreamWriter(new FileStream(exportProfileDlg.FileName, FileMode.Create), System.Text.Encoding.UTF8))
                    {
                        foreach(ListViewItem item in startedProgsList.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text);


                            string item_added_to_list = item.SubItems[1].ToString();
                            item_added_to_list = item_added_to_list.Replace("ListViewSubItem: {", "");
                            item_added_to_list = item_added_to_list.Replace("}", "");

                            started_progs.Add(item.ToString());
                        }

                        latestProfile = exportProfileDlg.FileNames[0];
                        SetLatestProfileIni();

                        MessageBox.Show("Profile exported successfully.", "Stac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            foreach (string prog in started_progs)
            {                
                foreach (ListViewItem item_ in startedProgsList.Items)
                {
                    runBtn_startingProgs.Add(item_.SubItems[1].Text);
                }

                Process.Start(prog);
            }
        }

        public void StartProgs()
        {
            string iniDir = homePath + "\\Stac\\stac.ini";

            if(Directory.Exists(homePath + "\\Stac"))
            {
                string[] startup_ini_file_lines = File.ReadAllLines(iniDir);
                string[] startup_ini_parts = startup_ini_file_lines[0].Split('=');

                string startup_opened_latest_profile_file = startup_ini_parts[1];

                string[] startup_opened_latest_profile_lines = File.ReadAllLines(startup_opened_latest_profile_file);

                started_progs.Clear();
                foreach (string line in startup_opened_latest_profile_lines)
                {
                    string[] parts = line.Split('\t');
                    started_progs.Add(parts[1]);
                }

                foreach (string prog in started_progs)
                {
                    //MessageBox.Show("@@@ [startup] prog in started_progs: " + prog);
                    Process.Start(prog);
                }                             
            }

            else
            {
                return;
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add - Add an executable to the profile.\nRemove - Remove an executable from the profile.\nExport - Export the profile.\nImport - Import a profile.\nRun - Runs all the programs in the list. Good for testing.\nInfo - Shows this dialog.\n\nThe programs that get started with Windows are the ones in your most recently opened profile.\n\nNote: Stac will automatically start whenever Windows boots up, but it will be invisible until you open it. Your programs will be started, and you won't see anything else that's automated.", "Stac Guide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("Stac", Application.ExecutablePath + " --startup");
            }
            else
            {
                registryKey.DeleteValue("Stac");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}