/*
 * ITSE 1430
 * Character Roster
 * Kiet Vo
 * Lab 5
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CharacterCreator.Web.Models
{
    public class CharacterModel 
    {
        public CharacterModel ()
        { }

        public CharacterModel ( Character character)
        {
            Id = character.Id;
            Name = character.Name;
            Profession = character.Profession;
            Race = character.Race;
            Strength = character.Strength;
            Intelligence = character.Intelligence;
            Agility= character.Agility;
            Constitution = character.Constitution;
            Charisma = character.Charisma;
            Description = character.Description;
        }

        public Character ToCharacter ()
        {
            return new Character() {
                Id = Id,
                Name = Name,
                Profession = Profession,
                Race = Race,
                Strength = Strength,
                Intelligence = Intelligence,
                Agility = Agility,
                Constitution = Constitution,
                Charisma = Charisma,
                Description = Description,
            };
        }
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(Character.MaximumNameLength)]

        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(Character.MaximumNameLength)]


        public string Profession { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(Character.MaximumNameLength)]


        public string Race { get; set; }


        [Range(1, 100, ErrorMessage = "Value must be between 1 and 100.")]
        public int Strength { get; set; }

        [Range(1, 100, ErrorMessage = "Value must be between 1 and 100.")]
        public int Intelligence { get; set; }

        [Range(1, 100, ErrorMessage = "Value must be between 1 and 100.")]
        public int Agility { get; set; }

        [Range(1, 100, ErrorMessage = "Value must be between 1 and 100.")]
        public int Constitution { get; set; }

        [Range(1, 100, ErrorMessage = "Value must be between 1 and 100.")]
        public int Charisma { get; set; }

        [StringLength(Character.MaximumNameLength)]
        public string Description;

    }
}


