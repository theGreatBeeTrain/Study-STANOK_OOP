using Study.LabWork2.Shared.Services;

namespace Study.LabWork2;

public static class Program
{

    private const int RUN_TASK_NUMBER = 1;

    public static void Main()
    {

        var service = new RunService();
        string? inp;

        do
        {
            inp = Console.ReadLine().ToLower();
            try
            {
                switch (inp)
                {

                    case "1":
                        service.RunTask1();
                        break;
                    case "2":
                        service.RunTask2();
                        break;
                    case "3":
                        service.RunTask3();
                        break;

                    case "":
                    case "exit":
                    case "quit":
                        inp = null;
                        break;

                    default:
                        throw new NotSupportedException();
                }
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Не поддерживается");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Не реализованно");
            }
        }
        while (inp != null);
    }
}
