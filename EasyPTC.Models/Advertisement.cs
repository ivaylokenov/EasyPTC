namespace EasyPTC.Models
{
    using EasyPTC.Data.Contracts;
    using System.ComponentModel.DataAnnotations;

    public class Advertisement : DeletableEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int AvailableClicks { get; set; }
    }
}
