﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Car
{
    public class AddCarRequest
    {
        public AddCarRequest(int colorId, int modelId, string carState, string kilometer, short modelYear, string plate)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
        }

        public int ColorId { get; set; }

        public int ModelId { get; set; }

        public string CarState { get; set; }

        public string Kilometer { get; set; }

        public short ModelYear { get; set; }

        public string Plate { get; set; }

        private bool IsValidModelYear(short modelYear)
        {
            int currentYear = DateTime.Now.Year;
            return (currentYear - modelYear) <= 20;
        }
    }
}