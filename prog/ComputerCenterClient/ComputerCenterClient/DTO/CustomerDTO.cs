using ComputerCenterClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCenterClient.DTO;

public  class CustomerDTO
{
    public Person Person { get; set; }

    public Customer Customer { get; set; }


    public CustomerDTO()
    {
        Person = new Person();
        Customer = new Customer();
    }

    public CustomerDTO(Person person,Customer customer)
    {
        Person = person;
        Customer = customer;
    }

    public CustomerDTO(Customer customer, Person person)
    {
        Person = person; 
        Customer = customer;
    }


}
