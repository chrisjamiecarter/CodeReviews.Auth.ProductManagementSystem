﻿namespace ProductManagementSystem.StevieTV.Models;

public class UserRolesViewModel
{
    public string UserId { get; set; }
    public string Email { get; set; }
    public IEnumerable<string> Roles { get; set; }
}