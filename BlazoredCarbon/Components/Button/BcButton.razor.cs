namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Button
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Web;

    public partial class BcButton
    {
        [Parameter]
        public Kind Kind { get; set; }

        [Parameter]
        public Size Size { get; set; }

        [Parameter]
        public State State { get; set; }

        [Parameter]
        public ButtonType ButtonType { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        private string _kindValue = string.Empty;
        private string _sizeValue = string.Empty;
        private bool _stateValue = false;
        private string _buttonType = string.Empty;

        private string _buttonDefaultCss = "bx--btn";
        private string _buttonEnabledDisabledEnabledValueString = "enabled";
        private string _buttonEnabledDisabledDisabledValueString = "disabled";

        private string _buttonSizeDefaultString = string.Empty;
        private string _buttonSizeFieldString = "bx--btn--field";
        private string _buttonSizeSmallString = "bx--btn--small";

        private string _buttonKindPrimaryString = "bx--btn--primary";
        private string _buttonKindSecondaryString = "bx--btn--secondary";
        private string _buttonKindTertiaryString = "bx--btn--tertiary";
        private string _buttonKindDangerString = "bx--btn--danger";
        private string _buttonKindGhostString = "bx--btn--ghost";

        protected override async Task OnInitializedAsync()
        {
            await SetOrDefaultKindValue().ConfigureAwait(false);
            await SetOrDefaultSizeValue().ConfigureAwait(false);
            await SetOrDefaultStateValue().ConfigureAwait(false);
            await SetOrDefaultButtonType().ConfigureAwait(false);
        }

        private async Task SetOrDefaultButtonType()
        {
            switch (ButtonType)
            {
                case ButtonType.Button:
                    _buttonType = ButtonTypes.Button;
                    break;

                case ButtonType.Submit:
                    _buttonType = ButtonTypes.Submit;
                    break;

                default:
                    _buttonType = ButtonTypes.Button;
                    break;
            }
        }

        private async Task SetOrDefaultStateValue()
        {
            switch (State)
            {
                case State.Enabled:
                    _stateValue = false;
                    break;

                case State.Disabled:
                    _stateValue = true;
                    break;

                default:
                    _stateValue = false;
                    break;
            }
        }

        private async Task SetOrDefaultSizeValue()
        {
            switch (Size)
            {
                case Size.Default:
                    _sizeValue = _buttonSizeDefaultString;
                    break;

                case Size.Field:
                    _sizeValue = _buttonSizeFieldString;
                    break;

                case Size.Small:
                    _sizeValue = _buttonSizeSmallString;
                    break;

                default:
                    _sizeValue = _buttonSizeDefaultString;
                    break;
            }
        }

        private async Task SetOrDefaultKindValue()
        {
            switch (Kind)
            {
                case Kind.Primary:
                    _kindValue = _buttonKindPrimaryString;
                    break;

                case Kind.Secondary:
                    _kindValue = _buttonKindSecondaryString;
                    break;

                case Kind.Tertiary:
                    _kindValue = _buttonKindTertiaryString;
                    break;

                case Kind.Danger:
                    _kindValue = _buttonKindDangerString;
                    break;

                case Kind.Ghost:
                    _kindValue = _buttonKindGhostString;
                    break;

                default:
                    _kindValue = _buttonKindPrimaryString;
                    break;
            }
        }

        private string GetCss()
        {
            return $"{_buttonDefaultCss} " +
                   $"{_kindValue} " +
                   $"{_sizeValue}";
        }
    }
}