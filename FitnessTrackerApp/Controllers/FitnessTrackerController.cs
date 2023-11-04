using FitnessTrackerApp.DAL.Interface;
using FitnessTrackerApp.DAL.Repository;
using FitnessTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FitnessTrackerApp.Controllers
{
    public class FitnessTrackerController : Controller
    {
        private readonly IFitnessTrackerInterface _Repository;
        public FitnessTrackerController(IFitnessTrackerInterface service)
        {
            _Repository = service;
        }
        public FitnessTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: FitnessTracker
        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        public async Task<ViewResult> Details(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(Workout workout)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult> EditAsync(int id)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Edit(Workout workout)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult> Delete(int id, bool? saveChangesError)
        {
            throw new NotImplementedException();
        }
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            throw new NotImplementedException();
        }
    }
}