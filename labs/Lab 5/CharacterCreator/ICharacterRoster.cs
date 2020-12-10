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
    public interface ICharacterRoster
    {
        Character Add ( Character character);

        void Delete ( int id );

        Character Get ( int id );

        IEnumerable<Character> GetAll ();

        void Update ( int id, Character character );

    }
}