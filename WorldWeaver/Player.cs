using System;

namespace WorldWeaver
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }
        public string Class { get; set; }
        public string NotesToDM { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int ProficiencyBonus { get; set; }
        public int WalkingSpeed { get; set; }
        public int Initiative { get; set; }
        public int ArmorClass { get; set; }
        public int TokenId { get; set; } // new property to match the 'token_id' column
    }
}
