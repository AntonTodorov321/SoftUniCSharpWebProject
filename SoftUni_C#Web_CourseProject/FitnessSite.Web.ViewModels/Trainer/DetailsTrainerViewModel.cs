﻿namespace FitnessSite.Web.ViewModels.Trainer
{
    public class DetailsTrainerViewModel
    {
        public Guid Id { get; set; }
        public int StartedAt { get; set; }
        public decimal PricePerMonth { get; set; }
        public string TelefoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int YearExperience { get; set; }
    }
}
