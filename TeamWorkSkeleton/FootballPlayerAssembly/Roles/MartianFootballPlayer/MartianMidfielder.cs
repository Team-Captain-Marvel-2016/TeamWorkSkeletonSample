﻿namespace FootballPlayerAssembly.RolesClasses.MartianFootballPlayer
{
    using FootballPlayerAssembly.SpeciesAbstractClasses;
    using TeamWork.Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MartianMidfielder : Martian
        {
            internal MartianMidfielder(TeamWork.Models.Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) 
                : base(player)
            {
            }

            internal MartianMidfielder(string name) : base(name)
            {
            }

            internal MartianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}