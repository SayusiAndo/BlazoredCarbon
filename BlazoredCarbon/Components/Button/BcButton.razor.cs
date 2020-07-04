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
                    _sizeValue = ButtonCss.BxBtnSizeDefault;
                    break;

                case Button.Size.Field:
                    _sizeValue = ButtonCss.BxBtnSizeField;
                    break;

                case Button.Size.Small:
                    _sizeValue = ButtonCss.BxBtnSizeSmall;
                    break;

                default:
                    _sizeValue = ButtonCss.BxBtnSizeDefault;
                    break;
            }
        }

        private void SetOrDefaultKindValue()
        {
            switch (Kind)
            {
                case Button.Kind.Primary:
                    _kindValue = ButtonCss.BxBtnKindPrimary;
                    break;

                case Button.Kind.Secondary:
                    _kindValue = ButtonCss.BxBtnKindSecondary;
                    break;

                case Button.Kind.Tertiary:
                    _kindValue = ButtonCss.BxBtnKindTertiary;
                    break;

                case Button.Kind.Danger:
                    _kindValue = ButtonCss.BxBtnKindDanger;
                    break;

                case Button.Kind.Ghost:
                    _kindValue = ButtonCss.BxBtnKindGhost;
                    break;

                default:
                    _kindValue = ButtonCss.BxBtnKindPrimary;
                    break;
            }
        }

        private string GetCss()
        {
            SetOrDefaultKindValue();
            SetOrDefaultSizeValue();
            SetOrDefaultButtonType();

            return $"{ButtonCss.BxBtn} " +
                   $"{_kindValue} " +
                   $"{_sizeValue}";
        }
    }
}