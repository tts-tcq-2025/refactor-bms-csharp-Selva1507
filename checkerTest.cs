using Xunit;

public class CheckerTests
{
    [Fact]
    public void NotOkWhenAnyVitalIsOffRange()
    {
        Assert.False(Checker.IsAllVitals_OK(99f, 102, 70));
        Assert.True(Checker.IsAllVitals_OK(98.1f, 70, 98));
    }

}
