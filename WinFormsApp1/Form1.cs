namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            if (textBoxSurname.Text.Length == 0)
            {
                MessageBox.Show("Не введена фамилия");
                return;
            }

            TaskForm tf = new TaskForm(
                textBoxSurname.Text,     
                comboBoxClass.Text,      
                numericUpDownCount.Value,
                radioButtonHard.Checked
            );

            tf.ShowDialog();
        }
    }
}
