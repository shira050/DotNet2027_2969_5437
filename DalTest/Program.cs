using System;
using DalApi;
using DO;

namespace DalTest;

internal class Program
{



    private static readonly IDal s_dal = new Dal.DalList();

    static void Main(string[] args)
    {
        try
        {
            Initialization.Initialize(s_dal);

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Test Entity (מבחנים)");
                Console.WriteLine("2. Student Entity (סטודנטים)");
                Console.WriteLine("3. Question Entity (שאלות)");
                Console.WriteLine("4. Answer Entity (תשובות)");
                Console.WriteLine("5. QuestionInTest Entity (שאלות במבחן)");
                Console.WriteLine("6. Initialize Data (אתחול נתונים)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            TestMenu();
                            break;
                        case 2:
                            StudentMenu();
                            break;
                        case 3:
                            QuestionMenu();
                            break;
                        case 4:
                            AnswerMenu();
                            break;
                        case 5:
                            QuestionInTestMenu();
                            break;
                        case 6:
                            Initialization.Initialize(s_dal);
                            Console.WriteLine("Data initialized successfully.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private static void TestMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Test CRUD Menu ---");
            Console.WriteLine("1. Create (הוספה)");
            Console.WriteLine("2. Read (קריאה לפי ת.ז)");
            Console.WriteLine("3. ReadAll (קריאת כל המבחנים)");
            Console.WriteLine("4. Update (עדכון)");
            Console.WriteLine("5. Delete (מחיקה)");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                try
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            AddTest();
                            break;
                        case 2:
                            ReadTest();
                            break;
                        case 3:
                            ReadAllTests();
                            break;
                        case 4:
                            UpdateTest();
                            break;
                        case 5:
                            DeleteTest();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
    private static void AnswerMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Answer CRUD Menu ---");
            Console.WriteLine("1. Create (הוספה)");
            Console.WriteLine("2. Read (קריאה לפי מזהה)");
            Console.WriteLine("3. ReadAll (קריאת כל התשובות)");
            Console.WriteLine("4. Update (עדכון)");
            Console.WriteLine("5. Delete (מחיקה)");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                try
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            AddAnswer();
                            break;
                        case 2:
                            ReadAnswer();
                            break;
                        case 3:
                            ReadAllAnswers();
                            break;
                        case 4:
                            UpdateAnswer();
                            break;
                        case 5:
                            DeleteAnswer();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
    private static void QuestionMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Question CRUD Menu ---");
            Console.WriteLine("1. Create (הוספה)");
            Console.WriteLine("2. Read (קריאה לפי מזהה)");
            Console.WriteLine("3. ReadAll (קריאת כל השאלות)");
            Console.WriteLine("4. Update (עדכון)");
            Console.WriteLine("5. Delete (מחיקה)");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                try
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            AddQuestion();
                            break;
                        case 2:
                            ReadQuestion();
                            break;
                        case 3:
                            ReadAllQuestions();
                            break;
                        case 4:
                            UpdateQuestion();
                            break;
                        case 5:
                            DeleteQuestion();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
    private static void QuestionInTestMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- QuestionInTest CRUD Menu ---");
            Console.WriteLine("1. Create (הוספה)");
            Console.WriteLine("2. Read (קריאה לפי מזהה)");
            Console.WriteLine("3. ReadAll (קריאת כל השאלות במבחנים)");
            Console.WriteLine("4. Update (עדכון)");
            Console.WriteLine("5. Delete (מחיקה)");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                try
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            AddQuestionInTest();
                            break;
                        case 2:
                            ReadQuestionInTest();
                            break;
                        case 3:
                            ReadAllQuestionInTests();
                            break;
                        case 4:
                            UpdateQuestionInTest();
                            break;
                        case 5:
                            DeleteQuestionInTest();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
    private static void StudentMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Student CRUD Menu ---");
            Console.WriteLine("1. Create (הוספה)");
            Console.WriteLine("2. Read (קריאה לפי ת.ז)");
            Console.WriteLine("3. ReadAll (קריאת כל הסטודנטים)");
            Console.WriteLine("4. Update (עדכון)");
            Console.WriteLine("5. Delete (מחיקה)");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                try
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            ReadStudent();
                            break;
                        case 3:
                            ReadAllStudents();
                            break;
                        case 4:
                            UpdateStudent();
                            break;
                        case 5:
                            DeleteStudent();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
    private static void AddAnswer()
    {
        Console.Write("Enter Question ID: ");
        int questionId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Answer Text: ");
        string? answerText = Console.ReadLine();

        Answer newAnswer = new Answer(0, questionId, answerText);
        int newId = s_dal.Answer.Create(newAnswer);
        Console.WriteLine($"Answer created successfully! The new ID is: {newId}");
    }

    private static void AddQuestion()
    {
        Console.Write("Enter Question Text: ");
        string? questionText = Console.ReadLine();
        Console.Write("Enter Correct Answer ID: ");
        int correctAnswerId = int.Parse(Console.ReadLine() ?? "0");

        Question newQuestion = new Question(0, questionText, correctAnswerId);
        int newId = s_dal.Question.Create(newQuestion);
        Console.WriteLine($"Question created successfully! The new ID is: {newId}");
    }

    private static void AddQuestionInTest()
    {
        Console.Write("Enter Student ID: ");
        int studentId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Test ID: ");
        int testId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Question ID: ");
        int questionId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Selected Answer ID: ");
        int selectedAnswerId = int.Parse(Console.ReadLine() ?? "0");

        QuestionInTest newQit = new QuestionInTest(0, studentId, testId, questionId, selectedAnswerId);
        int newId = s_dal.QuestionInTest.Create(newQit);
        Console.WriteLine($"QuestionInTest created successfully! The new ID is: {newId}");
    }

    private static void AddStudent()
    {
        Console.Write("Enter Student Name: ");
        string? studentName = Console.ReadLine();
        Console.Write("Enter Test ID: ");
        int testId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Grade (or leave empty for null): ");
        string? gradeInput = Console.ReadLine();
        int? grade = string.IsNullOrWhiteSpace(gradeInput) ? null : int.Parse(gradeInput);

        Student newStudent = new Student(0, studentName, testId, grade);
        int newId = s_dal.Student.Create(newStudent);
        Console.WriteLine($"Student created successfully! The new ID is: {newId}");
    }
    private static void AddTest()
    {
        Console.Write("Enter Subject ID (מספר נושא): ");
        int subject = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Number of Questions (כמות שאלות): ");
        int numQs = int.Parse(Console.ReadLine() ?? "0");


        Test newTest = new Test(0, (Subject)subject, DateTime.Now, numQs);int newId = s_dal.Test.Create(newTest);
        Console.WriteLine($"Test created successfully! The new ID is: {newId}");
    }
    private static void ReadAnswer()
    {
        Console.Write("Enter Answer ID to read: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Answer? a = s_dal.Answer.Read(id);
        if (a != null)
            Console.WriteLine(a);
        else
            Console.WriteLine("Answer not found.");
    }

    private static void ReadQuestion()
    {
        Console.Write("Enter Question ID to read: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Question? q = s_dal.Question.Read(id);
        if (q != null)
            Console.WriteLine(q);
        else
            Console.WriteLine("Question not found.");
    }

    private static void ReadQuestionInTest()
    {
        Console.Write("Enter QuestionInTest ID to read: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        QuestionInTest? qt = s_dal.QuestionInTest.Read(id);
        if (qt != null)
            Console.WriteLine(qt);
        else
            Console.WriteLine("QuestionInTest not found.");
    }

    private static void ReadStudent()
    {
        Console.Write("Enter Student ID to read: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Student? s = s_dal.Student.Read(id);
        if (s != null)
            Console.WriteLine(s);
        else
            Console.WriteLine("Student not found.");
    }
    private static void ReadTest()
    {
        Console.Write("Enter Test ID to read: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        Test? t = s_dal.Test.Read(id);
        if (t != null)
            Console.WriteLine(t);
        else
            Console.WriteLine("Test not found.");
    }
    private static void ReadAllAnswers()
    {
        var answers = s_dal.Answer.ReadAll();
        foreach (var a in answers)
        {
            Console.WriteLine(a);
        }
    }

    private static void ReadAllQuestions()
    {
        var questions = s_dal.Question.ReadAll();
        foreach (var q in questions)
        {
            Console.WriteLine(q);
        }
    }

    private static void ReadAllQuestionInTests()
    {
        var questionInTests = s_dal.QuestionInTest.ReadAll();
        foreach (var qt in questionInTests)
        {
            Console.WriteLine(qt);
        }
    }

    private static void ReadAllStudents()
    {
        var students = s_dal.Student.ReadAll();
        foreach (var s in students)
        {
            Console.WriteLine(s);
        }
    }
    private static void ReadAllTests()
    {
        var tests = s_dal.Test.ReadAll();
        foreach (var t in tests)
        {
            Console.WriteLine(t);
        }
    }
    private static void UpdateStudent()
    {
        Console.Write("Enter Student ID to update: ");
        int studentId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Student Name: ");
        string? studentName = Console.ReadLine();
        Console.Write("Enter new Test ID: ");
        int testId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Grade (or leave empty for null): ");
        string? gradeInput = Console.ReadLine();
        int? grade = string.IsNullOrWhiteSpace(gradeInput) ? null : int.Parse(gradeInput);

        Student updatedStudent = new Student(studentId, studentName, testId, grade);
        s_dal.Student.Update(updatedStudent);
        Console.WriteLine("Student updated successfully.");
    }

    private static void UpdateQuestion()
    {
        Console.Write("Enter Question ID to update: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Question Text: ");
        string? questionText = Console.ReadLine();
        Console.Write("Enter new Correct Answer ID: ");
        int correctAnswerId = int.Parse(Console.ReadLine() ?? "0");

        Question updatedQuestion = new Question(id, questionText, correctAnswerId);
        s_dal.Question.Update(updatedQuestion);
        Console.WriteLine("Question updated successfully.");
    }

    private static void UpdateAnswer()
    {
        Console.Write("Enter Answer ID to update: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Question ID: ");
        int questionId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Answer Text: ");
        string? answerText = Console.ReadLine();

        Answer updatedAnswer = new Answer(id, questionId, answerText);
        s_dal.Answer.Update(updatedAnswer);
        Console.WriteLine("Answer updated successfully.");
    }

    private static void UpdateQuestionInTest()
    {
        Console.Write("Enter QuestionInTest ID to update: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Student ID: ");
        int studentId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Test ID: ");
        int testId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Question ID: ");
        int questionId = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Selected Answer ID: ");
        int selectedAnswerId = int.Parse(Console.ReadLine() ?? "0");

        QuestionInTest updatedQit = new QuestionInTest(id, studentId, testId, questionId, selectedAnswerId);
        s_dal.QuestionInTest.Update(updatedQit);
        Console.WriteLine("QuestionInTest updated successfully.");
    }
    private static void UpdateTest()
    {
        Console.Write("Enter Test ID to update: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Subject ID: ");
        int subject = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Number of Questions: ");
        int numQs = int.Parse(Console.ReadLine() ?? "0");

        Test updatedTest = new Test(id, (Subject)subject, DateTime.Now, numQs); s_dal.Test.Update(updatedTest);
        Console.WriteLine("Test updated successfully.");
    }
    private static void DeleteStudent()
    {
        Console.Write("Enter Student ID to delete: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        s_dal.Student.Delete(id);
        Console.WriteLine("Student deleted successfully.");
    }

    private static void DeleteQuestion()
    {
        Console.Write("Enter Question ID to delete: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        s_dal.Question.Delete(id);
        Console.WriteLine("Question deleted successfully.");
    }

    private static void DeleteAnswer()
    {
        Console.Write("Enter Answer ID to delete: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        s_dal.Answer.Delete(id);
        Console.WriteLine("Answer deleted successfully.");
    }

    private static void DeleteQuestionInTest()
    {
        Console.Write("Enter QuestionInTest ID to delete: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        s_dal.QuestionInTest.Delete(id);
        Console.WriteLine("QuestionInTest deleted successfully.");
    }
    private static void DeleteTest()
    {
        Console.Write("Enter Test ID to delete: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        s_dal.Test.Delete(id);
        Console.WriteLine("Test deleted successfully.");
    }
}