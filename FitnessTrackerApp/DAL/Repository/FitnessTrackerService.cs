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

        public int DeleteWorkout(int workoutId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Workout GetWorkoutByID(int workoutId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Workout> IFitnessTrackerInterface.GetWorkouts()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Workout IFitnessTrackerInterface.InsertWorkout(Workout workout)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool IFitnessTrackerInterface.UpdateWorkout(Workout workout)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}