namespace finA0334407
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.識別碼DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.會員DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.會員編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性別DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.生日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.職業DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電子郵件DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.產品時效DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主要客戶潛力DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客戶資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.資料庫DataSet = new finA0334407.資料庫DataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Job = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_E_mail = new System.Windows.Forms.TextBox();
            this.comboBox_E_mail = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox_Product = new System.Windows.Forms.ListBox();
            this.checkBox_Member = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MemberNumber = new System.Windows.Forms.TextBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Customer = new System.Windows.Forms.GroupBox();
            this.button_ViewAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button_Preset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Month = new System.Windows.Forms.TextBox();
            this.textBox_Day = new System.Windows.Forms.TextBox();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.groupBox_SQL = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox_Situation = new System.Windows.Forms.GroupBox();
            this.label_Situation = new System.Windows.Forms.Label();
            this.客戶資料TableAdapter = new finA0334407.資料庫DataSetTableAdapters.客戶資料TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.資料庫DataSet)).BeginInit();
            this.groupBox_Customer.SuspendLayout();
            this.groupBox_SQL.SuspendLayout();
            this.groupBox_Situation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.識別碼DataGridViewTextBoxColumn,
            this.會員DataGridViewCheckBoxColumn,
            this.會員編號DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性別DataGridViewTextBoxColumn,
            this.生日DataGridViewTextBoxColumn,
            this.職業DataGridViewTextBoxColumn,
            this.電子郵件DataGridViewTextBoxColumn,
            this.產品時效DataGridViewTextBoxColumn,
            this.主要客戶潛力DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.客戶資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 282);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.TabStop = false;
            // 
            // 識別碼DataGridViewTextBoxColumn
            // 
            this.識別碼DataGridViewTextBoxColumn.DataPropertyName = "識別碼";
            this.識別碼DataGridViewTextBoxColumn.HeaderText = "識別碼";
            this.識別碼DataGridViewTextBoxColumn.Name = "識別碼DataGridViewTextBoxColumn";
            // 
            // 會員DataGridViewCheckBoxColumn
            // 
            this.會員DataGridViewCheckBoxColumn.DataPropertyName = "會員";
            this.會員DataGridViewCheckBoxColumn.HeaderText = "會員";
            this.會員DataGridViewCheckBoxColumn.Name = "會員DataGridViewCheckBoxColumn";
            // 
            // 會員編號DataGridViewTextBoxColumn
            // 
            this.會員編號DataGridViewTextBoxColumn.DataPropertyName = "會員編號";
            this.會員編號DataGridViewTextBoxColumn.HeaderText = "會員編號";
            this.會員編號DataGridViewTextBoxColumn.Name = "會員編號DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 性別DataGridViewTextBoxColumn
            // 
            this.性別DataGridViewTextBoxColumn.DataPropertyName = "性別";
            this.性別DataGridViewTextBoxColumn.HeaderText = "性別";
            this.性別DataGridViewTextBoxColumn.Name = "性別DataGridViewTextBoxColumn";
            // 
            // 生日DataGridViewTextBoxColumn
            // 
            this.生日DataGridViewTextBoxColumn.DataPropertyName = "生日";
            this.生日DataGridViewTextBoxColumn.HeaderText = "生日";
            this.生日DataGridViewTextBoxColumn.Name = "生日DataGridViewTextBoxColumn";
            // 
            // 職業DataGridViewTextBoxColumn
            // 
            this.職業DataGridViewTextBoxColumn.DataPropertyName = "職業";
            this.職業DataGridViewTextBoxColumn.HeaderText = "職業";
            this.職業DataGridViewTextBoxColumn.Name = "職業DataGridViewTextBoxColumn";
            // 
            // 電子郵件DataGridViewTextBoxColumn
            // 
            this.電子郵件DataGridViewTextBoxColumn.DataPropertyName = "電子郵件";
            this.電子郵件DataGridViewTextBoxColumn.HeaderText = "電子郵件";
            this.電子郵件DataGridViewTextBoxColumn.Name = "電子郵件DataGridViewTextBoxColumn";
            // 
            // 產品時效DataGridViewTextBoxColumn
            // 
            this.產品時效DataGridViewTextBoxColumn.DataPropertyName = "產品時效";
            this.產品時效DataGridViewTextBoxColumn.HeaderText = "產品時效";
            this.產品時效DataGridViewTextBoxColumn.Name = "產品時效DataGridViewTextBoxColumn";
            // 
            // 主要客戶潛力DataGridViewTextBoxColumn
            // 
            this.主要客戶潛力DataGridViewTextBoxColumn.DataPropertyName = "主要客戶潛力";
            this.主要客戶潛力DataGridViewTextBoxColumn.HeaderText = "主要客戶潛力";
            this.主要客戶潛力DataGridViewTextBoxColumn.Name = "主要客戶潛力DataGridViewTextBoxColumn";
            // 
            // 客戶資料BindingSource
            // 
            this.客戶資料BindingSource.DataMember = "客戶資料";
            this.客戶資料BindingSource.DataSource = this.資料庫DataSet;
            // 
            // 資料庫DataSet
            // 
            this.資料庫DataSet.DataSetName = "資料庫DataSet";
            this.資料庫DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(101, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Name.Location = new System.Drawing.Point(147, 63);
            this.textBox_Name.MaxLength = 15;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(142, 27);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(101, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "生日　西元";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(101, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "性別";
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_Female.Location = new System.Drawing.Point(195, 104);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(42, 20);
            this.radioButton_Female.TabIndex = 3;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "女";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_Male.Location = new System.Drawing.Point(147, 104);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(42, 20);
            this.radioButton_Male.TabIndex = 3;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "男";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(101, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "職業";
            // 
            // comboBox_Job
            // 
            this.comboBox_Job.DropDownHeight = 180;
            this.comboBox_Job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Job.DropDownWidth = 70;
            this.comboBox_Job.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Job.FormattingEnabled = true;
            this.comboBox_Job.IntegralHeight = false;
            this.comboBox_Job.ItemHeight = 16;
            this.comboBox_Job.Location = new System.Drawing.Point(147, 183);
            this.comboBox_Job.MaxDropDownItems = 100;
            this.comboBox_Job.Name = "comboBox_Job";
            this.comboBox_Job.Size = new System.Drawing.Size(70, 24);
            this.comboBox_Job.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(101, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "電子郵件";
            // 
            // textBox_E_mail
            // 
            this.textBox_E_mail.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_E_mail.Location = new System.Drawing.Point(179, 223);
            this.textBox_E_mail.MaxLength = 20;
            this.textBox_E_mail.Name = "textBox_E_mail";
            this.textBox_E_mail.Size = new System.Drawing.Size(166, 27);
            this.textBox_E_mail.TabIndex = 9;
            this.textBox_E_mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox_E_mail
            // 
            this.comboBox_E_mail.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_E_mail.FormattingEnabled = true;
            this.comboBox_E_mail.Location = new System.Drawing.Point(379, 223);
            this.comboBox_E_mail.Name = "comboBox_E_mail";
            this.comboBox_E_mail.Size = new System.Drawing.Size(159, 24);
            this.comboBox_E_mail.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(351, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "@";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(101, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "產品時效";
            // 
            // listBox_Product
            // 
            this.listBox_Product.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_Product.FormattingEnabled = true;
            this.listBox_Product.ItemHeight = 16;
            this.listBox_Product.Location = new System.Drawing.Point(179, 266);
            this.listBox_Product.Name = "listBox_Product";
            this.listBox_Product.Size = new System.Drawing.Size(68, 84);
            this.listBox_Product.TabIndex = 11;
            // 
            // checkBox_Member
            // 
            this.checkBox_Member.AutoSize = true;
            this.checkBox_Member.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox_Member.Location = new System.Drawing.Point(104, 26);
            this.checkBox_Member.Name = "checkBox_Member";
            this.checkBox_Member.Size = new System.Drawing.Size(84, 20);
            this.checkBox_Member.TabIndex = 0;
            this.checkBox_Member.Text = "會員  -   ";
            this.checkBox_Member.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(176, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "會員編號";
            // 
            // textBox_MemberNumber
            // 
            this.textBox_MemberNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_MemberNumber.Location = new System.Drawing.Point(254, 23);
            this.textBox_MemberNumber.MaxLength = 4;
            this.textBox_MemberNumber.Name = "textBox_MemberNumber";
            this.textBox_MemberNumber.Size = new System.Drawing.Size(119, 27);
            this.textBox_MemberNumber.TabIndex = 1;
            this.textBox_MemberNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Select
            // 
            this.button_Select.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Select.Location = new System.Drawing.Point(13, 38);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(80, 40);
            this.button_Select.TabIndex = 0;
            this.button_Select.Text = "查詢";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Insert.Location = new System.Drawing.Point(13, 84);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(80, 40);
            this.button_Insert.TabIndex = 1;
            this.button_Insert.Text = "新增";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Delete.Location = new System.Drawing.Point(13, 130);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(80, 40);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "刪除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Update.Location = new System.Drawing.Point(13, 176);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(80, 40);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "修改";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Confirm.Location = new System.Drawing.Point(425, 346);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(80, 40);
            this.button_Confirm.TabIndex = 13;
            this.button_Confirm.Text = "確定";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Cancel.Location = new System.Drawing.Point(511, 346);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(80, 40);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // groupBox_Customer
            // 
            this.groupBox_Customer.Controls.Add(this.button_ViewAll);
            this.groupBox_Customer.Controls.Add(this.label2);
            this.groupBox_Customer.Controls.Add(this.button_Cancel);
            this.groupBox_Customer.Controls.Add(this.textBox_Score);
            this.groupBox_Customer.Controls.Add(this.label13);
            this.groupBox_Customer.Controls.Add(this.button_Confirm);
            this.groupBox_Customer.Controls.Add(this.button_Preset);
            this.groupBox_Customer.Controls.Add(this.label8);
            this.groupBox_Customer.Controls.Add(this.label7);
            this.groupBox_Customer.Controls.Add(this.label6);
            this.groupBox_Customer.Controls.Add(this.textBox_Month);
            this.groupBox_Customer.Controls.Add(this.textBox_Day);
            this.groupBox_Customer.Controls.Add(this.textBox_Year);
            this.groupBox_Customer.Controls.Add(this.textBox_MemberNumber);
            this.groupBox_Customer.Controls.Add(this.label1);
            this.groupBox_Customer.Controls.Add(this.radioButton_Male);
            this.groupBox_Customer.Controls.Add(this.radioButton_Female);
            this.groupBox_Customer.Controls.Add(this.checkBox_Member);
            this.groupBox_Customer.Controls.Add(this.listBox_Product);
            this.groupBox_Customer.Controls.Add(this.label12);
            this.groupBox_Customer.Controls.Add(this.label11);
            this.groupBox_Customer.Controls.Add(this.comboBox_E_mail);
            this.groupBox_Customer.Controls.Add(this.textBox_E_mail);
            this.groupBox_Customer.Controls.Add(this.label10);
            this.groupBox_Customer.Controls.Add(this.comboBox_Job);
            this.groupBox_Customer.Controls.Add(this.label9);
            this.groupBox_Customer.Controls.Add(this.label4);
            this.groupBox_Customer.Controls.Add(this.label5);
            this.groupBox_Customer.Controls.Add(this.textBox_Name);
            this.groupBox_Customer.Controls.Add(this.label3);
            this.groupBox_Customer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Customer.Location = new System.Drawing.Point(12, 300);
            this.groupBox_Customer.Name = "groupBox_Customer";
            this.groupBox_Customer.Size = new System.Drawing.Size(597, 392);
            this.groupBox_Customer.TabIndex = 0;
            this.groupBox_Customer.TabStop = false;
            this.groupBox_Customer.Text = "客戶資料";
            // 
            // button_ViewAll
            // 
            this.button_ViewAll.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_ViewAll.Location = new System.Drawing.Point(425, 300);
            this.button_ViewAll.Name = "button_ViewAll";
            this.button_ViewAll.Size = new System.Drawing.Size(166, 40);
            this.button_ViewAll.TabIndex = 1011;
            this.button_ViewAll.Text = "顯示全部資料";
            this.button_ViewAll.UseVisualStyleBackColor = true;
            this.button_ViewAll.Click += new System.EventHandler(this.button_ViewAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(377, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 1009;
            this.label2.Text = "( 只需輸入數字 )";
            // 
            // textBox_Score
            // 
            this.textBox_Score.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Score.Location = new System.Drawing.Point(265, 355);
            this.textBox_Score.MaxLength = 2;
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(64, 27);
            this.textBox_Score.TabIndex = 12;
            this.textBox_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(101, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 16);
            this.label13.TabIndex = 1007;
            this.label13.Text = "主要客戶潛力 ( 成績 )";
            // 
            // button_Preset
            // 
            this.button_Preset.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Preset.Location = new System.Drawing.Point(511, 18);
            this.button_Preset.Name = "button_Preset";
            this.button_Preset.Size = new System.Drawing.Size(80, 32);
            this.button_Preset.TabIndex = 15;
            this.button_Preset.Text = "清空條件";
            this.button_Preset.UseVisualStyleBackColor = true;
            this.button_Preset.Click += new System.EventHandler(this.button_Preset_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(441, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 1003;
            this.label8.Text = "日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(349, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 1004;
            this.label7.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(257, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 1005;
            this.label6.Text = "年";
            // 
            // textBox_Month
            // 
            this.textBox_Month.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Month.Location = new System.Drawing.Point(287, 143);
            this.textBox_Month.MaxLength = 2;
            this.textBox_Month.Name = "textBox_Month";
            this.textBox_Month.Size = new System.Drawing.Size(56, 27);
            this.textBox_Month.TabIndex = 6;
            this.textBox_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Day
            // 
            this.textBox_Day.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Day.Location = new System.Drawing.Point(379, 143);
            this.textBox_Day.MaxLength = 2;
            this.textBox_Day.Name = "textBox_Day";
            this.textBox_Day.Size = new System.Drawing.Size(56, 27);
            this.textBox_Day.TabIndex = 7;
            this.textBox_Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Year
            // 
            this.textBox_Year.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Year.Location = new System.Drawing.Point(195, 143);
            this.textBox_Year.MaxLength = 4;
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(56, 27);
            this.textBox_Year.TabIndex = 5;
            this.textBox_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox_SQL
            // 
            this.groupBox_SQL.Controls.Add(this.label17);
            this.groupBox_SQL.Controls.Add(this.label16);
            this.groupBox_SQL.Controls.Add(this.label15);
            this.groupBox_SQL.Controls.Add(this.label14);
            this.groupBox_SQL.Controls.Add(this.button_Select);
            this.groupBox_SQL.Controls.Add(this.button_Insert);
            this.groupBox_SQL.Controls.Add(this.button_Update);
            this.groupBox_SQL.Controls.Add(this.button_Delete);
            this.groupBox_SQL.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_SQL.Location = new System.Drawing.Point(615, 464);
            this.groupBox_SQL.Name = "groupBox_SQL";
            this.groupBox_SQL.Size = new System.Drawing.Size(440, 228);
            this.groupBox_SQL.TabIndex = 0;
            this.groupBox_SQL.TabStop = false;
            this.groupBox_SQL.Text = "功能";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(99, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 16);
            this.label17.TabIndex = 1012;
            this.label17.Text = " >> 修改客戶資料";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(99, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 16);
            this.label16.TabIndex = 1011;
            this.label16.Text = " >> 刪除客戶資料";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(99, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 16);
            this.label15.TabIndex = 1010;
            this.label15.Text = " >> 新增客戶資料";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(99, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 16);
            this.label14.TabIndex = 1009;
            this.label14.Text = " >> 未設定條件為顯示所有資料";
            // 
            // groupBox_Situation
            // 
            this.groupBox_Situation.Controls.Add(this.label_Situation);
            this.groupBox_Situation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Situation.Location = new System.Drawing.Point(615, 300);
            this.groupBox_Situation.Name = "groupBox_Situation";
            this.groupBox_Situation.Size = new System.Drawing.Size(440, 158);
            this.groupBox_Situation.TabIndex = 0;
            this.groupBox_Situation.TabStop = false;
            this.groupBox_Situation.Text = "目前狀態";
            // 
            // label_Situation
            // 
            this.label_Situation.AutoSize = true;
            this.label_Situation.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Situation.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Situation.Location = new System.Drawing.Point(6, 60);
            this.label_Situation.Name = "label_Situation";
            this.label_Situation.Size = new System.Drawing.Size(165, 37);
            this.label_Situation.TabIndex = 0;
            this.label_Situation.Text = "顯示狀態";
            // 
            // 客戶資料TableAdapter
            // 
            this.客戶資料TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 699);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_Customer);
            this.Controls.Add(this.groupBox_SQL);
            this.Controls.Add(this.groupBox_Situation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.客戶資料BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.資料庫DataSet)).EndInit();
            this.groupBox_Customer.ResumeLayout(false);
            this.groupBox_Customer.PerformLayout();
            this.groupBox_SQL.ResumeLayout(false);
            this.groupBox_SQL.PerformLayout();
            this.groupBox_Situation.ResumeLayout(false);
            this.groupBox_Situation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Job;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_E_mail;
        private System.Windows.Forms.ComboBox comboBox_E_mail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox_Product;
        private System.Windows.Forms.CheckBox checkBox_Member;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MemberNumber;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox_Customer;
        private System.Windows.Forms.GroupBox groupBox_SQL;
        private System.Windows.Forms.GroupBox groupBox_Situation;
        private System.Windows.Forms.Label label_Situation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Month;
        private System.Windows.Forms.TextBox textBox_Day;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Button button_Preset;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_ViewAll;
        private 資料庫DataSet 資料庫DataSet;
        private System.Windows.Forms.BindingSource 客戶資料BindingSource;
        private 資料庫DataSetTableAdapters.客戶資料TableAdapter 客戶資料TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 識別碼DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 會員DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 會員編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性別DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 生日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 職業DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電子郵件DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品時效DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 主要客戶潛力DataGridViewTextBoxColumn;
    }
}

