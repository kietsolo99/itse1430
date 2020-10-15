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

        public string Name;
        //{
        //    get {
        //        return _name ?? "";
        //    }

        //    set {
        //        _name = value;
        //    }
        //}
        //private string _name = "";

        public string Profession;
        //{
        //    get { return _profession ?? ""; }
        //    set { _profession = value; }
        //}
        //private string _profession = "";


        public string Race;
        //{
        //    get { return _race ?? ""; }
        //    set { _race = value; }
        //}
        //private string _race = "";


        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Agility { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }


        public string Description;
        //{
        //    get { return _description ?? ""; }
        //    set { _description = value; }
        //}
        //private string _description = "";

        public string Validate ()
        { 
            if (String.IsNullOrEmpty(Name)) 
                return "Name is required";

            return null;
        }

    }
}
