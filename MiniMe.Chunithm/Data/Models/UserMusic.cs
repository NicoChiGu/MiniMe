﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniMe.Chunithm.Data.Models
{
    public class UserMusic : Protocols.UserMusic, IDbProfileObject
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        public Guid ProfileId { get; set; }

        public UserProfile Profile { get; set; }
    }
}
