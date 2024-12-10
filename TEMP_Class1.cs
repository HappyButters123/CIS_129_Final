using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using OxyPlot.Axes;
using System.Threading;
using System.Reflection;
using System.Windows.Documents;
using System.Windows.Input;
using System.Data.Common;

namespace CIS_129_Final
{
    public class TEMP_AppartmentsPowerConsumption
    {
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //This is a data class that is made by dex, it should be temporary.
        //if this is still here then the ones resoponsable for these functions didnt do them
        //the temporary ones (this) are used to not crash the program untill the full ones are done
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        //~~~~~~~~~~~~~~~~~~~~~~~~~Directory~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_FileDirectory = "ProgramPowerData\\APT";

        //~~~~~~~~~~~~~~~~~~~~~~DataFile For Power~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_PowerDataFile = "ProgramPowerData\\APT\\AptPowerData.txt";

        //~~~~~~~~~~~~~~~~~~~~~~DataFile For Size~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_SizeDataFile = "ProgramPowerData\\APT\\AptSquairFoodData.txt";

        //~~~~~~~~~~~~~~~~~~~~~~Storing Written bool for Power File~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_PowerDataFileWrittenConformation = "ProgramPowerData\\APT\\HasWrittenPowerData.txt";

        //~~~~~~~~~~~~~~~~~~~~~~Storing Written bool for Size File~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_SizeDataFileWrittenConformation = "ProgramPowerData\\APT\\HasWrittenSizeData.txt";

        //~~~~~~~~~~~~~~Total Number Of Data Points~~~~~~~~~~
        private readonly static int TotalDataColector = 1000;

        private readonly static int SizeLowerBound = 500;
        private readonly static int SizeUpperBound = 1200;

        private readonly static int PowerInKilowattHoursMonth_LowBound = 500_000;
        private readonly static int PowerInKilowattHoursMonth_TopBound = 875_000;

        private readonly static double PowerInKilowattHoursDay_LowBound = ((double)PowerInKilowattHoursMonth_LowBound) / 30;
        private readonly static double PowerInKilowattHoursDay_TopBound = ((double)PowerInKilowattHoursMonth_TopBound) / 30;

        public TEMP_AppartmentsPowerConsumption()
        {
            TEMP_AppartmentsPowerConsumptionDataMaker();
            TEMP_AppartmentsSquairFootDataMaker();
        }

        public bool ParseBool(string input)
        {
            if (input == null)
                throw new ArgumentNullException("input");

            switch (input.ToLower())
            {
                case "y":
                case "yes":
                case "true":
                    return true;

                case "n":
                case "no":
                case "false":
                    return false;

                // If the Text file is wrong (i.e. it contains "bad" data)
                default:
                    throw new ArgumentException("bad data - not a bool");
            }
        }

        public void TEMP_AppartmentsSquairFootDataMaker()
        {
            bool IsWriten;

            if (!File.Exists(APT_SizeDataFileWrittenConformation))
            {
                File.Create(APT_SizeDataFileWrittenConformation);
                IsWriten = false;
            }
            else
            {
                Console.WriteLine($"File.ReadAllText(APT_SizeDataFileWrittenConformation).Skip(0).ToString() {File.ReadAllText(APT_SizeDataFileWrittenConformation)}");
                IsWriten = ParseBool(File.ReadAllText(APT_SizeDataFileWrittenConformation));
                Console.WriteLine($"IsWriten {IsWriten}");
            }

            if (!IsWriten) {

                using (StreamWriter writer = new StreamWriter(APT_SizeDataFileWrittenConformation, false))
                {
                    Console.WriteLine("No need to continue The next time this is called");
                    writer.Write("y");
                }

                Random random = new Random();

                if (!Directory.Exists(APT_FileDirectory))
                {
                    Directory.CreateDirectory(APT_FileDirectory);
                }

                if (!File.Exists(APT_SizeDataFile))
                {
                    File.Create(APT_SizeDataFile);
                }

                File.WriteAllText(APT_SizeDataFile, string.Empty);

                using (StreamWriter writer = new StreamWriter(APT_SizeDataFile, true))
                {

                    for (int i = 0; i < TotalDataColector; i++)
                    {
                        writer.Write(random.Next(SizeLowerBound, SizeUpperBound) + "\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No need to continue");
            }
        }

        public List<double> TEMP_AppartmentsSquairFootData()
        {
            List<double> Out = new List<double>();

            for (int i = 0; i < TotalDataColector; i++)
            {
                Console.WriteLine(File.ReadLines(APT_SizeDataFile).Skip(i).First());

                var str = File.ReadLines(APT_SizeDataFile).Skip(i).First();
                var charsToRemove = new string[] { "\n" };
                foreach (var c in charsToRemove)
                {
                    str = str.Replace(c, string.Empty);
                }

                Out.Add(Convert.ToDouble(str));
            }

            return Out;
        }
       
        public void TEMP_AppartmentsPowerConsumptionDataMaker()
        {
            bool IsWriten;

            if (!File.Exists(APT_PowerDataFileWrittenConformation)) {
                File.Create(APT_PowerDataFileWrittenConformation);
                IsWriten = false;
            } else {
                IsWriten = ParseBool(File.ReadAllText(APT_PowerDataFileWrittenConformation));
            }

            if (!IsWriten)
            {
                using (StreamWriter writer = new StreamWriter(APT_PowerDataFileWrittenConformation, false))
                {
                    writer.Write("true");
                }
            }

            Random random = new Random();

            if (!Directory.Exists(APT_FileDirectory))
            {
                Directory.CreateDirectory(APT_FileDirectory);
            }

            if (!File.Exists(APT_PowerDataFile))
            {
                File.Create(APT_PowerDataFile);
            }

            File.WriteAllText(APT_PowerDataFile, string.Empty);
            
            using (StreamWriter writer = new StreamWriter(APT_PowerDataFile, true))
            {
                for (int i = 0; i < TotalDataColector; i++)
                {
                    string PowerInKilowattHoursFileLine =
                        // kWh Per Month
                        random.Next(PowerInKilowattHoursMonth_LowBound, PowerInKilowattHoursMonth_TopBound) + " | " +
                        // kWh Per Day
                        random.Next(((int)PowerInKilowattHoursDay_LowBound), ((int)PowerInKilowattHoursDay_TopBound)) + "\n";

                    // Write Both In One Line kWh
                    writer.Write(PowerInKilowattHoursFileLine);
                }
            }
        }
        
        public List<double> TEMP_AppartmentsMonthPowerConsumptionData()
        {
            List<double> Out = new List<double>();

            for (int i = 0; i < TotalDataColector; i++)
            {
                //Console.WriteLine($"Power Month Loop {i}");

                var str = File.ReadLines(APT_PowerDataFile).Skip(i).First();
                var charsToRemove = new string[] { "\n" };
                foreach (var c in charsToRemove)
                {
                    str = str.Replace(c, string.Empty);
                }

                var Half = str.Substring(0, str.IndexOf("|"));

                Out.Add(Convert.ToDouble(Half));
            }

            return Out;
        }
        
        public List<double> TEMP_AppartmentsDayPowerConsumptionData()
        {
            List<double> Out = new List<double>();

            for (int i = 0; i < TotalDataColector; i++)
            {
                //Console.WriteLine($"Power Day Loop {i}");

                var str = File.ReadLines(APT_PowerDataFile).Skip(i).First();
                var charsToRemove = new string[] { "\n" };
                foreach (var c in charsToRemove)
                {
                    str = str.Replace(c, string.Empty);
                }

                var Half = str.Substring((str.IndexOf("| ") + 1), (str.Length - (str.IndexOf("| ") + 1)));

                Out.Add(Convert.ToDouble(Half));
            }

            return Out;
        }

        public DataSet1 TEMP_AppartmentsPowerConsumptionDataToDataSet(DataSet1 dataSet)
        {
            dataSet.Table1.Clear();

            List<double> TEMP_AppartmentsMonthPowerConsumptionDataList = TEMP_AppartmentsMonthPowerConsumptionData();
            List<double> TEMP_AppartmentsDayPowerConsumptionDataList = TEMP_AppartmentsDayPowerConsumptionData();
            List<double> TEMP_AppartmentsSquairFootDataList = TEMP_AppartmentsSquairFootData();

            for (int X = 0; X < TotalDataColector; X++)
            {
                Console.WriteLine($"Dataset Load Loop {X}");
                dataSet.Table1.Rows.Add(X, ((int)TEMP_AppartmentsMonthPowerConsumptionDataList[X]), ((int)TEMP_AppartmentsDayPowerConsumptionDataList[X]), TEMP_AppartmentsSquairFootDataList[X]);
            }

            return dataSet;
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //This is a data class that is made by dex, it should be temporary.
        //if this is still here then the ones resoponsable for these functions didnt do them
        //the temporary ones (this) are used to not crash the program untill the full ones are done
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public PlotModel AppartmentsPowerConsumptionLineGraph(DataSet1 dataSet)
        {
            PlotModel AppartmentsPowerConsumptionModle = new PlotModel { Title = "Power Consumption" };

            LineSeries MonthData = new LineSeries()
            {
                Title = $"Appartments Power Consumption In Wats Per Month",
                Color = OxyPlot.OxyColors.Red,
                StrokeThickness = 2,
                MarkerSize = 4,
                MarkerType = OxyPlot.MarkerType.Square,
                TextColor = OxyPlot.OxyColors.Red,
            };

            for (int x = 0; x < TotalDataColector; x++)
            {
                Console.WriteLine("Month: " + x);
                MonthData.Points.Add(new DataPoint(x, dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerMonth));
            }

            LineSeries DayData = new LineSeries()
            {
                Title = $"Appartments Power Consumption In Wats Per Day",
                Color = OxyPlot.OxyColors.Blue,
                StrokeThickness = 2,
                MarkerSize = 4,
                MarkerType = OxyPlot.MarkerType.Square,
                TextColor = OxyPlot.OxyColors.Blue,
            };

            for (int x = 0; x < TotalDataColector; x++)
            {
                Console.WriteLine("Day: " + x);
                MonthData.Points.Add(new DataPoint(x, dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerDay));
            }

            var YAxes = new LinearAxis { Position = AxisPosition.Left, MinimumPadding = -0.5, MaximumPadding = 1, AbsoluteMinimum = -0.5 };

            var XAxes = new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = -0.5, MaximumPadding = 1, AbsoluteMinimum = -0.5 };

            AppartmentsPowerConsumptionModle.Series.Add(MonthData);
            AppartmentsPowerConsumptionModle.Series.Add(DayData);

            AppartmentsPowerConsumptionModle.Axes.Add(YAxes);
            AppartmentsPowerConsumptionModle.Axes.Add(XAxes);

            Console.WriteLine("Done");
            return AppartmentsPowerConsumptionModle;
        }

        public PlotModel AppartmentsPowerConsumptionBarGraph(DataSet1 dataSet)
        {
            PlotModel AppartmentsPowerConsumptionModle = new PlotModel { Title = "Power Consumption" };

            BarSeries BarMonthData = new BarSeries
            {
                Title = $"Appartments Power Consumption In Wats Per Month",
                BarWidth = 4,
                FillColor = OxyPlot.OxyColors.Red,
                StrokeThickness = 2,
                TextColor = OxyPlot.OxyColors.Blue,

            };

            for (int x = 0; x < TotalDataColector; x++)
            {
                BarMonthData.Items.Add(new BarItem(dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerMonth, x));
            }

            BarSeries BarDayData = new BarSeries
            {
                Title = $"Appartments Power Consumption In Wats Per Day",
                BarWidth = 4,
                FillColor = OxyPlot.OxyColors.Red,
                StrokeThickness = 2,
                TextColor = OxyPlot.OxyColors.Blue,

            };

            for (int x = 0; x < TotalDataColector; x++)
            {
                BarDayData.Items.Add(new BarItem(dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerDay, x));
            }

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left, MinimumPadding = -0.5, MaximumPadding = 0.06, AbsoluteMinimum = -0.5 };

            for (int i = 0; i < TotalDataColector; i++)
            {
                categoryAxis.Labels.Add($"Category {i}");
            }

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, MaximumPadding = 0.06, AbsoluteMinimum = 0 };

            AppartmentsPowerConsumptionModle.Series.Add(BarMonthData);
            AppartmentsPowerConsumptionModle.Series.Add(BarDayData);

            AppartmentsPowerConsumptionModle.Axes.Add(categoryAxis);
            AppartmentsPowerConsumptionModle.Axes.Add(valueAxis);

            return AppartmentsPowerConsumptionModle;
        }
        
        public PlotModel AppartmentsPowerConsumptionColumnGraph(DataSet1 dataSet)
        {
            PlotModel AppartmentsPowerConsumptionModle = new PlotModel { Title = "Power Consumption" };

            BarSeries BarMonthData = new BarSeries
            {
                Title = $"Appartments Power Consumption In Wats Per Month",
                BarWidth = 4,
                FillColor = OxyPlot.OxyColors.Red,
                StrokeThickness = 2,
                TextColor = OxyPlot.OxyColors.Green,
                XAxisKey = "x1",
                YAxisKey = "y1"
            };

            for (int x = 0; x < TotalDataColector; x++)
            {
                BarMonthData.Items.Add(new BarItem(dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerMonth, x));
            }

            BarSeries BarDayData = new BarSeries
            {
                Title = $"Appartments Power Consumption In Wats Per Day",
                BarWidth = 4,
                FillColor = OxyPlot.OxyColors.Blue,
                StrokeThickness = 2,
                TextColor = OxyPlot.OxyColors.Green,
                XAxisKey = "x1",
                YAxisKey = "y1"

            };

            for (int x = 0; x < TotalDataColector; x++)
            {
                BarDayData.Items.Add(new BarItem(dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerDay, x));
            }

            var categoryAxis = new CategoryAxis { AbsoluteMinimum = -1, Position = AxisPosition.Bottom, Key = "y1" };
            var valueAxis1 = new LinearAxis
            {
                Title = "Value Axis 1",
                Position = AxisPosition.Left,
                MinimumPadding = 0.06,
                MaximumPadding = 0.06,
                ExtraGridlines = new[] { 0d },
                Key = "x1",
                AbsoluteMinimum = -1
            };

            AppartmentsPowerConsumptionModle.Series.Add(BarMonthData);
            AppartmentsPowerConsumptionModle.Series.Add(BarDayData);

            AppartmentsPowerConsumptionModle.Axes.Add(categoryAxis);
            AppartmentsPowerConsumptionModle.Axes.Add(valueAxis1);

            return AppartmentsPowerConsumptionModle;
        }

        public PlotModel AppartmentsPowerConsumptionPieGraph(DataSet1 dataSet, int TypeOneTwoThree)
        {
            PlotModel AppartmentsSizeRatioModle = new PlotModel { Title = "Size" };

            //Averages~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            double SizeAverage = SizeLowerBound + (SizeUpperBound - SizeLowerBound) / 2;
            double DayAverage = PowerInKilowattHoursDay_LowBound + (PowerInKilowattHoursDay_TopBound - PowerInKilowattHoursDay_LowBound) / 2;
            double MonthAverage = PowerInKilowattHoursMonth_LowBound + (PowerInKilowattHoursMonth_TopBound - PowerInKilowattHoursMonth_LowBound) / 2;
            //Averages~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            PieSeries BlankPieDATA = new PieSeries();
            PieSeries SizePieDATA = new PieSeries();
            PieSeries DayPieDATA = new PieSeries();
            PieSeries MonthPieDATA = new PieSeries();

            int IsSmall = 0;
            int IsLarg = 0;

            int OverDayAverage = 0;
            int UnderDayAverage = 0;

            int OverMonthAverage = 0;
            int UnderMonthAverage = 0;

            //Size Loop
            for (int x = 0; x < TotalDataColector; x++)
            {
                if(dataSet.Table1.ElementAt(x).AreaInSquareFeet <= SizeAverage)
                {
                    IsSmall++;
                }
                else { IsLarg++; }
            }

            //Day Loop
            for (int x = 0; x < TotalDataColector; x++)
            {
                if(dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerDay <= DayAverage)
                {
                    UnderDayAverage++;
                }
                else { OverDayAverage++; }
            }

            //Month Loop
            for (int x = 0; x < TotalDataColector; x++)
            {
                if(dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerMonth <= MonthAverage)
                {
                    UnderMonthAverage++;
                }
                else { OverMonthAverage++; }
            }

            Console.WriteLine(
                 "Full Pie Data | " +
                 $"SizeAverage {SizeAverage}" + " | " +
                 $"DayAverage {DayAverage}" + " | " +
                 $"MonthAverage {MonthAverage}" + " | " +
                 $"IsSmall {IsSmall}" + " | " +
                 $"IsLarg {IsLarg}" + " | " +
                 $"OverDayAverage {OverDayAverage}" + " | " +
                 $"UnderDayAverage {UnderDayAverage}" + " | " +
                 $"OverMonthAverage {OverMonthAverage}" + " | " +
                 $"UnderMonthAverage {UnderMonthAverage}"
            );

            SizePieDATA.Slices.Add(new PieSlice("Is Small", IsSmall) { IsExploded = true });
            SizePieDATA.Slices.Add(new PieSlice("Is Larg", IsLarg) { IsExploded = true });

            DayPieDATA.Slices.Add(new PieSlice("Less Than Average", UnderDayAverage) { IsExploded = true });
            DayPieDATA.Slices.Add(new PieSlice("More Than Average", OverDayAverage) { IsExploded = true });

            MonthPieDATA.Slices.Add(new PieSlice("Less Than Average", UnderMonthAverage) { IsExploded = true });
            MonthPieDATA.Slices.Add(new PieSlice("More Than Average", OverMonthAverage) { IsExploded = true });

            if(TypeOneTwoThree < 1 || TypeOneTwoThree > 3)
            {
                AppartmentsSizeRatioModle.Series.Add(BlankPieDATA);
                AppartmentsSizeRatioModle.Title = "Blank";
            }
            else
            {
                switch (TypeOneTwoThree)
                {
                    case 1:
                        AppartmentsSizeRatioModle.Series.Add(SizePieDATA);
                        AppartmentsSizeRatioModle.Title = $"Size {SizeAverage}";
                        break;
                    case 2:
                        AppartmentsSizeRatioModle.Series.Add(DayPieDATA);
                        AppartmentsSizeRatioModle.Title = $"Day {DayAverage}";
                        break;
                    case 3:
                        AppartmentsSizeRatioModle.Series.Add(MonthPieDATA);
                        AppartmentsSizeRatioModle.Title = $"Month {DayAverage}";
                        break;
                }
            }
            
            return AppartmentsSizeRatioModle;
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        internal class TEMP_Class1
        {
        }
    }
}
