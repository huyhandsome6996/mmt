public class thongkediem
{
    public static void tim_max(List<double> ds)
    {
        int n= ds.Count;
        double max_diem= ds[0];
        for(int i=1; i<n; i += 1)
        {
            if(max_diem < ds[i])
            {
                max_diem=ds[i];
            }
        }
        Console.WriteLine(max_diem);
    }
    public static void tim_min(List<double> arr)
    {
        int n= arr.Count;
        double min_val= arr[0];
        for(int i=1; i<n; i++)
        {
            if (min_val > arr[i])
            {
                min_val = arr[i];
            }
        }
        Console.WriteLine(min_val);
    }
    public static void diem_tb(List<double> arr)
    {
        
    }
    public static void Main()
    {
        List<double> ds_diem= new List<double>();
        Console.Write("nhập danh sách điểm đi: ");
        while (true)
        {
            String nhap_diem= Console.ReadLine();
            if(nhap_diem== "#")
            {
                break;
            }
            else
            {
                ds_diem.Add(double.Parse(nhap_diem));
            }
        }
        for(int i=0; i<ds_diem.Count; i++)
        {
            Console.WriteLine(ds_diem[i]);
            Console.WriteLine();
        }
        tim_max(ds_diem);
    }
}