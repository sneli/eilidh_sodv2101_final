namespace eilidh_finalproject
{
    partial class ToDoList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtToDo = new TextBox();
            btnAddToDo = new Button();
            flpToDoList = new FlowLayoutPanel();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtToDo
            // 
            txtToDo.AcceptsReturn = true;
            txtToDo.Location = new Point(8, 435);
            txtToDo.Multiline = true;
            txtToDo.Name = "txtToDo";
            txtToDo.PlaceholderText = "Add to List...";
            txtToDo.Size = new Size(178, 26);
            txtToDo.TabIndex = 0;
            // 
            // btnAddToDo
            // 
            btnAddToDo.BackColor = Color.FromArgb(250, 231, 209);
            btnAddToDo.FlatStyle = FlatStyle.Flat;
            btnAddToDo.ForeColor = Color.FromArgb(232, 172, 161);
            btnAddToDo.Location = new Point(190, 435);
            btnAddToDo.Name = "btnAddToDo";
            btnAddToDo.Size = new Size(54, 23);
            btnAddToDo.TabIndex = 1;
            btnAddToDo.Text = "Add";
            btnAddToDo.UseVisualStyleBackColor = false;
            btnAddToDo.Click += btnAddToDo_Click;
            // 
            // flpToDoList
            // 
            flpToDoList.Dock = DockStyle.Top;
            flpToDoList.FlowDirection = FlowDirection.TopDown;
            flpToDoList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flpToDoList.ForeColor = Color.White;
            flpToDoList.Location = new Point(0, 0);
            flpToDoList.Name = "flpToDoList";
            flpToDoList.Size = new Size(313, 429);
            flpToDoList.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(250, 231, 209);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(232, 172, 161);
            btnDelete.Location = new Point(250, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(54, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 220, 227);
            ClientSize = new Size(313, 465);
            Controls.Add(btnDelete);
            Controls.Add(flpToDoList);
            Controls.Add(btnAddToDo);
            Controls.Add(txtToDo);
            Name = "ToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDoList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtToDo;
        private Button btnAddToDo;
        private FlowLayoutPanel flpToDoList;
        private Button btnDelete;
    }
}