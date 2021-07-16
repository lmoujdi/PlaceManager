using PlaceManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceManager.Data.Repositories
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly PlaceDbContext _context;
        public PlaceRepository(PlaceDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Place> GetAll()
        {
            return _context.Places.ToList();
        }

        public Place GetById(string id)
        {
            return _context.Places.Find(id);
        }
    }
}
