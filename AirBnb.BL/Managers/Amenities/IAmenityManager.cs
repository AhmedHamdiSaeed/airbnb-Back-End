using AirBnb.BL.Dtos.AmentityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Amenities
{
	public interface IAmenityManager
	{
		Task<bool> AddAmentity(AmenityAddDto amenityAddDto);
		Task<AmenityDto> Update(int amenityId, AmenityAddDto amenityAddDto);
		Task Delete(int amenityId);
		Task<IEnumerable<AmenityDto>> GetAllPropAmentity(int propId);
	}
}
