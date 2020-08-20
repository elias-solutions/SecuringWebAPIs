namespace Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        [Key] public Guid Identifier { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
    }
}
