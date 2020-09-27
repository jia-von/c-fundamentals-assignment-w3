using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Fundamentals_Assignment_W3
{
	public class Allergies
	{
		// do not alter this enum
		[Flags]
		public enum Allergen
		{
			Eggs = 1,           //eggs*2^0
			Peanuts = 2,		//eggs*2^1
			Shellfish = 4,		//eggs*2^2
			Strawberries = 8,   //eggs*2^3
			Tomatoes = 16,      //eggs*2^4
			Chocolate = 32,     //eggs*2^5
			Pollen = 64,        //eggs*2^6
			Cats = 128          //eggs*2^7
		}

		// write your code below this line

		// constructors 

		public Allergies(string name)
		{
			Name = name;
			Score = 0;
		}
		public Allergies(string name, int score)
		{
			Name = name;
			Score = score;
		}

		public Allergies(string name, string allergen)
		{
			Name = name;
			Irritants = allergen.Split(' ').Distinct().ToArray(); //How to split string: https://stackoverflow.com/questions/3676261/how-to-split-text-value-into-array-with-words-in-c

            foreach (string irritant in Irritants)//Tally up the score when the string matches the allergen
            {
				switch (irritant)
                {
					case "Egg":
						Score += 1;
						break;
					case "Peanuts":
						Score += 2;
						break;
					case "Shellfish":
						Score += 4;
						break;
					case "Strawberries":
						Score += 8;
						break;
					case "Tomatoes":
						Score += 16;
						break;
					case "Chocolate":
						Score += 32;
						break;
					case "Pollen":
						Score += 64;
						break;
					case "Cats":
						Score += 128;
						break;
				}	
            }
		}
		// properties
		public string Name { get; } // the neme of the person
		private int _score;
        public int Score
        {
            get
            {
				return _score;
            }
            protected set
            {
				if(value > 255)
                {
					_score = 255;
                }else
				if(value < 0)
                {
					_score = 0;
                }
                else
                {
					_score = value;
				}

            }
        }
		public string[] Irritants { get; set; }

        //methods

        public override string ToString()
        {
            //to find out the allergen based on the Score
			

			// add code here to return string representation of this instance
			return $"{Name} has no allergies!";
		}

		public bool IsAllergicTo(int allergen)
		{
			while(Score/allergen>1)
            {
				Score = Score - allergen;
            }
			if(Score/allergen == 1)
            {
				return true;
            }
			return false;
		}

		public void IsAllergicTo(string allergen)
		{

		}

		public void AddAllergy(string allergen)
		{
			switch (allergen)
			{
				case "Egg":
					Score = 1;
					break;
				case "Peanuts":
					Score = 2;
					break;
				case "Shellfish":
					Score = 4;
					break;
				case "Strawberries":
					Score = 8;
					break;
				case "Tomatoes":
					Score = 16;
					break;
				case "Chocolate":
					Score = 32;
					break;
				case "Pollen":
					Score = 64;
					break;
				case "Cats":
					Score = 128;
					break;
			}
		}

		public void AddAllergy(Allergen allergen)
		{
			Score += (int)allergen;
		}

		public void DeleteAllergy(string allergen)
		{
			switch (allergen)
			{
				case "Egg":
					Score -= 1;
					break;
				case "Peanuts":
					Score -= 2;
					break;
				case "Shellfish":
					Score -= 4;
					break;
				case "Strawberries":
					Score -= 8;
					break;
				case "Tomatoes":
					Score -= 16;
					break;
				case "Chocolate":
					Score -= 32;
					break;
				case "Pollen":
					Score -= 64;
					break;
				case "Cats":
					Score -= 128;
					break;
			}
		}

		public void DeleteAllergy(Allergen allergen)
		{
			Score -= (int)allergen;
		}


	}
}
