using System;

Console.Clear();

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// En-tête
Console.WriteLine("Student\t\tGrade\n");
// calculer les sommes
foreach (string name in studentNames)
{
	string currentStudent = name;

	if (currentStudent == "Sophia")
	{
		studentScores = sophiaScores;
	}
	else if (currentStudent == "Andrew")
	{
		studentScores = andrewScores;
	}
	else if (currentStudent == "Emma")
	{
		studentScores = emmaScores;
	}
	else if (currentStudent == "Logan")
	{
		studentScores = loganScores;
	}
	else if (currentStudent == "Becky")
	{
		studentScores = beckyScores;
	}
	else if (currentStudent == "Chris")
	{
		studentScores = chrisScores;
	}
	else if (currentStudent == "Eric")
	{
		studentScores = ericScores;
	}
	else if (currentStudent == "Gregor")
	{
		studentScores = gregorScores;
	}

	int studentSum = 0;
	decimal studentScore = 0;

	// si nombre de notes > 5 boucler sur elements du tableau à partir de l'index 5 jusque "longueur tableau -1"

	int gradedAssignments = 0;
	foreach (int score in studentScores)
	{
		gradedAssignments +=1;
        if (gradedAssignments <= currentAssignments)
        {
        studentSum += score;

        }else
        {
        studentSum += score / 10;
        }
	}

	studentScore = (decimal)studentSum / currentAssignments;

	// Détermination de la note sous forme de lettre
    if (studentScore >= 97)
	{
		currentStudentLetterGrade = "A+";
	}
	else if (studentScore >= 93)
	{
		currentStudentLetterGrade = "A";
	}
	else if (studentScore >= 90)
	{
		currentStudentLetterGrade = "A-";
	}
	else if (studentScore >= 87)
	{
		currentStudentLetterGrade = "B+";
	}
	else if (studentScore >= 83)
	{
		currentStudentLetterGrade = "B";
	}
	else if (studentScore >= 80)
	{
		currentStudentLetterGrade = "B-";
	}
	else if (studentScore >= 77)
	{
		currentStudentLetterGrade = "C+";
	}
	else if (studentScore >= 73)
	{
		currentStudentLetterGrade = "C";
	}
	else if (studentScore >= 70)
	{
		currentStudentLetterGrade = "C-";
	}
	else if (studentScore >= 67)
	{
		currentStudentLetterGrade = "D-";
	}
	else if (studentScore >= 63)
	{
		currentStudentLetterGrade = "D";
	}
	else if (studentScore >= 60)
	{
		currentStudentLetterGrade = "D-";
	}
	else 
	{
		currentStudentLetterGrade = "F";
	}

	Console.WriteLine($"{currentStudent}:\t\t{studentScore}\t{currentStudentLetterGrade}");

}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
