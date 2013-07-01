﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MonoGame.Framework;
using System;


namespace BattleCrittersMetro
{
    /// <summary>
    /// The root page used to display the game.
    /// </summary>
    public sealed partial class GamePage : SwapChainBackgroundPanel
    {
        readonly Game1 _game;

        public GamePage(string launchArguments)
        {
            this.InitializeComponent();

            // Create the game.
            try
            {
                _game = XamlGame<Game1>.Create(launchArguments, Window.Current.CoreWindow, this);
            }
            catch (Exception e)
            {
                string s = e.ToString();
                throw new Exception(s);
            }
        }
    }
}
