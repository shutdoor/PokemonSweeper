﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSweeper.Game.Field.Game
{
    public class PokeSweepGame
    {
        private int scoreValue;

        public int Score
        {
            get { return scoreValue; }
            set { scoreValue = value; }
        }

        private List<Field.Pokemon.Pokemon> pokemonValue;

        public List<Field.Pokemon.Pokemon> Pokemon
        {
            get { return pokemonValue; }
            set { pokemonValue = value; }
        }

        private int levelValue;

        public int Level
        {
            get { return levelValue; }
            set { levelValue = value; }
        }
        

        public int CalculateNewScore(System.Diagnostics.Stopwatch timer, int clicks, List<Field.Pokemon.Pokemon> pokemon)
        {
            int newPokemon = 0;
            foreach (Field.Pokemon.Pokemon monster in pokemon.Where(m => Pokemon.Contains(m))) newPokemon++;
            return (int)((newPokemon * 10000 + 1000 - clicks) / (timer.Elapsed.TotalSeconds + clicks));
        }

        public PokeSweepGame()
        {
            Level = 1;
            Pokemon = new List<Pokemon.Pokemon>();
            Score = 0;
        }
        
        
    }
}