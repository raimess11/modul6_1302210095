using modul6_1302210095;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user1 = new SayaTubeUser("raimess");

        SayaTubeVideo video1 = new SayaTubeVideo("Review Film regy ketawa oleh rahma");
        video1.IncresePlayCount(11);
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film iqro smekdon oleh rahma");
        video2.IncresePlayCount(13);
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film rahma salto oleh rahma");
        video3.IncresePlayCount(21);
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film alrm sahur zeta oleh rahma");
        video4.IncresePlayCount(31);
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film 1 semester gak ngapa ngapain oleh rahma");
        video5.IncresePlayCount(1);
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film raimess skizo part 2 oleh rahma");
        video6.IncresePlayCount(41);
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film zeta lucu oleh rahma");
        video7.IncresePlayCount(78);
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film titan kepleset oleh rahma");
        video8.IncresePlayCount(12);
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film iklan balsem cap kaki 3 oleh rahma");
        video9.IncresePlayCount(95);
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film asmr closeup iga bakar dustin oleh rahma");
        video10.IncresePlayCount(44);
        SayaTubeVideo videojelek = new SayaTubeVideo("Review Film asmr closeup iga bakar dustin oleh rahma");
        videojelek.IncresePlayCount(int.MaxValue);
        videojelek.IncresePlayCount(-1);

        user1.AddVideo(video1);
        user1.AddVideo(video2);
        user1.AddVideo(video3);
        user1.AddVideo(video4);
        user1.AddVideo(video5);
        user1.AddVideo(video6);
        user1.AddVideo(video7);
        user1.AddVideo(video8);
        user1.AddVideo(video9);
        user1.AddVideo(video10);

        user1.AddVideo(videojelek);
        SayaTubeUser user2 = new SayaTubeUser(new string(new char[100]));
        SayaTubeUser user3 = new SayaTubeUser(null);


        user1.PrintAllVideoPlayCount();
        Console.WriteLine("Total play count: " + user1.GetTotalVideoPlayCount());
        
    }
}
