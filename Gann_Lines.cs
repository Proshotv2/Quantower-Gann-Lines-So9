// Copyright QUANTOWER LLC. © 2017-2022. All rights reserved.

using System;
using System.Drawing;
using TradingPlatform.BusinessLayer;

namespace Gann_Lines
{
	public class Gann_Lines : Indicator
    {
        public Gann_Lines()
            : base()
        {
            // Defines indicator's name and description.
            Name = "Gann_Lines";
            Description = "My indicator's annotation";

            // Defines line on demand with particular parameters.
            AddLineSeries("Mid", Color.White, 1, LineStyle.Solid);
            AddLineSeries("Second", Color.Yellow, 1, LineStyle.Solid);
            AddLineSeries("Third", Color.Yellow, 1, LineStyle.Solid);
            AddLineSeries("Fourth", Color.Yellow, 1, LineStyle.Solid);
            AddLineSeries("Fifth", Color.Yellow, 1, LineStyle.Solid);
            AddLineSeries("SecondDown", Color.Yellow, 1, LineStyle.Solid);
            AddLineSeries("ThirdDown", Color.Yellow, 1, LineStyle.Solid);
            AddLineSeries("FourthDown", Color.Yellow, 1, LineStyle.Solid);
            AddLineSeries("FifthDown", Color.Yellow, 1, LineStyle.Solid);


            // By default indicator will be applied on main window of the chart
            // Never AutoScale
            SeparateWindow = false;
            UpdateType = IndicatorUpdateType.OnTick;
            AllowFitAuto = false;
        }

        protected override void OnInit()
        {
            // Add your initialization code here
        }

        protected override void OnUpdate(UpdateArgs args)
        {

            double priceline = Close();
            double degree = .125;
            double sqrtPrice = Math.Sqrt(priceline);
            double roundPrice = Math.Round(sqrtPrice, 0);

            double mid = roundPrice;
            double secondLine = mid + degree;
            double thirdLine = secondLine + degree;
            double fourthLine = thirdLine + degree;
            double fifthLine = fourthLine + degree;

            double secondLine2 = mid - degree;
            double thirdLine2 = secondLine2 - degree;
            double fourthLine2 = thirdLine2 - degree;
            double fifthLine2 = fourthLine2 - degree;

            //Re-Square the values
            mid = Math.Pow(mid, 2);
            secondLine = Math.Pow(secondLine, 2);
            thirdLine = Math.Pow(thirdLine, 2);
            fourthLine = Math.Pow(fourthLine, 2);
            fifthLine = Math.Pow(fifthLine, 2);

            secondLine2 = Math.Pow(secondLine2, 2);
            thirdLine2 = Math.Pow(thirdLine2, 2);
            fourthLine2 = Math.Pow(fourthLine2, 2);
            fifthLine2 = Math.Pow(fifthLine2, 2);


            SetValue(mid, 0);
            SetValue(secondLine, 1);
            SetValue(thirdLine, 2);
            SetValue(fourthLine, 3);
            SetValue(fifthLine, 4);
            SetValue(secondLine2, 5);
            SetValue(thirdLine2, 6);
            SetValue(fourthLine2, 7);
            SetValue(fifthLine2, 8);

        }
    }
}
