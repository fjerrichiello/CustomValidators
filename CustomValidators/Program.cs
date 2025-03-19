// See https://aka.ms/new-console-template for more information

using CustomValidators;
using Dumpify;

var item = new DomainItem(true, null, DateOnly.FromDateTime(DateTime.Now));
var item2 = new SecondDomainItem(DateOnly.FromDateTime(DateTime.Today));

var wrapper = new ValidatorWrapper(item, item2);

var validator = new TestValidator();

var validator2 = new TestValidatorWrapper();

validator2.Validate(wrapper);


var result1 = validator.Validate(item);

result1.ToDictionary().Dump();