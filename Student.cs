using System;

public class Student
{
    public string StudentId { get; set; }
    public string FullName { get; set; }
    public string ClassName { get; set; }
    public void Display()
    {
        Console.WriteLine(StudentId + " - " + FullName + " - " + ClassName);
    }
}