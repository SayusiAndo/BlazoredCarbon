namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System.Threading.Tasks;
    using Xunit;

    public class ButtonComponent_Size_StateChange_Should
    {
        [Theory]
        [InlineData("Default", "Small")]
        [InlineData("Default", "Field")]
        [InlineData("Small", "Field")]
        [InlineData("Small", "Default")]
        [InlineData("Field", "Default")]
        [InlineData("Field", "Small")]
        public async Task BeDefault_ByDefault(
            string startState,
            string endState)
        {
        }
    }
}