using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Entities;

public class Attribute : Base
{
    [Required(ErrorMessage ="نام ویژگی اجباری است")]
    public string Name { get; set; }  

    [Required(ErrorMessage ="دسته بندی اجباری است")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
