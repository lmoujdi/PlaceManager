using PlaceManager.Data.Repositories;
using System;

namespace PlaceManager.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IPlaceRepository PlaceRepository { get; }
        int Save();
    }
}
