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
        private readonly static string APT_FileDirectory = "C:\\Users\\dexma\\source\\repos\\CIS_129_Final\\ProgramPowerData\\APT";

        //~~~~~~~~~~~~~~~~~~~~~~DataFile For Power~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_PowerDataFile = "C:\\Users\\dexma\\source\\repos\\CIS_129_Final\\ProgramPowerData\\APT\\AptPowerData.txt";

        //~~~~~~~~~~~~~~~~~~~~~~DataFile For Size~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_SizeDataFile = "C:\\Users\\dexma\\source\\repos\\CIS_129_Final\\ProgramPowerData\\APT\\AptSquairFoodData.txt";

        //~~~~~~~~~~~~~~~~~~~~~~Storing Written bool for Power File~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_PowerDataFileWrittenConformation = "C:\\Users\\dexma\\source\\repos\\CIS_129_Final\\ProgramPowerData\\APT\\HasWrittenPowerData.txt";

        //~~~~~~~~~~~~~~~~~~~~~~Storing Written bool for Size File~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private readonly static string APT_SizeDataFileWrittenConformation = "C:\\Users\\dexma\\source\\repos\\CIS_129_Final\\ProgramPowerData\\APT\\HasWrittenSizeData.txt";

        //~~~~~~~~~~~~~~Total Number Of Data Points~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
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
       
        public void TEMP_AppartmentsSquairFootDataMaker()
        {
            if (!File.Exists(APT_SizeDataFileWrittenConformation))
            {
                File.Create(APT_SizeDataFileWrittenConformation);
            }

            bool IsWriten = Convert.ToBoolean(File.ReadAllText(APT_SizeDataFileWrittenConformation));

            if (!IsWriten)
            {
                using (StreamWriter writer = new StreamWriter(APT_SizeDataFileWrittenConformation, false))
                {
                    writer.Write("true");
                }
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

        public List<double> TEMP_AppartmentsSquairFootData()
        {
            List<double> Out = new List<double>();

            for (int i = 0; i < TotalDataColector; i++)
            {
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
                IsWriten = Convert.ToBoolean(File.ReadAllText(APT_PowerDataFileWrittenConformation));
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

        public PlotModel AppartmentsPowerConsumptionBarGraph()
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

            for (int x = 0; x < TEMP_AppartmentsMonthPowerConsumptionData().Count; x++)
            {
                BarMonthData.Items.Add(new BarItem(TEMP_AppartmentsMonthPowerConsumptionData()[x], x));
            }

            BarSeries BarDayData = new BarSeries
            {
                Title = $"Appartments Power Consumption In Wats Per Day",
                BarWidth = 4,
                FillColor = OxyPlot.OxyColors.Red,
                StrokeThickness = 2,
                TextColor = OxyPlot.OxyColors.Blue,

            };

            for (int x = 0; x < TEMP_AppartmentsDayPowerConsumptionData().Count; x++)
            {
                BarDayData.Items.Add(new BarItem(TEMP_AppartmentsDayPowerConsumptionData()[x], x));
            }

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left, MinimumPadding = -0.5, MaximumPadding = 0.06, AbsoluteMinimum = -0.5 };

            for (int i = 0; i < 4; i++)
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

        public PlotModel AppartmentsPowerConsumptionPieGraph(DataSet1 dataSet, int TypeOneTwoThree)
        {
            PlotModel AppartmentsSizeRatioModle = new PlotModel { Title = "Size" };
            PlotModel AppartmentsDayPowerRatioModle = new PlotModel { Title = "Size" };
            PlotModel AppartmentsMonthPowerRatioModle = new PlotModel { Title = "Size" };

            //Averages~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            double SizeAverage = 0;
            double DayAverage = 0;
            double MonthAverage = 0;
            //Averages~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            for (int x = 0; x < TotalDataColector; x++)
            {
                SizeAverage += dataSet.Table1.ElementAt(x).AreaInSquareFeet;
                DayAverage += dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerDay;
                MonthAverage += dataSet.Table1.ElementAt(x).PowerInKilowattHoursPerMonth;
            }

            SizeAverage = SizeAverage / (double)TotalDataColector;
            DayAverage = DayAverage / (double)TotalDataColector;
            MonthAverage = MonthAverage / (double)TotalDataColector;

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
            }
            else
            {
                switch (TypeOneTwoThree)
                {
                    case 1:
                        AppartmentsSizeRatioModle.Series.Add(SizePieDATA);
                        break;
                    case 2:
                        AppartmentsSizeRatioModle.Series.Add(DayPieDATA);
                        break;
                    case 3:
                        AppartmentsSizeRatioModle.Series.Add(MonthPieDATA);
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
