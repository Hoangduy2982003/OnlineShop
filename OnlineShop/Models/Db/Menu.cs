﻿namespace OnlineShop.Models.Db;

public partial class Menu
{
    public int Id { get; set; }

    public string? MenuTitle { get; set; }

    public string? Link { get; set; }

    public string? Type { get; set; }
}
