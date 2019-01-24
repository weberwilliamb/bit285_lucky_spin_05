using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class Repository
    {
        private List<Spin> spins = new List<Spin>();

        public IEnumerable<Spin> PlayerSpins
        {
            get
            {
                return spins;
            }
        }
        public void AddSpin (Spin PlayerSpin)
        {
            spins.Add(PlayerSpin);
        }
    }
}
