namespace Stack_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pancakes = new Stack(0);
            var gui = new Gui(pancakes);
            while (true)
            {
                gui.Update();
            }
        }
    }
}
