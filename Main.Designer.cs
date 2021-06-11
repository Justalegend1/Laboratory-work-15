
namespace Laboratory_work_15
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JoinBeginningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JoinBeforeCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JoinEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JoinItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteKeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletItToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AverageTemperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.EditToolStripMenuItem,
            this.OperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.CreateFileToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OpenFileToolStripMenuItem.Text = "Открыть...";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click_1);
            // 
            // CreateFileToolStripMenuItem
            // 
            this.CreateFileToolStripMenuItem.Name = "CreateFileToolStripMenuItem";
            this.CreateFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CreateFileToolStripMenuItem.Text = "Создать";
            this.CreateFileToolStripMenuItem.Click += new System.EventHandler(this.CreateFileToolStripMenuItem_Click_1);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.UpdateToolStripMenuItem.Text = "Обновить";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CloseToolStripMenuItem.Text = "Выход";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JoinToolStripMenuItem,
            this.ChangeToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.EditToolStripMenuItem.Text = "Изменения";
            // 
            // JoinToolStripMenuItem
            // 
            this.JoinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JoinBeginningToolStripMenuItem,
            this.JoinBeforeCurrentToolStripMenuItem,
            this.JoinEndToolStripMenuItem});
            this.JoinToolStripMenuItem.Name = "JoinToolStripMenuItem";
            this.JoinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.JoinToolStripMenuItem.Text = "Добавить";
            // 
            // JoinBeginningToolStripMenuItem
            // 
            this.JoinBeginningToolStripMenuItem.Name = "JoinBeginningToolStripMenuItem";
            this.JoinBeginningToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.JoinBeginningToolStripMenuItem.Text = "В начало";
            this.JoinBeginningToolStripMenuItem.Click += new System.EventHandler(this.JoinBeginningToolStripMenuItem_Click_1);
            // 
            // JoinBeforeCurrentToolStripMenuItem
            // 
            this.JoinBeforeCurrentToolStripMenuItem.Name = "JoinBeforeCurrentToolStripMenuItem";
            this.JoinBeforeCurrentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.JoinBeforeCurrentToolStripMenuItem.Text = "Перед текущим";
            this.JoinBeforeCurrentToolStripMenuItem.Click += new System.EventHandler(this.JoinBeforeCurrentToolStripMenuItem_Click_1);
            // 
            // JoinEndToolStripMenuItem
            // 
            this.JoinEndToolStripMenuItem.Name = "JoinEndToolStripMenuItem";
            this.JoinEndToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.JoinEndToolStripMenuItem.Text = "В конец";
            this.JoinEndToolStripMenuItem.Click += new System.EventHandler(this.JoinEndToolStripMenuItem_Click_1);
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeKeyToolStripMenuItem,
            this.JoinItToolStripMenuItem});
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ChangeToolStripMenuItem.Text = "Изменить";
            // 
            // ChangeKeyToolStripMenuItem
            // 
            this.ChangeKeyToolStripMenuItem.Name = "ChangeKeyToolStripMenuItem";
            this.ChangeKeyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ChangeKeyToolStripMenuItem.Text = "По ключу";
            this.ChangeKeyToolStripMenuItem.Click += new System.EventHandler(this.ChangeKeyToolStripMenuItem_Click_1);
            // 
            // JoinItToolStripMenuItem
            // 
            this.JoinItToolStripMenuItem.Name = "JoinItToolStripMenuItem";
            this.JoinItToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.JoinItToolStripMenuItem.Text = "Выбранный";
            this.JoinItToolStripMenuItem.Click += new System.EventHandler(this.JoinItToolStripMenuItem_Click_1);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteKeyToolStripMenuItem1,
            this.DeletItToolStripMenuItem1});
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            // 
            // DeleteKeyToolStripMenuItem1
            // 
            this.DeleteKeyToolStripMenuItem1.Name = "DeleteKeyToolStripMenuItem1";
            this.DeleteKeyToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.DeleteKeyToolStripMenuItem1.Text = "По ключу";
            this.DeleteKeyToolStripMenuItem1.Click += new System.EventHandler(this.DeleteKeyToolStripMenuItem1_Click_1);
            // 
            // DeletItToolStripMenuItem1
            // 
            this.DeletItToolStripMenuItem1.Name = "DeletItToolStripMenuItem1";
            this.DeletItToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.DeletItToolStripMenuItem1.Text = "Выбранный";
            this.DeletItToolStripMenuItem1.Click += new System.EventHandler(this.DeletItToolStripMenuItem1_Click_1);
            // 
            // OperationsToolStripMenuItem
            // 
            this.OperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AverageTemperatureToolStripMenuItem,
            this.FindDaysToolStripMenuItem});
            this.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            this.OperationsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.OperationsToolStripMenuItem.Text = "Действия";
            // 
            // AverageTemperatureToolStripMenuItem
            // 
            this.AverageTemperatureToolStripMenuItem.Name = "AverageTemperatureToolStripMenuItem";
            this.AverageTemperatureToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.AverageTemperatureToolStripMenuItem.Text = "Средняя температура";
            this.AverageTemperatureToolStripMenuItem.Click += new System.EventHandler(this.AverageTemperatureToolStripMenuItem_Click_1);
            // 
            // FindDaysToolStripMenuItem
            // 
            this.FindDaysToolStripMenuItem.Name = "FindDaysToolStripMenuItem";
            this.FindDaysToolStripMenuItem.Size = new System.Drawing.Size(357, 26);
            this.FindDaysToolStripMenuItem.Text = "Отрезок между отриц температурами";
            this.FindDaysToolStripMenuItem.Click += new System.EventHandler(this.FindDaysToolStripMenuItem_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(524, 324);
            this.listBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 370);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JoinBeginningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JoinBeforeCurrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JoinEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JoinItToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteKeyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeletItToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AverageTemperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindDaysToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}