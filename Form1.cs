namespace WinFS_DZ_1
{
    public partial class MyApplication : Form
    {
        public MyApplication()
        {
            InitializeComponent();
        }

        private void ShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це інформаційне повідомлення", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenNonModal_Click(object sender, EventArgs e)
        {
            Form2 nonModalForm = new Form2();
            nonModalForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 modalForm = new Form3();
            modalForm.ShowDialog();
        }
    }
}
