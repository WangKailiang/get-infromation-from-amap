using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Xml;
using System.Net;
using System.IO;
using LitJson;

namespace AMAP
{
    public partial class targetInfoGet : Form
    {
        public targetInfoGet()
        {
            InitializeComponent();
            Initial();
            mapBrowser.Navigate(Application.StartupPath  + @"\AMAP.htm");
            
        }
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            string html = GetTarInfo();
            WriteInfo(html);
        }
        private void btnOutPuttoExcel_Click(object sender, EventArgs e)
        {
            OutPut();
        }
        private void OutPut() 
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File To";
            saveFileDialog.ShowDialog();

            Stream myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));

            string str = "";
            try
            {
                //写标题
                for (int i = 0; i < dataInfo.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        str += "\t";
                    }
                    str += dataInfo.Columns[i].HeaderText;
                }
                sw.WriteLine(str);
                //写内容
                
                for (int j = 0; j < dataInfo.Rows.Count-1; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dataInfo.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += "\t";
                        }
                        tempStr += dataInfo.Rows[j].Cells[k].Value.ToString();
                    }
                    sw.WriteLine(tempStr);
                }
                sw.Close();
                myStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }
        private void Initial()
        {
            dataInfo.Columns.Add("Country", "国家");
            dataInfo.Columns.Add("Descrip", "详细信息");
            dataInfo.Columns.Add("Teleph", "联系电话");
            dataInfo.Columns.Add("Name", "单位名称");
            dataInfo.Columns.Add("Lon", "经度");
            dataInfo.Columns.Add("Adress", "地址");
            dataInfo.Columns.Add("Lat", "维度");
            dataInfo.Columns.Add("类型", "服务类型");
        }
        private string GetTarInfo()
        {
            //获取目标物经纬度坐标信息
            string targetLngLat = mapBrowser.Document.GetElementById("lnglat").GetAttribute("value");
            if (targetLngLat == "") { MessageBox.Show("没有选择目标物，请选择后再获取信息");}
            string[] sArray = targetLngLat.Split(',');
            string search = "http://ditu.amap.com/service/regeo?longitude=" + sArray[0] + "&latitude=" + sArray[1];
            //string search = "http://ditu.amap.com/service/regeo?longitude=118.890923&latitude=31.937697";
            Uri url = new Uri(search);

            //HttpWebRequest实例化实现查询
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(url);

            //Request属性设置
            Request.KeepAlive = true;
            Request.ProtocolVersion = HttpVersion.Version11;
            Request.Method = "GET";
            Request.Accept = "*/* ";
            Request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.56 Safari/536.5";
            Request.Referer = url.ToString();

            //从Internet资源返回数据流
            HttpWebResponse htmlResponse = (HttpWebResponse)Request.GetResponse();
            Stream htmlStream = htmlResponse.GetResponseStream();
            StreamReader weatherStreamReader = new StreamReader(htmlStream, Encoding.UTF8);
            string html = weatherStreamReader.ReadToEnd();
            weatherStreamReader.Close();
            htmlStream.Close();
            htmlResponse.Close();
            return html;
        }
        private void WriteInfo(string html)
        {
            JsonReader reader = new JsonReader(html);
            JsonData data = JsonMapper.ToObject(reader);

            if (data["status"].ToString() == "1")
            {
                JsonData targetInfo = (JsonData)data["data"]["poi_list"];
                foreach (JsonData text in targetInfo)
                {
                    int index = dataInfo.Rows.Add();
                    dataInfo.Rows[index].Cells[0].Value = data["data"]["country"].ToString();
                    dataInfo.Rows[index].Cells[1].Value = data["data"]["desc"].ToString();
                    dataInfo.Rows[index].Cells[2].Value = text[2].ToString();
                    dataInfo.Rows[index].Cells[3].Value = text[3].ToString();
                    dataInfo.Rows[index].Cells[4].Value = text[6].ToString();
                    dataInfo.Rows[index].Cells[5].Value = text[7].ToString();
                    dataInfo.Rows[index].Cells[6].Value = text[8].ToString();
                    dataInfo.Rows[index].Cells[7].Value = text[9].ToString();
                    break;
                }
            }
            else if (data["status"].ToString() == "2")
            {
            }
            else
            {
                MessageBox.Show("参数错误");
            }
        }

    }
}
