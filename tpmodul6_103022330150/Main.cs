using tpmodul6_103022330150;

class Program
{
    public static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Ihsan Romdhon");

        try
        {
            for (int i = 0; i < 100; i++)
            {
                video.IncreasePlayCount(10000000);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }

        video.PrintVideoDetails();
    }
}
