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
    /// <summary>Represents a character.</summary>
    public class Character : IValidatableObject
    {
        /// <summary>Gets the maximum attribute value.</summary>
        public const int MaximumAttributeValue = 100;

        /// <summary>Gets the minimum attribute value.</summary>
        public const int MinimumAttributeValue = 1;

        public int Id { get; set; }


        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        /// <summary>Gets or sets the biography.</summary>
        public string Biography
        {
            get { return _bio ?? ""; }
            set { _bio = value; }
        }

        /// <summary>Gets or sets the profession.</summary>
        public Profession Profession { get; set; }

        /// <summary>Gets or sets the race.</summary>
        public Race Race { get; set; }

        /// <summary>Gets or sets the strength.</summary>
        public int Strength { get; set; }

        /// <summary>Gets or sets the intelligence.</summary>
        public int Intelligence { get; set; }

        /// <summary>Gets or sets the agility.</summary>
        public int Agility { get; set; }

        /// <summary>Gets or sets the constitution.</summary>
        public int Constitution { get; set; }

        /// <summary>Gets or sets the charisma.</summary>
        public int Charisma { get; set; }

        public override string ToString ()
        {
            return Name;
        }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (String.IsNullOrEmpty(Name))
            {
                //errorMessage = "Name is required";
                yield return new ValidationResult("Name is required", new[] { nameof(Name) });
            };

            if (Profession == null)
            {
                //errorMessage = "Profession is required";
                yield return new ValidationResult("Profession is required", new[] { nameof(Profession) });
            };

            if (Race == null)
            {
                //errorMessage = "Race is required";
                yield return new ValidationResult("Profession is required", new[] { nameof(Race) });
            };

            if (!ValidateAttribute(Strength))
            {
                //errorMessage = $"Strength must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                yield return new ValidationResult($"Strength must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Strength) });
            };
            if (!ValidateAttribute(Intelligence))
            {
                //errorMessage = $"Intelligence must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                yield return new ValidationResult($"Intelligence must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Intelligence) });
            };
            if (!ValidateAttribute(Agility))
            {
                //errorMessage = $"Agility must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                yield return new ValidationResult($"Agility must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Agility) });
            };
            if (!ValidateAttribute(Constitution))
            {
                //errorMessage = $"Constitution must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                yield return new ValidationResult($"Constitution must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Constitution) });
            };
            if (!ValidateAttribute(Charisma))
            {
                //errorMessage = $"Charisma must be between {MinimumAttributeValue} and {MaximumAttributeValue}";
                yield return new ValidationResult($"Charisma must be between {MinimumAttributeValue} and {MaximumAttributeValue}", new[] { nameof(Charisma) });
            };

            //errorMessage = null;
            //return true;            
        }

        #region Private Members
                
        private bool ValidateAttribute ( int value )
        {
            return (value >= MinimumAttributeValue) && (value <= MaximumAttributeValue);
        }
        
        private string _name, _bio;
        #endregion
    }
}
