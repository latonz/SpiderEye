﻿using System;
using System.Threading.Tasks;

namespace SpiderEye
{
    /// <summary>
    /// Represents a webview.
    /// </summary>
    internal interface IWebview : IDisposable
    {
        /// <summary>
        /// Fires before the webview navigates to an new URL.
        /// </summary>
        event NavigatingEventHandler Navigating;

        /// <summary>
        /// Loads the given URI.
        /// </summary>
        /// <param name="uri">The URI to load.</param>
        void LoadUri(Uri uri);

        /// <summary>
        /// Executes the given JavaScript within the webview and gets the result.
        /// </summary>
        /// <param name="script">The JavaScript to execute.</param>
        /// <returns>A <see cref="Task{TResult}"/> with the result of the script.</returns>
        Task<string> ExecuteScriptAsync(string script);
    }
}
