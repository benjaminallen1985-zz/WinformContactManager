namespace WinformContactManager
{
    partial class contactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contactForm));
            System.Windows.Forms.Label lblContactId;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblCompany;
            System.Windows.Forms.Label lblPhone;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblClient;
            System.Windows.Forms.Label lblLastCall;
            this._imgSciFi = new System.Windows.Forms.PictureBox();
            this._contactManagerDataSet = new WinformContactManager.ContactManagerDBDataSet();
            this._bndContactList = new System.Windows.Forms.BindingSource(this.components);
            this._taContacts = new WinformContactManager.ContactManagerDBDataSetTableAdapters.ContactsTableAdapter();
            this._taContactsAdapterManager = new WinformContactManager.ContactManagerDBDataSetTableAdapters.TableAdapterManager();
            this._bndNavContactList = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this._txtContactId = new System.Windows.Forms.TextBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtCompany = new System.Windows.Forms.TextBox();
            this._txtPhone = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.chkboxClient = new System.Windows.Forms.CheckBox();
            this._dtLastCall = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            lblContactId = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblCompany = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblClient = new System.Windows.Forms.Label();
            lblLastCall = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._imgSciFi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._contactManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndNavContactList)).BeginInit();
            this._bndNavContactList.SuspendLayout();
            this.SuspendLayout();
            // 
            // _imgSciFi
            // 
            this._imgSciFi.Image = global::WinformContactManager.Properties.Resources.background_img;
            this._imgSciFi.Location = new System.Drawing.Point(403, 68);
            this._imgSciFi.Name = "_imgSciFi";
            this._imgSciFi.Size = new System.Drawing.Size(427, 120);
            this._imgSciFi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imgSciFi.TabIndex = 0;
            this._imgSciFi.TabStop = false;
            this._imgSciFi.Click += new System.EventHandler(this.OnShowAboutBox);
            // 
            // _contactManagerDataSet
            // 
            this._contactManagerDataSet.DataSetName = "ContactManagerDBDataSet";
            this._contactManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _bndContactList
            // 
            this._bndContactList.DataMember = "Contacts";
            this._bndContactList.DataSource = this._contactManagerDataSet;
            // 
            // _taContacts
            // 
            this._taContacts.ClearBeforeFill = true;
            // 
            // _taContactsAdapterManager
            // 
            this._taContactsAdapterManager.BackupDataSetBeforeUpdate = false;
            this._taContactsAdapterManager.ContactsTableAdapter = this._taContacts;
            this._taContactsAdapterManager.UpdateOrder = WinformContactManager.ContactManagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _bndNavContactList
            // 
            this._bndNavContactList.AddNewItem = this.bindingNavigatorAddNewItem;
            this._bndNavContactList.BindingSource = this._bndContactList;
            this._bndNavContactList.CountItem = this.bindingNavigatorCountItem;
            this._bndNavContactList.DeleteItem = this.bindingNavigatorDeleteItem;
            this._bndNavContactList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contactsBindingNavigatorSaveItem});
            this._bndNavContactList.Location = new System.Drawing.Point(0, 0);
            this._bndNavContactList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._bndNavContactList.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._bndNavContactList.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._bndNavContactList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._bndNavContactList.Name = "_bndNavContactList";
            this._bndNavContactList.PositionItem = this.bindingNavigatorPositionItem;
            this._bndNavContactList.Size = new System.Drawing.Size(830, 25);
            this._bndNavContactList.TabIndex = 1;
            this._bndNavContactList.Text = "bindingNavigator1";
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
            // contactsBindingNavigatorSaveItem
            // 
            this.contactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsBindingNavigatorSaveItem.Image")));
            this.contactsBindingNavigatorSaveItem.Name = "contactsBindingNavigatorSaveItem";
            this.contactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contactsBindingNavigatorSaveItem.Text = "Save Data";
            this.contactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsBindingNavigatorSaveItem_Click);
            // 
            // lblContactId
            // 
            lblContactId.AutoSize = true;
            lblContactId.Location = new System.Drawing.Point(74, 71);
            lblContactId.Name = "lblContactId";
            lblContactId.Size = new System.Drawing.Size(59, 13);
            lblContactId.TabIndex = 2;
            lblContactId.Text = "Contact Id:";
            // 
            // _txtContactId
            // 
            this._txtContactId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "ContactId", true));
            this._txtContactId.Location = new System.Drawing.Point(141, 68);
            this._txtContactId.Name = "_txtContactId";
            this._txtContactId.Size = new System.Drawing.Size(200, 20);
            this._txtContactId.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(74, 97);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(38, 13);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // _txtName
            // 
            this._txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "Name", true));
            this._txtName.Location = new System.Drawing.Point(141, 94);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(200, 20);
            this._txtName.TabIndex = 5;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new System.Drawing.Point(74, 123);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new System.Drawing.Size(54, 13);
            lblCompany.TabIndex = 6;
            lblCompany.Text = "Company:";
            // 
            // _txtCompany
            // 
            this._txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "Company", true));
            this._txtCompany.Location = new System.Drawing.Point(141, 120);
            this._txtCompany.Name = "_txtCompany";
            this._txtCompany.Size = new System.Drawing.Size(200, 20);
            this._txtCompany.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(74, 149);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(61, 13);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Telephone:";
            // 
            // _txtPhone
            // 
            this._txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "Telephone", true));
            this._txtPhone.Location = new System.Drawing.Point(141, 146);
            this._txtPhone.Name = "_txtPhone";
            this._txtPhone.Size = new System.Drawing.Size(200, 20);
            this._txtPhone.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(74, 175);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // _txtEmail
            // 
            this._txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bndContactList, "Email", true));
            this._txtEmail.Location = new System.Drawing.Point(141, 172);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(200, 20);
            this._txtEmail.TabIndex = 11;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new System.Drawing.Point(74, 203);
            lblClient.Name = "lblClient";
            lblClient.Size = new System.Drawing.Size(36, 13);
            lblClient.TabIndex = 12;
            lblClient.Text = "Client:";
            // 
            // chkboxClient
            // 
            this.chkboxClient.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this._bndContactList, "Client", true));
            this.chkboxClient.Location = new System.Drawing.Point(141, 198);
            this.chkboxClient.Name = "chkboxClient";
            this.chkboxClient.Size = new System.Drawing.Size(200, 24);
            this.chkboxClient.TabIndex = 13;
            this.chkboxClient.UseVisualStyleBackColor = true;
            this.chkboxClient.CheckedChanged += new System.EventHandler(this.clientCheckBox_CheckedChanged);
            // 
            // lblLastCall
            // 
            lblLastCall.AutoSize = true;
            lblLastCall.Location = new System.Drawing.Point(74, 232);
            lblLastCall.Name = "lblLastCall";
            lblLastCall.Size = new System.Drawing.Size(50, 13);
            lblLastCall.TabIndex = 14;
            lblLastCall.Text = "Last Call:";
            // 
            // _dtLastCall
            // 
            this._dtLastCall.DataBindings.Add(new System.Windows.Forms.Binding("Value", this._bndContactList, "LastCall", true));
            this._dtLastCall.Location = new System.Drawing.Point(141, 228);
            this._dtLastCall.Name = "_dtLastCall";
            this._dtLastCall.Size = new System.Drawing.Size(200, 20);
            this._dtLastCall.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(403, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnClose);
            // 
            // contactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 320);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(lblContactId);
            this.Controls.Add(this._txtContactId);
            this.Controls.Add(lblName);
            this.Controls.Add(this._txtName);
            this.Controls.Add(lblCompany);
            this.Controls.Add(this._txtCompany);
            this.Controls.Add(lblPhone);
            this.Controls.Add(this._txtPhone);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(lblClient);
            this.Controls.Add(this.chkboxClient);
            this.Controls.Add(lblLastCall);
            this.Controls.Add(this._dtLastCall);
            this.Controls.Add(this._bndNavContactList);
            this.Controls.Add(this._imgSciFi);
            this.Name = "contactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.contactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._imgSciFi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._contactManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndNavContactList)).EndInit();
            this._bndNavContactList.ResumeLayout(false);
            this._bndNavContactList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _imgSciFi;
        private ContactManagerDBDataSet _contactManagerDataSet;
        private System.Windows.Forms.BindingSource _bndContactList;
        private ContactManagerDBDataSetTableAdapters.ContactsTableAdapter _taContacts;
        private ContactManagerDBDataSetTableAdapters.TableAdapterManager _taContactsAdapterManager;
        private System.Windows.Forms.BindingNavigator _bndNavContactList;
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
        private System.Windows.Forms.ToolStripButton contactsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox _txtContactId;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtCompany;
        private System.Windows.Forms.TextBox _txtPhone;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.CheckBox chkboxClient;
        private System.Windows.Forms.DateTimePicker _dtLastCall;
        private System.Windows.Forms.Button btnClose;
    }
}

