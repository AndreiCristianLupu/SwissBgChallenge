// Let’s assume this is the factorial function, inside the Factorial class - even if it should have some
// limitations/validations for [10, 10000] range and also long values instead of int/float. But we are
// here to test it, so who cares 🙂

public float CalculateFactorial(int x)
{
if (x < 2)
return 1;
return x * CalculateFactorial(x-1);
}
[TestMethod]
public void TenFactorial_resultsIn3MilsAndSo()
{
Factorial calculator = new Factorial();
float result = calculator.CalculateFactorial(0);
Assert.AreEqual(3628800, result);
}



[TestMethod]
public void TenFactorial_resultsIn3MilsAndSo()
{
Factorial calculator = new Factorial();
float result = calculator.CalculateFactorial(0);
Assert.AreEqual(3628800, result);
}

//We can for the positive case to write some others tests with good values, using equivalence
//partitioning, but we know that 170 is the real deal and biggest value for Factorials so we’ll test
//only for 10, 11, 50, 120, 169
[TestMethod]
public void NineFactorial_resultsShouldNotBeCalculatedInTheApp()
{
Factorial calculator = new Factorial();
float result = calculator.CalculateFactorial(9);
Assert.AreNotEqual(362880, result);

//OR LIKE THIS
//StringAssert.Contains(result.Text, “We cannot calculate for values lower than 10”);
//Assuming that CalculateFactorial has exception handlers for these cases (<10 and >10k)
//For a mix of negative and positive testing we are going to use boundary value analysis and
//test negative values such as 9 and 10001, and good values such as 10, 11 and 9999, 10000
//(with the mention for the last two to have infinity result)

}
[TestMethod]
public void One_Seven_ZeroFactorial_resultsInInfinity()
{
Factorial calculator = new Factorial();
float result = calculator.CalculateFactorial(170);
float pos_inf = 1 / 0; //this is the representation of positive infinity in c#
Assert.AreEqual(pos_inf, result);

//again, assuming that CalculateFactorial has exception handler for 170 case
//All values above 170 should be treated exactly like this, so we can write some other tests for
//9999, 10k
}