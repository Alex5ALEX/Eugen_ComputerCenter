namespace ComputerCenterClient.Models;

public class Person
{
    //atributs
    public Guid Id { get; set; }

    public string Name { get; set; } = String.Empty;

    public string Surname { get; set; } = String.Empty;

    public string Phone { get; set; } = String.Empty;

    public string Email { get; set; } = String.Empty;

    public string Address { get; set; } = String.Empty;


    //enterance
    public string Login {  get; set; } = String.Empty;  

    public string Password {  get; set; } = String.Empty;   

}
