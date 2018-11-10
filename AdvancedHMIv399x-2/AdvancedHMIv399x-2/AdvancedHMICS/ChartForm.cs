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
using System.IO;
namespace AdvancedHMICS
{
    public partial class ChartForm : Form
    {

        public string reciver_message = "";
        int show_form = 0,old_show_form=0;
        UInt32 counter_time = 0;
        Boolean first_run = true;
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        MongoServer _server;
        MongoDatabase _database;
        MongoCollection _collection;
        double[] old_data = new double[31];
        double[] now_data = new double[31];

        public ChartValues<ObservableValue> DataByDay { get; set; }
        public ChartValues<ObservableValue> DataByMonth { get; set; }
        public ColumnSeries ChartByDay { get; set; }
        public ColumnSeries ChartByMonth { get; set; }
        public Axis LableByDay { get; set; }
        public Axis LableByMonth { get; set; }
        public struct DataExportByMonth
        {
            public UInt64 Id_station;
            public UInt64[] DataByDay;
            public UInt64[] DataByMon;
            public UInt64 DataByYear;
        }
        public struct DataExportByDay
        {
            public UInt64 Id_station;
            public UInt64[,] Data;
            public UInt64[] DataByMon;
            public UInt64 DataByYear;
        }
        DataExportByMonth[] my_data = new DataExportByMonth[5];
        DataExportByDay[] My_DataExportByDay = new DataExportByDay[5];
        public ChartForm()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            //frmForm2.closeForm();

        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            for (int cr = 0; cr < 5; cr++)
            {
                my_data[cr].DataByDay = new UInt64[31];
                my_data[cr].DataByMon = new UInt64[12];
                My_DataExportByDay[cr].Data = new UInt64[31, 12];
                My_DataExportByDay[cr].DataByMon = new UInt64[12];
            }
           
            label3.Text+=  " "+ reciver_message;
            show_form = 1;
            string connection = "mongodb://localhost:27017";
            //string connection = ConfigurationSettings.AppSettings["Connection"];

            _server = MongoServer.Create(connection);

            _database = _server.GetDatabase("PowerDAQ", SafeMode.True);

            //cartesianChart1.LegendLocation = LegendLocation.Right;
            DataByDay = new ChartValues<ObservableValue>
              {
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0),
                new ObservableValue(0)

              };

            DataByMonth = new ChartValues<ObservableValue>
                      {
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),

                      };

            //UInt32.TryParse(reciver_message, out show_form);
            //MessageBox.Show(reciver_message);
            ChartByMonth = new ColumnSeries
            {
                Title = "Trạm " + reciver_message,
                Values = DataByMonth,
                Foreground = System.Windows.Media.Brushes.Violet,
                DataLabels = true,
                LabelPoint = point => point.Y + "kW"

            };
            ChartByDay = new ColumnSeries
            {
                Title = "Trạm " + reciver_message,
                Values = DataByDay,
                Foreground = System.Windows.Media.Brushes.Violet,
                DataLabels = true//,
                                 //LabelPoint = point => point.Y + "K"
            };
            cartesianChart1.Series.Add(ChartByDay);
            cartesianChart1.Series.Add(ChartByMonth);
            
                LableByMonth = new Axis
                {
                    Labels = new[]
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "10",
                    "11",
                    "12",
                    "13",
                    "14",
                    "15",
                    "16",
                    "17",
                    "18",
                    "19",
                    "20",
                    "21",
                    "22",
                    "23",
                    "24",
                    "25",
                    "26",
                    "27",
                    "28",
                    "29",
                    "30",
                    "31"
                },
                    Foreground = System.Windows.Media.Brushes.Aqua,
                    Separator = new Separator // force the separator step to 1, so it always display all labels
                    {
                        Step = 1,
                        IsEnabled = false //disable it to make it invisible.
                    },
                    LabelsRotation = 15
                };
            cartesianChart1.AxisX.Add(LableByMonth);
            cartesianChart1.AxisY.Add(new Axis
            {
                //LabelFormatter = value => value + ".00K items",
                LabelFormatter = value => value + " kW",
                Foreground = System.Windows.Media.Brushes.DodgerBlue,

                Separator = new Separator()
            });
            checkBox1.Checked = !(checkBox2.Checked);
            show_form = 1;
            ChartByDay.Visibility = System.Windows.Visibility.Hidden;
            ChartByMonth.Visibility = System.Windows.Visibility.Visible;

            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 12;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int date = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            UInt64 temp = 0,temp1=0;
            counter_time++;
            if(old_show_form!=show_form)
            {
                first_run = true;
                old_show_form = show_form;
            }
            label4.Text = "";
            label4.Text = DateTime.Now.ToShortDateString();
            label5.Text = "";
            label5.Text = DateTime.Now.ToLongTimeString();
            if (first_run)
            {
                
                if (show_form==2)
                {
                    for (int i = 0; i < 31; i++)
                    {
                        now_data[i] = read_data_day(reciver_message, i + 1, month, year);
                    }
                    for (int i = 0; i < 31; i++)
                    {
                        if (old_data[i] != now_data[i]) ;
                        {

                            DataByDay[i] = new ObservableValue(now_data[i]);
                            old_data[i] = now_data[i];
                        }
                    }
                }
                else
                {
                    for (int dm = 0; dm < 12; dm++)
                    {
                        for (int dd = 0; dd < 31; dd++)
                        {
                            
                            My_DataExportByDay[int.Parse(reciver_message)-1].Data[dd, dm] = UInt64.Parse(read_data_day(reciver_message, dd + 1, dm+1, year).ToString());
                            My_DataExportByDay[int.Parse(reciver_message)-1].DataByMon[dm] += My_DataExportByDay[int.Parse(reciver_message)-1].Data[dd, dm];
                        }
                        My_DataExportByDay[int.Parse(reciver_message)-1].DataByYear += My_DataExportByDay[int.Parse(reciver_message)-1].DataByMon[dm];
                        
                    }
                    for (int dm = 0; dm < 12; dm++)
                    {
                        DataByMonth[dm] = new ObservableValue((My_DataExportByDay[int.Parse(reciver_message)-1].DataByMon[dm]));
                    }
                }
                first_run = false;
            }
            if (counter_time > 5)
            {
                counter_time = 0;
                if (show_form == 2)
                {
                    temp1 = UInt64.Parse(read_data_day(reciver_message, date, month, year).ToString()) ;
                    DataByDay[date-1] = new ObservableValue(temp1);
                    lblTotal.Text = "";
                    lblTotal.Text = temp1.ToString() + " kW";
                    label7.Text = "";
                    label7.Text = "Total For ToDay";
                }
                else
                {
                    
                    temp = My_DataExportByDay[int.Parse(reciver_message)-1].DataByMon[month-1]+ UInt64.Parse(read_data_day(reciver_message, date, month, year).ToString())- UInt64.Parse(read_old_data_day(reciver_message, date, month, year).ToString());
                    //MessageBox.Show(temp.ToString());
                    DataByMonth[month-1] = new ObservableValue(temp);
                    lblTotal.Text = temp.ToString() + " kW";
                    label7.Text = "";
                    label7.Text = "Total For This Month";
                    //temp = 0;
                }

            }
        }
        private double read_data_now(string id, DateTime aDateTime)
        {

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
        private double read_old_data_day(string id, int date, int month, int year)
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
                data_return = double.Parse(_user_id.OldData);
            }


            return data_return;
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
        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        private void GetMessage(string Message)
        {
            reciver_message = Message;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = !(checkBox1.Checked);
            show_form = 1;
            ChartByDay.Visibility = System.Windows.Visibility.Hidden;
            ChartByMonth.Visibility = System.Windows.Visibility.Visible;
            
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 12;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = !(checkBox2.Checked);
            show_form = 2;
            ChartByMonth.Visibility = System.Windows.Visibility.Hidden;
            ChartByDay.Visibility = System.Windows.Visibility.Visible;
            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 31;
            //cartesianChart1.AxisX[0].Labels[0] = "Data14444444";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            int date = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            for (int dm = 0; dm < 12; dm++)
            {
                for (int dd = 0; dd < 31; dd++)
                {

                    My_DataExportByDay[int.Parse(reciver_message) - 1].Data[dd, dm] = UInt64.Parse(read_data_day(reciver_message, dd + 1, dm + 1, year).ToString());
                    My_DataExportByDay[int.Parse(reciver_message) - 1].DataByMon[dm] += My_DataExportByDay[int.Parse(reciver_message) - 1].Data[dd, dm];
                }
                My_DataExportByDay[int.Parse(reciver_message) - 1].DataByYear += My_DataExportByDay[int.Parse(reciver_message) - 1].DataByMon[dm];

            }
            string path = @"D:\PowerDAQ\ExportData\";
            string sub_path = "Station"+ reciver_message;
            if (show_form == 2)
            {
                 sub_path += "_Day_" + month.ToString() + "_" + date.ToString() + "_" + year.ToString() + ".csv";
            }
            else if (show_form == 1)
            {
                 sub_path += "_Month_" + month.ToString() + "_" + date.ToString() + "_" + year.ToString() + ".csv";
            }
            
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
                    if (show_form == 2)
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
                                    sw.WriteLine(My_DataExportByDay[UInt64.Parse(reciver_message)-1].Data[dd - 1, dm]);
                                }
                                else
                                {
                                    sw.Write(My_DataExportByDay[UInt64.Parse(reciver_message) - 1].Data[dd - 1, dm] + ",");
                                }
                            }
                        }
                    }
                    else if (show_form == 1)
                    {
                        for (UInt64 dm = 0; dm < 13; dm++)
                        {
                            if(dm==12)
                            {
                                sw.WriteLine("Thang " + (dm));
                            }
                            else if(dm==0)
                            {
                                sw.Write(",");
                            }
                            else
                            {
                                sw.Write("Thang " + (dm) + ",");
                            }
                            
                        }
                        for (UInt64 dm = 0; dm < 13; dm++)
                        {
                            if (dm == 0)
                            {
                                sw.Write("Data,");
                            }
                            else
                            {
                                
                                sw.Write(My_DataExportByDay[int.Parse(reciver_message) - 1].DataByMon[dm-1] + ",");
                            }
                        }
                    }
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
