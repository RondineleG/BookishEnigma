﻿namespace BookishEnigma.Core.Dtos;

public class AccountDto
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string? AccountType { get; set; }
}
