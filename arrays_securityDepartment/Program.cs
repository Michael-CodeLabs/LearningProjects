string[] fraudulentOrderIDs = new string[8];

fraudulentOrderIDs[0] = "B123";
fraudulentOrderIDs[1] = "C234";
fraudulentOrderIDs[2] = "A345";
fraudulentOrderIDs[3] = "C15";
fraudulentOrderIDs[4] = "B177";
fraudulentOrderIDs[5] = "G3003";
fraudulentOrderIDs[6] = "C235";
fraudulentOrderIDs[7] = "B175";

foreach (string i in fraudulentOrderIDs)
if (i.StartsWith("B"))
{
    Console.WriteLine(i);
}