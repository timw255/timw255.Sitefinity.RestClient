using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class ValidatorDefinition : DefinitionBase
    {
        public string AlphaNumericViolationMessage { get; set; }
        public Collection<ComparingValidatorDefinition> ComparingValidatorDefinitions { get; set; }
        public string CurrencyViolationMessage { get; set; }
        public string EmailAddressViolationMessage { get; set; }
        public ValidationFormat ExpectedFormat { get; set; }
        public string IntegerViolationMessage { get; set; }
        public string InternetUrlViolationMessage { get; set; }
        public int MaxLength { get; set; }
        public string MaxLengthViolationMessage { get; set; }
        public object MaxValue { get; set; }
        public string MaxValueViolationMessage { get; set; }
        public string MessageCssClass { get; set; }
        public string MessageTagName { get; set; }
        public int MinLength { get; set; }
        public string MinLengthViolationMessage { get; set; }
        public object MinValue { get; set; }
        public string MinValueViolationMessage { get; set; }
        public string NonAlphaNumericViolationMessage { get; set; }
        public string NumericViolationMessage { get; set; }
        public string PercentageViolationMessage { get; set; }
        public string RegularExpression { get; set; }
        public string RegularExpressionSeparator { get; set; }
        public string RegularExpressionViolationMessage { get; set; }
        public bool? Required { get; set; }
        public string RequiredViolationMessage { get; set; }
        public string ResourceClassId { get; set; }
        public string USSocialSecurityNumberViolationMessage { get; set; }
        public string USZipCodeViolationMessage { get; set; }
        public bool? ValidateIfInvisible { get; set; }

        public ValidatorDefinition() { }
    }
}
