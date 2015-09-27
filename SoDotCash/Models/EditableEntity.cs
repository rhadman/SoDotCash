
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SoDotCash.Models
{

    /// <summary>
    /// Base class which Model objects can inherit from to implement IEditableObject and provide
    ///   notification when an edit has been completed.
    /// </summary>
    public class EditableEntity : IEditableObject
    {

        // A delegate type for hooking up change notifications.
        public delegate void EditEventHandler(object sender, EventArgs e);

        // An event that clients can use to be notified before an edit operation begins
        public event EditEventHandler EditBeginning;

        // An event that clients can use to be notified just after an edit operation begins
        public event EditEventHandler EditBegun;

        // An event that clients can use to be notified just before an edit operation completes
        public event EditEventHandler EditEnding;

        // An event that clients can use to be notified after an edit operation completes
        public event EditEventHandler EditEnded;

        // An event that clients can use to be notified after an edit operation is cancelled
        public event EditEventHandler EditCancelled;

        // Invoke the EditBeginning event
        protected virtual void OnEditBeginning(EventArgs e)
        {
            EditBeginning?.Invoke(this, e);
        }

        // Invoke the EditBegun event
        protected virtual void OnEditBegun(EventArgs e)
        {
            EditBegun?.Invoke(this, e);
        }

        // Invoke the EditEnding event; called when the edit operation is finalized
        protected virtual void OnEditEnding(EventArgs e)
        {
            EditEnding?.Invoke(this, e);
        }

        // Invoke the EditEnded event
        protected virtual void OnEditEnded(EventArgs e)
        {
            EditEnded?.Invoke(this, e);
        }

        // Invoke the EditCancelled event
        protected virtual void OnEditconcelled(EventArgs e)
        {
            EditCancelled?.Invoke(this, e);
        }


        /// <summary>
        /// The Datagrid WPF control has a bug that causes BeginEdit and EndEdit to be called twice.
        ///   The first EndEdit is called before the data is updated.
        /// </summary>
        [NotMapped]
        private SoCashDbContext _editContext;
        [NotMapped]
        private int _editCount;

        /// <summary>
        /// Access to the DB context used in the current edit operation
        /// </summary>
        public SoCashDbContext EditContext => _editContext;

        /// <summary>
        /// Called before an edit operation begins on this object
        /// </summary>
        public void BeginEdit()
        {
            // If no db context is started, start one now
            if (_editContext == null)
            {
                // Notify event waiters
                OnEditBeginning(EventArgs.Empty);

                // Begin a db context
                _editContext = new SoCashDbContext();

                // Attach this entry to the context - initially unchanged, but changes will be tracked from here out
                _editContext.Entry(this).State = EntityState.Unchanged;

                // Notify event waiters
                OnEditBegun(EventArgs.Empty);
            }
            _editCount++;
        }

        /// <summary>
        /// Called after an edit operation ends on this object
        /// </summary>
        public void EndEdit()
        {
            _editCount--;
            if (_editCount > 0 || _editContext == null)
                return;

            // Notify event waiters
            OnEditEnding(EventArgs.Empty);

            // Commit changes to database
            _editContext.SaveChanges();

            // End context
            _editContext.Dispose();
            _editContext = null;

            // Notify event waiters
            OnEditEnded(EventArgs.Empty);
        }

        /// <summary>
        /// Called when an edit operation is aborted
        /// </summary>
        public void CancelEdit()
        {
            _editCount--;
            if (_editCount > 0 || _editContext == null)
                return;

            // End context
            _editContext.Dispose();
            _editContext = null;

            // Notify event waiters
            OnEditconcelled(EventArgs.Empty);
        }



    }
}