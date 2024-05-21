using System;
using System.Collections.Generic;
using LuckySpin.Models;

namespace LuckySpin.Services
{
    public class Repository : IRepository
    {
        private List<Spin> spins;
        public Repository(){
            spins = new List<Spin>();
        }

       public IEnumerable<Spin> getSpins() {
             return spins;
       }
        public void AddSpin(Spin s)
        {
            spins.Add(s);
        }
    }
}
