using System;
using System.Net;

namespace Tmpp
{
    // Builder pattern

    public class Members
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Nrtelefon { get; set; }
        public string Email { get; set; }
        public string Gen { get; set; }
        public string Data { get; set; }


    }




    class Members_builder
    {
        private readonly Members _members = new Members();



        public Members_builder Nume(string nume)
        {
            _members.Nume = nume;
            return this;
        }


        public Members_builder Prenume(string prenume)
        {
            _members.Prenume = prenume;
            return this;
        }


        public Members_builder Nr_telefon(string nrtelefon)
        {
            _members.Nrtelefon = nrtelefon;
            return this;
        }


        public Members_builder Email(string email)
        {
            _members.Email = email;
            return this;
        }


        public Members_builder Gen(string gen)
        {
            _members.Gen = gen;
            return this;
        }


        public Members_builder Data(string data)
        {
            _members.Data = data;
            return this;
        }


        Members Build()
        { 
            return _members;
        }
    }


       


}