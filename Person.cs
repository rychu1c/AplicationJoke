using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string Login { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Status { get; set; }
    public string Location { get; set; }
    public string LevelOfAccess { get; set; } = AccessLevel.User;
    


    private enum AccessLevel
    {
        User,
        Admin
    }

    public Person(string _login, string _name, string _surname, string _status, string _location)
    {
        Login = _login;
        Name = _name;
        Surname = _surname;
        Status = _status;
        Location = _location;
    }
}