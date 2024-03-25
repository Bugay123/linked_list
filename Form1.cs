namespace linked_list
{
    public partial class Form1 : Form
    {
        private class Task
        {
            public string Title { get; set; }
            public string Description { get; set; }

            public Task(string title, string description)
            {
                Title = title;
                Description = description;
            }
        }

        private LinkedList<Task> tasks;

        public Form1()
        {
            InitializeComponent();
            tasks = new LinkedList<Task>();
        }

        private void UpdateTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in tasks)
            {
                listBoxTasks.Items.Add(task.Title);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;
            Task newTask = new Task(title, description);
            tasks.AddLast(newTask);
            UpdateTaskList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                string newTitle = textBoxTitle.Text;
                string newDescription = textBoxDescription.Text;
                Task selectedTask = tasks.ElementAt(listBoxTasks.SelectedIndex);
                selectedTask.Title = newTitle;
                selectedTask.Description = newDescription;
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                tasks.Remove(tasks.ElementAt(listBoxTasks.SelectedIndex));
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                Task selectedTask = tasks.ElementAt(listBoxTasks.SelectedIndex);
                textBoxTitle.Text = selectedTask.Title;
                textBoxDescription.Text = selectedTask.Description;
            }
        }
    }
}
