using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoDotCash.Services;

namespace SoDotCashTest
{
    /// <summary>
    /// The BackgroundTaskTracker provides a managed lifecycle mechanism of tracking long running tasks.
    /// The tests here verify operation of the tracking component.
    /// </summary>
    [TestClass]
    public class TaskTrackerTest
    {
        /// <summary>
        /// Helper method which verifies common task tracking state for no action pending
        /// </summary>
        private void VerifyNoActionState()
        {
            // No actions pending to start
            Assert.IsFalse(BackgroundTaskTracker.Instance.ActionsPending);

            // Should report 100% with no tasks
            Assert.AreEqual(BackgroundTaskTracker.Instance.CompletionProgress, 100);

            // Should report no action description
            Assert.AreEqual(BackgroundTaskTracker.Instance.NoActionDescription,
                BackgroundTaskTracker.Instance.CurrentActionDescription);
        }

        /// <summary>
        /// The task tracker should have no active tasks to start
        /// </summary>
        [TestMethod]
        public void TestInitialState()
        {
            // Singleton must exist
            Assert.IsNotNull(BackgroundTaskTracker.Instance);

            // Verify no action state
            VerifyNoActionState();
        }

        /// <summary>
        /// Tests adding and completing a single task
        /// </summary>
        [TestMethod]
        public void TestSingleAction()
        {
            // Start a tracked task
            using (BackgroundTaskTracker.BeginTask("TestTaskA"))
            {
                // Should reflect action pending
                Assert.IsTrue(BackgroundTaskTracker.Instance.ActionsPending);

                // Should reflect 0 completion
                Assert.AreEqual(BackgroundTaskTracker.Instance.CompletionProgress, 0);

                // Should reflect task name as decription
                Assert.AreEqual(BackgroundTaskTracker.Instance.CurrentActionDescription, "TestTaskA");
            }

            // Task now complete
            // Verify no action state
            VerifyNoActionState();
        }

        /// <summary>
        /// Tests adding and completing multiple tasks
        /// </summary>
        [TestMethod]
        public void TestStackedActions()
        {
            // Start tracked task A
            using (BackgroundTaskTracker.BeginTask("TestTaskA"))
            {
                // Start tracked task B
                using (BackgroundTaskTracker.BeginTask("TestTaskB"))
                {

                    // Should reflect action pending
                    Assert.IsTrue(BackgroundTaskTracker.Instance.ActionsPending);

                    // Should reflect 0 completion
                    Assert.AreEqual(BackgroundTaskTracker.Instance.CompletionProgress, 0);

                    // Should reflect task name as decription
                    Assert.AreEqual(BackgroundTaskTracker.Instance.CurrentActionDescription, "TestTaskB");

                    // Start tracked task C
                    using (BackgroundTaskTracker.BeginTask("TestTaskC"))
                    {
                        // Should reflect action pending
                        Assert.IsTrue(BackgroundTaskTracker.Instance.ActionsPending);

                        // Should reflect 0 completion
                        Assert.AreEqual(BackgroundTaskTracker.Instance.CompletionProgress, 0);

                        // Should reflect task name as decription
                        Assert.AreEqual(BackgroundTaskTracker.Instance.CurrentActionDescription, "TestTaskC");
                    }

                    // Complete C

                    // Should reflect 33% completion
                    Assert.AreEqual(BackgroundTaskTracker.Instance.CompletionProgress, 33);

                    // Should reflect task name B as decription
                    Assert.AreEqual(BackgroundTaskTracker.Instance.CurrentActionDescription, "TestTaskB");

                }

                // Complete B

                // Should reflect 66% completion
                Assert.AreEqual(BackgroundTaskTracker.Instance.CompletionProgress, 66);

                // Should reflect task name B as decription
                Assert.AreEqual(BackgroundTaskTracker.Instance.CurrentActionDescription, "TestTaskA");

            }
            // Tasks now complete
            // Verify no action state
            VerifyNoActionState();
        }

        /// <summary>
        /// Tests replacing the no action description
        /// </summary>
        [TestMethod]
        public void TestNoActionDescription()
        {
            BackgroundTaskTracker.Instance.NoActionDescription = "Test Description";

            // Should reflect new default as decription
            Assert.AreEqual(BackgroundTaskTracker.Instance.CurrentActionDescription, "Test Description");
        }
    }
}
