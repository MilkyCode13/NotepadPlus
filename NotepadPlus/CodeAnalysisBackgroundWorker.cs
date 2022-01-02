using System.ComponentModel;

namespace NotepadPlus
{
    /// <summary>
    /// Code analysis background worker.
    /// </summary>
    internal sealed class CodeAnalysisBackgroundWorker : BackgroundWorker
    {
        /// <summary>
        /// Whether the run is pending.
        /// </summary>
        private bool runPending;

        /// <summary>
        /// Constructs the worker.
        /// </summary>
        /// <param name="analyzer">The code analyzer.</param>
        public CodeAnalysisBackgroundWorker(CodeAnalyzer analyzer)
        {
            Analyzer = analyzer;
            DoWork += RunAnalysis;
            RunWorkerCompleted += CheckIfRunNeeded;
        }

        /// <summary>
        /// Gets the analyzer.
        /// </summary>
        private CodeAnalyzer Analyzer { get; }

        /// <summary>
        /// Schedule a run of the worker.
        /// </summary>
        public void ScheduleRun()
        {
            if (IsBusy)
            {
                runPending = true;
            }
            else
            {
                RunWorkerAsync();
            }
        }

        /// <summary>
        /// Checks if a run is pending.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void CheckIfRunNeeded(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (runPending)
            {
                runPending = false;
                RunWorkerAsync();
            }
        }

        /// <summary>
        /// Run an analysis.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void RunAnalysis(object? sender, DoWorkEventArgs e)
        {
            Analyzer.Analyze();
        }
    }
}