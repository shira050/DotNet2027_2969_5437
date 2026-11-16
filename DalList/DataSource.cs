
using DalApi;
using DO; // מכיל את כל הישויות שלכן מתיקיית DO

namespace DalList;

internal static class DataSource
{
    internal static List<Test?> Tests = new List<Test?>();
    internal static List<Question?> Questions = new List<Question?>();
    internal static List<Answer?> Answers = new List<Answer?>();
    internal static List<Student?> Students = new List<Student?>(); // השארתי את השם לפי מה שהגדרתן קודם
    internal static List<QuestionInTest?> QuestionInTests = new List<QuestionInTest?>();

    internal static class Config
    {
        // Answer
        private const int minAnswerNum = 100;
        private static int answerNum = minAnswerNum;
        public static int AnswerNum => answerNum++; // מקדם את מונה התשובות

        // Question 
        private const int minQuestion = 1;
        private static int minQuestionNum = minQuestion;
        public static int QuestionNum => minQuestionNum++;

        // QuestionInTest
        private const int minQuestionInTest = 1;
        private static int minQuestionInTestNum = minQuestionInTest;
        public static int QuestionInTestNum => minQuestionInTestNum++;

        private const int minTestNum = 1000;
        private static int testNum = minTestNum;
        public static int TestNum => testNum++;

    }
}