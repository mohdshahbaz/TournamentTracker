using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents what the prize is for the given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The Unique Identifier for the Prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The numeric identifier for the place (2 for the second place, etc).
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The friendly name for the place ( first place, first runner up, etc).
        /// </summary>
        public String PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earns or zero if not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double PrizePercentage { get; set; }


        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int.TryParse(placeNumber, out int placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double.TryParse(prizePercentage, out double prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}
