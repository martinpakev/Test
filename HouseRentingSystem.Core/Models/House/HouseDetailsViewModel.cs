﻿using HouseRentingSystem.Core.Contracts;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseDetailsViewModel : IHouseModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

    }
}