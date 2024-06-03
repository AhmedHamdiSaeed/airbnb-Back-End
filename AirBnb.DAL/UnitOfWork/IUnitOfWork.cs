using AirBnb.DAL.Repos.AmentityRepo;
using AirBnb.DAL.Repos.AppointmentAvailableRepo;
using AirBnb.DAL.Repos.BookingRepo;
using AirBnb.DAL.Repos.CategoryRepo;
using AirBnb.DAL.Repos.ReviewRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Unit
{
	public interface  IUnitOfWork
	{
		IAmentityRepository AmentityRepository { get; }
		IReviewRepository ReviewRepository { get; }
		IBookingRepository BookingRepository { get; }
		ICategoryRepository CategoryRepository { get; }

		IApptAvailableRepository ApptAvailableRepository { get; }

		int SaveChanges();
	}
}
