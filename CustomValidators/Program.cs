// See https://aka.ms/new-console-template for more information

using CustomValidators;
using Dumpify;

var item = new DomainItem(true);
var item2 = new DomainItem(false);

var validator = new TestValidator();

var result1 = validator.Validate(item);
var result2 = validator.Validate(item2);

result1.ToDictionary().Dump();
result2.ToDictionary().Dump();