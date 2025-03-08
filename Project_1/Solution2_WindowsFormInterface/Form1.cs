using System.Diagnostics;

namespace Solution2_WindowsFormInterface
{
    public partial class Project1_Interface : Form
    {
        public Project1_Interface()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string consoleAppRelativePath = @"..\..\..\..\Project_1\bin\Debug\Project_1.exe";
            string consoleAppPath = Path.Combine(projectDirectory, consoleAppRelativePath);

            //Create a new process.
            Process process = new Process();
            process.StartInfo.FileName = consoleAppPath;

            //Start the process.
            try { process.Start(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { process.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string consoleAppRelativePath = @"..\..\..\..\Solution2_FermatNumbers\bin\Debug\net8.0\Solution2_FermatNumbers.exe";
            //Project_1\Solution2_FermatNumbers\bin\Debug\net8.0
            string consoleAppPath = Path.Combine(projectDirectory, consoleAppRelativePath);

            //Create a new process.
            Process process = new Process();
            process.StartInfo.FileName = consoleAppPath;

            //Start the process.
            try { process.Start(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { process.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
