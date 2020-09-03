using System;
using System.Collections.Generic;
using System.Text;

namespace C_Fundamentals_Assignment_W3
{
	public class Allergies
	{
		// do not alter this enum
		[Flags]
		public enum Allergen
		{
			Eggs = 1,			
			Peanuts = 2,	
			Shellfish = 4,		
			Strawberries = 8,	
			Tomatoes = 16,		
			Chocolate = 32,		
			Pollen = 64,		
			Cats = 128			
		}

        // write your code below this line

        // constructors 

		public Allergies(string name, int score)
		{
			Name = name;
			Score = score;
		}

		public Allergies(string name, string allergen)
		{
			Name = name;
			Irritants = allergen.Split(' '); //How to split string: https://stackoverflow.com/questions/3676261/how-to-split-text-value-into-array-with-words-in-c

            foreach (string irritant in Irritants)
            {
				switch (irritant)
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
				_score += value;
            }
        }
		public string[] Irritants { get;}

        //methods
        public override string ToString()
        {
            // add code here to return string representation of this instance
            return base.ToString();
        }

        public void IsAllergicTo(Allergen allergen)
		{

		}

		public void IsAllergicTo(string allergen)
		{

		}

		public void AddAllergy(string allergen)
		{

		}

		public void AddAllergy(Allergen allergen)
		{

		}

		public void DeleteAllergy(string allergen)
		{

		}

		public void DeleteAllergy(Allergen allergen)
		{

		}


	}
}
