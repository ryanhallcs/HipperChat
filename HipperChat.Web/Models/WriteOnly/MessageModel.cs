﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HipperChat.Web.Models.WriteOnly
{
    public class MessageModel
    {
        [AllowHtml]
        public string Message { get; set; }
        public bool IsHtml { get; set; }
        public bool SuchAnnoy { get; set; }
        public string Color { get; set; }
        public string ApiKey { get; set; }

        public List<RoomItem> Rooms { get; set; }
        public List<UserItem> Users { get; set; } 
        public List<EmoticonItem> Emoticons { get; set; }
    }

    public class RoomItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }

    public class EmoticonItem
    {
        public bool IsGlobal { get; set; }
        public string Code { get; set; }
        public string Url { get; set; }
    }

    public class UserItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MentionName { get; set; }
    }
}