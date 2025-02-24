
using System.Threading.Tasks;

namespace Todo_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskFormTextBox = new Label();
            taskLabel1 = new Label();
            dueDateLabel1 = new Label();
            taskTextBox1 = new TextBox();
            addButton = new Button();
            clearButton = new Button();
            taskListTextBox = new Label();
            taskPanel = new FlowLayoutPanel();
            dueDateTextBox1 = new TextBox();
            topBorder = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)topBorder).BeginInit();
            SuspendLayout();
            // 
            // taskFormTextBox
            // 
            taskFormTextBox.AutoSize = true;
            taskFormTextBox.Location = new Point(20, 9);
            taskFormTextBox.Name = "taskFormTextBox";
            taskFormTextBox.Size = new Size(61, 15);
            taskFormTextBox.TabIndex = 0;
            taskFormTextBox.Text = "Task Form";
            // 
            // taskLabel1
            // 
            taskLabel1.AutoSize = true;
            taskLabel1.Location = new Point(20, 40);
            taskLabel1.Name = "taskLabel1";
            taskLabel1.Size = new Size(30, 15);
            taskLabel1.TabIndex = 1;
            taskLabel1.Text = "Task";
            // 
            // dueDateLabel1
            // 
            dueDateLabel1.AutoSize = true;
            dueDateLabel1.Location = new Point(20, 69);
            dueDateLabel1.Name = "dueDateLabel1";
            dueDateLabel1.Size = new Size(55, 15);
            dueDateLabel1.TabIndex = 2;
            dueDateLabel1.Text = "Due Date";
            // 
            // taskTextBox1
            // 
            taskTextBox1.Location = new Point(81, 37);
            taskTextBox1.Name = "taskTextBox1";
            taskTextBox1.Size = new Size(252, 23);
            taskTextBox1.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.Location = new Point(258, 95);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(177, 95);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // taskListTextBox
            // 
            taskListTextBox.AutoSize = true;
            taskListTextBox.Location = new Point(19, 132);
            taskListTextBox.Name = "taskListTextBox";
            taskListTextBox.Size = new Size(56, 15);
            taskListTextBox.TabIndex = 10;
            taskListTextBox.Text = "Tasks List";
            // 
            // taskPanel
            // 
            taskPanel.AutoSize = true;
            taskPanel.BorderStyle = BorderStyle.FixedSingle;
            taskPanel.FlowDirection = FlowDirection.TopDown;
            taskPanel.Location = new Point(12, 140);
            taskPanel.Name = "taskPanel";
            taskPanel.Size = new Size(338, 298);
            taskPanel.TabIndex = 11;
            taskPanel.WrapContents = false;
            // 
            // dueDateTextBox1
            // 
            dueDateTextBox1.Location = new Point(81, 66);
            dueDateTextBox1.Name = "dueDateTextBox1";
            dueDateTextBox1.Size = new Size(252, 23);
            dueDateTextBox1.TabIndex = 12;
            // 
            // topBorder
            // 
            topBorder.BorderStyle = BorderStyle.FixedSingle;
            topBorder.Location = new Point(12, 16);
            topBorder.Name = "topBorder";
            topBorder.Size = new Size(338, 113);
            topBorder.TabIndex = 13;
            topBorder.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 450);
            Controls.Add(taskListTextBox);
            Controls.Add(dueDateTextBox1);
            Controls.Add(taskPanel);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(taskTextBox1);
            Controls.Add(dueDateLabel1);
            Controls.Add(taskLabel1);
            Controls.Add(taskFormTextBox);
            Controls.Add(topBorder);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)topBorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskFormTextBox;
        private Label taskLabel1;
        private Label dueDateLabel1;
        private TextBox taskTextBox1;
        private Button addButton;
        private Button clearButton;
        private Label taskListTextBox;
        private FlowLayoutPanel taskPanel;
        private TextBox dueDateTextBox1;
        private PictureBox topBorder;
    }
}
