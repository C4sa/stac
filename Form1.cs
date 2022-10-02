using Microsoft.VisualBasic;
using System.Text;
using System.Diagnostics;

namespace stac
{
    public partial class Stac : Form
    {
        // This list contains the paths to all of the executables to be launched at Windows' startup.
        public List<string> started_progs = new List<string>();

        public Stac()
        {
            InitializeComponent();
            
            // Code ran at startup
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

                string f = openProfileDlg.FileNames[0];
                string[] lines = System.IO.File.ReadAllLines(f);
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
            if (startedProgsList.Items.Count > 0)
            {
                startedProgsList.Items.Remove(startedProgsList.SelectedItems[0]);
                started_progs.Remove(startedProgsList.SelectedItems[0].ToString());
            }
        }

        private async void expBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Stac Saves|*.stac", ValidateNames = true })
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using(TextWriter tw = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach(ListViewItem item in startedProgsList.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text);

                            started_progs.Add(item.ToString());
                        }

                        MessageBox.Show("Programs exported successfully.", "Stac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < started_progs.Count; i++)
            {
                Process.Start(started_progs[i]);
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add - Add an executable to the profile.\nRemove - Remove an executable from the profile.\nExport - Export the profile.\nImport - Import a profile.\nRun - Runs all the programs in the list. Good for testing.\nInfo - Shows this dialog.", "Stac Guide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}