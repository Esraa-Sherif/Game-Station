namespace GameStation.Attributes
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string _allowedExtensions;
        public AllowedExtensionsAttribute(string allowedExtensions)
        {
            _allowedExtensions = allowedExtensions;
        }
        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                var IsAllowed = _allowedExtensions.Split(separator: ',').Contains(extension, StringComparer.OrdinalIgnoreCase);
                if (!IsAllowed)
                {
                    return new ValidationResult(errorMessage: "$Only {_allowedExtensions} are allowed !");
                }
            }
            return ValidationResult.Success;
        }
    }
}
