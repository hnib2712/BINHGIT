using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Language.V1;
using DetectLanguage;
using Newtonsoft.Json;
using LanguageDetect.Models;
using System.Data.SqlClient;
using System.Configuration;
using Google.Apis.Util;

namespace LanguageDetect
{
    public partial class Form1 : Form
    {

        public ProcessLinqDataContext db = new ProcessLinqDataContext();
        DetectLanguageClient client = new DetectLanguageClient("1876c993bd6215438e815948969771fe");

        static string constring = @"Data Source=BINHVT\BINH2016;Initial Catalog=yb_masterlist;integrated security=True";

        SqlConnection conn = new SqlConnection(constring);
        private void setRowFromTo()
        {
            Fr = Convert.ToInt32(FromRow.Text);
            Tr = Convert.ToInt32(ToRow.Text);
        }
       
                
        



        private int Fr, Tr;
        string[] t = new string[] { };
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yb_masterlistDataSet3.sp_Getmasterlist1000' table. You can move, or remove it, as needed.
            this.sp_Getmasterlist1000TableAdapter.Fill(this.yb_masterlistDataSet3.sp_Getmasterlist1000);
            //Load data 1000 row từ storepocedure (dữ liệu mẫu)
            //this.sp_Getmasterlist1000TableAdapter.Fill(this.yb_masterlistDataSet1.sp_Getmasterlist1000);

            // Gán giá trị FromRow, ToRow từ form
            setRowFromTo();



        }
       
       
        //Xuất ra file excel từ datagridview
        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Application.Interactive = false;
            app.Visible = true;
            
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs("D:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }

        //load data vào gridview từ FromRow - ToRow
        private void LoadData_Click(object sender, EventArgs e)
        {
            setRowFromTo();
            //dùng linq
            var LoadDB = (from p in db.masterlists 
                          where p.Indent >= Fr && p.Indent <=Tr
                          select p);

            dataGridView1.DataSource = LoadDB;
            MessageBox.Show("Job Done!");
        }

        //load data theo điều kiện 3 vào gridview từ SP
        private void button3_Click(object sender, EventArgs e)
        {
            setRowFromTo();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_GetFromTo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FromRow", SqlDbType.VarChar).Value = Convert.ToInt32(FromRow.Text);
            cmd.Parameters.Add("@ToRow", SqlDbType.VarChar).Value = Convert.ToInt32(ToRow.Text);

            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            MessageBox.Show("Job Done!");

        }

        //Duyệt qua từng record từ FromRow - Torow gửi request đến API lấy kq trả về Update vào Db nếu là "vi" sẽ update LangVi = 1
        private async void button1_Click(object sender, EventArgs e)
        {

            setRowFromTo();
            for (int i = Fr; i <= Tr; i++){
                var master = (from p in db.masterlists
                              where p.Indent == i
                              select p).FirstOrDefault();
                string languageCode = await client.DetectCodeAsync(master.TITLE.ToString());
                if ((languageCode.ToString()) == "vi")
                {

                    master.LangVi = true;
                }
                else { }
                //}
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    
                }

            }

            MessageBox.Show("Job Done!");

            //Sử dụng mảng chuỗi để post request và nhận kết quả json (kết quả trả về bị sai) - send 10 row trả về 18 
            //Không sử dụng được cách này đối với DetectLanguage - phải duyệt qua từng record và request api

            //DetectResult[][] results = await client.BatchDetectAsync(texts);
            //string jsonData = JsonConvert.SerializeObject(results);
            //textBox1.Text = languageCode.ToString();
        }
    }
}
