using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Person
    {
        public int Year {  get; set; }
        public string Name {  get; set; }
        public Person(int year, string name) {
            Year = year;
            Name = name;
        } 
    }
    class Son : Person
    {
        private int _IQ {  get; set; }
        public Son(int year, string name, int  IQ): base(year, name) {
            _IQ = IQ;
        }
    }
    class Daughter : Person
    {
        private string _FavoritePony {  get; set; }
        public Daughter(int year, string name, string favoritePony): base(year, name) {

            _FavoritePony = favoritePony;
        }

    }
    internal class Start
    {
       public Start() {
            Person person = new Person(34, "Bob");
            Son son = new Son(12, "Nick", 360);
            Daughter daughter = new Daughter(10, "Mary", "Rainbow Dash");
        } 
    }
}
