using FitnessTrackerApp.DAL.Interface;
using FitnessTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FitnessTrackerApp.DAL.Repository
{
    public class FitnessTrackerRepository : IFitnessTrackerRepository
    {
        private FitnessTrackerDbContext _context;
        public FitnessTrackerRepository(FitnessTrackerDbContext Context)
        {
            this._context = Context;
        }
        public async Task<IEnumerable<Workout>> GetWorkouts()
        {
            throw new NotImplementedException();
        }
        public async Task<Workout> GetWorkoutByID(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Workout> InsertWorkout(Workout workout)
        {
            throw new NotImplementedException();
        }
        public async Task<int> DeleteWorkout(int workoutID)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> UpdateWorkout(Workout workout)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
