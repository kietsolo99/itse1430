/*
 * ITSE 1430
 * Character Creator
 * Kiet Vo
 * Lab 3
 */
using System;

namespace CharacterCreator
{
    public abstract class Profession
    {
        #region Construction

        protected Profession ( string name )
        {
            Name = name ?? "";
        }
        #endregion

        public string Name { get; }
    }
}
