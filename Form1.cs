namespace stac
{
    public partial class Stac : Form
    {
        public List<string> started_progs = new List<string>();

        public Stac()
        {
            InitializeComponent();
        }

        private void openExeBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openExeDlg = new OpenFileDialog();

            openExeDlg.Title = "Open .exe file";
            openExeDlg.InitialDirectory = @"c:\";
            openExeDlg.Filter = "ExeCuties (*.exe)|*.exe|ExeCuties (*.exe)|*.exe";
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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (startedProgsList.Items.Count > 0)
                startedProgsList.Items.Remove(startedProgsList.SelectedItems[0]);
        }
    }
}