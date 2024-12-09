namespace ComputerCenterClient.Models;

public class Customer
{
    //atributs
    public Guid Id { get; set; }

    public string Name { get; set; } = String.Empty;

    public string Surname { get; set; } = String.Empty;

    public string Phone { get; set; } = String.Empty;

    public string Email { get; set; } = String.Empty;

    public string Address { get; set; } = String.Empty;


    //links
    public List<Order> Orders { get; set; } = [];

}
