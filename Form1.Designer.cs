namespace linked_list
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
            listBoxTasks = new ListBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            textBoxTitle = new TextBox();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(140, 20);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(200, 259);
            listBoxTasks.TabIndex = 0;
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(20, 190);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(20, 215);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(20, 245);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(20, 40);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(20, 100);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(111, 80);
            textBoxDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(20, 80);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(88, 15);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Discription task";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "Task title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 301);
            Controls.Add(label1);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxTasks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTasks;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private TextBox textBoxTitle;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private Label label1;
    }
}
