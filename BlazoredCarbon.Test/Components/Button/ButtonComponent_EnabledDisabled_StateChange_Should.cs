namespace SayusiAndo.BlazoredCarbon.Test.Components.Button
{
    using System.Threading.Tasks;
    using Xunit;

    // ReSharper disable once InconsistentNaming
    public class ButtonComponent_EnabledDisabled_StateChange_Should
    {
        [Theory]
        [InlineData("enabled", "disabled")]
        [InlineData("disabled", "enabled")]
        public async Task Change_EnabledDisabledState(
            string startState,
            string endState)
        {
        }
    }
}