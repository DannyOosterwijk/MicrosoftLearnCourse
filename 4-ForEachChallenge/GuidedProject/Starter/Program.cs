using System;
using System.Linq.Expressions;

// initialize variables - graded assignments 
int currentAssignments = 5;

//student scores
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

Console.WriteLine("Student\t\tGrade\n");

//loop through all students
foreach (string name in studentNames)
{
    int[] studentScores = new int[10];

    //get student scores based on name
    if (name == "Sophia")
        studentScores = sophiaScores;

    else if (name == "Andrew")
        studentScores = andrewScores;

    else if (name == "Emma")
        studentScores = emmaScores;

    else if (name == "Logan")
        studentScores = loganScores;
        
    else if (name == "Becky")
        studentScores = beckyScores;

    else if (name == "Chris")
        studentScores = chrisScores;

    else if (name == "Eric")
        studentScores = ericScores;

    else if (name == "Gregor")
        studentScores = gregorScores;
        
    else
        continue;


    //calculate exam score by adding up all exams
    int studentSum = 0;
    decimal studentScore;

    int index = 0;
    foreach (int score in studentScores)
    {
        index++;
        //check if score is extra credit
        if (index > currentAssignments)
            studentSum += score / 10;
        else
            studentSum += score;
    }
    studentScore = (decimal)studentSum / currentAssignments;

    //assign the student a grade
    string studentGrade = "";

    if (studentScore >= 97)
        studentGrade = "A+";

    else if (studentScore >= 93)
        studentGrade = "A";

    else if (studentScore >= 90)
        studentGrade = "A-";

    else if (studentScore >= 87)
        studentGrade = "B+";

    else if (studentScore >= 83)
        studentGrade = "B";

    else if (studentScore >= 80)
        studentGrade = "B-";

    else if (studentScore >= 77)
        studentGrade = "C+";

    else if (studentScore >= 73)
        studentGrade = "C";

    else if (studentScore >= 70)
        studentGrade = "C-";

    else if (studentScore >= 67)
        studentGrade = "D+";

    else if (studentScore >= 63)
        studentGrade = "D";

    else if (studentScore >= 60)
        studentGrade = "D-";

    else
        studentGrade = "F";

    //write the finished result
    Console.WriteLine(name + ":\t\t" + studentScore + "\t" + studentGrade);
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
