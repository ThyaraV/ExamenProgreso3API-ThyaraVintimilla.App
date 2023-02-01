﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgreso3API_ThyaraVintimilla.TV_Models
{
    [Table("api")]
    public class TV_Root
    {

        //[PrimaryKey, AutoIncrement]
        public string word { get; set; }
        public Phonetic[] phonetics { get; set; }
        public Meaning[] meanings { get; set; }
        public License license { get; set; }
        public string[] sourceUrls { get; set; }

    }
    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string word { get; set; }
        public Phonetic[] phonetics { get; set; }
        public Meaning[] meanings { get; set; }
        public License license { get; set; }
        public string[] sourceUrls { get; set; }
    }



    public class License
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Phonetic
    {
        public string audio { get; set; }
        public string sourceUrl { get; set; }
        public License1 license { get; set; }
        public string text { get; set; }
    }

    public class License1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Meaning
    {
        public string partOfSpeech { get; set; }
        public Definition[] definitions { get; set; }
        public string[] synonyms { get; set; }
        public string[] antonyms { get; set; }
    }

    public class Definition
    {
        public string definition { get; set; }
        public object[] synonyms { get; set; }
        public object[] antonyms { get; set; }
        public string example { get; set; }
    }
}
