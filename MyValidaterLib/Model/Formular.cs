namespace MyValidaterLib.Model
{
	public class Formular
	{
		private int _id;
		private string _firstName;
		private string _sirName;
		private string _street;
		private int _number;
		private int _zipCode;
		private string _city;
		private int _phone;
		private string _email;

		public Formular()
		{
			_id = 0;
			_firstName = "";
			_sirName = "";
			_street = "";
			_number = 0;
			_zipCode = 0;
			_city = "";
			_phone = 0;
			_email = "";
		}
		public Formular (int id, string firstName, string sirName, string street, int number, int zipCode, string city, int phone, string email)
		{
			_id = id;
			_firstName = firstName;
			_sirName = sirName;
			_street = street;
			_number = number;
			_zipCode = zipCode;
			_city = city;
			_phone = phone;
			_email = email;
		}

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}
		public string SirName
		{
			get { return _sirName; }
			set { _sirName = value; }
		}
		public string Street
		{
			get { return _street; }
			set { _street = value; }
		}
		public int Number
		{
			get { return _number; }
			set { _number = value; }
		}
		public int ZipCode
		{
			get { return _zipCode; }
			set { _zipCode = value; }
		}
		public string City
		{
			get { return _city; }
			set { _city = value; }
		}
		public int Phone
		{
			get { return _phone; }
			set { _phone = value; }
		}
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		public override string ToString()
		{
			return $"ID: {_id}, First Name: {_firstName}, Sir Name: {_sirName}, Street: {_street}, Number: {_number}, Zip Code: {_zipCode}, City: {_city}, Phone: {_phone}, Email: {_email}";
		}
	}
}
