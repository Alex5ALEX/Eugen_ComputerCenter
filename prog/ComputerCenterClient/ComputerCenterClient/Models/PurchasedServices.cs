namespace ComputerCenterClient.Models;

public class PurchasedServices
{
    //atributs
    public int Quantity { get; set; } = 0;


    //links
    public Guid Id_Order { get; set; }

    public Order? Order { get; set; }


    public Guid Id_Services { get; set; }

    public Services? Services { get; set; }


}
