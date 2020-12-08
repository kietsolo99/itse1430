/*
 * ITSE 1430
 * Character Roster
 * Kiet Vo
 * Lab 3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CharacterCreator
{
    public class Character : IValidatableObject
    {

        public const int MaximumNameLength = 50;

        public readonly int MaximumDescriptionLength = 200;

        public int Id { get; set; }

        public string Name
        {
            get { return _name ?? ""; }

            set { _name = value; }
        }
        private string _name = "";

        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }
        private string _profession;

        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }
        private string _race;

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Agility { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }


        public string Description;

        public override string ToString ()
        {
            return Name;
        }

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


