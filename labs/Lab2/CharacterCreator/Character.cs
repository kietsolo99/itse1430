/*
 * ITSE 1430
 * Kiet Vo
 * Lab 2
 */
using System;

namespace CharacterCreator
{
    public class Character
    {

        public const int MaximumNameLength = 50;

        public readonly int MaximumDescriptionLength = 200;

        public int Id { get; set; }

        public string Name
        {
            get { return _name ?? "";}

            set { _name = value;}
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


        public string Validate ()
        { 
            if (String.IsNullOrEmpty(Name)) 
                return "Name is required";

            if (Strength <= 0 && Strength > 100)
                return "Values must be between 1 and 100";

            if (Intelligence <= 0 && Intelligence > 100)
                return "Values must be between 1 and 100";
            
            if (Agility <= 0 && Agility > 100)
                return "Values must be between 1 and 100";
            
            if (Constitution <= 0 && Constitution > 100)
                return "Values must be between 1 and 100";
            
            if (Charisma <= 0 && Charisma > 100)
                return "Values must be between 1 and 100";

            return null;
        }

        public override string ToString ()
        {
            return Name;
        }
    }
}
