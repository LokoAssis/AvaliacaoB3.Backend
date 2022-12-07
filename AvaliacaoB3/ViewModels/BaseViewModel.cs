using FluentValidation.Results;

namespace AvaliacaoB3.ViewModels
{
    public class BaseViewModel
    {
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        public BaseViewModel() => ValidationResult = new ValidationResult();
    }
}
