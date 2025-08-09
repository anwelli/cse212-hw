using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
        [TestMethod]
    // Scenario: Enqueue and Dequeue a single item
    // Expected Result: The item should be dequeued correctly
    // Defect(s) Found: None
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities
    // Expected Result: The items should be dequeued in order of priority
    // Defect(s) Found: None
    public void TestPriorityQueue_MultipleItems()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 2);
        priorityQueue.Enqueue("Item3", 3);
        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();
        var result3 = priorityQueue.Dequeue();
        Assert.AreEqual("Item3", result1);
        Assert.AreEqual("Item2", result2);
        Assert.AreEqual("Item1", result3);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority
    // Expected Result: The items should be dequeued in the order they were enqueued
    // Defect(s) Found: None
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 1);
        priorityQueue.Enqueue("Item3", 1);
        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();
        var result3 = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result1);
        Assert.AreEqual("Item2", result2);
        Assert.AreEqual("Item3", result3);
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: An InvalidOperationException should be thrown
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException");
        }
        catch (InvalidOperationException)
        {
        }
    }

    [TestMethod]
    // Scenario: Enqueue and Dequeue multiple items with different priorities and same priorities
    // Expected Result: The items should be dequeued correctly based on priority and order
    // Defect(s) Found: None
    public void TestPriorityQueue_MultipleItemsDifferentPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 1);
        priorityQueue.Enqueue("Item2", 3);
        priorityQueue.Enqueue("Item3", 2);
        priorityQueue.Enqueue("Item4", 3);
        var result1 = priorityQueue.Dequeue();
        var result2 = priorityQueue.Dequeue();
        var result3 = priorityQueue.Dequeue();
        var result4 = priorityQueue.Dequeue();
        Assert.AreEqual("Item2", result1);
        Assert.AreEqual("Item4", result2);
        Assert.AreEqual("Item3", result3);
        Assert.AreEqual("Item1", result4);
}

}