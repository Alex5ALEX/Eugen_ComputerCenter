namespace ComputerCenterServer.Models;

public class Order
{
    //atributs
    public Guid Id { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;


    //links
    public Guid Id_Customer { get; set; }

    public Customer? Customer { get; set; }


    public List<PurchasedProduct> PurchasedProduct { get; set; } = [];
    public List<PurchasedServices> PurchasedServices { get; set; } = [];
}
