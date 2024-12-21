using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerCenterClient.Models;


namespace ComputerCenterClient.DTO;

public class AdminDTO
{
    public Admin Admin { get; set; }

    public Person Person { get; set; }

    public AdminDTO()
    {
        Person = new Person();
        Admin = new Admin();  
    }

    public AdminDTO(Admin admin, Person person)
    {
        Admin = admin;
        Person = person;
    }
    
    public AdminDTO(Person person, Admin admin)
    {
        Admin = admin;
        Person = person;
    }


}
