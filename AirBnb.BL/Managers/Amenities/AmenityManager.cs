using AirBnb.BL.Dtos.AmentityDtos;
using AirBnb.DAL.Data.Model;
using AirBnb.DAL.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Amenities
{
	public class AmenityManager : IAmenityManager
	{
		private readonly IUnitOfWork _unitOfWork;
		public AmenityManager(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}


		// Add new amenity
		public async Task<AmenityDto> Add(AmenityAddDto amenityAddDto)
		{
			var amenity = new Amenity
			{
				Name = amenityAddDto.Name,
				Description = amenityAddDto.Description,
				propertyId = amenityAddDto.propertyId
			};


			await _unitOfWork.AmentityRepository.AddAsync(amenity);
			_unitOfWork.SaveChanges();

			return new AmenityDto
			{
				Id = amenity.Id,
				Name = amenity.Name,
				Description = amenity.Description,
				propertyId = amenity.propertyId
			};

		}

		// Update amenity
		public async Task<AmenityDto> Update(int amenityId, AmenityAddDto amenityAddDto)
		{
			var amenity = await _unitOfWork.AmentityRepository.GetByIdAsync(amenityId);

			if (amenity == null)
			{
				return null;
			}

			amenity.Name = amenityAddDto.Name;
			amenity.propertyId = amenityAddDto.propertyId;
			amenity.Description = amenityAddDto.Description;

			_unitOfWork.SaveChanges();

			return new AmenityDto
			{
				Id = amenity.Id,
				Name = amenity.Name,
				Description = amenity.Description,
				propertyId = amenity.propertyId
			};

		}

		// Delete amenity
		public async Task Delete(int amenityId)
		{
			var amenity = await _unitOfWork.AmentityRepository.GetByIdAsync(amenityId);
			if (amenity == null)
			{
				throw new Exception($"Amenity with ID {amenityId} not found.");
			}

			_unitOfWork.AmentityRepository.Delete(amenity);
			_unitOfWork.SaveChanges();
		}


	}
}
