﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdas
{
    class Program
    {
        public class Author
{
    private string name;
    private short age;
    private string title;
    private bool mvp;
    private DateTime pubdate;
    public delegate string dele(Author input);
    public Author(string name, short age, string title, bool mvp, DateTime pubdate)
    {
        this.name = name;
        this.age = age;
        this.title = title;
        this.mvp = mvp;
        this.pubdate = pubdate;
    }
  
    public string Name
    {
        get { return name;  }
        set { name = value; }
    }
  
    public short Age
    {
        get { return age; }
        set { age = value; }
    }
    public string BookTitle
    {
        get { return title; }
        set { title = value; }
    }
    public bool IsMVP
    {
        get { return mvp; }
        set { mvp = value; }
    }
    public DateTime PublishedDate
    {
        get { return pubdate; }
        set { pubdate = value; }
    }
}
        static void Main(string[] args)
        {
            List<Author> AuthorList = new List<Author>();
            AuthorList.Add(new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)));
            AuthorList.Add(new Author("Neel Beniwal", 18, "Graphics Development with C#", false, new DateTime(2010, 2, 22)));
            AuthorList.Add(new Author("Praveen Kumar", 28, "Mastering WCF", true, new DateTime(2012, 01, 01)));
            AuthorList.Add(new Author("Mahesh Chand", 35, "Graphics Programming with GDI+", true, new DateTime(2008, 01, 20)));
            AuthorList.Add(new Author("Raj Kumar", 30, "Building Creative Systems", false, new DateTime(2011, 6, 3)));

        }
        public delegate int Comparison<in T>(T left, T right);
    }
}
