using SchoolSchedule.Мусор;

namespace SchoolSchedule
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SubjectController subjectController = new SubjectController();


            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }


    }
}