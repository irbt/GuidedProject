using System;

Console.Clear();

// initialize variables - graded assignments 
int currentAssignments = 5;
string[] studentNames = new string[] { "sophia", "andrew", "emma", "logan" };
int[] studentScores = new int[10];


int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 86, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

// En-tête
Console.WriteLine("Student\t\tGrade\n");
// calculer les sommes
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "logan")
    {
        studentScores = loganScores;
    }

    int studentSum = 0;
    decimal studentScore = 0;

    foreach (int score in studentScores)
    {
        studentSum += score;
    }

    studentScore = (decimal)studentSum / currentAssignments;

    Console.WriteLine($"{currentStudent}:\t\t{studentScore}\t?");

}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
