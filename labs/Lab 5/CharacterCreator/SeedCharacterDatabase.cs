using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public static class SeedCharacterDatabase
    {
        public static void Seed ( this ICharacterRoster source )
        {
            var items = new[] {
                new Character() {
                    Name = "Katarina",
                    Profession = "Rogue",
                    Race = "Human",
                    Description = "Greatest Assasin",
                    Strength = 60,
                    Intelligence = 60,
                    Agility = 80,
                    Constitution = 50,
                    Charisma = 70,
                },

                new Character() {
                    Name = "Ganda",
                    Profession = "Wizard",
                    Race = "Elf",
                    Description = "White Wizard",
                    Strength = 50,
                    Intelligence = 85,
                    Agility = 35,
                    Constitution = 70,
                    Charisma = 80,
                },

                new Character() {
                    Name = "Saurin",
                    Profession = "Hunter",
                    Race = "Dwarf",
                    Description = "Dark Lord",
                    Strength = 70,
                    Intelligence = 90,
                    Agility = 20,
                    Constitution = 20,
                    Charisma = 50,
                }
            };

            foreach (var item in items)
                source.Add(item);

        }
    }
}
