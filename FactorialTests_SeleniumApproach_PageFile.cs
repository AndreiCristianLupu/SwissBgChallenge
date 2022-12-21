// ’m naturally using the Page Object design pattern, although some SOLID principles are not
// very well applied..it is still the best pattern for our needs so far. I’m going to write only the core
// for every file (I suppose I don’t have to send something that can be compiled, there’ll be lots of
// files and libraries for no reason)
// Pagefile.cs:


[FindsBy(How = How.Id, Using = "number")]
private IWebElement InputField { get; set; }
[FindsBy(How = How.Id, Using = "getFactorial")]
private IWebElement Calculate { get; set; }
public void CalculateFactorialOf (string x)
{
InputField.SendKeys(x);
Calculate.Click();
}
