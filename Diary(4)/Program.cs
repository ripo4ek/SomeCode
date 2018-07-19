using System.Reflection.PortableExecutable;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var diary = new DiaryGui(new Diary());
            while (true)
            {
                diary.Update();
            }
        }

    }
}