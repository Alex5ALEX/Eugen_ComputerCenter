namespace ComputerCenterServer.Models;

public class Manufacture
{
    //atributs
    public Guid Id { get; set; }

    public string Company { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;



    //links
    public List<Product> Products { get; set; } = [];

}
