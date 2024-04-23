namespace WebApp.DTOs;

public class Photo
{
    public string Id { get; set; }
    public string Owner { get; set; }
    public string Secret { get; set; }
    public string Server { get; set; }
    public int Farm { get; set; }
    public string Title { get; set; }
    public int Ispublic { get; set; }
    public int Isfriend { get; set; }
    public int Isfamily { get; set; }
}