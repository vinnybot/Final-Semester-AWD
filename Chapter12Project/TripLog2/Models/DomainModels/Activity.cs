﻿namespace TripLog2.Models.DomainModels
{
    public class Activity
    {
        public Activity() => Trips = new HashSet<Trip>();
        public int ActivityId { get; set; } //Primary Key

        public string Name { get; set; } = string.Empty;

        public ICollection<Trip> Trips { get; set; }
    }
}
