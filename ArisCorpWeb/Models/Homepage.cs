﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{

    public class HomeRootobject
    {
        public HomeAPI data { get; set; }
    }

    public class HomeAPI
    {
        public int id { get; set; }
        public About_Ariscorp about_ariscorp { get; set; }
        public Ariscorp_History ariscorp_history { get; set; }
        public Ariscorp_Manifest ariscorp_manifest { get; set; }
        public Ariscorp_Charta ariscorp_charta { get; set; }
        public Ariscorp_Member[] ariscorp_member { get; set; }
        public Ariscorp_Partner[] ariscorp_partner { get; set; }
        public Ariscorp_Gameplays[] ariscorp_gameplays { get; set; }
    }

    public class About_Ariscorp
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime date_updated { get; set; }
        public string about_ariscorp { get; set; }
    }

    public class Ariscorp_History
    {
        public int id { get; set; }
        public string status { get; set; }
        public DateTime date_updated { get; set; }
        public string ariscorp_history { get; set; }
    }

    public class Ariscorp_Manifest
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime date_updated { get; set; }
        public string manifest { get; set; }
    }

    public class Ariscorp_Charta
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public string charta { get; set; }
    }

    public class Ariscorp_Member
    {
        public string name { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime date_updated { get; set; }
        public string titel { get; set; }
        public string steckbrief { get; set; }
        public string bio { get; set; }
        public string potrait { get; set; }
        public string[] rollen { get; set; }
    }

    public class Ariscorp_Partner
    {
        public int id { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
        public string date_created { get; set; }
        public string partner_logo { get; set; }
        public string partner_name { get; set; }
        public string partner_website { get; set; }
    }

    public class Ariscorp_Gameplays
    {
        public string gameplay { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime date_updated { get; set; }
        public string gameplay_beschreibung { get; set; }
        public string bild1 { get; set; }
        public string bild2 { get; set; }
        public string gameplay_logo { get; set; }
        public object test { get; set; }
    }

}
