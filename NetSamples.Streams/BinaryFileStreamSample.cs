namespace NetSamples.Streams;

public class BinaryFileStreamSample
{
    public void WorkWithFile(string filePath)
    {

        var namesList = new List<string>()
        {
            "Sekiguchi Sharaku",
            "Amari Oniji",
            "Kawata Tomohiko",
            "Gima Kyoden",
            "Isayama Kosho",
            "Tachibana Okura",
            "Ueyonabaru Tetsuyuki",
            "Mizuno Chikafusa",
            "Okazaki Sadaharu",
            "Toma Yoshitake"
        };
        var companiesList = new List<string>()
        {
            "Mitsubishi",
            "KDDI",
            "Japan Post Holdings",
            "Sumitomo Mitsui Financial Group",
            "Honda Motor",
            "Mitsubishi UFJ Financial Group",
            "Nippon Telegraph and Telephone",
            "Sony",
            "SoftBank",
            "Toyota Motor"
        };

        using (var bw = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write)))
        {
            for (int i = 0; i < 10; i++)
            {
                var durationOfWorkInYears = new Random().Next(1, 70);
                bw.Write(namesList[i]); 
                bw.Write(durationOfWorkInYears);
                bw.Write(companiesList[i]);
            }
        }

        var employees = new List<JapanEmployee>();

        using (var br = new BinaryReader(File.Open(filePath, FileMode.Open, FileAccess.Read)))
        {
            for (int i = 0; i < 10; i++)
            {
                var name = br.ReadString();
                var duration = br.ReadInt32();
                var company  = br.ReadString();

                employees.Add(new JapanEmployee()
                {
                    Name = name, 
                    Duration = duration, 
                    Company = company
                });
            }
        }

        foreach (var japanEmployee in employees)
        {
            Console.WriteLine($"{japanEmployee.Name} works in {japanEmployee.Company} for {japanEmployee.Duration} years");
        }
    }
}
