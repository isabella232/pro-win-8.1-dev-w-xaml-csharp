﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        private static readonly string[] firstNames = { "Adam", "Bob", "Carl", "David", "Edgar", "Frank", "George", "Harry", "Isaac", "Jesse", "Ken", "Larry" };
        private static readonly string[] lastNames = { "Aaronson", "Bobson", "Carlson", "Davidson", "Enstwhile", "Ferguson", "Harrison", "Isaacson", "Jackson", "Kennelworth", "Levine" };
        private static readonly string[] cities = { "Boston", "New York", "LA", "San Francisco", "Phoenix", "San Jose", "Cincinnati", "Bellevue" };

        public override string ToString()
        {
            return string.Format( "{0} {1} ({2})", FirstName, LastName, City );
        }

        public static IEnumerable<Person> CreatePeople( int count )
        {
            var people = new List<Person>();

            var r = new Random();

            for ( int i = 0; i < count; i++ )
            {
                var p = new Person()
                {
                    FirstName = firstNames[r.Next( firstNames.Length )],
                    LastName = lastNames[r.Next( lastNames.Length )],
                    City = cities[r.Next( cities.Length )]
                };
                people.Add( p );
            }
            return people;
        }


    }
}
