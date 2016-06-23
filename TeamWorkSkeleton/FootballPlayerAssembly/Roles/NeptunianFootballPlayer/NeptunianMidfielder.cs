﻿namespace TeamWork.Models.Roles.NeptunianFootballPlayer
{
    using Models.Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class NeptunianMidfielder : Neptunian
        {
            internal NeptunianMidfielder(string name)
                : base(name)
            {
            }

            internal NeptunianMidfielder(Factory.Models.Generic.FootballPlayerFactory.GenericFootballPlayer player) : base(player)
            {
            }

            internal NeptunianMidfielder(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints) 
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}