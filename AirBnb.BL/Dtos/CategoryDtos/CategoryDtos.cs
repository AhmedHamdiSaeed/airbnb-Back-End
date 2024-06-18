using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CategoryDtos
{
	public class CategoryGetDtos 
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
	}
    public record CategoryEditDto(int id,string Name, IFormFile IconURL, string Desc);
    public record CategoryEditDtoURL(int id, string Name, string IconURL, string Desc);
    public record CategoryAddDto(string Name, IFormFile IconURL, string? Desc);
    public record CategoryDto(string Name, string IconURL, string Desc);

}
