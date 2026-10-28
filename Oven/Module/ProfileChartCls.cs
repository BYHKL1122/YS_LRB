using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using Framework;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Legends;


namespace YS_6000.Module
{
    class ProfileChartCls
    {
        public PlotView chartView = new PlotView();
        public PlotModel chartModel = new PlotModel();
        public List<LineSeries> Lines = new List<LineSeries>();
        public DateTimeAxis xAxis = new DateTimeAxis();
        public LinearAxis yAxis = new LinearAxis();
        public static List<Color> colors = new List<Color>()
                    {Color.Red, Color.FromArgb(255, 0,192,0), Color.FromArgb(255, 0, 0 ,192), Color.FromArgb(255, 128, 64, 64) };

        public ProfileChartCls(String title, String ytitle)
        {
            chartModel.Title = title;
            chartView.Model = chartModel;
            chartView.Dock = System.Windows.Forms.DockStyle.Fill;
            chartModel.TitleFontSize = 9;

            Legend legend = new Legend();
            //legend.LegendTitle = "Legend";
            //legend.IsLegendVisible = true;
            legend.LegendPosition = LegendPosition.BottomRight;
            legend.GroupNameFontSize = 6;

            chartModel.Legends.Add(legend);

            xAxis.MajorGridlineStyle = LineStyle.Automatic;
            xAxis.MinorGridlineStyle = LineStyle.Automatic;
            xAxis.Position = AxisPosition.Bottom;
            xAxis.Title = ""; //"Time";
            xAxis.StringFormat = "HH:mm:ss";

            yAxis.MajorGridlineStyle = LineStyle.Automatic;
            yAxis.MinorGridlineStyle = LineStyle.Automatic;
            yAxis.Position = AxisPosition.Left;
            yAxis.Title = ytitle;
            yAxis.LabelFormatter = (double arg) =>
            {
                string result = String.Format("{0}", arg);
                return result;
            };
            yAxis.Minimum = 0;


            chartModel.Axes.Add(xAxis);
            chartModel.Axes.Add(yAxis);

            foreach (Channel ch in Channel.Channels)
            {
                if (ch.Function == "Profile")
                    addLine(ch.Name);
                //if (ch.Function != "Profile")
                //{
                //    Lines[Lines.Count - 1].IsVisible = false;
                //}
            }

        }

        public void addLine(String title)
        {

            LineSeries s;
            s = new LineSeries();
            Lines.Add(s);
            s.Title = title;
            s.TrackerFormatString = "{2:yyyy-MM-dd HH:mm:ss}" + Environment.NewLine + "{0}={Y:F1}";
            s.MarkerType = MarkerType.None;
            s.MarkerStroke = OxyColors.Automatic;
            s.LineStyle = LineStyle.Automatic;
            s.Color = OxyColors.Automatic;
            s.Points.Clear();

            chartModel.Series.Add(s);

        }

        public void AppendPoint(QueueNode mdata)
        {
            for (int ch = 0; ch < mdata.Temps.Length; ch++)
            {
                var dp = new DataPoint(DateTimeAxis.ToDouble(mdata.dTime), mdata.Temps[ch]);
                Lines[ch].Points.Add(dp);
            }

        }

        public void clearPoints()
        {
            for (int i = 0; i < chartModel.Series.Count; i++)
            {
                Lines[i].Points.Clear();
            }
        }
        public void setColor(int lineno, Color color)
        {
            if (Lines.Count > 0)
                Lines[lineno].Color = OxyColor.FromRgb(color.R, color.G, color.B);
        }
    }
}
