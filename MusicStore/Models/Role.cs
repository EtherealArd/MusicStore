using System;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}