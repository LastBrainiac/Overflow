using System.ComponentModel.DataAnnotations;

namespace QuestionService.Validators
{
    public class TagListValidator(int min, int max) : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is List<string> tags)
            {
                if (tags.Count >= min && tags.Count <= max)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult($"The number of tags must be between {min} and {max}. Current count: {tags.Count}");
                }
            }
            return new ValidationResult("Invalid tag list");
        }
    }
}
