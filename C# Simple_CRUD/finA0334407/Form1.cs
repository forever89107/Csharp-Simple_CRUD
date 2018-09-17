using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//(1)
using System.Data.OleDb;

namespace finA0334407
{
    public partial class Form1 : Form
    {
        //(2) 設定全域變數 ds
        DataSet ds = new DataSet();  //dataset

        string pressWhichButton = "";
        string sex = "";
        string memberNumber = "";
        int score = 0;
        string e_mail = "";

        //(3) 加入副程式 DbQuery() 及 DbUpdate()
        //在需查詢事件中使用
        private void dbquery(string dbname, string SelectCmdString, DataSet ds)
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\" + dbname;
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();

            try
            {
                ds.Clear();
                connection.Open();
                oledbAdapter.SelectCommand = new OleDbCommand(SelectCmdString, connection);
                oledbAdapter.Fill(ds);
                oledbAdapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        //在更新(新增,刪除,修改)事件中使用
        private void dbupdate(string dbname, string UpdateCmdString)
        {
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\" + dbname;
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();

            try
            {
                connection.Open();
                oledbAdapter.UpdateCommand = new OleDbCommand(UpdateCmdString, connection);
                oledbAdapter.UpdateCommand.ExecuteNonQuery();
                oledbAdapter.Dispose();
                connection.Close();

                MessageBox.Show("Row(s) Updated !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("該生日日期不存在 !!");
            }
        }

        //控制是否啟動介面控制項
        private void interfaceEnabled(bool b)
        {
            checkBox_Member.Enabled = b;
            textBox_MemberNumber.Enabled = b;
            textBox_Name.Enabled = b;
            radioButton_Male.Enabled = b;
            radioButton_Female.Enabled = b;
            textBox_Year.Enabled = b;
            textBox_Month.Enabled = b;
            textBox_Day.Enabled = b;
            comboBox_Job.Enabled = b;
            textBox_E_mail.Enabled = b;
            comboBox_E_mail.Enabled = b;
            listBox_Product.Enabled = b;
            textBox_Score.Enabled = b;
        }

        //控制是否啟動按鈕控制項
        private void buttonEanbled_SQL(bool b)
        {
            button_Select.Enabled = b;
            button_Insert.Enabled = b;
            button_Delete.Enabled = b;
            button_Update.Enabled = b;
            button_Confirm.Enabled = !b;
            button_Cancel.Enabled = !b;
        }

        //重置(清除)介面上所有資料
        private void preset()
        {
            checkBox_Member.Checked = false;
            textBox_MemberNumber.Text = "";
            textBox_Name.Text = "";
            radioButton_Male.Checked = false;
            radioButton_Female.Checked = false;
            textBox_Year.Text = "";
            textBox_Month.Text = "";
            textBox_Day.Text = "";
            comboBox_Job.Text = "";
            textBox_E_mail.Text = "";
            comboBox_E_mail.Text = "";
            listBox_Product.SetSelected(0, true);
            textBox_Score.Text = "";
        }

        //檢查性別
        private void setUpData() 
        {
            string Sex = "";

            if (radioButton_Male.Checked)
                Sex = "男";
            else if (radioButton_Female.Checked)
                Sex = "女";

            sex = Sex;

            if (checkBox_Member.Checked)
                memberNumber = "'VIP_" + Int32.Parse(textBox_MemberNumber.Text).ToString("0000").Trim() + "',";
            else if (!checkBox_Member.Checked)
                memberNumber = "'',";

            if (textBox_E_mail.Text.Trim() == "" && comboBox_E_mail.Text.Trim() == "")
                e_mail = "'',";
            else if (textBox_E_mail.Text.Trim() != "" || comboBox_E_mail.Text.Trim() != "")
                e_mail = "'" + textBox_E_mail.Text.Trim() + "@" + comboBox_E_mail.Text.Trim() + "',";

            if (textBox_Score.Text != "")
                score = Int32.Parse(textBox_Score.Text.Trim());
            else if (textBox_Score.Text == "")
                score = 0;

        }

        //複合查詢,並將查詢結果顯示在dataGridView
        private void conditionalSelect()
        {
            string cmdStr = "select * from 客戶資料 where true";

            setUpData();

            if (textBox_MemberNumber.Text.Trim() != "")
                cmdStr += " and 會員 = true" + " and 會員編號 = 'VIP_" + Int32.Parse(textBox_MemberNumber.Text).ToString("0000").Trim() + "'";
            if (textBox_Name.Text.Trim() != "")
                cmdStr += " and 姓名 = '" + textBox_Name.Text.Trim() + "'";
            if (radioButton_Male.Checked || radioButton_Female.Checked)
                cmdStr += " and 性別 = '" + sex + "'";
            if (textBox_Year.Text.Trim() != "" && textBox_Month.Text.Trim() != "" && textBox_Day.Text.Trim() != "")
                cmdStr += " and 生日 = '" + textBox_Year.Text.Trim() + "/" + textBox_Month.Text.Trim() + "/" + textBox_Day.Text.Trim() + "'";
            if (comboBox_Job.Text != "")
                cmdStr += " and 職業 = '" + comboBox_Job.Text + "'";
            if (textBox_E_mail.Text.Trim() != "" && comboBox_E_mail.Text.Trim() != "")
                cmdStr += " and 電子郵件 = '" + textBox_E_mail.Text.Trim() + "@" + comboBox_E_mail.Text.Trim() + "'";
            if (listBox_Product.Text != "")
                cmdStr += " and 產品時效 = '" + listBox_Product.Text + "'";
            if (textBox_Score.Text != "")
                cmdStr += " and 主要客戶潛力 = " + textBox_Score.Text.Trim();

            dbquery("資料庫.accdb", cmdStr, ds);    //呼叫dbquery()查詢, 並將查詢結果存入ds
            dataGridView1.DataSource = ds.Tables[0];    //顯示查詢結果
        }


        //將資料表中欄位的資料顯示在介面上
        private void displayDataOnInterface(object sender, EventArgs e) 
        {
            try
            {
                if (textBox_MemberNumber.Text != "")
                {
                    checkBox_Member.Checked = true;
                    string[] MemberNumber = ds.Tables[0].Rows[0].ItemArray[2].ToString().Split(new char[] { 'V', 'I', 'P', '_' });
                    textBox_MemberNumber.Text = Int32.Parse(MemberNumber[4]).ToString("#");
                }

                textBox_Name.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();

                if (ds.Tables[0].Rows[0].ItemArray[4].ToString() == "男")
                    radioButton_Male.Checked = true;
                else if ((ds.Tables[0].Rows[0].ItemArray[4].ToString() == "女"))
                    radioButton_Female.Checked = true;
                setUpData();

                // Split() 消除指定字元
                string[] birthday = ds.Tables[0].Rows[0].ItemArray[5].ToString().Split(new char[] { '/', '/', ' ' });
                textBox_Year.Text = birthday[0];
                textBox_Month.Text = birthday[1];
                textBox_Day.Text = birthday[2];

                comboBox_Job.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();

                string[] email = ds.Tables[0].Rows[0].ItemArray[7].ToString().Split(new char[] { '@' });
                textBox_E_mail.Text = email[0];
                comboBox_E_mail.Text = email[1];

                listBox_Product.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
                textBox_Score.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString();
            }
            catch (IndexOutOfRangeException) 
            {
                //刪除與修改若查詢不到符合條件的資料,將不會有ds.Table[0].Rows[0]存在
                MessageBox.Show("找無此資料 !!");
                button_Cancel_Click(sender, e);
                displayAllDataOnDataGridView();
                
            }
        }

        private void displayAllDataOnDataGridView() 
        {
            string cmdstring = "select * from 客戶資料";
            dbquery("資料庫.accdb", cmdstring, ds);      //呼叫dbquery()查詢, 並將查詢結果存入ds
            dataGridView1.DataSource = ds.Tables[0];  //顯示查詢結果
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 '資料庫DataSet.客戶資料' 資料表。您可以視需要進行移動或移除。
            this.客戶資料TableAdapter.Fill(this.資料庫DataSet.客戶資料);

            string[] job = new string[] { "", "學生", "科技", "服務", "製造", "家管", "軍公教", "其他" };
            comboBox_Job.Items.AddRange(job);

            string[] e_mail = new string[] { "gmail.com", "gmail.com.tw", "yahoo.com", "yahoo.com.tw" };
            comboBox_E_mail.Items.AddRange(e_mail);

            string[] product = new string[] { "", "3個月", "6個月", "1年", "3年" };
            listBox_Product.Items.AddRange(product);
            
            label_Situation.Text = "";
            interfaceEnabled(false);
            buttonEanbled_SQL(true);
            button_ViewAll.Visible = false;
            preset();
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            if (pressWhichButton == "update")
                preset();

            label_Situation.Text = "輸入欲" + button_Select.Text + "客戶";
            pressWhichButton = "select";
            interfaceEnabled(true);
            buttonEanbled_SQL(false);
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            label_Situation.Text = "輸入欲" + button_Insert.Text + "客戶";
            pressWhichButton = "insert";
            interfaceEnabled(true);
            buttonEanbled_SQL(false);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            label_Situation.Text = "查詢欲" + button_Delete.Text + "客戶";
            pressWhichButton = "berforeDelete_conditionalSelect";
            interfaceEnabled(true);
            buttonEanbled_SQL(false);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            label_Situation.Text = "查詢欲" + button_Update.Text + "客戶";
            pressWhichButton = "beforeUpdate_conditionalSelect";
            interfaceEnabled(true);
            buttonEanbled_SQL(false);
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (pressWhichButton != "berforeDelete_conditionalSelect" && pressWhichButton != "beforeUpdate_conditionalSelect")
            {
                interfaceEnabled(false);
                buttonEanbled_SQL(true);
            }

            string cmdStr = "";

            if (pressWhichButton == "select")
            {
                label_Situation.Text = "查詢完畢";
                conditionalSelect();
                button_ViewAll.Visible = true;
            }

            if (pressWhichButton == "insert")
            {
                label_Situation.Text = "";

                setUpData();

                string columnBirthday = "";
                string birthday = "";

                if (textBox_Year.Text.Trim() != "" && textBox_Month.Text.Trim() != "" && textBox_Day.Text.Trim() != "")
                {
                    columnBirthday = ",生日";
                    birthday = "'" + textBox_Year.Text.Trim() + "/" + textBox_Month.Text.Trim() + "/" + textBox_Day.Text.Trim() + "',";
                }
                else
                {
                    columnBirthday = "";
                    birthday = "";
                }
                                
                cmdStr = "insert into 客戶資料 (會員,會員編號,姓名,性別" + columnBirthday + ",職業,電子郵件,產品時效,主要客戶潛力) values "
                        + "(" 
                        + checkBox_Member.Checked + ","
                        + memberNumber
                        + "'" + textBox_Name.Text.Trim() + "',"
                        + "'" + sex + "',"
                        + birthday
                        + "'" + comboBox_Job.Text + "',"
                        + e_mail
                        + "'" + listBox_Product.Text + "',"
                        + score 
                        + ")";

                dbupdate("資料庫.accdb", cmdStr);   //呼叫DbUpdate ()更新資料

                displayAllDataOnDataGridView();

                preset();
            }
                //刪除前先查詢客戶資料
            else if (pressWhichButton == "berforeDelete_conditionalSelect")
            {
                label_Situation.Text = "是否刪除客戶？";
                interfaceEnabled(false);
                buttonEanbled_SQL(false);
                button_Preset.Enabled = false;
                pressWhichButton = "delete";

                conditionalSelect();
                displayDataOnInterface(sender, e);
            }
            else if (pressWhichButton == "delete") 
            {
                label_Situation.Text = "";
                button_Preset.Enabled = true;

                cmdStr = "delete from 客戶資料 where 姓名 = '" + textBox_Name.Text + "'";
                dbupdate("資料庫.accdb", cmdStr);   //呼叫DbUpdate ()更新資料

                displayAllDataOnDataGridView();

                preset();
            }
                //修改前先查詢客戶資料
            else if (pressWhichButton == "beforeUpdate_conditionalSelect")
            {
                label_Situation.Text = "是否修改客戶？";
                buttonEanbled_SQL(false);
                pressWhichButton = "update";
                conditionalSelect();
                displayDataOnInterface(sender, e);
            }
            else if (pressWhichButton == "update")
            {
                label_Situation.Text = "";

                setUpData();

                cmdStr = "update 客戶資料 set "
                        + "會員 = " + checkBox_Member.Checked + ","
                        + "會員編號 = " + memberNumber
                        + "姓名 = '" + textBox_Name.Text.Trim() + "',"
                        + "性別 = '" + sex + "',"
                        + "生日 = '" + textBox_Year.Text.Trim() + "/" + textBox_Month.Text.Trim() + "/" + textBox_Day.Text.Trim() + "',"
                        + "職業 = '" + comboBox_Job.Text + "',"
                        + "電子郵件 = '" + e_mail + "',"
                        + "產品時效 = '" + listBox_Product.Text + "',"
                        + "主要客戶潛力 = " + score
                        + " where 識別碼 = " + ds.Tables[0].Rows[0].ItemArray[0];

                dbupdate("資料庫.accdb", cmdStr);   //呼叫DbUpdate ()更新資料

                displayAllDataOnDataGridView();

                preset();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            label_Situation.Text = "";
            interfaceEnabled(false);
            buttonEanbled_SQL(true);
            button_Preset.Enabled = true;
            preset();
            displayAllDataOnDataGridView();
        }
                
        private void button_Preset_Click(object sender, EventArgs e)
        {
            preset();
        }

        private void button_ViewAll_Click(object sender, EventArgs e)
        {
            label_Situation.Text = "";
            displayAllDataOnDataGridView();
            preset();
            button_ViewAll.Visible = false;
        }
    }
}
