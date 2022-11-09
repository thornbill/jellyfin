namespace MediaBrowser.Model.Entities
{
    /// <summary>
    /// The different types of supported media segments.
    /// </summary>
    public enum MediaSegmentType
    {
        /// <summary>
        /// A segment that should be skipped during playback.
        /// </summary>
        Skip = 0,
        /// <summary>
        /// A segment that should be muted during playback.
        /// </summary>
        Mute = 1,
        /// <summary>
        /// A segment representing a chapter in the media.
        /// </summary>
        Chapter = 2,
        /// <summary>
        /// A segment representing commercial/advertisement content in the media.
        /// </summary>
        Commercial = 3,
        /// <summary>
        /// A segment representing intro content in the media.
        /// </summary>
        Intro = 4,
        /// <summary>
        /// A segment representing outro content in the media.
        /// </summary>
        Outro = 5,
        /// <summary>
        /// A segment representing preview content in the media.
        /// </summary>
        Preview = 6,
        /// <summary>
        /// A segment representing a recap or summary content in the media.
        /// </summary>
        Recap = 7
    }
}
