// Testfile.cs:

[TestCase("0")]
[TestCase("asdqwdwd")]
[TestCase("")]
[TestCase("@#$%^&")]
public void NegativeLogin(string value)
{
TestFile firstPage = new TestFile(Driver);
firstPage.Login(user, pass);
Assert.IsTrue(Driver.PageSource.Contains("Please enter an integer"));
//OR LIKE THIS
// Assert.AreEqual(Driver.FindElement(By.Id(“resultDiv”)), “Please enter an integer”));