namespace ControleDeDespesas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.Label iD_CONTALabel;
            System.Windows.Forms.Label dESCRICAOLabel;
            System.Windows.Forms.Label dATALabel;
            System.Windows.Forms.Label cATEGORIALabel;
            System.Windows.Forms.Label vALORLabel;
            this.despesasDataSet = new ControleDeDespesas.DespesasDataSet();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasTableAdapter = new ControleDeDespesas.DespesasDataSetTableAdapters.ContasTableAdapter();
            this.tableAdapterManager = new ControleDeDespesas.DespesasDataSetTableAdapters.TableAdapterManager();
            this.contasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CONTATextBox = new System.Windows.Forms.TextBox();
            this.dESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cATEGORIATextBox = new System.Windows.Forms.TextBox();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            iD_CONTALabel = new System.Windows.Forms.Label();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            dATALabel = new System.Windows.Forms.Label();
            cATEGORIALabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingNavigator)).BeginInit();
            this.contasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // despesasDataSet
            // 
            this.despesasDataSet.DataSetName = "DespesasDataSet";
            this.despesasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "Contas";
            this.contasBindingSource.DataSource = this.despesasDataSet;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContasTableAdapter = this.contasTableAdapter;
            this.tableAdapterManager.UpdateOrder = ControleDeDespesas.DespesasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contasBindingNavigator
            // 
            this.contasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contasBindingNavigator.BindingSource = this.contasBindingSource;
            this.contasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contasBindingNavigatorSaveItem});
            this.contasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contasBindingNavigator.Name = "contasBindingNavigator";
            this.contasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contasBindingNavigator.Size = new System.Drawing.Size(359, 25);
            this.contasBindingNavigator.TabIndex = 0;
            this.contasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contasBindingNavigatorSaveItem
            // 
            this.contasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contasBindingNavigatorSaveItem.Image")));
            this.contasBindingNavigatorSaveItem.Name = "contasBindingNavigatorSaveItem";
            this.contasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.contasBindingNavigatorSaveItem.Text = "Save Data";
            this.contasBindingNavigatorSaveItem.Click += new System.EventHandler(this.contasBindingNavigatorSaveItem_Click);
            // 
            // iD_CONTALabel
            // 
            iD_CONTALabel.AutoSize = true;
            iD_CONTALabel.Location = new System.Drawing.Point(41, 41);
            iD_CONTALabel.Name = "iD_CONTALabel";
            iD_CONTALabel.Size = new System.Drawing.Size(61, 13);
            iD_CONTALabel.TabIndex = 1;
            iD_CONTALabel.Text = "ID CONTA:";
            // 
            // iD_CONTATextBox
            // 
            this.iD_CONTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "ID_CONTA", true));
            this.iD_CONTATextBox.Location = new System.Drawing.Point(113, 38);
            this.iD_CONTATextBox.Name = "iD_CONTATextBox";
            this.iD_CONTATextBox.Size = new System.Drawing.Size(67, 20);
            this.iD_CONTATextBox.TabIndex = 2;
            // 
            // dESCRICAOLabel
            // 
            dESCRICAOLabel.AutoSize = true;
            dESCRICAOLabel.Location = new System.Drawing.Point(30, 121);
            dESCRICAOLabel.Name = "dESCRICAOLabel";
            dESCRICAOLabel.Size = new System.Drawing.Size(72, 13);
            dESCRICAOLabel.TabIndex = 3;
            dESCRICAOLabel.Text = "DESCRICAO:";
            // 
            // dESCRICAOTextBox
            // 
            this.dESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "DESCRICAO", true));
            this.dESCRICAOTextBox.Location = new System.Drawing.Point(113, 121);
            this.dESCRICAOTextBox.Multiline = true;
            this.dESCRICAOTextBox.Name = "dESCRICAOTextBox";
            this.dESCRICAOTextBox.Size = new System.Drawing.Size(213, 53);
            this.dESCRICAOTextBox.TabIndex = 4;
            // 
            // dATALabel
            // 
            dATALabel.AutoSize = true;
            dATALabel.Location = new System.Drawing.Point(199, 97);
            dATALabel.Name = "dATALabel";
            dATALabel.Size = new System.Drawing.Size(39, 13);
            dATALabel.TabIndex = 5;
            dATALabel.Text = "DATA:";
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasBindingSource, "DATA", true));
            this.dATADateTimePicker.Location = new System.Drawing.Point(244, 94);
            this.dATADateTimePicker.Name = "dATADateTimePicker";
            this.dATADateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.dATADateTimePicker.TabIndex = 6;
            // 
            // cATEGORIALabel
            // 
            cATEGORIALabel.AutoSize = true;
            cATEGORIALabel.Location = new System.Drawing.Point(30, 67);
            cATEGORIALabel.Name = "cATEGORIALabel";
            cATEGORIALabel.Size = new System.Drawing.Size(72, 13);
            cATEGORIALabel.TabIndex = 7;
            cATEGORIALabel.Text = "CATEGORIA:";
            // 
            // cATEGORIATextBox
            // 
            this.cATEGORIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "CATEGORIA", true));
            this.cATEGORIATextBox.Location = new System.Drawing.Point(113, 64);
            this.cATEGORIATextBox.Name = "cATEGORIATextBox";
            this.cATEGORIATextBox.Size = new System.Drawing.Size(213, 20);
            this.cATEGORIATextBox.TabIndex = 8;
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(56, 97);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(46, 13);
            vALORLabel.TabIndex = 9;
            vALORLabel.Text = "VALOR:";
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "VALOR", true));
            this.vALORTextBox.Location = new System.Drawing.Point(113, 94);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(67, 20);
            this.vALORTextBox.TabIndex = 10;
            // 
            // frmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 186);
            this.Controls.Add(iD_CONTALabel);
            this.Controls.Add(this.iD_CONTATextBox);
            this.Controls.Add(dESCRICAOLabel);
            this.Controls.Add(this.dESCRICAOTextBox);
            this.Controls.Add(dATALabel);
            this.Controls.Add(this.dATADateTimePicker);
            this.Controls.Add(cATEGORIALabel);
            this.Controls.Add(this.cATEGORIATextBox);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(this.contasBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Despesas";
            this.Load += new System.EventHandler(this.frmContas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despesasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingNavigator)).EndInit();
            this.contasBindingNavigator.ResumeLayout(false);
            this.contasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DespesasDataSet despesasDataSet;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private DespesasDataSetTableAdapters.ContasTableAdapter contasTableAdapter;
        private DespesasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CONTATextBox;
        private System.Windows.Forms.TextBox dESCRICAOTextBox;
        private System.Windows.Forms.DateTimePicker dATADateTimePicker;
        private System.Windows.Forms.TextBox cATEGORIATextBox;
        private System.Windows.Forms.TextBox vALORTextBox;
    }
}

