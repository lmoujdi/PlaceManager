using Microsoft.AspNetCore.Mvc;
using PlaceManager.Data;
using PlaceManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceManager.API.Controllers
{
    [Route("api/places")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public PlacesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Place> GetAll()
        {
            return _unitOfWork.PlaceRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Place Get(string id)
        {
            return  _unitOfWork.PlaceRepository.GetById(id);
        }
    }
}
