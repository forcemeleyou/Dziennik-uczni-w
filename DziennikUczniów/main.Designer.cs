namespace DziennikUczniów
{
    partial class main
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
            btnAdd = new Button();
            btnEdyt = new Button();
            btnDelate = new Button();
            btnReflesh = new Button();
            dgvDiary = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDiary).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkGreen;
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdyt
            // 
            btnEdyt.BackColor = Color.FromArgb(255, 128, 0);
            btnEdyt.ForeColor = Color.MintCream;
            btnEdyt.Location = new Point(93, 12);
            btnEdyt.Name = "btnEdyt";
            btnEdyt.Size = new Size(75, 23);
            btnEdyt.TabIndex = 1;
            btnEdyt.Text = "Edytuj";
            btnEdyt.UseVisualStyleBackColor = false;
            btnEdyt.Click += btnEdyt_Click;
            // 
            // btnDelate
            // 
            btnDelate.BackColor = Color.FromArgb(192, 0, 0);
            btnDelate.ForeColor = SystemColors.ButtonHighlight;
            btnDelate.Location = new Point(174, 12);
            btnDelate.Name = "btnDelate";
            btnDelate.Size = new Size(75, 23);
            btnDelate.TabIndex = 2;
            btnDelate.Text = "Usuń";
            btnDelate.UseVisualStyleBackColor = false;
            btnDelate.Click += btnDelate_Click;
            // 
            // btnReflesh
            // 
            btnReflesh.BackColor = SystemColors.ActiveCaption;
            btnReflesh.Location = new Point(255, 12);
            btnReflesh.Name = "btnReflesh";
            btnReflesh.Size = new Size(75, 23);
            btnReflesh.TabIndex = 3;
            btnReflesh.Text = "Odśwież";
            btnReflesh.UseVisualStyleBackColor = false;
            btnReflesh.Click += btnReflesh_Click;
            // 
            // dgvDiary
            // 
            dgvDiary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDiary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiary.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDiary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiary.Location = new Point(12, 50);
            dgvDiary.Name = "dgvDiary";
            dgvDiary.RowHeadersVisible = false;
            dgvDiary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiary.Size = new Size(1104, 388);
            dgvDiary.TabIndex = 4;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1128, 450);
            Controls.Add(dgvDiary);
            Controls.Add(btnReflesh);
            Controls.Add(btnDelate);
            Controls.Add(btnEdyt);
            Controls.Add(btnAdd);
            Name = "main";
            Text = "Dziennik ucznia";
            ((System.ComponentModel.ISupportInitialize)dgvDiary).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnReflesh;
        private Button btnDelate;
        private Button btnEdyt;
        private Button btnAdd;
        private DataGridView dgvDiary;
    }
}
