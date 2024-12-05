using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eilidh_finalproject
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToDo.Text))
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = txtToDo.Text,
                    AutoSize = true,
                    Margin = new Padding(5)
                };

                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                flpToDoList.Controls.Add(checkBox);
                txtToDo.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task!");
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                // Apply or remove strike-through effect based on checkbox state
                if (checkBox.Checked)
                {
                    checkBox.Font = new Font(checkBox.Font, FontStyle.Strikeout);
                }
                else
                {
                    checkBox.Font = new Font(checkBox.Font, FontStyle.Regular);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete finished tasks?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                foreach (Control control in flpToDoList.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        flpToDoList.Controls.Remove(control);
                        control.Dispose();
                    }
                }
            }
        }
    }
}
