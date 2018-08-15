namespace ActionsAndTriggers
{
    

    class Program
    {
        static void Main(string[] args)
        {
            
            var gui = new CommandGui();
            while (true)
            {
                gui.Update();
            }

            

        }
    }
}
