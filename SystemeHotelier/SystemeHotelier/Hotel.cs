using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log210_Lab_Eq10
{
    class Hotel
    {
        List<Room> _rooms;

        /// <summary>
        /// Retourne le nombre de chambres d'une catégorie spécifiée.
        /// </summary>
        /// <param name="category">La catégorie spécifiée</param>
        /// <returns>Le nombre de chambres de la catégorie spécifiée</returns>
        public int getRoomsNb(RoomCategory category)
        {
            int roomsNb = 0;

            foreach (Room r in _rooms)
            {
                if (r.Category == category)
                {
                    roomsNb++;
                }
            }
            return roomsNb;
        }

    }

}
