﻿namespace HospitalApp.Models
{
    public class Patient: Person
    {
        public string? Disease { get; set; }

        public int WardNumber { get; set; }

        public int BedNumber { get; set; }

    }
}
