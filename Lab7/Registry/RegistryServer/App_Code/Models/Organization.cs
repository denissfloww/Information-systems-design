using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Organization
/// </summary>
public class Organization
{
    public Organization()
    {
       
    }

    public int id { get; set; }
    public string name { get; set; }
    public string adress { get; set; }
    public string tel { get; set; }
    public List<User> users { get; set; }
}