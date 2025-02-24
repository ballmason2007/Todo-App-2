using System.Threading.Tasks;

namespace Todo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = taskTextBox1.Text;
            string dueDate = dueDateTextBox1.Text;

            //Couldn't make this line work to save my life so I google it. I forgot to put the variables. Simple mistake.
            if (string.IsNullOrWhiteSpace(task) || string.IsNullOrWhiteSpace(dueDate))
            {
                MessageBox.Show("Please fill out all necessary information.");
                return;
            }

            taskControl newTask = new taskControl(dueDate, task); 
            taskPanel.Controls.Add(newTask);

            taskTextBox1.Clear();
            dueDateTextBox1.Clear();
        }
    }
}
