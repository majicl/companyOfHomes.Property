using System;
using Domain.SeedWork;

namespace Domain.Properties
{
    public class Property
    {
        public Property()
        {
            this.Created = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public Guid Token { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public bool AutoGenerateTitle { get; set; }
        public int Bedrooms { get; set; }
        public float Bathrooms { get; set; }
        public float SquareFootage { get; set; }
        public decimal RentAmount { get; set; }
        public bool SmokingAllowed { get; set; }
        public bool WheelchairAccessibility { get; set; }
        public bool IsFurnished { get; set; }
        public string Description { get; set; }
        public string PendingChanges { get; set; }

        public string LandlordName { get; set; }
        public string LandlordEmail { get; set; }
        public string LandlordPhone { get; set; }

        public DateTime? PublishDate { get; set; }
        public int DefaultPhotoId { get; set; }
        public int DurationOfSeeingMinutes { get; set; }
        public int SameTimeVisitorCount { get; set; }
        public int ShowingAdvanceNotice { get; set; }
        public bool EmailSharingAllowed { get; set; }
        public bool PhoneSharingAllowed { get; set; }
        public bool JustPostalCodeSharingAllowed { get; set; }
        public string TimeZoneId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal Debt { get; set; }
        public int ViewCount { get; set; }
        public int PreviewCount { get; set; }
        public bool Isverified { get; set; }
        public string VerifiedByPhone { get; set; }
        public int VerifyingTryCount { get; set; }
        public int FailedVerificationCount { get; set; }
    }
}
