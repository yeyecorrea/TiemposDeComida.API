namespace TiemposDeComida.Domain.Entities
{
    public class PhotoOpinion
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int OpinionId { get; set; }
        public Opinion Opinion { get; set; } = null!;
    }
}
