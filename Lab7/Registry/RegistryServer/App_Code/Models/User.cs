using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Модель пользователя
/// </summary>
public class User
{
    public User()
    {
       
    }

    public int id { get; set; }
    public bool isOperator { get; set; }
    public string username { get; set; }

    public Organization idOrg { get; set; }
}
