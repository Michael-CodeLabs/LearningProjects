int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string currentStudent in studentNames)
{
    int[] studentScores;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else
        continue;

    int sumExamScores = 0;
    int sumExtraCredit = 0;
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
            sumExamScores += score;
        else
            sumExtraCredit += score;
    }

    decimal averageExamScore = (decimal)sumExamScores / examAssignments;
    decimal finalNumericScore = (sumExamScores + (0.1m * sumExtraCredit)) / examAssignments;
    decimal extraCreditPoints = (0.1m * sumExtraCredit) / examAssignments;

    string letterGrade;

    if (finalNumericScore >= 97)
        letterGrade = "A+";
    else if (finalNumericScore >= 93)
        letterGrade = "A";
    else if (finalNumericScore >= 90)
        letterGrade = "A-";
    else if (finalNumericScore >= 87)
        letterGrade = "B+";
    else if (finalNumericScore >= 83)
        letterGrade = "B";
    else if (finalNumericScore >= 80)
        letterGrade = "B-";
    else if (finalNumericScore >= 77)
        letterGrade = "C+";
    else if (finalNumericScore >= 73)
        letterGrade = "C";
    else if (finalNumericScore >= 70)
        letterGrade = "C-";
    else if (finalNumericScore >= 67)
        letterGrade = "D+";
    else if (finalNumericScore >= 63)
        letterGrade = "D";
    else if (finalNumericScore >= 60)
        letterGrade = "D-";
    else
        letterGrade = "F";

    // Output the result in the required format
    Console.WriteLine($"{currentStudent}\t\t{averageExamScore:F1}\t\t{finalNumericScore:F2}\t{letterGrade}\t{sumExtraCredit} ({extraCreditPoints:F2} pts)");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
