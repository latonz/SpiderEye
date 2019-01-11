namespace SpiderEye
{
    /// <summary>
    /// Represents a window.
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        /// Gets or sets the window title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Shows this window.
        /// </summary>
        void Show();
    }
}