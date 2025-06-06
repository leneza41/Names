using System.Diagnostics;

namespace Names
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
            }
        }

        private void Names_Load(object sender, EventArgs e)
        {

        }
    }
}
