using FitnessTrackerApp.DAL.Interface;
using FitnessTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitnessTrackerApp.DAL.Repository
{
    public class FitnessTrackerService : IFitnessTrackerInterface
    {
        private IFitnessTrackerRepository _repo;
        public FitnessTrackerService(IFitnessTrackerRepository repo)
        {
            this._repo = repo;
        }

        public async Task<int> DeleteWorkout(int workoutId)
        {
            throw new NotImplementedException();
        }

        public Task<Workout> GetWorkoutByID(int workoutId)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            throw new NotImplementedException();
        }


        Task<IEnumerable<Workout>> IFitnessTrackerInterface.GetWorkouts()
        {
            throw new NotImplementedException();
        }

        Task<Workout> IFitnessTrackerInterface.InsertWorkout(Workout workout)
        {
            throw new NotImplementedException();
        }

        Task<bool> IFitnessTrackerInterface.UpdateWorkout(Workout workout)
        {
            throw new NotImplementedException();
        }
    }
}