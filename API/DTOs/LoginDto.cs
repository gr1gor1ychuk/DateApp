using System;
using Microsoft.Build.Framework;

namespace API.DTOs;

public class LoginDto
{
  public string Email { get; set; } = "";
  public string Password { get; set; } = "";

}
