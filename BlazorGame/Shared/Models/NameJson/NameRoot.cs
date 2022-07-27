using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGame.Shared.Models.NameJson
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AlternativeCountries
    {
        public int US { get; set; }
        public int GB { get; set; }
        public int AU { get; set; }
        public int PL { get; set; }
    }

    public class Country
    {
        public string country_code { get; set; }
        public int country_certainty { get; set; }
        public string country_code_alpha { get; set; }
        public string name { get; set; }
        public string continent { get; set; }
        public string demonym { get; set; }
        public string primary_language_code { get; set; }
        public string primary_language { get; set; }
        public string currency { get; set; }
        public AlternativeCountries alternative_countries { get; set; }
    }

    public class Datum
    {
        public Salutation salutation { get; set; }
        public Name name { get; set; }
        public Email email { get; set; }
        public string password { get; set; }
        public Country country { get; set; }
    }

    public class Email
    {
        public string address { get; set; }
        public string username { get; set; }
        public string domain { get; set; }
        public Provider provider { get; set; }
        public bool business { get; set; }
    }

    public class Firstname
    {
        public string name { get; set; }
        public string name_ascii { get; set; }
        public bool validated { get; set; }
        public string gender { get; set; }
        public string gender_formatted { get; set; }
        public bool unisex { get; set; }
        public int gender_deviation { get; set; }
        public string country_code { get; set; }
        public int country_certainty { get; set; }
        public int country_rank { get; set; }
        public int country_frequency { get; set; }
        public AlternativeCountries alternative_countries { get; set; }
    }

    public class Lastname
    {
        public string name { get; set; }
        public string name_ascii { get; set; }
        public bool validated { get; set; }
        public string country_code { get; set; }
        public int country_certainty { get; set; }
        public int country_rank { get; set; }
        public int country_frequency { get; set; }
        public AlternativeCountries alternative_countries { get; set; }
    }

    public class Name
    {
        public Firstname firstname { get; set; }
        public Lastname lastname { get; set; }
    }

    public class Provider
    {
        public string name { get; set; }
        public string country_code { get; set; }
    }

    public class NameRoot
    {
        public int results { get; set; }
        public object error { get; set; }
        public List<Datum> data { get; set; }
    }

    public class Salutation
    {
        public string salutation { get; set; }
        public string initials { get; set; }
        public string lastname { get; set; }
    }

}
