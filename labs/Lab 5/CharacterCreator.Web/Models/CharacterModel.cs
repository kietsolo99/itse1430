/*
 * ITSE 1430
 * Character Roster
 * Kiet Vo
 * Lab 3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CharacterCreator.Web.Models
{
    public class CharacterModel /*: IValidatableObject*/
    {

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Profession { get; set; }

        public string Race { get; set; }


        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Agility { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }


        public string Description;


        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (String.IsNullOrEmpty(Name)) 
                yield return new ValidationResult("Name is required", new[] { nameof(Name) });

            if (Strength <= 0 && Strength > 100)
                yield return new ValidationResult("Values must be between 1 and 100", new[] { nameof(Strength) });

            if (Intelligence <= 0 && Intelligence > 100)
                yield return new ValidationResult("Values must be between 1 and 100", new[] { nameof(Intelligence) });

            if (Agility <= 0 && Agility > 100)
                yield return new ValidationResult("Values must be between 1 and 100", new[] { nameof(Agility) });

            if (Constitution <= 0 && Constitution > 100)
                yield return new ValidationResult("Values must be between 1 and 100", new[] { nameof(Constitution) });

            if (Charisma <= 0 && Charisma > 100)
                yield return new ValidationResult("Values must be between 1 and 100", new[] { nameof(Charisma) });
        }

    }
}


