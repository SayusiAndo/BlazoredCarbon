namespace SayusiAndo.Carbon.BlazoredCarbon.Components.Button
{
    /// <summary>
    /// The BcButton Api.
    /// </summary>
    public struct BcButtonApi
    {
        /// <summary>
        /// The BcButton Kind Api.
        /// </summary>
        public struct Kind
        {
            /// <summary>
            /// Configures the BcButton component Kind to be Primary.
            /// </summary>
            public const string Primary = "Primary";

            /// <summary>
            /// Configures the BcButton component Kind to be Secondary.
            /// </summary>
            public const string Secondary = "Secondary";

            /// <summary>
            /// Configures the BcButton component Kind to be Tertiary.
            /// </summary>
            public const string Tertiary = "Tertiary";

            /// <summary>
            /// Configure the BcButton component Kind to be Danger.
            /// </summary>
            public const string Danger = "Danger";

            /// <summary>
            /// Configure the BcButton component Kind to be Ghost.
            /// </summary>
            public const string Ghost = "Ghost";
        }

        /// <summary>
        /// The BcButton Size Api.
        /// </summary>
        public struct Size
        {
            /// <summary>
            /// Configures the BcButton component Size to be Default.
            /// </summary>
            public const string Default = "default";

            /// <summary>
            /// Configures the BcButton component Size to be Field.
            /// </summary>
            public const string Field = "field";

            /// <summary>
            /// Configures the BcButton component Size to be Small.
            /// </summary>
            public const string Small = "small";
        }
    }
}