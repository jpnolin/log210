using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log210_Lab_Eq10
{
    class Reservation
    {
        private List<Stay> _stays;
        private int _confirmationNum;
        private static int _confirmationNumCounter = 1;

        public Reservation(List<Stay> stays)
        {
            _stays = stays;
            _confirmationNum = _confirmationNumCounter++;
        }

        /// <summary>
        /// Affiche les informations de la réservation.
        /// </summary>
        public void toString()
        {
            foreach (Stay s in _stays)
            {
                s.toString();
            }
        }

    }

}
