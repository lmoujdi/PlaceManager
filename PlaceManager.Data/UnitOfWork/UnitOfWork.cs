using PlaceManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceManager.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlaceDbContext _context;

        public IPlaceRepository PlaceRepository { get; }

        public UnitOfWork(PlaceDbContext placeDbContext,
            IPlaceRepository placeRepository)
        {
            this._context = placeDbContext;
            this.PlaceRepository = placeRepository;
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
