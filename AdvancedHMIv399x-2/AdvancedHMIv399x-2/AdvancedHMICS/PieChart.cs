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
using System.Diagnostics;
using System.Threading;
namespace AdvancedHMICS
{
    public partial class PieChart : Form
    {
        public PieChart()
        {
            InitializeComponent();
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
        MongoServer _server;
        MongoDatabase _database;
        MongoCollection _collection;
        int date = DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        Boolean first_run = true, is_collum_chart = false;
        public struct DataExportByDay
        {
            public UInt64 Id_station;
            public UInt64[,] Data;
            public UInt64[] DataByMon;
            public UInt64 DataByYear;
        }
        DataExportByDay[] My_DataExportByDay = new DataExportByDay[5];
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

        public ColumnSeries ChartByMonth1 { get; set; }
        public ColumnSeries ChartByMonth2 { get; set; }
        public ColumnSeries ChartByMonth3 { get; set; }
        public ColumnSeries ChartByMonth4 { get; set; }
        public ColumnSeries ChartByMonth5 { get; set; }
        public ColumnSeries ChartByYear1 { get; set; }
        public ColumnSeries ChartByYear2 { get; set; }
        public ColumnSeries ChartByYear3 { get; set; }
        public ColumnSeries ChartByYear4 { get; set; }
        public ColumnSeries ChartByYear5 { get; set; }
        public Axis LableByDay { get; set; }
        public Axis LableByMonth { get; set; }


        public ChartValues<ObservableValue> DataByMonth1 { get; set; }
        public ChartValues<ObservableValue> DataByMonth2 { get; set; }
        public ChartValues<ObservableValue> DataByMonth3 { get; set; }
        public ChartValues<ObservableValue> DataByMonth4 { get; set; }
        public ChartValues<ObservableValue> DataByMonth5 { get; set; }

        public ChartValues<ObservableValue> DataByYear1 { get; set; }
        public ChartValues<ObservableValue> DataByYear2 { get; set; }
        public ChartValues<ObservableValue> DataByYear3 { get; set; }
        public ChartValues<ObservableValue> DataByYear4 { get; set; }
        public ChartValues<ObservableValue> DataByYear5 { get; set; }

        private void PieChart_Load(object sender, EventArgs e)
        {
            for (int cr = 0; cr < 5; cr++)
            {
                My_DataExportByDay[cr].Data = new UInt64[31, 12];
                My_DataExportByDay[cr].DataByMon = new UInt64[12];
            }
            string connection = "mongodb://localhost:27017";
            _server = MongoServer.Create(connection);
            _database = _server.GetDatabase("PowerDAQ", SafeMode.True);
            Thread.Sleep(1000);
            for (int station = 0; station < 5; station++)
            {
                for (int dm = 0; dm < 12; dm++)
                {
                    for (int dd = 0; dd < 31; dd++)
                    {

                        My_DataExportByDay[station].Data[dd, dm] = UInt64.Parse(read_data_day((station + 1).ToString(), dd + 1, dm + 1, year).ToString());
                        My_DataExportByDay[station].DataByMon[dm] += My_DataExportByDay[station].Data[dd, dm];
                    }
                    My_DataExportByDay[station].DataByYear += My_DataExportByDay[station].DataByMon[dm];
                }

            }
            cartesianChart1.Hide();
            pieChart1.InnerRadius = 100;
            pieChart1.LegendLocation = LegendLocation.Right;
            pieChart1.HoverPushOut = 30;

            pieChart1.Series = new SeriesCollection
      {

        new PieSeries
        {
          Title = "Station 1",
          Values = new ChartValues<double> {My_DataExportByDay[0].DataByYear},

          DataLabels = true
        },
        new PieSeries
        {
          Title = "Station 2",
          Values = new ChartValues<double> {My_DataExportByDay[1].DataByYear},
          DataLabels = true
        },
        new PieSeries
        {
          Title = "Station 3",
          Values = new ChartValues<double> {My_DataExportByDay[2].DataByYear},
          DataLabels = true
        },
        new PieSeries
        {
          Title = "Station 4",
          Values = new ChartValues<double> {My_DataExportByDay[3].DataByYear},
          DataLabels = true
        },
        new PieSeries
        {
          Title = "Station 5",
          Values = new ChartValues<double> {My_DataExportByDay[4].DataByYear},
          DataLabels = true
        }
      };
            #region init_data
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
          "12"
        },
                Foreground = System.Windows.Media.Brushes.Red,
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
                Foreground = System.Windows.Media.Brushes.Blue,

                Separator = new Separator()
            });


            DataByMonth1 = new ChartValues<ObservableValue> {
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
            DataByMonth2 = new ChartValues<ObservableValue> {
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
            DataByMonth3 = new ChartValues<ObservableValue> {
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
            DataByMonth4 = new ChartValues<ObservableValue> {
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
            DataByMonth5 = new ChartValues<ObservableValue> {
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
            DataByYear1 = new ChartValues<ObservableValue> { new ObservableValue(0) };
            DataByYear2 = new ChartValues<ObservableValue> { new ObservableValue(0) };
            DataByYear3 = new ChartValues<ObservableValue> { new ObservableValue(0) };
            DataByYear4 = new ChartValues<ObservableValue> { new ObservableValue(0) };
            DataByYear5 = new ChartValues<ObservableValue> { new ObservableValue(0) };

            #endregion

            DataByYear1[0] = new ObservableValue((My_DataExportByDay[0].DataByYear));
            DataByYear2[0] = new ObservableValue((My_DataExportByDay[1].DataByYear));
            DataByYear3[0] = new ObservableValue((My_DataExportByDay[2].DataByYear));
            DataByYear4[0] = new ObservableValue((My_DataExportByDay[3].DataByYear));
            DataByYear5[0] = new ObservableValue((My_DataExportByDay[4].DataByYear));

            for (int dm = 0; dm < 12; dm++)
            {
                DataByMonth1[dm] = new ObservableValue((My_DataExportByDay[0].DataByMon[dm]));
                DataByMonth2[dm] = new ObservableValue((My_DataExportByDay[1].DataByMon[dm]));
                DataByMonth3[dm] = new ObservableValue((My_DataExportByDay[2].DataByMon[dm]));
                DataByMonth4[dm] = new ObservableValue((My_DataExportByDay[3].DataByMon[dm]));
                DataByMonth5[dm] = new ObservableValue((My_DataExportByDay[4].DataByMon[dm]));

            }

            ChartByMonth1 = new ColumnSeries
            {
                Title = "Station1",
                Values = DataByMonth1
            };
            ChartByMonth2 = new ColumnSeries
            {
                Title = "Station2",
                Values = DataByMonth1
            };
            ChartByMonth3 = new ColumnSeries
            {
                Title = "Station3",
                Values = DataByMonth1
            };
            ChartByMonth4 = new ColumnSeries
            {
                Title = "Station4",
                Values = DataByMonth1
            };
            ChartByMonth5 = new ColumnSeries
            {
                Title = "Station5",
                Values = DataByMonth1
            };
            ChartByYear1 = new ColumnSeries
            {
                Title = "Station1",
                Values = DataByYear1
            };
            ChartByYear2 = new ColumnSeries
            {
                Title = "Station2",
                Values = DataByYear2
            };
            ChartByYear3 = new ColumnSeries
            {
                Title = "Station3",
                Values = DataByYear3
            };
            ChartByYear4 = new ColumnSeries
            {
                Title = "Station4",
                Values = DataByYear4
            };
            ChartByYear5 = new ColumnSeries
            {
                Title = "Station5",
                Values = DataByYear5
            };



            cartesianChart1.Series.Add(ChartByMonth1);
            cartesianChart1.Series.Add(ChartByMonth2);
            cartesianChart1.Series.Add(ChartByMonth3);
            cartesianChart1.Series.Add(ChartByMonth4);
            cartesianChart1.Series.Add(ChartByMonth5);

            cartesianChart1.Series.Add(ChartByYear1);
            cartesianChart1.Series.Add(ChartByYear2);
            cartesianChart1.Series.Add(ChartByYear3);
            cartesianChart1.Series.Add(ChartByYear4);
            cartesianChart1.Series.Add(ChartByYear5);

            ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
            ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
            ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
            ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
            ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

            cartesianChart1.AxisX[0].MinValue = 0;
            cartesianChart1.AxisX[0].MaxValue = 12;

            chkChartPie.Checked = !(chkChartCollum.Checked);
            chkByMonth.Enabled = false;
            ChkByYear.Enabled = true;
            chkSta1.Enabled = false;
            chkSta2.Enabled = false;
            chkSta3.Enabled = false;
            chkSta4.Enabled = false;
            chkSta5.Enabled = false;
            chkStaAll.Enabled = true;


        }

        private void chkChartPie_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void chkChartCollum_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkChartPie_MouseClick(object sender, MouseEventArgs e)
        {
            cartesianChart1.Hide();
            pieChart1.Show();
            chkChartPie.CheckState = CheckState.Checked;
            chkChartCollum.CheckState = CheckState.Unchecked;

            chkByMonth.Enabled = false;
            ChkByYear.Enabled = true;
            chkSta1.Enabled = false;
            chkSta2.Enabled = false;
            chkSta3.Enabled = false;
            chkSta4.Enabled = false;
            chkSta5.Enabled = false;
            chkStaAll.Enabled = true;
            chkStaAll.CheckState = CheckState.Checked;
            chkByMonth.CheckState = CheckState.Unchecked;
            ChkByYear.CheckState = CheckState.Checked;
            is_collum_chart = false;


        }

        private void chkChartCollum_Click(object sender, EventArgs e)
        {
            cartesianChart1.Show();
            pieChart1.Hide();
            chkChartPie.CheckState = CheckState.Unchecked;
            chkChartCollum.CheckState = CheckState.Checked;
            chkByMonth.Enabled = true;
            ChkByYear.Enabled = true;
            chkSta1.Enabled = true;
            chkSta2.Enabled = true;
            chkSta3.Enabled = true;
            chkSta4.Enabled = true;
            chkSta5.Enabled = true;
            chkStaAll.Enabled = true;
            chkStaAll.CheckState = CheckState.Checked;
            ChkByYear.CheckState = CheckState.Checked;
            is_collum_chart = true;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
            if (is_collum_chart)
            {
                #region check_by_month
                if (chkByMonth.CheckState == CheckState.Checked)
                {
                    chkStaAll.Enabled = true;
                    if (chkSta1.CheckState == CheckState.Checked)
                    {

                        ChartByMonth1.Visibility = System.Windows.Visibility.Visible;
                        ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                        ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                        cartesianChart1.AxisX[0].MinValue = 0;
                        cartesianChart1.AxisX[0].MaxValue = 12;
                    }
                    if (chkSta2.CheckState == CheckState.Checked)
                    {

                        ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth2.Visibility = System.Windows.Visibility.Visible;
                        ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                        ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                        cartesianChart1.AxisX[0].MinValue = 0;
                        cartesianChart1.AxisX[0].MaxValue = 12;


                    }
                    if (chkSta3.CheckState == CheckState.Checked)
                    {

                        ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth3.Visibility = System.Windows.Visibility.Visible;
                        ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                        ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                        cartesianChart1.AxisX[0].MinValue = 0;
                        cartesianChart1.AxisX[0].MaxValue = 12;

                    }
                    if (chkSta4.CheckState == CheckState.Checked)
                    {

                        ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth4.Visibility = System.Windows.Visibility.Visible;
                        ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                        cartesianChart1.AxisX[0].MinValue = 0;
                        cartesianChart1.AxisX[0].MaxValue = 12;

                    }
                    if (chkSta5.CheckState == CheckState.Checked)
                    {

                        ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByMonth5.Visibility = System.Windows.Visibility.Visible;
                        ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                        cartesianChart1.AxisX[0].MinValue = 0;
                        cartesianChart1.AxisX[0].MaxValue = 12;

                    }
                    if (chkStaAll.CheckState == CheckState.Checked)
                    {

                        ChartByMonth1.Visibility = System.Windows.Visibility.Visible;
                        ChartByMonth2.Visibility = System.Windows.Visibility.Visible;
                        ChartByMonth3.Visibility = System.Windows.Visibility.Visible;
                        ChartByMonth4.Visibility = System.Windows.Visibility.Visible;
                        ChartByMonth5.Visibility = System.Windows.Visibility.Visible;
                        ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                        ChartByYear5.Visibility = System.Windows.Visibility.Hidden;


                        cartesianChart1.AxisX[0].MinValue = 0;
                        cartesianChart1.AxisX[0].MaxValue = 12;
                    }

                }
                #endregion
                #region check_by_year
                if (ChkByYear.CheckState == CheckState.Checked)
                {
                   

                    
                        chkStaAll.Enabled = true;
                        if (chkSta1.CheckState == CheckState.Checked)
                        {

                            ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                            ChartByYear1.Visibility = System.Windows.Visibility.Visible;
                            ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                            cartesianChart1.AxisX[0].MinValue = 0;
                            cartesianChart1.AxisX[0].MaxValue = 1;
                        }
                        if (chkSta2.CheckState == CheckState.Checked)
                        {

                            ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                            ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear2.Visibility = System.Windows.Visibility.Visible;
                            ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                            cartesianChart1.AxisX[0].MinValue = 0;
                            cartesianChart1.AxisX[0].MaxValue = 1;


                        }
                        if (chkSta3.CheckState == CheckState.Checked)
                        {

                            ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                            ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear3.Visibility = System.Windows.Visibility.Visible;
                            ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                            cartesianChart1.AxisX[0].MinValue = 0;
                            cartesianChart1.AxisX[0].MaxValue = 1;

                        }
                        if (chkSta4.CheckState == CheckState.Checked)
                        {

                            ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                            ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear4.Visibility = System.Windows.Visibility.Visible;
                            ChartByYear5.Visibility = System.Windows.Visibility.Hidden;

                            cartesianChart1.AxisX[0].MinValue = 0;
                            cartesianChart1.AxisX[0].MaxValue = 1;

                        }
                        if (chkSta5.CheckState == CheckState.Checked)
                        {

                            ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                            ChartByYear1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByYear5.Visibility = System.Windows.Visibility.Visible;

                            cartesianChart1.AxisX[0].MinValue = 0;
                            cartesianChart1.AxisX[0].MaxValue = 1;

                        }
                        if (chkStaAll.CheckState == CheckState.Checked)
                        {

                            ChartByMonth1.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth2.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth3.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth4.Visibility = System.Windows.Visibility.Hidden;
                            ChartByMonth5.Visibility = System.Windows.Visibility.Hidden;

                            ChartByYear1.Visibility = System.Windows.Visibility.Visible;
                            ChartByYear2.Visibility = System.Windows.Visibility.Visible;
                            ChartByYear3.Visibility = System.Windows.Visibility.Visible;
                            ChartByYear4.Visibility = System.Windows.Visibility.Visible;
                            ChartByYear5.Visibility = System.Windows.Visibility.Visible;


                            cartesianChart1.AxisX[0].MinValue = 0;
                            cartesianChart1.AxisX[0].MaxValue = 1;
                        }

                    
                    #endregion

                }

            }
        }

        private void chkSta1_Click(object sender, EventArgs e)
        {
            chkSta1.CheckState = CheckState.Checked;
            chkSta2.CheckState = CheckState.Unchecked;
            chkSta3.CheckState = CheckState.Unchecked;
            chkSta4.CheckState = CheckState.Unchecked;
            chkSta5.CheckState = CheckState.Unchecked;
            chkStaAll.CheckState = CheckState.Unchecked;
            first_run = true;
            chkByMonth.CheckState = CheckState.Checked;
            ChkByYear.CheckState = CheckState.Unchecked;
        }

        private void chkSta2_Click(object sender, EventArgs e)
        {
            chkSta1.CheckState = CheckState.Unchecked;
            chkSta2.CheckState = CheckState.Checked;
            chkSta3.CheckState = CheckState.Unchecked;
            chkSta4.CheckState = CheckState.Unchecked;
            chkSta5.CheckState = CheckState.Unchecked;
            chkStaAll.CheckState = CheckState.Unchecked;
            first_run = true;
            chkByMonth.CheckState = CheckState.Checked;
            ChkByYear.CheckState = CheckState.Unchecked;

        }

        private void chkSta3_Click(object sender, EventArgs e)
        {
            chkSta1.CheckState = CheckState.Unchecked;
            chkSta2.CheckState = CheckState.Unchecked;
            chkSta3.CheckState = CheckState.Checked;
            chkSta4.CheckState = CheckState.Unchecked;
            chkSta5.CheckState = CheckState.Unchecked;
            chkStaAll.CheckState = CheckState.Unchecked;
            first_run = true;
            chkByMonth.CheckState = CheckState.Checked;
            ChkByYear.CheckState = CheckState.Unchecked;
        }

        private void chkSta4_Click(object sender, EventArgs e)
        {
            chkSta1.CheckState = CheckState.Unchecked;
            chkSta2.CheckState = CheckState.Unchecked;
            chkSta3.CheckState = CheckState.Unchecked;
            chkSta4.CheckState = CheckState.Checked;
            chkSta5.CheckState = CheckState.Unchecked;
            chkStaAll.CheckState = CheckState.Unchecked;
            first_run = true;
            chkByMonth.CheckState = CheckState.Checked;
            ChkByYear.CheckState = CheckState.Unchecked;
        }

        private void chkSta5_Click(object sender, EventArgs e)
        {
            chkSta1.CheckState = CheckState.Unchecked;
            chkSta2.CheckState = CheckState.Unchecked;
            chkSta3.CheckState = CheckState.Unchecked;
            chkSta4.CheckState = CheckState.Unchecked;
            chkSta5.CheckState = CheckState.Checked;
            chkStaAll.CheckState = CheckState.Unchecked;
            first_run = true;
            chkByMonth.CheckState = CheckState.Checked;
            ChkByYear.CheckState = CheckState.Unchecked;
        }

        private void chkStaAll_Click(object sender, EventArgs e)
        {
            chkSta1.CheckState = CheckState.Unchecked;
            chkSta2.CheckState = CheckState.Unchecked;
            chkSta3.CheckState = CheckState.Unchecked;
            chkSta4.CheckState = CheckState.Unchecked;
            chkSta5.CheckState = CheckState.Unchecked;
            chkStaAll.CheckState = CheckState.Checked;
            first_run = true;
            chkByMonth.CheckState = CheckState.Checked;
            ChkByYear.CheckState = CheckState.Unchecked;
        }

        private void chkByDay_Click(object sender, EventArgs e)
        {
            chkByMonth.CheckState = CheckState.Unchecked;
            ChkByYear.CheckState = CheckState.Unchecked;
        }

        private void chkByMonth_Click(object sender, EventArgs e)
        {

            chkByMonth.CheckState = CheckState.Checked;
            ChkByYear.CheckState = CheckState.Unchecked;
        }

        private void chkByDay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkByYear_MouseClick(object sender, MouseEventArgs e)
        {

            chkByMonth.CheckState = CheckState.Unchecked;
            ChkByYear.CheckState = CheckState.Checked;
        }
    }
}
