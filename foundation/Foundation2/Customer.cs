using System;
using System.Collections.Generic;

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name{ get => name; set => name = value; }
    public Address Address { get => address; set => address = value; }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}