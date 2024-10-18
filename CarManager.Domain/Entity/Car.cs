namespace CarManager.Domain.Entity;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Version { get; set; }
    public string Class { get; set; }
    public string Engine { get; set; }
    public double Price { get; set; }
    public string Image { get; set; }
}