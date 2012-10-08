using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log210_Lab_Eq10
{
    class Stay
    {
        private DateTime _checkIn;
        private DateTime _checkOut;
        private List<StayLineItem> _stayLineItems;

        public Stay(DateTime checkIn, DateTime checkout, List<StayLineItem> stayLineItems)
        {
            _checkIn = checkIn;
            _checkOut = checkout;
            _stayLineItems = stayLineItems;
        }

        /// <summary>
        /// Affiche les informations du séjour.
        /// </summary>
        public void toString()
        {
            foreach (StayLineItem sli in _stayLineItems)
            {
                sli.toString();
            }
        }

    }

}
