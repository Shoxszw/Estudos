namespace MeusContatos
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
            System.Windows.Forms.Label iD_CONTATOLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label aNIVERSARIOLabel;
            this.agendaDeContatosDataSet = new MeusContatos.AgendaDeContatosDataSet();
            this.contatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatosTableAdapter = new MeusContatos.AgendaDeContatosDataSetTableAdapters.ContatosTableAdapter();
            this.tableAdapterManager = new MeusContatos.AgendaDeContatosDataSetTableAdapters.TableAdapterManager();
            this.contatosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contatosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CONTATOTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.tELEFONETextBox = new System.Windows.Forms.TextBox();
            this.aNIVERSARIODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fAMILIACheckBox = new System.Windows.Forms.CheckBox();
            iD_CONTATOLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            aNIVERSARIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingNavigator)).BeginInit();
            this.contatosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // agendaDeContatosDataSet
            // 
            this.agendaDeContatosDataSet.DataSetName = "AgendaDeContatosDataSet";
            this.agendaDeContatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contatosBindingSource
            // 
            this.contatosBindingSource.DataMember = "Contatos";
            this.contatosBindingSource.DataSource = this.agendaDeContatosDataSet;
            // 
            // contatosTableAdapter
            // 
            this.contatosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContatosTableAdapter = this.contatosTableAdapter;
            this.tableAdapterManager.UpdateOrder = MeusContatos.AgendaDeContatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contatosBindingNavigator
            // 
            this.contatosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contatosBindingNavigator.BindingSource = this.contatosBindingSource;
            this.contatosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contatosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contatosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contatosBindingNavigatorSaveItem});
            this.contatosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contatosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contatosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contatosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contatosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contatosBindingNavigator.Name = "contatosBindingNavigator";
            this.contatosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contatosBindingNavigator.Size = new System.Drawing.Size(444, 25);
            this.contatosBindingNavigator.TabIndex = 0;
            this.contatosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contatosBindingNavigatorSaveItem
            // 
            this.contatosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contatosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contatosBindingNavigatorSaveItem.Image")));
            this.contatosBindingNavigatorSaveItem.Name = "contatosBindingNavigatorSaveItem";
            this.contatosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contatosBindingNavigatorSaveItem.Text = "Save Data";
            this.contatosBindingNavigatorSaveItem.Click += new System.EventHandler(this.contatosBindingNavigatorSaveItem_Click);
            // 
            // iD_CONTATOLabel
            // 
            iD_CONTATOLabel.AutoSize = true;
            iD_CONTATOLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CONTATOLabel.Location = new System.Drawing.Point(12, 41);
            iD_CONTATOLabel.Name = "iD_CONTATOLabel";
            iD_CONTATOLabel.Size = new System.Drawing.Size(71, 28);
            iD_CONTATOLabel.TabIndex = 1;
            iD_CONTATOLabel.Text = "Código:";
            // 
            // iD_CONTATOTextBox
            // 
            this.iD_CONTATOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "ID_CONTATO", true));
            this.iD_CONTATOTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CONTATOTextBox.Location = new System.Drawing.Point(122, 38);
            this.iD_CONTATOTextBox.Name = "iD_CONTATOTextBox";
            this.iD_CONTATOTextBox.Size = new System.Drawing.Size(62, 36);
            this.iD_CONTATOTextBox.TabIndex = 2;
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMELabel.Location = new System.Drawing.Point(12, 83);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(63, 28);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "Nome:";
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "NOME", true));
            this.nOMETextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOMETextBox.Location = new System.Drawing.Point(122, 80);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(286, 36);
            this.nOMETextBox.TabIndex = 4;
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONELabel.Location = new System.Drawing.Point(12, 125);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(83, 28);
            tELEFONELabel.TabIndex = 5;
            tELEFONELabel.Text = "Telefone:";
            // 
            // tELEFONETextBox
            // 
            this.tELEFONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatosBindingSource, "TELEFONE", true));
            this.tELEFONETextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tELEFONETextBox.Location = new System.Drawing.Point(122, 122);
            this.tELEFONETextBox.Name = "tELEFONETextBox";
            this.tELEFONETextBox.Size = new System.Drawing.Size(157, 36);
            this.tELEFONETextBox.TabIndex = 6;
            // 
            // aNIVERSARIOLabel
            // 
            aNIVERSARIOLabel.AutoSize = true;
            aNIVERSARIOLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aNIVERSARIOLabel.Location = new System.Drawing.Point(12, 168);
            aNIVERSARIOLabel.Name = "aNIVERSARIOLabel";
            aNIVERSARIOLabel.Size = new System.Drawing.Size(108, 28);
            aNIVERSARIOLabel.TabIndex = 7;
            aNIVERSARIOLabel.Text = "Aniversário:";
            // 
            // aNIVERSARIODateTimePicker
            // 
            this.aNIVERSARIODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contatosBindingSource, "ANIVERSARIO", true));
            this.aNIVERSARIODateTimePicker.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aNIVERSARIODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aNIVERSARIODateTimePicker.Location = new System.Drawing.Point(122, 164);
            this.aNIVERSARIODateTimePicker.Name = "aNIVERSARIODateTimePicker";
            this.aNIVERSARIODateTimePicker.Size = new System.Drawing.Size(157, 36);
            this.aNIVERSARIODateTimePicker.TabIndex = 8;
            // 
            // fAMILIACheckBox
            // 
            this.fAMILIACheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contatosBindingSource, "FAMILIA", true));
            this.fAMILIACheckBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fAMILIACheckBox.Location = new System.Drawing.Point(285, 168);
            this.fAMILIACheckBox.Name = "fAMILIACheckBox";
            this.fAMILIACheckBox.Size = new System.Drawing.Size(135, 24);
            this.fAMILIACheckBox.TabIndex = 10;
            this.fAMILIACheckBox.Text = "É da família";
            this.fAMILIACheckBox.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(444, 242);
            this.Controls.Add(iD_CONTATOLabel);
            this.Controls.Add(this.iD_CONTATOTextBox);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMETextBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONETextBox);
            this.Controls.Add(aNIVERSARIOLabel);
            this.Controls.Add(this.aNIVERSARIODateTimePicker);
            this.Controls.Add(this.fAMILIACheckBox);
            this.Controls.Add(this.contatosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus Contatos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingNavigator)).EndInit();
            this.contatosBindingNavigator.ResumeLayout(false);
            this.contatosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgendaDeContatosDataSet agendaDeContatosDataSet;
        private System.Windows.Forms.BindingSource contatosBindingSource;
        private AgendaDeContatosDataSetTableAdapters.ContatosTableAdapter contatosTableAdapter;
        private AgendaDeContatosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contatosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contatosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CONTATOTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox tELEFONETextBox;
        private System.Windows.Forms.DateTimePicker aNIVERSARIODateTimePicker;
        private System.Windows.Forms.CheckBox fAMILIACheckBox;

    }
}

