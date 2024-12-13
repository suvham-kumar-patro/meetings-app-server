﻿using System.ComponentModel.DataAnnotations;

namespace Meetings_App_Server.Models.DTO;

public class LoginRequestDto

{

    [Required]

    [DataType(DataType.EmailAddress)]

    public string Username { get; set; }


    [Required]

    [DataType(DataType.Password)]

    public string Password { get; set; }

}