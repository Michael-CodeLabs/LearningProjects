//string[] fradulentOrderIDs = new string[3];

/*fradulentOrderIDs[0] = "A123";
fradulentOrderIDs[1] = "B456";
fradulentOrderIDs[2] = "C789";
//fradulentOrderIDs[3] = "D000";
*/


string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
