﻿namespace GameStation.Attributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }
        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;

            if (file is not null)
            {

                if (file.Length > _maxFileSize)
                {
                    return new ValidationResult(errorMessage: "$Maximum Allowed Size is {_maxFileSize} Bytes !");
                }
            }
            return ValidationResult.Success;
        }
    }
}
