namespace WebApp.DTOs;

public class IndexRequest
{
    public string Id { get; set; }
    public int Page { get; set; } = 1;
    public int PerPage { get; set; } = 20;
}