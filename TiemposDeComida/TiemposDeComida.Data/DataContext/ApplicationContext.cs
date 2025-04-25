using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TiemposDeComida.Domain.Entities;

namespace TiemposDeComida.Data.DataContext
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        // Usuarios y perfiles
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<PhotoUser> PhotoUsers { get; set; }
        public DbSet<ProfileUser> ProfileUsers { get; set; } = null!;

        // Restaurantes y todo lo relacionado
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<PhotoRestaurant> PhotoRestaurants { get; set; }
        public DbSet<RestaurantCategory> RestaurantCategorys { get; set; }
        public DbSet<ReservationMethod> ReservationMethods { get; set; }

        // Menú
        public DbSet<MenuCategory> MenuCategoris { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        // Reservas
        public DbSet<Booking> Bookings { get; set; }

        // Opiniones
        public DbSet<Opinion> Opiniones { get; set; }
        public DbSet<PhotoOpinion> PhotoOpinions { get; set; }
        public DbSet<ResponseOpinion> ResponseOpinions { get; set; } = null!;

        // Características, tipos y filtros
        public DbSet<FeatureRestaurant> FeatureRestaurants { get; set; }
        public DbSet<RestaurantFeature> RestaurantFeatures { get; set; }

        public DbSet<TypeKitchen> TypeKitchens { get; set; }
        public DbSet<RestaurantTypeKitchen> RestaurantTypeKitchens { get; set; }

        public DbSet<TypeFood> TypeFood { get; set; }
        public DbSet<RestaurantTypeFood> RestaurantTypeFoods { get; set; }

        public DbSet<EstablishmentType> EstablishmentTypes { get; set; } = null!;

        // Filtros adicionales
        //public DbSet<Precio> Precios { get; set; }

        // Otros si los usas después
        // public DbSet<Notificacion> Notificaciones { get; set; }
        // public DbSet<Ubicacion> Ubicaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RestaurantFeature>()
                .HasKey(rc => new { rc.RestaurantId, rc.FeatureRestaurantId });

            builder.Entity<RestaurantFeature>()
                .HasOne(rc => rc.Restaurant)
                .WithMany(r => r.RestaurantFeatures)
                .HasForeignKey(rc => rc.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict); // 👈 evita múltiples cascadas

            builder.Entity<RestaurantFeature>()
                .HasOne(rc => rc.FeatureRestaurant)
                .WithMany()
                .HasForeignKey(rc => rc.FeatureRestaurantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RestaurantTypeFood>()
                .HasKey(rc => new { rc.RestaurantId, rc.TypeFoodId });

            builder.Entity<RestaurantTypeFood>()
                .HasOne(rc => rc.Restaurant)
                .WithMany(r => r.RestaurantTypeFoods)
                .HasForeignKey(rc => rc.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RestaurantTypeFood>()
                .HasOne(rc => rc.TypeFood)
                .WithMany()
                .HasForeignKey(rc => rc.TypeFoodId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RestaurantTypeKitchen>()
                .HasKey(rc => new { rc.RestaurantId, rc.TypeKitchenId });

            builder.Entity<RestaurantTypeKitchen>()
                .HasOne(rc => rc.Restaurant)
                .WithMany(r => r.RestaurantTypeKitchens)
                .HasForeignKey(rc => rc.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RestaurantTypeKitchen>()
                .HasOne(rc => rc.TypeKitchen)
                .WithMany()
                .HasForeignKey(rc => rc.TypeKitchenId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ResponseOpinion>()
            .HasOne(ro => ro.Restaurant)
            .WithMany()
            .HasForeignKey(ro => ro.RestaurantId)
            .OnDelete(DeleteBehavior.Restrict);
        }



    }
}
