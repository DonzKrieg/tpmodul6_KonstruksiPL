using tpmodul6_103022330150;

class Program
{
    public static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Muhammad Ihsan Romdhon");
        video.IncreasePlayCount(10);
        video.PrintVideoDetails();
    }
}
