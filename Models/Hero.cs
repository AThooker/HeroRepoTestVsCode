namespace HeroApi.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string SuperName { get; set; }
        public string Power { get; set; }
        public bool BecomesVillian { get; set; }
        public string? Secret { get; set; }
    }
}