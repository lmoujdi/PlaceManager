using PlaceManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceManager.Data.Repositories
{
    public interface IPlaceRepository
    {
        Place GetById(string id);
        IEnumerable<Place> GetAll();
    }
}
