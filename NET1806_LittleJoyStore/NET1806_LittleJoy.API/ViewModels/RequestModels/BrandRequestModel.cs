﻿using System.ComponentModel.DataAnnotations;

namespace NET1806_LittleJoy.API.ViewModels.RequestModels
{
    public class BrandRequestModel
    {
        public int Id { get; set; }

        public string? BrandName { get; set; }

        [MaxLength]
        public string? Logo { get; set; }

        [MaxLength]
        public string? BrandDescription { get; set; }
    }
}
