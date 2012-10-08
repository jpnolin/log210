using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log210_Lab_Eq10
{
    enum RoomCategory 
    {
        Standard,
        Superior,
        Deluxe
    }

    class Room
    {
        private RoomCategory _category;

        public Room (RoomCategory category)
        {
           _category = category;
        }

        public RoomCategory Category
        {
            get
            {
                return _category;
            }
        }

    }
   
}
