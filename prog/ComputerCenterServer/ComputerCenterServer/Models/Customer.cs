namespace ComputerCenterServer.Models;

public class Customer
{
    //atributs

    public Guid Id { get; set; }    


    //links
    public List<Order> Orders { get; set; } = [];

    public Guid Id_Person { get; set; }

    public Person? Person {  get; set; }
}
