namespace EfCore.Entities;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public decimal ChasisNo { get; set; }
    public virtual Engine? Engine { get; set; }
}
