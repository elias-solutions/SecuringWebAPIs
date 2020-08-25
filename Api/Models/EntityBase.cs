using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class EntityBase
    {
        [Key] public Guid Identifier { get; set; }
    }
}