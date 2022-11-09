using System;

namespace MediaBrowser.Model.Entities
{
    /// <summary>
    /// A representation of a segment of a media file.
    /// </summary>
    public class MediaSegment
    {
        /// <summary>
        /// Gets or sets the StartPosition.
        /// </summary>
        /// <value>
        /// The start position of the segment in Ticks.
        /// </value>
        public long StartPosition { get; set; }

        /// <summary>
        /// Gets or sets the EndPosition.
        /// </summary>
        /// <value>
        /// The end position of the segment in Ticks.
        /// </value>
        public long? EndPosition { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The name of the segment.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        /// <value>
        /// The type of the segment.
        /// </value>
        public MediaSegmentType Type { get; set; }

        /// <summary>
        /// Gets or sets the ImagePath.
        /// </summary>
        /// <value>
        /// The path for the image that represents this segment.
        /// </value>
        public string? ImagePath { get; set; }

        /// <summary>
        /// Gets or sets the ImageDateModified.
        /// </summary>
        /// <value>
        /// The date the segment image was modified.
        /// </value>
        public DateTime? ImageDateModified { get; set; }

        /// <summary>
        /// Gets or sets the ImageTag.
        /// </summary>
        /// <value>
        /// The segment image tag.
        /// </value>
        public string? ImageTag { get; set; }

        /// <summary>
        /// Converts a ChapterInfo object to a MediaSegment.
        /// </summary>
        /// <param name="chapter"></param>
        /// <returns></returns>
        /// <remarks>
        /// Deprecated.
        /// </remarks>
        public static MediaSegment FromChapterInfo(ChapterInfo chapter)
        {
            return new MediaSegment
            {
                StartPosition = chapter.StartPositionTicks,
                Name = chapter.Name,
                Type = MediaSegmentType.Chapter,
                ImagePath = chapter.ImagePath,
                ImageDateModified = chapter.ImageDateModified,
                ImageTag = chapter.ImageTag
            };
        }

        public ChapterInfo ToChapterInfo()
        {
            return new ChapterInfo
            {
                StartPositionTicks = StartPosition,
                Name = Name,
                ImagePath = ImagePath,
                ImageDateModified = ImageDateModified ?? DateTime.MinValue,
                ImageTag = ImageTag
            };
        }
    }
}
