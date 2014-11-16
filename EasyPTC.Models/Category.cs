namespace EasyPTC.Models
{
    using EasyPTC.Data.Contracts;
    using System.ComponentModel.DataAnnotations;

    public class Category : DeletableEntity, IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsPublic { get; set; }

        public int MaxAds { get; set; }
    }
}
