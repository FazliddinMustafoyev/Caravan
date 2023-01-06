﻿using Caravan.Domain.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Caravan.Service.Dtos
{
    public class TruckCreateDto
    {
        [Required]
        [MaxLength(30), MinLength(3)]
        public string Name { get; set; } = string.Empty;

        public IFormFile? Image { get; set; }

        [Required]
        public double? MaxLoad { get; set; }

        public bool IsEmpty { get; set; } = true;

        public string? Description { get; set; }

        [Required]
        public string TruckNumber { get; set; } = string.Empty;

        [Required]
        public virtual Domain.Entities.Location TruckLocation { get; set; } = default!;

        public static implicit operator Truck(TruckCreateDto truckCreateDto)
        {
            return new Truck()
            {
                Name = truckCreateDto.Name,
                ImagePath = truckCreateDto.ImagePath,
                MaxLoad = truckCreateDto.MaxLoad,
                IsEmpty = truckCreateDto.IsEmpty,
                Description = truckCreateDto.Description,
                TruckNumber = truckCreateDto.TruckNumber,
                TruckLocation = truckCreateDto.TruckLocation
            };
        }
    }
}
