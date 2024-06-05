using AirBnb.DAL.Data.context;
using AirBnb.DAL.Repos.AmentityRepo;
using AirBnb.DAL.Repos.AppointmentAvailableRepo;
using AirBnb.DAL.Repos.BookingRepo;
using AirBnb.DAL.Repos.CategoryRepo;
using AirBnb.DAL.Repos.cityRepo;
using AirBnb.DAL.Repos.PropertyRepo;
using AirBnb.DAL.Repos.ReviewRepo;
using AirBnb.DAL.Repos.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.DAL.Unit
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContext _context;
		public IAmentityRepository AmentityRepository { get; }

		public IReviewRepository ReviewRepository { get; }

		public IBookingRepository BookingRepository { get; }
		public ICategoryRepository CategoryRepository { get; }
		public IApptAvailableRepository ApptAvailableRepository { get; }

		public IPropertyRepository PropertyRepository { get; }

		public ICityPrpository CityPrpository { get; }

		public IUserRepository UserRepository { get; }
		public UnitOfWork(AppDbContext context, IUserRepository userRepository, ICityPrpository cityPrpository, IPropertyRepository propertyRepository, IBookingRepository bookingRepository, IReviewRepository reviewRepository, IApptAvailableRepository apptAvailableRepository, IAmentityRepository amentityRepository, ICategoryRepository categoryRepository)
        {
            _context = context;
			BookingRepository = bookingRepository;
			ReviewRepository = reviewRepository;
			AmentityRepository = amentityRepository;
			CategoryRepository = categoryRepository;
			ApptAvailableRepository = apptAvailableRepository;
			PropertyRepository = propertyRepository;
			CityPrpository = cityPrpository;
			UserRepository = userRepository;
		}
        public int SaveChanges()
		{
			return _context.SaveChanges();
		}
	}
}
