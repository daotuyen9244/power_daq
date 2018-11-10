using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.IO;
namespace AdvancedHMICS
{
    public partial class MainForm : Form
    {
        MongoServer _server;
        MongoDatabase _database;
        MongoCollection _collection;
        double timer_counter_minutes = 0;
        string text = "",old_text="";
        string old_polling_time = "100", old_timeout = "3000";
        int timer_check = 0;
        int counter = 0;
        int old_baudrate = 0;
        string old_port = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int cr = 0; cr < 5; cr++)
            {
                My_DataExportByDay[cr].Data = new UInt64[31, 12];
                My_DataExportByDay[cr].DataByMon = new UInt64[12];
            }
            modbusRTUCom1.PortName = txtPortName.Text;
            modbusRTUCom1.BaudRate = int.Parse(txtBaudRate.Text);
            old_port = txtPortName.Text;
            old_baudrate = int.Parse(txtBaudRate.Text);
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.FileName = "cmd.exe";
            pro.WorkingDirectory = @"D:\PowerDAQ\MongoDB\Server\4.0\bin";
            pro.Arguments = "/C mongod.exe --dbpath D:\\PowerDAQ\\MongoDB\\database";
            pro.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            Process proStart = new Process();
            proStart.StartInfo = pro;
            proStart.Start();
            Thread.Sleep(3000);
            string connection = "mongodb://localhost:27017";
            //string connection = ConfigurationSettings.AppSettings["Connection"];

            _server = MongoServer.Create(connection);
            _database = _server.GetDatabase("PowerDAQ", SafeMode.True);
            

        }
        private double read_data_day(string id, int date, int month, int year)
        {

            double data_return = 0;
            _collection = _database.GetCollection<Station>("PowerCollection");
            var entityQuery = Query.And(
                                Query<Station>.EQ(e => e.Id_station, id),
                                Query<Station>.EQ(e => e.Date, date.ToString()),
                                Query<Station>.EQ(e => e.Month, month.ToString()),
                                Query<Station>.EQ(e => e.Year, year.ToString())
                              );
            Station _user_id = _collection.FindAs<Station>(entityQuery).FirstOrDefault();
            if (_user_id != null)
            {
                data_return = double.Parse(_user_id.Data);
            }


            return data_return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int date = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            for (int cr =0;cr<5;cr++)
            { 
                for (int dm = 0; dm < 12; dm++)
                {
                    for (int dd = 0; dd < 31; dd++)
                    {

                        My_DataExportByDay[cr].Data[dd, dm] = UInt64.Parse(read_data_day((cr+1).ToString(), dd + 1, dm + 1, year).ToString());
                        My_DataExportByDay[cr].DataByMon[dm] += My_DataExportByDay[cr].Data[dd, dm];
                    }
                    My_DataExportByDay[cr].DataByYear += My_DataExportByDay[cr].DataByMon[dm];

                }
                string path = @"D:\PowerDAQ\ExportData\";
                string sub_path = "Station" + (cr+1).ToString();

                sub_path += "_" + month.ToString() + "_" + date.ToString() + "_" + year.ToString() + ".csv";
                path += sub_path;
                if (File.Exists(path))
                {
                    // Use a try block to catch IOExceptions, to
                    // handle the case of the file already being
                    // opened by another process.
                    try
                    {
                        File.Delete(path);
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (!File.Exists(path))
                {

                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                       
                            for (UInt64 dd = 0; dd < 32; dd++)
                            {
                                if (dd == 0)
                                {
                                    sw.Write(",");
                                }
                                else if (dd == 31)
                                {
                                    sw.WriteLine("Day 31 ");
                                }
                                else
                                {
                                    sw.Write("Day " + (dd) + ",");
                                }
                            }
                            for (UInt64 dm = 0; dm < 12; dm++)
                            {

                                for (UInt64 dd = 0; dd < 32; dd++)
                                {

                                    if (dd == 0)
                                    {
                                        sw.Write("Thang " + (dm + 1) + ",");
                                    }
                                    else if (dd == 31)
                                    {
                                        sw.WriteLine(My_DataExportByDay[cr].Data[dd - 1, dm]);
                                    }
                                    else
                                    {
                                        sw.Write(My_DataExportByDay[cr].Data[dd - 1, dm] + ",");
                                    }
                                }
                            }
                    }
                }
            }
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.FileName = "cmd.exe";
            pro.WorkingDirectory = @"D:\PowerDAQ\MongoDB\Server\4.0\bin";
            pro.Arguments = "/C mongoexport.exe -d PowerDAQ -c PowerCollection -o D:\\PowerDAQ\\Backup\\bk_PowerDAQ.json";
            pro.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            Process proStart = new Process();
            proStart.StartInfo = pro;
            proStart.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PieChart a = new PieChart();

            //a.Sender(txtValue.Text);
          

            a.Show();
        }
        public class Station
        {
            public ObjectId Id { get; set; }

            public string Id_station { get; set; }

            public string Data { get; set; }

            public string OldData { get; set; }

            public string Date { get; set; }

            public string Month { get; set; }

            public string Year { get; set; }
        }
        public struct DataExportByDay
        {
            public UInt64 Id_station;
            public UInt64[,] Data;
            public UInt64[] DataByMon;
            public UInt64 DataByYear;
        }
        DataExportByDay[] My_DataExportByDay = new DataExportByDay[5];
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer_counter_minutes++;
            timer_check++;
            if(timer_check >30)
            {
                if (((txtPortName.Text) != old_port) || ((old_baudrate != int.Parse(txtBaudRate.Text))))
                {
                    modbusRTUCom1.PortName = txtPortName.Text;
                    modbusRTUCom1.BaudRate = int.Parse(txtBaudRate.Text);
                    old_port = txtPortName.Text;
                    old_baudrate = int.Parse(txtBaudRate.Text);
                }
                if (((txtPollingTime.Text) != old_polling_time) || ((txtTimeOut.Text != old_timeout)))
                {
                    modbusRTUCom1.PollRateOverride = int.Parse(txtPollingTime.Text);
                    modbusRTUCom1.TimeOut = int.Parse(txtTimeOut.Text);
                    old_polling_time = txtPollingTime.Text;
                    old_timeout = txtTimeOut.Text;
                }
                    timer_check = 0;
            }
            
            if(timer_counter_minutes>=5)
            {
                timer_counter_minutes = 0;
                _collection = _database.GetCollection<Station>("PowerCollection");
                double[] data_record = new double[6];
                data_record[1] = digitalPanelMeter1.Value;
                data_record[2] = digitalPanelMeter2.Value;
                data_record[3] = digitalPanelMeter3.Value;
                data_record[4] = digitalPanelMeter4.Value;
                data_record[5] = digitalPanelMeter5.Value;


                text = "";
                text += "-------------- " + DateTime.Now + " --------------\n";
                
                for (int i =1;i<6;i++)
                {
                    if (checked_informtion(i.ToString(), DateTime.Now))
                    {
                        
                        if(update_data(i.ToString(), DateTime.Now, (data_record[i]).ToString()))
                        {
                            text += ">ID " + i.ToString() + " update OK ";
                            text += ">>>ID " + i.ToString() + " data is: " + read_data(i.ToString(), DateTime.Now) +"\n";
                            
                        }
                        else
                        {
                            text += ">ID " + i.ToString() + " update NG\n";
                        }
                    }
                    else
                    {
                        if(create_data(i.ToString(), DateTime.Now, (data_record[i]).ToString()))
                        {
                            text += ">ID " + i.ToString() + " dc tao\n";
                            text += ">>>ID " + i.ToString() + " data is: " + read_data(i.ToString(), DateTime.Now) + "\n";
                        }
                        else
                        {
                            text += ">ID " + i.ToString() + " ko dc tao \n";
                        }
                    }
                }
                text += old_text;
                richTextBox1.Text = "";
                richTextBox1.Text += text;
                old_text = text;
                counter++;
                if(counter>2)
                {
                    counter = 0;
                    richTextBox1.Text = "";
                    richTextBox1.Text = text;
                    old_text = "";
                }




            }
            
           
            
            
        }
        private Boolean checked_informtion(string id ,DateTime aDateTime)
        {
            Boolean status = true;

            _collection = _database.GetCollection<Station>("PowerCollection");
            
            int date = aDateTime.Day;
            int month = aDateTime.Month;
            int year = aDateTime.Year;
            
            var entityQuery = Query.And(
                      Query<Station>.EQ(e => e.Id_station, id),
                      Query<Station>.EQ(e => e.Date, date.ToString()),
                      Query<Station>.EQ(e => e.Month, month.ToString()),
                      Query<Station>.EQ(e => e.Year, year.ToString())
                  );
            Station _user_id = _collection.FindAs<Station>(entityQuery).FirstOrDefault();
            if (_user_id != null)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            
            return status;
        }
        private Boolean update_data(string id, DateTime aDateTime,string Data_in)
        {
            Boolean status = false;

            _collection = _database.GetCollection<Station>("PowerCollection");
            int date = aDateTime.Day;
            int month = aDateTime.Month;
            int year = aDateTime.Year;
            var entityQuery = Query.And(
                      Query<Station>.EQ(e => e.Id_station, id),
                      Query<Station>.EQ(e => e.Date, date.ToString()),
                      Query<Station>.EQ(e => e.Month, month.ToString()),
                      Query<Station>.EQ(e => e.Year, year.ToString())
                  );
            Station _user_id = _collection.FindAs<Station>(entityQuery).FirstOrDefault();
            if (_user_id != null)
            {
                double datatotal = 0;
                _user_id.OldData = _user_id.Data;
                datatotal = double.Parse(_user_id.OldData);
                datatotal = double.Parse(Data_in);
                _user_id.Data = datatotal.ToString();
                _collection.Save(_user_id);
                status = true;
            }
           

            return status;
        }
        private Boolean create_data(string id, DateTime aDateTime,string Data_in)
        {
            Boolean status = false;

            _collection = _database.GetCollection<Station>("PowerCollection");
            int date = aDateTime.Day;
            int month = aDateTime.Month;
            int year = aDateTime.Year;
            
            var user = new Station { };
            user.Id_station = id;
            user.Data = Data_in;
            user.Date = date.ToString();
            user.Month = month.ToString();
            user.Year = year.ToString();
            //user.Age = Convert.ToInt32(txtAge.Text);
            //user.Name = txtName.Text;
            //user.Location = txtLocation.Text;
            _collection.Insert(user);


            return status;
        }
        private double read_data(string id, DateTime aDateTime)
        {
            Boolean status = false;
            double data_return = 0;
            _collection = _database.GetCollection<Station>("PowerCollection");
            int date = aDateTime.Day;
            int month = aDateTime.Month;
            int year = aDateTime.Year;
            var entityQuery = Query.And(
                      Query<Station>.EQ(e => e.Id_station, id),
                      Query<Station>.EQ(e => e.Date, date.ToString()),
                      Query<Station>.EQ(e => e.Month, month.ToString()),
                      Query<Station>.EQ(e => e.Year, year.ToString())
                  );
            Station _user_id = _collection.FindAs<Station>(entityQuery).FirstOrDefault();
            if (_user_id != null)
            {
                data_return = double.Parse(_user_id.Data);
            }


            return data_return;
        }
        private void digitalPanelMeter1_Click(object sender, EventArgs e)
        {
            ChartForm a = new ChartForm();

            //a.Sender(txtValue.Text);
            a.Sender("1");

            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.FileName = "cmd.exe";
            pro.WorkingDirectory = @"D:\PowerDAQ\MongoDB\Server\4.0\bin";
            pro.Arguments = "/C mongoimport.exe -d PowerDAQ -c PowerCollection D:\\PowerDAQ\\Backup\\bk_PowerDAQ.json";
            pro.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            Process proStart = new Process();
            proStart.StartInfo = pro;
            proStart.Start();
        }

        private void digitalPanelMeter3_Click(object sender, EventArgs e)
        {
            ChartForm a = new ChartForm();

            //a.Sender(txtValue.Text);
            a.Sender("3");

            a.Show();
        }

        private void digitalPanelMeter4_Click(object sender, EventArgs e)
        {
            ChartForm a = new ChartForm();

            //a.Sender(txtValue.Text);
            a.Sender("4");

            a.Show();
        }

        private void digitalPanelMeter5_Click(object sender, EventArgs e)
        {
            ChartForm a = new ChartForm();

            //a.Sender(txtValue.Text);
            a.Sender("5");

            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void modbusRTUCom1_DataReceived(object sender, MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs e)
        {

        }

        private void digitalPanelMeter2_Click(object sender, EventArgs e)
        {
            ChartForm a = new ChartForm();

            //a.Sender(txtValue.Text);
            a.Sender("2");

            a.Show();
        }
    }
}
