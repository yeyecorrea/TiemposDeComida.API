namespace TiemposDeComida.Domain.Entities
{
    public class RestaurantFeature
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;

        public int FeatureRestaurantId { get; set; }
        public FeatureRestaurant FeatureRestaurant { get; set; } = null!;
    }
}
