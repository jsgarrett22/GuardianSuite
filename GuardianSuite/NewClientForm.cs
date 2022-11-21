namespace GuardianSuite
{
    public partial class NewClientForm : Form
    {
        public NewClientForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a valid name.");
            } else if (listNames.Items.Contains(txtName.Text))
            {
                MessageBox.Show("That name already exists in the list. Please try again.");
            }
            {
                string newMember = txtName.Text;
                listNames.Items.Add(newMember);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            listNames.Items.Clear();
        }
    }
}