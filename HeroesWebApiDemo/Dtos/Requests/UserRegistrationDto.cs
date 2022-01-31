﻿using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace HeroesWebApiDemo.Dtos.Requests;

public class UserRegistrationDto
{
    public string UserName { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public string Password { get; set; }
}