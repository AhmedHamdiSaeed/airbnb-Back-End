using AirBnb.DAL.Data.context;
using AirBnb.DAL.Repos.AmentityRepo;
using AirBnb.DAL.Repos.AppointmentAvailableRepo;
using AirBnb.DAL.Repos.BookingRepo;
using AirBnb.DAL.Repos.ReviewRepo;
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

        public IApptAvailableRepository ApptAvailableRepository { get; }

        public UnitOfWork(AppDbContext context, IBookingRepository bookingRepository, IReviewRepository reviewRepository, IAmentityRepository amentityRepository, IApptAvailableRepository apptAvailableRepository)
        {
            _context = context;
			BookingRepository = bookingRepository;
			ReviewRepository = reviewRepository;
			AmentityRepository = amentityRepository;
			ApptAvailableRepository = apptAvailableRepository;

        }
        public int SaveChanges()
		{
			return _context.SaveChanges();
		}
	}
}
