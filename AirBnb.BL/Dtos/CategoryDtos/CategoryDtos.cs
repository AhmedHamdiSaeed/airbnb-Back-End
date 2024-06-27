using AirBnb.DAL.Data.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Dtos.CategoryDtos
{
	public class GetOneCategoryDtos 
	{
        public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
        public string IconURL { get; set; }
        public IEnumerable<PropertyDtos.PropertyGetDto> Properties { get; set; }
    }
    public record CategoryEditDto(int id,string Name, IFormFile IconURL, string Desc);
    public record CategoryEditDtoURL(int id, string Name, string IconURL, string Desc);
    public record CategoryAddDto(string Name, string IconURL, string? Desc);
    public record CategoryDto(string Name, string IconURL, string Desc);
	public record CategoryReadDto(string Name,string IconURL);

    public class getAllCategoryDto
    {
		public int Id { get; set; }
        public string Name { get; set; }
        public string IconURL { get; set; }
    }



}
