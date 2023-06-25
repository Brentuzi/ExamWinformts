namespace Exam
{
    partial class editroute
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
            System.Windows.Forms.Label route_NumberLabel;
            System.Windows.Forms.Label daily_PassengersLabel;
            System.Windows.Forms.Label number_of_StopsLabel;
            System.Windows.Forms.Label number_of_Vehicles_on_RouteLabel;
            System.Windows.Forms.Label transportType_CodeLabel;
            System.Windows.Forms.Label path_CodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editroute));
            this.marshirutDataSet = new Exam.MarshirutDataSet();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new Exam.MarshirutDataSetTableAdapters.RouteTableAdapter();
            this.tableAdapterManager = new Exam.MarshirutDataSetTableAdapters.TableAdapterManager();
            this.routeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.routeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.route_NumberComboBox = new System.Windows.Forms.ComboBox();
            this.daily_PassengersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.number_of_StopsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.number_of_Vehicles_on_RouteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.transportType_CodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.path_CodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            route_NumberLabel = new System.Windows.Forms.Label();
            daily_PassengersLabel = new System.Windows.Forms.Label();
            number_of_StopsLabel = new System.Windows.Forms.Label();
            number_of_Vehicles_on_RouteLabel = new System.Windows.Forms.Label();
            transportType_CodeLabel = new System.Windows.Forms.Label();
            path_CodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marshirutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingNavigator)).BeginInit();
            this.routeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daily_PassengersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_StopsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_Vehicles_on_RouteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportType_CodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.path_CodeNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // route_NumberLabel
            // 
            route_NumberLabel.AutoSize = true;
            route_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            route_NumberLabel.Location = new System.Drawing.Point(6, 48);
            route_NumberLabel.Name = "route_NumberLabel";
            route_NumberLabel.Size = new System.Drawing.Size(118, 16);
            route_NumberLabel.TabIndex = 1;
            route_NumberLabel.Text = "Номер маршрута";
            // 
            // daily_PassengersLabel
            // 
            daily_PassengersLabel.AutoSize = true;
            daily_PassengersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            daily_PassengersLabel.Location = new System.Drawing.Point(6, 90);
            daily_PassengersLabel.Name = "daily_PassengersLabel";
            daily_PassengersLabel.Size = new System.Drawing.Size(141, 16);
            daily_PassengersLabel.TabIndex = 3;
            daily_PassengersLabel.Text = "Пассажиров за день";
            // 
            // number_of_StopsLabel
            // 
            number_of_StopsLabel.AutoSize = true;
            number_of_StopsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_of_StopsLabel.Location = new System.Drawing.Point(6, 124);
            number_of_StopsLabel.Name = "number_of_StopsLabel";
            number_of_StopsLabel.Size = new System.Drawing.Size(122, 16);
            number_of_StopsLabel.TabIndex = 5;
            number_of_StopsLabel.Text = "кол-во остановок";
            // 
            // number_of_Vehicles_on_RouteLabel
            // 
            number_of_Vehicles_on_RouteLabel.AutoSize = true;
            number_of_Vehicles_on_RouteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            number_of_Vehicles_on_RouteLabel.Location = new System.Drawing.Point(6, 150);
            number_of_Vehicles_on_RouteLabel.Name = "number_of_Vehicles_on_RouteLabel";
            number_of_Vehicles_on_RouteLabel.Size = new System.Drawing.Size(164, 16);
            number_of_Vehicles_on_RouteLabel.TabIndex = 7;
            number_of_Vehicles_on_RouteLabel.Text = "количество транспорта";
            // 
            // transportType_CodeLabel
            // 
            transportType_CodeLabel.AutoSize = true;
            transportType_CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            transportType_CodeLabel.Location = new System.Drawing.Point(6, 176);
            transportType_CodeLabel.Name = "transportType_CodeLabel";
            transportType_CodeLabel.Size = new System.Drawing.Size(110, 16);
            transportType_CodeLabel.TabIndex = 9;
            transportType_CodeLabel.Text = "тип транспорта";
            // 
            // path_CodeLabel
            // 
            path_CodeLabel.AutoSize = true;
            path_CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            path_CodeLabel.Location = new System.Drawing.Point(6, 209);
            path_CodeLabel.Name = "path_CodeLabel";
            path_CodeLabel.Size = new System.Drawing.Size(64, 16);
            path_CodeLabel.TabIndex = 11;
            path_CodeLabel.Text = "маршрут";
            // 
            // marshirutDataSet
            // 
            this.marshirutDataSet.DataSetName = "MarshirutDataSet";
            this.marshirutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.marshirutDataSet;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PathTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = this.routeTableAdapter;
            this.tableAdapterManager.TransportTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Exam.MarshirutDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // routeBindingNavigator
            // 
            this.routeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.routeBindingNavigator.BindingSource = this.routeBindingSource;
            this.routeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.routeBindingNavigator.CountItemFormat = "из {0}";
            this.routeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.routeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.routeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.routeBindingNavigatorSaveItem});
            this.routeBindingNavigator.Location = new System.Drawing.Point(198, 251);
            this.routeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.routeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.routeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.routeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.routeBindingNavigator.Name = "routeBindingNavigator";
            this.routeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.routeBindingNavigator.Size = new System.Drawing.Size(168, 25);
            this.routeBindingNavigator.TabIndex = 0;
            this.routeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(40, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // routeBindingNavigatorSaveItem
            // 
            this.routeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.routeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("routeBindingNavigatorSaveItem.Image")));
            this.routeBindingNavigatorSaveItem.Name = "routeBindingNavigatorSaveItem";
            this.routeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.routeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.routeBindingNavigatorSaveItem.Visible = false;
            this.routeBindingNavigatorSaveItem.Click += new System.EventHandler(this.routeBindingNavigatorSaveItem_Click);
            // 
            // route_NumberComboBox
            // 
            this.route_NumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "Route_Number", true));
            this.route_NumberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.route_NumberComboBox.FormattingEnabled = true;
            this.route_NumberComboBox.Location = new System.Drawing.Point(210, 45);
            this.route_NumberComboBox.Name = "route_NumberComboBox";
            this.route_NumberComboBox.Size = new System.Drawing.Size(121, 24);
            this.route_NumberComboBox.TabIndex = 2;
            // 
            // daily_PassengersNumericUpDown
            // 
            this.daily_PassengersNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.routeBindingSource, "Daily_Passengers", true));
            this.daily_PassengersNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daily_PassengersNumericUpDown.Location = new System.Drawing.Point(210, 83);
            this.daily_PassengersNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.daily_PassengersNumericUpDown.Name = "daily_PassengersNumericUpDown";
            this.daily_PassengersNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.daily_PassengersNumericUpDown.TabIndex = 4;
            // 
            // number_of_StopsNumericUpDown
            // 
            this.number_of_StopsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.routeBindingSource, "Number_of_Stops", true));
            this.number_of_StopsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_StopsNumericUpDown.Location = new System.Drawing.Point(211, 122);
            this.number_of_StopsNumericUpDown.Name = "number_of_StopsNumericUpDown";
            this.number_of_StopsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.number_of_StopsNumericUpDown.TabIndex = 6;
            // 
            // number_of_Vehicles_on_RouteNumericUpDown
            // 
            this.number_of_Vehicles_on_RouteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.routeBindingSource, "Number_of_Vehicles_on_Route", true));
            this.number_of_Vehicles_on_RouteNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_Vehicles_on_RouteNumericUpDown.Location = new System.Drawing.Point(210, 148);
            this.number_of_Vehicles_on_RouteNumericUpDown.Name = "number_of_Vehicles_on_RouteNumericUpDown";
            this.number_of_Vehicles_on_RouteNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.number_of_Vehicles_on_RouteNumericUpDown.TabIndex = 8;
            // 
            // transportType_CodeNumericUpDown
            // 
            this.transportType_CodeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.routeBindingSource, "TransportType_Code", true));
            this.transportType_CodeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportType_CodeNumericUpDown.Location = new System.Drawing.Point(210, 174);
            this.transportType_CodeNumericUpDown.Name = "transportType_CodeNumericUpDown";
            this.transportType_CodeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.transportType_CodeNumericUpDown.TabIndex = 10;
            // 
            // path_CodeNumericUpDown
            // 
            this.path_CodeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.routeBindingSource, "Path_Code", true));
            this.path_CodeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.path_CodeNumericUpDown.Location = new System.Drawing.Point(210, 209);
            this.path_CodeNumericUpDown.Name = "path_CodeNumericUpDown";
            this.path_CodeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.path_CodeNumericUpDown.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(route_NumberLabel);
            this.groupBox1.Controls.Add(this.path_CodeNumericUpDown);
            this.groupBox1.Controls.Add(path_CodeLabel);
            this.groupBox1.Controls.Add(this.transportType_CodeNumericUpDown);
            this.groupBox1.Controls.Add(daily_PassengersLabel);
            this.groupBox1.Controls.Add(this.number_of_Vehicles_on_RouteNumericUpDown);
            this.groupBox1.Controls.Add(this.number_of_StopsNumericUpDown);
            this.groupBox1.Controls.Add(number_of_StopsLabel);
            this.groupBox1.Controls.Add(this.daily_PassengersNumericUpDown);
            this.groupBox1.Controls.Add(transportType_CodeLabel);
            this.groupBox1.Controls.Add(this.route_NumberComboBox);
            this.groupBox1.Controls.Add(number_of_Vehicles_on_RouteLabel);
            this.groupBox1.Controls.Add(this.routeBindingNavigator);
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 298);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(26, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editroute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 378);
            this.Controls.Add(this.groupBox1);
            this.Name = "editroute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.editroute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marshirutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingNavigator)).EndInit();
            this.routeBindingNavigator.ResumeLayout(false);
            this.routeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daily_PassengersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_StopsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_Vehicles_on_RouteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportType_CodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.path_CodeNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MarshirutDataSet marshirutDataSet;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private MarshirutDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private MarshirutDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator routeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton routeBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox route_NumberComboBox;
        private System.Windows.Forms.NumericUpDown daily_PassengersNumericUpDown;
        private System.Windows.Forms.NumericUpDown number_of_StopsNumericUpDown;
        private System.Windows.Forms.NumericUpDown number_of_Vehicles_on_RouteNumericUpDown;
        private System.Windows.Forms.NumericUpDown transportType_CodeNumericUpDown;
        private System.Windows.Forms.NumericUpDown path_CodeNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}