/*
 * ITSE 1430
 * Character Roster
 * Kiet Vo
 * Lab 3
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

#region
namespace CharacterCreator
{
    public abstract class CharacterRoster : ICharacterRoster
    {
        public Character Add ( Character character, out string error )
        {

            var results = new ObjectValidator().TryValidateFullObject(character);
            if (results.Count() > 0)
            {
                foreach (var result in results)
                {
                    error = result.ErrorMessage;
                    return null;
                };
            };

            var existing = GetByName(character.Name);
            if (existing != null)
            {
                error = "Character must be unique";
                return null;
            };

            error = null;
            return AddCore(character);
        }

        public void Delete ( int id )
        {

            DeleteCore(id);
        }

        public IEnumerable<Character> GetAll ()
        {
            return GetAllCore();
        }
        public Character Get ( int id )
        {

            return GetByIdCore(id);
        }


        public string Update ( int id, Character character )
        {
            var results = new ObjectValidator().TryValidateFullObject(character);
            if (results.Count() > 0)
            {
                foreach (var result in results)
                {
                    return result.ErrorMessage;
                };
            };

            var existing = GetByName(character.Name);
            if (existing != null && existing.Id != id)
                return "Character must be unique";

            UpdateCore(id, character);

            return "";
        }

        protected abstract Character AddCore ( Character character );

        protected abstract void DeleteCore ( int id );

        protected virtual Character GetByName ( string name )
        {
            foreach (var character in GetAll())
            {
                if (String.Compare(character.Name, name, true) == 0)
                    return character;
            };

            return null;
        }

        protected abstract IEnumerable<Character> GetAllCore ();

        protected abstract Character GetByIdCore ( int id );

        protected abstract void UpdateCore ( int id, Character character );
        private Character CloneCharacter ( Character character )
        {
            var item = new Character();
            item.Id = character.Id;
            item.Name = character.Name;
            item.Profession = character.Profession;
            item.Race = character.Race;
            item.Strength = character.Strength;
            item.Intelligence = character.Intelligence;
            item.Agility = character.Agility;
            item.Constitution = character.Constitution;
            item.Charisma = character.Charisma;
            item.Description = character.Description;

            return item;
        }

        private Character[] _characters = new Character[100];
        private int _id = 1;

    }
}

#endregion Old Codes


