using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log210_Lab_Eq10
{
    class Agenda
    {
        private static Agenda _instance;
        private List<Reservation> _reservations;

        /// <summary>
        /// Constructeur privé (singleton).
        /// </summary>
        private Agenda();

        /// <summary>
        /// Retourne une référence vers le singleton.
        /// </summary>
        /// <returns>Une référence vers le singleton</returns>
        public static Agenda getInstance()
        {
            if (_instance == null)
            {
                _instance = new Agenda();
            }
            return _instance;
        }

    }

}
