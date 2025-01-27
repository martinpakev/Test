using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Comment("House identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("Title")]
        public string Title {  get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image url")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("Montly price")]
        [Column(TypeName = "decimal(18,2)")]
        //[Range(typeof(decimal), HouseRentingPriceMin, HouseRentingPriceMax, ConvertValueInInvariantCulture = true)]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("Category Identifier")]
        public int CategoryId  { get; set; }

        [Required]
        [Comment("Agent Identifier")]
        public int AgentId { get; set; }

        [Comment("Renter Identifier")]
        public string? RenterId  { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;


        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;
    }
}
