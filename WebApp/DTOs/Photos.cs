namespace WebApp.DTOs;

public class Photos
{
    public int Page { get; set; }
    public int Pages { get; set; }
    public int Perpage { get; set; }
    public int Total { get; set; }
    public List<Photo> Photo { get; set; }
}