using Xunit;
using TaskManager;
namespace xUnitTest
{
    public class UnitTest1
    {
        private ToDoList _todoList;

        public UnitTest1()
        {
            _todoList = new ToDoList();
        }

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task";
            _todoList.AddTask(task);
            var tasks = _todoList.GetTasks();
            Assert.Contains(task, tasks);

        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskToList()
        {
            var task = "Remove task";
            _todoList.AddTask(task);
            _todoList.RemoveTask(0);
            var tasks = _todoList.GetTasks();
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "Valid Task";
            _todoList.AddTask(task);
            _todoList.RemoveTask(10);
            var tasks = _todoList.GetTasks();
            Assert.Single(tasks);
;        }
    }
}