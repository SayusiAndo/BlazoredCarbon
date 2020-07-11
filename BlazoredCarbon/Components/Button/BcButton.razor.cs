namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Button
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Web;

    /// <summary>
    ///     BcButton component
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
        public string ButtonTypes { get; set; }

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
            switch (ButtonTypes)
            {
                case HtmlElements.ButtonTypes.Button:
                    _buttonType = HtmlElements.ButtonTypes.Button;
                    break;

                case HtmlElements.ButtonTypes.Submit:
                    _buttonType = HtmlElements.ButtonTypes.Submit;
                    break;

                default:
                    _buttonType = HtmlElements.ButtonTypes.Button;
                    break;
            }
        }

        private void SetOrDefaultSizeValue()
        {
            switch (Size)
            {
                case BcButtonApi.Size.Default:
                    _sizeValue = CarbonDesignSystemCss.Button.BxBtnSizeDefault;
                    break;

                case BcButtonApi.Size.Field:
                    _sizeValue = CarbonDesignSystemCss.Button.BxBtnSizeField;
                    break;

                case BcButtonApi.Size.Small:
                    _sizeValue = CarbonDesignSystemCss.Button.BxBtnSizeSmall;
                    break;

                default:
                    _sizeValue = CarbonDesignSystemCss.Button.BxBtnSizeDefault;
                    break;
            }
        }

        private void SetOrDefaultKindValue()
        {
            switch (Kind)
            {
                case BcButtonApi.Kind.Primary:
                    _kindValue = CarbonDesignSystemCss.Button.BxBtnKindPrimary;
                    break;

                case BcButtonApi.Kind.Secondary:
                    _kindValue = CarbonDesignSystemCss.Button.BxBtnKindSecondary;
                    break;

                case BcButtonApi.Kind.Tertiary:
                    _kindValue = CarbonDesignSystemCss.Button.BxBtnKindTertiary;
                    break;

                case BcButtonApi.Kind.Danger:
                    _kindValue = CarbonDesignSystemCss.Button.BxBtnKindDanger;
                    break;

                case BcButtonApi.Kind.Ghost:
                    _kindValue = CarbonDesignSystemCss.Button.BxBtnKindGhost;
                    break;

                default:
                    _kindValue = CarbonDesignSystemCss.Button.BxBtnKindPrimary;
                    break;
            }
        }

        private string GetCss()
        {
            SetOrDefaultKindValue();
            SetOrDefaultSizeValue();
            SetOrDefaultButtonType();

            return $"{CarbonDesignSystemCss.Button.BxBtn} " +
                   $"{_kindValue} " +
                   $"{_sizeValue}";
        }
    }
}