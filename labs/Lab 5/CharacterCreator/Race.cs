/*
 * ITSE 1430
 * Character Creator
 * Kiet Vo
 * Lab 3
 */
using System;

namespace CharacterCreator
{
    public abstract class Race
    {
        #region Construction

        protected Race ( string name )
        {
            Name = name ?? "";
        }
        #endregion

        public string Name { get; }
    }
}
