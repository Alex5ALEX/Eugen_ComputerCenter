namespace ComputerCenterClient.Models;

public class Admin
{
    //atributs

    public Guid Id { get; set; }

    public string Jobtitle { get; set; } 


    //links


    public Guid Id_Person { get; set; }

    public Person? Person { get; set; }

}
