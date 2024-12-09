namespace ComputerCenterClient.Models;

public class Provider
{
    //atributs
    public Guid Id { get; set; }

    public string Company { get; set; } = String.Empty;

    public string ContactPerson { get; set; } = String.Empty;

    public string Phone { get; set; } = String.Empty;

    public string Email { get; set; } = String.Empty;

    public string Address { get; set; } = String.Empty;


    //links
    public List<Product> Products { get; set; } = [];

}
