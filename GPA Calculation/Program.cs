string studentName = "Nazish naheed";
string course1Name = "English";
string course2Name = "Algebra";
string course3Name = "Biology";
string course4Name = "Computer Science I";
string course5Name = "Psychology";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

double totalCredits = calculateCredits();
double gpa = Math.Round(totalCredits / creditSum(), 2);

// print lines
Console.WriteLine("Student: " + studentName + "\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t4\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t3\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t3\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t3\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t4\t\t{course5Credit}\n");
Console.Write($"Final GPA:\t{gpa}");

// returns all courses credits sum
int creditSum()
{
    return course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
}

// calculate credit against the grade
double calculateCredits()
{
    double creditsGrades = 0;
    for (int course = 1; course < 6; course++)
    {
        switch (course)
        {
            case 1: creditsGrades += course1Credit * 4; break;
            case 2: creditsGrades += course2Credit * 3; break;
            case 3: creditsGrades += course3Credit * 3; break;
            case 4: creditsGrades += course4Credit * 3; break;
            case 5: creditsGrades += course5Credit * 4; break;
            default: break;
        }
    }

    return creditsGrades;
}