namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Button
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Web;

    /// <summary>
    ///     Button component
    /// </summary>
    public partial class BcButton
    {
        private string _buttonDefaultCss = "bx--btn";
        private string _buttonKindDangerString = "bx--btn--danger";
        private string _buttonKindGhostString = "bx--btn--ghost";

        private string _buttonKindPrimaryString = "bx--btn--primary";
        private string _buttonKindSecondaryString = "bx--btn--secondary";
        private string _buttonKindTertiaryString = "bx--btn--tertiary";

        private string _buttonSizeDefaultString = string.Empty;
        private string _buttonSizeFieldString = "bx--btn--field";
        private string _buttonSizeSmallString = "bx--btn--small";
        private string _buttonType = string.Empty;

        private string _kindValue = string.Empty;
        private string _sizeValue = string.Empty;

        /// <summary>
        ///     Kind parameter which can be setup using <see cref="Button.Kind" />.
        ///     If it is not set up, then primary is the default value.
        /// </summary>
        [Parameter]
        public string Kind { get; set; }

        /// <summary>
        ///     Size parameter which can be setup using <see cref="Button.Size" />.
        ///     If it is not set up then Default is the default value.
        /// </summary>
        [Parameter]
        public string Size { get; set; }

        /// <summary>
        ///     IsDisable parameter.
        ///     If it is not set up, then Enabled is the default.
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; } = false;

        /// <summary>
        ///     ButtonType parameter.
        ///     If it is not set up, then button is the default.
        /// </summary>
        [Parameter]
        public ButtonType ButtonType { get; set; }

        /// <summary>
        ///     ChildContent of the component.
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        /// <summary>
        ///     Callback method of the component.
        /// </summary>
        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        /// <summary>
        ///     Whatever doesn't match will be taken care of by this.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object> UnknownParameters { get; set; }


        private void SetOrDefaultButtonType()
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

        private void SetOrDefaultSizeValue()
        {
            switch (Size)
            {
                case Button.Size.Default:
                    _sizeValue = _buttonSizeDefaultString;
                    break;

                case Button.Size.Field:
                    _sizeValue = _buttonSizeFieldString;
                    break;

                case Button.Size.Small:
                    _sizeValue = _buttonSizeSmallString;
                    break;

                default:
                    _sizeValue = _buttonSizeDefaultString;
                    break;
            }
        }

        private void SetOrDefaultKindValue()
        {
            switch (Kind)
            {
                case Button.Kind.Primary:
                    _kindValue = _buttonKindPrimaryString;
                    break;

                case Button.Kind.Secondary:
                    _kindValue = _buttonKindSecondaryString;
                    break;

                case Button.Kind.Tertiary:
                    _kindValue = _buttonKindTertiaryString;
                    break;

                case Button.Kind.Danger:
                    _kindValue = _buttonKindDangerString;
                    break;

                case Button.Kind.Ghost:
                    _kindValue = _buttonKindGhostString;
                    break;

                default:
                    _kindValue = _buttonKindPrimaryString;
                    break;
            }
        }

        private string GetCss()
        {
            SetOrDefaultKindValue();
            SetOrDefaultSizeValue();
            SetOrDefaultButtonType();

            return $"{_buttonDefaultCss} " +
                   $"{_kindValue} " +
                   $"{_sizeValue}";
        }
    }
}