﻿namespace FootballTeamGenerator.Models
{
    public class Player
    {   
        //Stat min and max constants
        private const int minStatValue = 0;
        private const int maxStatValue = 100;

        //Argument exeptions
        private const string propertyStatArgumentExeption = "{0} should be between 0 and 100.";
        private const string propertyNameArgumentExeption = "A name should not be empty.";

        //Player stats fields
        private string name; 
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        
        public string Name
        {
            get => name;
            private set
            {   
                //Check for empty name
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(propertyNameArgumentExeption);
                }

                name = value;
            }
        }
        public int Endurance
        {
            get => endurance;
            private set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException(string.Format(propertyStatArgumentExeption, nameof(Endurance)));
                }
                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            private set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException(string.Format(propertyStatArgumentExeption, nameof(Sprint)));
                }
                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException(string.Format(propertyStatArgumentExeption, nameof(Dribble)));
                }
                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            private set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException(string.Format(propertyStatArgumentExeption, nameof(Passing)));
                }
                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                if (CheckStatValue(value))
                {
                    throw new ArgumentException(string.Format(propertyStatArgumentExeption, nameof(Shooting)));
                }
                shooting = value;
            }
        }

        //Get player average stats
        public double Stats => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;

        //Method for cheking invalid stat values
        private bool CheckStatValue(int value) => value < minStatValue || value > maxStatValue;
    }
}
