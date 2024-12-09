namespace ComputerCenterClient.Models;

public class Services
{
    //atributs
    public Guid Id { get; set; }

    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public decimal Price { get; set; } = 0;


    //links
    public List<PurchasedServices> PurchasedServices { get; set; } = [];
}
