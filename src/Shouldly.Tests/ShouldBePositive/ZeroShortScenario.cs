namespace Shouldly.Tests.ShouldBePositive;

public class ZeroShortScenario
{
    [Fact]
    public void ZeroShortScenarioShouldFail()
    {
        short val = 0;
        Verify.ShouldFail(() =>
                val.ShouldBePositive("Some additional context"),

            errorWithSource:
            """
            val
                should be positive but
            0
                is negative

            Additional Info:
                Some additional context
            """,

            errorWithoutSource:
            """
            0
                should be positive but is negative

            Additional Info:
                Some additional context
            """);
    }
}