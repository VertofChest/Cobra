﻿namespace Cobra.Server.Hitman.Models
{
    public class UserProfileSpecialRatings
    {
        public int NumAchievedRatings { get; set; }
        public int NumTotalRatings { get; set; }
        public List<SpecialRating> Ratings { get; set; }
    }
}
