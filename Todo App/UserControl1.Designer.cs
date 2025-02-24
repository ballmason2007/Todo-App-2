namespace Todo_App
{
    partial class taskControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            doneButton = new Button();
            dueDateLabel = new Label();
            taskLabel2 = new Label();
            SuspendLayout();
            // 
            // doneButton
            // 
            doneButton.Location = new Point(118, 14);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(75, 23);
            doneButton.TabIndex = 2;
            doneButton.Text = "Mark Done";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dueDateLabel.Location = new Point(3, 18);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(63, 15);
            dueDateLabel.TabIndex = 5;
            dueDateLabel.Text = "Due Date:";
            // 
            // taskLabel2
            // 
            taskLabel2.AutoSize = true;
            taskLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            taskLabel2.Location = new Point(3, 43);
            taskLabel2.Name = "taskLabel2";
            taskLabel2.Size = new Size(34, 15);
            taskLabel2.TabIndex = 6;
            taskLabel2.Text = "Task:";
            // 
            // taskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskLabel2);
            Controls.Add(dueDateLabel);
            Controls.Add(doneButton);
            Name = "taskControl";
            Size = new Size(196, 135);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskLabel;
        private Button doneButton;
        private Label dueDateLabel;
        private Label taskLabel2;
    }
}
