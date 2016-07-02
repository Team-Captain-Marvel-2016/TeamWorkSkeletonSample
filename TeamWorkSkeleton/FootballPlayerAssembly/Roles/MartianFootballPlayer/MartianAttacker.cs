﻿namespace TeamWork.Models.Roles.MartianFootballPlayer
{
    using Global.Contracts;
    using Species.Abstract;

    public static partial class FootballPlayerFactory
    {
        internal class MartianAttacker : Martian
        {
            internal MartianAttacker(string name)
                : base(name)
            {
            }

            internal MartianAttacker(IFootballPlayer player) 
                : base(player)
            {
            }

            internal MartianAttacker(string name, int pass, int shoot, int dribble, int save, int tackle, int interception, int awareness, int actionPoints)
                : base(name, pass, shoot, dribble, save, tackle, interception, awareness, actionPoints)
            {
            }
        }
    }
}
