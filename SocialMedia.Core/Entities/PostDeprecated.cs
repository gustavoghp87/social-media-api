﻿using System;

namespace SocialMedia.Core.Entities
{
    public class PostDeprecated
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
