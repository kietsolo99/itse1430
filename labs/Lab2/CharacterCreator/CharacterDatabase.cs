using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public class CharacterDatabase
    {
        public Character Add ( Character character, out string error )
        {
            error = "";

            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == null)
                {
                    var item = CloneCharacter(character);

                    item.Id = _id++;

                    _characters[index] = item;

                    character.Id = item.Id;
                    return character;

                };

            };

            error = "No more room";
            return null;
        }
        public void Delete ( int id )
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index]?.Id == id) 
                {
                    _characters[index] = null;
                    return;
                };
            };
        }
        public Character Get ( int id )
        {
            foreach (var character in _characters)
            {
                if (character?.Id == id)               
                    return CloneCharacter(character);
            };

            return null;
        }

        public Character[] GetAll ()
        {
            return _characters;
        }

        public string Update ( int id, Character character )
        {
            var existing = Get(id);
            if (existing == null)
                return "Character not found";

            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index]?.Id == id)  
                {
                    var item = CloneCharacter(character);

                    item.Id = id;
                    _characters[index] = item;
                    return "";
                };
            };

            return "";
        }

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
