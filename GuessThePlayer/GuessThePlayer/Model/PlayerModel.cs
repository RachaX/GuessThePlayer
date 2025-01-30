using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

public class PlayerModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    [JsonPropertyName("ImageBase64")]
    public string ImageBase64 { get; set; }

    public PlayerModel()
    {
        
    }

    public PlayerModel(int id, string name, string imageBase64)
    {
        Id = id;
        Name = name;
        ImageBase64 = imageBase64;
    }

    public BitmapImage ConvertBase64ToImage()
    {
        byte[] imageBytes = Convert.FromBase64String(this.ImageBase64);
        using (MemoryStream ms = new MemoryStream(imageBytes))
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = ms;
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.EndInit();
            image.Freeze();
            return image;
        }
    }
}

public class PlayerService
{
    public static string relativePath = @"..\..\Resources\Levels\";
    public static string workingDir = AppDomain.CurrentDomain.BaseDirectory;
    public static string basePath = Path.GetFullPath(Path.Combine(workingDir, relativePath));

    public static async Task<List<PlayerModel>> loadLevel(string sport, string diff)
    {
        if (sport.Equals("Fudbal"))
            sport = "Football";
        else if (sport.Equals("Kosarka"))
            sport = "Basketball";

        string path = String.Concat(basePath, diff, "\\",  sport);    

        string[] file = Directory.GetFiles(path);

        string json = await Task.Run(() => File.ReadAllText(file[0]));

        List<PlayerModel> list = new List<PlayerModel>();

        try
        {
            list = JsonSerializer.Deserialize<List<PlayerModel>>(json);
        }
        catch(Exception e) 
        { 
            Console.WriteLine(e.Message);
        }

        return list;
    }
}
