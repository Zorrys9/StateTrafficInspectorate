using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Logic.LogicsModel;
using Microsoft.Win32;

namespace StateTrafficInspectorate
{
    /// <summary>
    /// Логика взаимодействия для ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
        }
        private DataTable dtReport = DriverLogic.GetReportList();
        private static char separator = ';';
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {

                ReportList.ItemsSource = dtReport.DefaultView;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "CSV формат|* .csv";
                save.Title = "Сохранение файла";
                save.ShowDialog();

                if (dtReport != null)
                {
                    FileStream fs = null;
                    fs = File.OpenWrite(save.FileName);
                    using (TextWriter tw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                    {
                        String line = "";
                        //Выводим имя таблицы
                        if (!String.IsNullOrEmpty(dtReport.TableName))
                            tw.WriteLine(dtReport.TableName);
                        //Вывод названий столбцов
                        foreach (DataColumn colName in dtReport.Columns)
                        {
                            line += String.Format("\"{0}\"{1}", colName.ColumnName, separator);
                        }
                        tw.WriteLine(line.TrimEnd(separator));
                        //Вывод данных
                        foreach (DataRow dr in dtReport.Rows)
                        {
                            line = "";
                            Array.ForEach(dr.ItemArray, obj => line += String.Format("\"{0}\"{1}", obj, separator));
                            tw.WriteLine(line.TrimEnd(separator));
                        }
                    }
                    fs.Close();
                    fs.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Inspector.InspectorMainWindow inspectorMain = new Inspector.InspectorMainWindow();
            inspectorMain.Show();
            this.Close();
        }
    }
}
