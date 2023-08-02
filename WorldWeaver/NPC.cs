using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWeaver.Models
{
    public class NPC
    {
        public int NPCId { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int ArmorClass { get; set; }
        public string CharacterNotes { get; set; }
        public string Skills { get; set; }
        public string Abilities { get; set; }
        public string Attacks { get; set; }
        public int TokenId { get; set; }
    }


}
