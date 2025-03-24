using System;
using Domain.Models;

namespace Domain.ViewModels;

public class HomePageViewModel
{
    public HomePageViewModel()
    {
        this.Products = new();
    }
    public List<Product> Products { get; set; }
    
}
