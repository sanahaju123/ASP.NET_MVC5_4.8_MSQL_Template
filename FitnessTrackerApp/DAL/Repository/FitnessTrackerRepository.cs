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
        public IEnumerable<Workout> GetWorkouts()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Workout GetWorkoutByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Workout InsertWorkout(Workout workout)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteWorkout(int workoutID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateWorkout(Workout workout)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
