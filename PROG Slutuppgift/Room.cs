using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Slutuppgift
{
    public class Room
    {
        private Room? _north;
        private Room? _south;
        private Room? _east;
        private Room? _west;

        public string Description { get; set; } = "";

        public Loot? loot;

        public Room? GoSouth => _south;
        public Room? GoEast => _east;
        public Room? GoWest => _west;
        public Room? GoNorth => _north; 


        public void AddToNorth(Room otherRoom, bool oneway = false)
        {
            if (!oneway)
                otherRoom._south = this;
            _north = otherRoom;
        }
        public void AddToSouth(Room otherRoom, bool oneway = false)
        {
            if (!oneway)
                otherRoom._north = this;
            _south = this;
        }

        public void AddToEast(Room otherRoom, bool oneway = false)
        {
            if (!oneway)
                otherRoom._west = this;
            _east = otherRoom;
        }

        public void AddToWest(Room otherRoom, bool oneway = false)
        {
            if (!oneway)
                otherRoom._east = this;
            _west = otherRoom;
        }


    }
}
