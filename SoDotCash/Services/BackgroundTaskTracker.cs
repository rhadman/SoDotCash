using System;
using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;

namespace SoDotCash.Services
{
    

    /// <summary>
    /// A singleton object providing tracking for async operations with descriptions
    /// </summary>
    public sealed class BackgroundTaskTracker : ObservableObject
    {
        #region [Public Interface]
        /// <summary>
        /// Internal reference to single instance of the tracker
        /// </summary>
        public static BackgroundTaskTracker Instance { get; } = new BackgroundTaskTracker();

        /// <summary>
        /// Action string returned if no action is in progress
        /// </summary>
        public string NoActionDescription { get; set; } = "Ready.";

        /// <summary>
        /// String describing the current action being processed. 
        /// </summary>
        private readonly List<Tracker> _currentActions = new List<Tracker>();
        public string CurrentActionDescription
        {
            get
            {
                lock (this)
                {
                    // If there are any descriptions, return the last one
                    if (_currentActions.Any())
                        return _currentActions.Last().Description;
                    // Otherwise return default
                    return NoActionDescription;
                }
            }
        }

        /// <summary>
        /// Percentage of actions completed. Value is 100 if no actions are in the processing queue
        /// </summary>
        public int CompletionProgress
        {
            get
            {
                lock (this)
                {
                    // If there are no actions, this is 100% complete
                    if (_actionCount == 0)
                        return 100;
                    // Return percentage of actions completed
                    return ((_actionCount - _currentActions.Count) * 100) / _actionCount;
                }
            }
        }

        /// <summary>
        /// Bool indicator of whether all tasks are complete
        /// </summary>
        public bool ActionsPending => (CompletionProgress < 100);


        /// <summary>
        /// Call in a using block:
        /// using (BackgroundTaskTracker.BeginTask("Doing something")) {  await myAsyncTask(); } 
        /// </summary>
        /// <param name="description">Description of the task that will be run</param>
        /// <returns>Tracker instance to be used as IDisposable</returns>
        public static Tracker BeginTask(string description)
        {
            return new Tracker(description);
        }

        #endregion

        #region [Tracker Class]

        /// <summary>
        /// Call in a using block:
        /// using (BackgroundTaskTracker.BeginTask("Doing something")) {  await myAsyncTask(); } 
        /// </summary>
        public class Tracker : IDisposable
        {
            /// <summary>
            /// Saved description for removing on end
            /// </summary>
            public string Description { get;}
            public Tracker(string description)
            {
                Description = description;
                Instance.AddTracker(this);
            }

            /// <summary>
            /// Handle completion of a task
            /// </summary>
            public void Dispose()
            {
                Instance.RemoveTracker(this);
            }
        }

        /// <summary>
        /// Add a task tracker to the tracked tasks
        /// </summary>
        /// <param name="tracker">Tracker object to add</param>
        private void AddTracker(Tracker tracker)
        {
            lock (Instance)
            {
                // Add tracker to list
                _currentActions.Add(tracker);

                // Note another action
                ActionCount++;
            }

            // Affects these properties
            RaisePropertyChanged(() => CurrentActionDescription);
            RaisePropertyChanged(() => ActionsPending);
        }

        /// <summary>
        /// Called when a tracker is disposed of to remove it from the list
        /// </summary>
        /// <param name="tracker">Tracker object to remove</param>
        private void RemoveTracker(Tracker tracker)
        {
            lock (Instance)
            {
                // Remove tracker from the current actions list
                _currentActions.Remove(tracker);

                // If all actions are completed, reset to default state
                if (!_currentActions.Any())
                {
                    ActionCount = 0;
                    RaisePropertyChanged(() => ActionsPending);
                }
            }

            // Affects these properties
            RaisePropertyChanged(() => CurrentActionDescription);
        }

        #endregion

        #region [Internal]

        /// <summary>
        /// Count of actions added to while there are actions outstanding.
        /// This resets to 0 when _completedActionCount == _actionCount
        /// </summary>
        private int _actionCount;
        private int ActionCount
        {
            get { return _actionCount; }
            set
            {
                _actionCount = value;
                RaisePropertyChanged(() => CompletionProgress);
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Internal constructor
        /// </summary>
        private BackgroundTaskTracker()
        {
        }

        #endregion

    }
}
