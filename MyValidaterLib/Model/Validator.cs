using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyValidaterLib.Model
{
	public class Validator
	{
		public bool ValidateFirstName(string name)
		{
			// Ensure that the name only contains letters and is not empty
			string pattern = @"^[A-Za-z]+$";

			Regex reg = new Regex(pattern);
			return reg.IsMatch(name);
		}


		public bool ValidateSirName(string name)
		{
			// Ensure that the surname only contains letters, spaces, hyphens, and apostrophes, and is not empty
			string pattern = @"^[A-Za-z]+(?:[ '-][A-Za-z]+)*$";
			Regex reg = new Regex(pattern);
			return reg.IsMatch(name);
		}


		public bool ValidateStreet(string street)
		{
			// ensure that the street name only contains letters, numbers, and spaces, and is not empty
			string pattern = @"^[A-Za-z0-9\s]+$";
			Regex reg = new Regex(pattern);
			return reg.IsMatch(street);
		}

		// ensure that the number is a positive integer
		public bool ValidateNumber(int number){
			string pattern = @"^[A-Za-z0-9\s]+$";
			Regex reg = new Regex(pattern);
			return reg.IsMatch(number.ToString());
		}

		// ensure that the zip code is a 4-digit number
		public bool ValidateZipCode(int zipCode)
		{
			string pattern = @"^\d{4}$";
			Regex reg = new Regex(pattern);
			return reg.IsMatch(zipCode.ToString());
		}
		// ensure that the city name only contains letters and is not empty
		public bool ValidateCity(string city){
			string pattern = @"^[A-Za-z]+$";
			Regex reg = new Regex(pattern);
			return reg.IsMatch(city);
		}
		// ensure that the phone number is a 10-digit number
		public bool ValidatePhone(int phone)
		{
			string pattern = @"^\d{10}$";
			Regex reg = new Regex(pattern);
			return reg.IsMatch(phone.ToString());
		}
		// ensure that the email address is in a valid format
		public bool ValidateEmail(string email)
		{
			string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			Regex reg = new Regex(pattern);
			return reg.IsMatch(email);
		}

	}
}