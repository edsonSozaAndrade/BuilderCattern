namespace BuilderCattern.DTO
{
    public class SpringfieldCitizen
    {
        public required string Head { get; set; }
        public required string Torso { get; set; }
        public required string Legs { get; set; }
        public required string Outfit { get; set; }

        public override string ToString()
        {
            return $"""
            Springfield Citizen Created:
            - Head: {Head}
            - Torso: {Torso}
            - Legs: {Legs}
            - Outfit: {Outfit}
            """;
        }
    }
}
