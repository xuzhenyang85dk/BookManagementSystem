using System;
namespace BookManagementSystem
{
	public class Book
	{
		// use auto properties and private set encapsulation
		public string _title { get; private set; }
		public string _author { get; private set; }
		public bool _isBorrowed { get; set; }

		// Constructor ensue init properties
		public Book(string title, string author)
		{
			_title = title;
			_author = author;
			_isBorrowed = false;
		}

		public string GetBookInfo()
		{
			string temp = _isBorrowed ? "Borrowed" : "Allow to borrow";
			return $"{_title} - {_author} - {temp} ";
		}
	}
}

