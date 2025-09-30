using SyncfusionBlazorAppRegister.Models;

namespace SyncfusionBlazorAppRegister.Services
{
    public class PropertyService
    {
        public List<PropertyInfo> GetProperties()
        {
            return new List<PropertyInfo>
            {
                new PropertyInfo
                {
                    Id = 1,
                    Title = "Modern Loft in Boston",
                    Description = "Spacious loft with skyline views.",
                    City = "Boston",
                    Type = "Loft",
                    Price = 850000,
                    Bedrooms = 2,
                    Bathrooms = 2,
                    ImageUrl = "images/loft1.jpg",
                    VideoUrl = "videos/loft1.mp4",
                    ListedDate = DateTime.Now.AddDays(-10),
                    IsFeatured = true
                },
                // Add more mock listings here
            };
        }
    }
}