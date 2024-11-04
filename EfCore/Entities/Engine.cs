namespace EfCore.Entities;

public class Engine
{
    public int Id { get; set; }
    public int CylindersCount { get; set; }
    public string EngineType { get; set; } = "V";
    //public Car? Car { get; set; }
}
