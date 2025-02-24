using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_App
{
    public partial class taskControl : UserControl
    {
        public taskControl()
        {
            InitializeComponent();
        }

        public taskControl(string dueDate, string task)
        {
            InitializeComponent();
            taskLabel2.Text = "Task: " + task;
            dueDateLabel.Text = "Due Date: " + dueDate;
            doneButton.Click += doneButton_Click;
        }

        private void doneButton_Click(object? sender, EventArgs e) // Looked up how to fix warning CS8622, added the "?"
        {
            // Made this an if/else with ChatGPT's help. I could not figure out why it kept crashing everytime that
            // I hit "Mark Done". Deleting the control made the parent null and made it crash so I added the else return.
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }
            else
            {
                return;
            }
        }
    }
}
