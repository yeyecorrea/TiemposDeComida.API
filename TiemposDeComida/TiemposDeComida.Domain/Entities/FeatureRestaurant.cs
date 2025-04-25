namespace TiemposDeComida.Domain.Entities
{
    public class FeatureRestaurant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!; // Ej: "Gluten-Free", "Tarjetas de crédito"
        public ICollection<RestaurantFeature> RestaurantFeatures { get; set; } = new List<RestaurantFeature>();
    }

}
