namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System.Threading.Tasks;
    using Xunit;

    public class ButtonComponent_Kind_StateChange_Should
    {
        [Theory]
        [InlineData("Primary", "Secondary")]
        [InlineData("Primary", "Tertiary")]
        [InlineData("Primary", "Danger")]
        [InlineData("Primary", "Ghost")]
        [InlineData("Secondary", "Tertiary")]
        [InlineData("Secondary", "Danger")]
        [InlineData("Secondary", "Ghost")]
        [InlineData("Secondary", "Primary")]
        [InlineData("Tertiary", "Danger")]
        [InlineData("Tertiary", "Ghost")]
        [InlineData("Tertiary", "Primary")]
        [InlineData("Tertiary", "Secondary")]
        [InlineData("Danger", "Ghost")]
        [InlineData("Danger", "Primary")]
        [InlineData("Danger", "Secondary")]
        [InlineData("Danger", "Tertiary")]
        [InlineData("Ghost", "Primary")]
        [InlineData("Ghost", "Secondary")]
        [InlineData("Ghost", "Tertiary")]
        [InlineData("Ghost", "Danger")]
        public async Task ChangeKindState(
            string startState,
            string endState)
        {
        }
    }
}