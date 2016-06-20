﻿using System.Windows.Controls;
using VisualizationAssembly.CanvasUtilsClasses;

namespace _00_TestingClassesAssembly.WPFCanvasTestingClasses
{
    using PlayerAssembly.HumanPlayerClass.PlayerOneSingletonClass;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using VisualizationAssembly.Enumerations;
    using VisualizationAssembly.InitPlayingFieldClasses;

    public static class WpfCanvasInitialStateTesting
    {
        public static void Test_01(Canvas canvas)
        {
            // Create a team
            PlayerOne.CreatePlayerOne("name", "teamname");
            PlayerOne.Player.CreateTeam("myTeam");
            
            // Get team positions
            InitTeamVisualization.GetInitialFootballPlayerPositions
                (PlayerOne.Player.Team, StartingFieldType.Left);

            // Add all FootballPlayer objects as 
            // children to PlayingField Canvas

            foreach (var player in PlayerOne.Player.Team)
            {
                CanvasChildrenUtilities.AddChild(canvas, player);
            }

            // Draw
        }


    }
}