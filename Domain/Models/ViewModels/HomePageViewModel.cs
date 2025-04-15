using System;
using Domain.Models.Entities;

namespace Domain.Models.ViewModels;

public class HomePageViewModel
{
    public HomePageViewModel()
    {
        Products = new();
    }
    public List<Product> Products { get; set; }
    public HeaderItemsViewModel HeaderItems { get; set; }
}
