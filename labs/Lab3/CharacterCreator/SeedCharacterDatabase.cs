using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class SeedCharacterDatabase
    {
        public void Seed ( ICharacterDatabase database )
        {
            var items = new[] {
                new Character() {
                    Name = "Katarina",
                    //Profession = "Rouge",
                    //Race = "Human",
                    Biography = "Greatest Assasin",
                    Strength = 60,
                    Intelligence = 60,
                    Agility = 80,
                    Constitution = 50,
                    Charisma = 70,
                },

                new Character() {
                    Name = "Ganda",
                    //Profession = "Elf",
                    //Race = "Wizard",
                    Biography = "White Wizard",
                    Strength = 50,
                    Intelligence = 85,
                    Agility = 35,
                    Constitution = 70,
                    Charisma = 80,
                },

                new Character() {
                    Name = "Saurin",
                    //Profession = "Elf",
                    //Race = "Wizard",
                    Biography = "Dark Lord",
                    Strength = 70,
                    Intelligence = 90,
                    Agility = 20,
                    Constitution = 20,
                    Charisma = 50,
                }
            };

            foreach (var item in items)
                database.Add(item, out var error);

        }
    }
}
