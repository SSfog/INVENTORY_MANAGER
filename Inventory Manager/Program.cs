namespace Inventory_Manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Добавление_производителя());
            Start first=new Start();    
            DateTime end = DateTime.Now+TimeSpan.FromSeconds(4);
            first.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();  
            first.Dispose();
            Application.Run(new Полная_таблица());
            //Application.Run(new Start());
        }
    }
}