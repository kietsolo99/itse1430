/*
 * ITSE 1430
 * Character Roster
 * Kiet Vo
 * Lab 5
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
        public Character Add ( Character character)
        {

            if (character == null)
                throw new ArgumentNullException(nameof(character));  

            //Movie is valid
            ObjectValidator.ValidateFullObject(character);

            var existing = GetByName(character.Name);
            if (existing != null)
                throw new InvalidOperationException("Character must be unique");


            // Generalize errors
            try
            {
                return AddCore(character);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Add Failed", e);
            };
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

        public void Update ( int id, Character character )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero");
            if (character == null)
                throw new ArgumentNullException(nameof(character));

            ObjectValidator.ValidateFullObject(character);

            var existing = GetByName(character.Name);
            if (existing != null && existing.Id != id)
                throw new InvalidOperationException("Character must be unique");

            try
            {
                UpdateCore(id, character);
            } catch (Exception e)
            {
                //Throwing a new exception
                throw new InvalidOperationException("Update Failed", e);
            };
        }

        protected abstract Character AddCore ( Character character );

        protected abstract void DeleteCore ( int id );

        protected virtual Character GetByName ( string name ) => GetAll().FirstOrDefault(x => String.Compare(x.Name, name, true) == 0);

        protected abstract IEnumerable<Character> GetAllCore ();

        protected abstract Character GetByIdCore ( int id );

        protected abstract void UpdateCore ( int id, Character character );

    }
}

#endregion Old Codes


