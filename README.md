# Quantower-Gann-Lines-So9
An indicator built for Quantower that will simply take the current price and plot the Gann Square of 9 lines from the nearest whole number to the next whole number.

This is a very basic interpretation and use of Square of 9 first introduced by W.D. Gann. The idea is that price can be squared by both numeric and time values. Doing so will allow you to codify the markets. In this we will first square the current price and then round to the nearest whole number. You will then increment up and down from that price by .125 and re-square the prices then plot them.

//Current Price
double priceline = Close();
double degree = .125;

//Square root it
double sqrtPrice = Math.Sqrt(priceline);

//Round it
double roundPrice = Math.Round(sqrtPrice, 0);

//Start at mid and increment up and down by the degree (45 degree rotation)
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


