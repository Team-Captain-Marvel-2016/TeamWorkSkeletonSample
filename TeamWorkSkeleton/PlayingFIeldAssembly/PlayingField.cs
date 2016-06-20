﻿namespace PlayingFIeldAssembly
{
    using GameLogicEventsAssembly;
    using System;

    public static class PlayingField
    {
        static  PlayingField()
        {
            Field = new bool[1, 1];

            ResetGameState.ResetGameEvent += OnResetEvent;
        }

        public static bool[,] Field { get; set; }

       private static void OnResetEvent(object sender, EventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}


