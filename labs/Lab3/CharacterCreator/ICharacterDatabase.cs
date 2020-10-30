/*
 * ITSE 1430
 * Character Roster
 * Kiet Vo
 * Lab 3
 */
using System;
using System.Collections.Generic;

namespace CharacterCreator
{
    public interface ICharacterDatabase
    {
        Character Add ( Character character, out string error );

        void Delete ( int id );

        Character Get ( int id );

        IEnumerable<Character> GetAll ();

        string Update ( int id, Character character );
    }
}