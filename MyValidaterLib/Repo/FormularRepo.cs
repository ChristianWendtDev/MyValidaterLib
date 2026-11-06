using System;
using System.Collections.Generic;
using System.Text;
using MyValidaterLib.Model;


namespace MyValidaterLib.Repo
{
	public class FormularRepo
	{
		private List<Formular> _formulars;

		public FormularRepo()
		{
			_formulars = new List<Formular>();
		}
		public FormularRepo(List<Formular> formulars)
		{
			_formulars = formulars;
		}
		public List<Formular> Formulars
		{
			get { return _formulars; }
			set { _formulars = value; }
		}

		public Formular GetById(int id)
		{
			foreach (var formular in _formulars)
			{
				if (_formulars.IndexOf(formular) == id)
				{
					return formular;
				}

			}
			return null;
		}

		public Formular Add(Formular formular)
		{
			_formulars.Add(formular);
			return formular;
		}

		public Formular Delete(int id)
		{
			Formular formular = GetById(id);
			if (formular != null)
			{
				_formulars.Remove(formular);
				return formular;
			}
			return null;
		}

		public Formular Update(Formular formular)
		{
			Formular UpdatedFormular = GetById(formular.Id);
			if (UpdatedFormular != null);
			{
				UpdatedFormular.FirstName = formular.FirstName;
				UpdatedFormular.SirName = formular.SirName;
				UpdatedFormular.Street = formular.Street;
				UpdatedFormular.Number = formular.Number;
				UpdatedFormular.ZipCode = formular.ZipCode;
				UpdatedFormular.City = formular.City;
				UpdatedFormular.Phone = formular.Phone;
				UpdatedFormular.Email = formular.Email;


			}
			return UpdatedFormular;
		}

		public List<Formular> ReadAll()
		{
			return new List<Formular>(_formulars);
		}
	}	
}
