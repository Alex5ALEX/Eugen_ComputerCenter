namespace ComputerCenterServer.Models;


public class Product
{
    //atributs
    public Guid Id { get; set; }

    public string Type { get; set; } = string.Empty;

    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public decimal Price { get; set; } = 0;


    //links
    public List<PurchasedProduct> PurchasedProduct { get; set; } = [];


    public Guid Id_Provider { get; set; }

    public Provider? Provider { get; set; }


    public Guid Id_Manufacture { get; set; }

    public Manufacture? Manufacture { get; set; }
}
