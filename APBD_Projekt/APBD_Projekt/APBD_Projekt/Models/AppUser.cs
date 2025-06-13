﻿using System.ComponentModel.DataAnnotations;

namespace APBD_Projekt.Models;

public class AppUser
{
    [Key]
    public int IdUser { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string Rola { get; set; }
    public string RefreshToken { get; set; }
    public DateTime? RefreshTokenExp { get; set; }
}