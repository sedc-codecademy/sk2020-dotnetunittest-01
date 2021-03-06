﻿namespace SEDC.Travel.Service.Model.DTO
{
    public class HotelDto
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Web { get; set; }

        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public int HotelCategoryId { get; set; }

        public string HotelCategory { get; set; }
    }
}
