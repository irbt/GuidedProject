using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
string[] studentNames = new string [] {"sophia", "andrew", "emma", "logan"};
int[] studentScores = new int[10];


int[] sophiaScores = new int[]{90, 86, 87, 98, 100};
int[] andrewScores = new int[]{92, 89, 81, 86, 90};
int[] emmaScores =   new int[]{90, 85, 87, 98, 68};
int[] loganScores =  new int[]{90, 95, 87, 88, 96};


// calculer les sommes
foreach (string name in studentNames)
{
    int sophiaSum = 0;
    decimal sophiaScore = 0;

    if (name == "sophia")
    {
        foreach (int score in sophiaScores)
        {
            sophiaSum = score;
        }
    }

    
        sophiaScore = (decimal)sophiaSum / currentAssignments;


        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

    }
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
