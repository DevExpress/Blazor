using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Pages.Editors.Common.Models;

public class Starship {
    [Required(ErrorMessage = "The Identifier value should be specified.")]
    [StringLength(16, ErrorMessage = "The Identifier exceeds 16 characters.")]
    public string Identifier { get; set; }

    [Range(1, 3, ErrorMessage = "The Primary Classification value should be specified.")]
    public int Classification { get; set; }

    [Range(1, 100000, ErrorMessage = "The Maximum Accommodation value should be a number between 1 and 100,000.")]
    public int MaximumAccommodation { get; set; }

    [Required]
    [DateInPast(ErrorMessage = "The Production Date value cannot be later than today.")]
    public DateTime ProductionDate { get; set; }

    [Required(ErrorMessage = "The Description should be specified.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "You need an engine to fly."), EnumDataType(typeof(Engine))]
    public Engine? Engine { get; set; }
}
