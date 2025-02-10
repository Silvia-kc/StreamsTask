using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StreamsTask
{
    public interface IPlayer
    {
        void Add(Player player);
        bool Remove(Player player);
        IEnumerable<Player> GetPlayers();
    }
}
