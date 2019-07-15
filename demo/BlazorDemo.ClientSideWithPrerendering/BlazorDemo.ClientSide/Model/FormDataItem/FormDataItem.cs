using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Blazor.Model {
    public class FormDataItem {
        [Required]
        [Display(Name = "Public name")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }

        [Range(typeof(DateTime), "01/01/1945", "01/01/2000")]
        [DisplayFormat(DataFormatString = "dd MMMM yyyy")]
        public DateTime? Birthday { get; set; }

        [DataType(DataType.MultilineText)]
        [DisplayFormat(NullDisplayText = "N/A")]
        [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Text is too long")]
        public string Notes { get; set; }

        [Range(0, 10, ErrorMessage = "{0} must be a decimal/number between {1} and {2}.")]
        public int Worked { get; set; }

        [Display(Name = "Position")]
        public string Position { get; set; }
    }
}