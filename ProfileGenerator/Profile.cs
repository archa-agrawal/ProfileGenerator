using System;
namespace ProfileGenerator
{
	public class Profile
    {
		
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
        }

        public string ViewProfile()
        {
            string profileInfo = ($"Name : {this.name}, Age: {this.age}, City: {this.city}, country: {this.country}, hobbies: ");
            foreach (string hobby in this.hobbies)
            {
                profileInfo = profileInfo + hobby + ", ";
            }
            return profileInfo;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}

