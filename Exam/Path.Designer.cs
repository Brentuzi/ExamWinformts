namespace Exam
{
    partial class Path
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label start_PointLabel;
            System.Windows.Forms.Label end_PointLabel;
            System.Windows.Forms.Label distanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Path));
            this.marshirutDataSet = new Exam.MarshirutDataSet();
            this.pathBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pathTableAdapter = new Exam.MarshirutDataSetTableAdapters.PathTableAdapter();
            this.tableAdapterManager = new Exam.MarshirutDataSetTableAdapters.TableAdapterManager();
            this.pathBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pathBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.start_PointTextBox = new System.Windows.Forms.TextBox();
            this.end_PointTextBox = new System.Windows.Forms.TextBox();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.path_CodeTextBox = new System.Windows.Forms.TextBox();
            start_PointLabel = new System.Windows.Forms.Label();
            end_PointLabel = new System.Windows.Forms.Label();
            distanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marshirutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathBindingNavigator)).BeginInit();
            this.pathBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_PointLabel
            // 
            start_PointLabel.AutoSize = true;
            start_PointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            start_PointLabel.Location = new System.Drawing.Point(5, 58);
            start_PointLabel.Name = "start_PointLabel";
            start_PointLabel.Size = new System.Drawing.Size(137, 25);
            start_PointLabel.TabIndex = 1;
            start_PointLabel.Text = "Начало пути";
            // 
            // end_PointLabel
            // 
            end_PointLabel.AutoSize = true;
            end_PointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            end_PointLabel.Location = new System.Drawing.Point(5, 105);
            end_PointLabel.Name = "end_PointLabel";
            end_PointLabel.Size = new System.Drawing.Size(125, 25);
            end_PointLabel.TabIndex = 3;
            end_PointLabel.Text = "Конец пути";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            distanceLabel.Location = new System.Drawing.Point(17, 145);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new System.Drawing.Size(120, 25);
            distanceLabel.TabIndex = 5;
            distanceLabel.Text = "Дистанция";
            // 
            // marshirutDataSet
            // 
            this.marshirutDataSet.DataSetName = "MarshirutDataSet";
            this.marshirutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pathBindingSource
            // 
            this.pathBindingSource.DataMember = "Path";
            this.pathBindingSource.DataSource = this.marshirutDataSet;
            // 
            // pathTableAdapter
            // 
            this.pathTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PathTableAdapter = this.pathTableAdapter;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.TransportTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Exam.MarshirutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pathBindingNavigator
            // 
            this.pathBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pathBindingNavigator.BindingSource = this.pathBindingSource;
            this.pathBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pathBindingNavigator.CountItemFormat = "из {0}";
            this.pathBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pathBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.pathBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pathBindingNavigatorSaveItem});
            this.pathBindingNavigator.Location = new System.Drawing.Point(10, 199);
            this.pathBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pathBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pathBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pathBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pathBindingNavigator.Name = "pathBindingNavigator";
            this.pathBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pathBindingNavigator.Size = new System.Drawing.Size(232, 28);
            this.pathBindingNavigator.TabIndex = 0;
            this.pathBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(58, 25);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // pathBindingNavigatorSaveItem
            // 
            this.pathBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pathBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pathBindingNavigatorSaveItem.Image")));
            this.pathBindingNavigatorSaveItem.Name = "pathBindingNavigatorSaveItem";
            this.pathBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 25);
            this.pathBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.pathBindingNavigatorSaveItem.Visible = false;
            this.pathBindingNavigatorSaveItem.Click += new System.EventHandler(this.pathBindingNavigatorSaveItem_Click);
            // 
            // start_PointTextBox
            // 
            this.start_PointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathBindingSource, "Start_Point", true));
            this.start_PointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_PointTextBox.Location = new System.Drawing.Point(147, 58);
            this.start_PointTextBox.Name = "start_PointTextBox";
            this.start_PointTextBox.ReadOnly = true;
            this.start_PointTextBox.Size = new System.Drawing.Size(120, 29);
            this.start_PointTextBox.TabIndex = 2;
            // 
            // end_PointTextBox
            // 
            this.end_PointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathBindingSource, "End_Point", true));
            this.end_PointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.end_PointTextBox.Location = new System.Drawing.Point(147, 111);
            this.end_PointTextBox.Name = "end_PointTextBox";
            this.end_PointTextBox.ReadOnly = true;
            this.end_PointTextBox.Size = new System.Drawing.Size(120, 29);
            this.end_PointTextBox.TabIndex = 4;
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pathBindingSource, "Distance", true));
            this.distanceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distanceNumericUpDown.Location = new System.Drawing.Point(147, 150);
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.distanceNumericUpDown.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.path_CodeTextBox);
            this.groupBox1.Controls.Add(this.end_PointTextBox);
            this.groupBox1.Controls.Add(this.pathBindingNavigator);
            this.groupBox1.Controls.Add(distanceLabel);
            this.groupBox1.Controls.Add(this.start_PointTextBox);
            this.groupBox1.Controls.Add(this.distanceNumericUpDown);
            this.groupBox1.Controls.Add(start_PointLabel);
            this.groupBox1.Controls.Add(end_PointLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 247);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(412, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 359);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Панель администратора";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 127);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Редактирование";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(21, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(272, 37);
            this.button6.TabIndex = 8;
            this.button6.Text = "Закончить редактирование";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(21, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Начать редактирование";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 87);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление нового пути";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(163, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить изменения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить новый путь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // path_CodeTextBox
            // 
            this.path_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathBindingSource, "Path_Code", true));
            this.path_CodeTextBox.Location = new System.Drawing.Point(167, 31);
            this.path_CodeTextBox.Name = "path_CodeTextBox";
            this.path_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.path_CodeTextBox.TabIndex = 8;
            // 
            // Path
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Path";
            this.Text = "Пути";
            this.Load += new System.EventHandler(this.Path_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marshirutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathBindingNavigator)).EndInit();
            this.pathBindingNavigator.ResumeLayout(false);
            this.pathBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MarshirutDataSet marshirutDataSet;
        private System.Windows.Forms.BindingSource pathBindingSource;
        private MarshirutDataSetTableAdapters.PathTableAdapter pathTableAdapter;
        private MarshirutDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pathBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pathBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox start_PointTextBox;
        private System.Windows.Forms.TextBox end_PointTextBox;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox path_CodeTextBox;
    }
}