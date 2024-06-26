﻿using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class UserProfil
    {
        public int UserProfilId { get; set; }

        [MaxLength(20)]
        public string? Theme { get; set; }

        [MaxLength(100)]
        public string? NotifitacionPreferences { get; set; }

        //idegen kulcs (Foreign Key) felvétele
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
