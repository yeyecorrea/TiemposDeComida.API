namespace TiemposDeComida.Domain.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RestaurantCategoryId { get; set; } // Foreign Key
        public string Cities { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? WebPage { get; set; }
        public string Phone { get; set; } = null!;
        public int ReservationMethodId { get; set; }
        public double Latitude { get; set; }
        public double Length { get; set; }
        public string Schedules { get; set; } = null!;
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<Opinion> Opinions { get; set; } = new List<Opinion>();
        public ICollection<PhotoRestaurant> PhotosRestuarants { get; set; } = new List<PhotoRestaurant>();
        public ICollection<MenuItem> Menu { get; set; } = new List<MenuItem>();
        public RestaurantCategory RestaurantCategory { get; set; } = null!;

        public ICollection<TypeFood> TypeFoods { get; set; } = new List<TypeFood>();
        public ICollection<TypeKitchen> TypeKitchens { get; set; } = new List<TypeKitchen>();
        public ReservationMethod ReservationMethod { get; set; } = null;
        public ICollection<RestaurantFeature> RestaurantFeatures { get; set; } = new List<RestaurantFeature>();
        public ICollection<RestaurantTypeFood> RestaurantTypeFoods { get; set; } = new List<RestaurantTypeFood>();
        public ICollection<RestaurantTypeKitchen> RestaurantTypeKitchens { get; set; } = new List<RestaurantTypeKitchen>();
    }
}
