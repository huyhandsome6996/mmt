
public class tinh_so_theo_bit
{
    public static void tinhbit(int n)
    {
        int tinhtoan=1;
        int k=1;
        while (k < n)
        {
            tinhtoan= tinhtoan * 2;
            k+=1;
        }
        Console.WriteLine(tinhtoan);
    }
    public static void Main()
    {
        tinhbit(16);
    }
}