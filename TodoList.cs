using System.Collections.Generic;
class TodoList
{
    private List<Todo> todos;
    int totalTasks = 0;

    public TodoList() {
        todos = GenerateRandomTodos(5);
        totalTasks = todos.Count;
    }

    private List<Todo> GenerateRandomTodos(int count) {
        List<Todo> todos = new List<Todo>();
        Random random = new Random();

        string[] texts = { "Buy groceries", "Finish homework", "Call mom", "Go for a run", "Read a book", "Pay bills" };
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Orange" };

        for (int i = 0; i < count; i++)
        {
            string randomText = texts[random.Next(texts.Length)];
            string randomColor = colors[random.Next(colors.Length)];
            int randomPriority = random.Next(1, 5); // Adjust the priority range as needed

            Todo todo = new Todo(randomText, randomColor, randomPriority);
            todos.Add(todo);
        }

        return todos;
    }

    public override string ToString() {
        string output = "";

        output += "┌─────────────────────────────┬─────────┬───────────┬────────────────────────┐\n";
        output += "│             Text            │  Color  │  Priority │      Created Time      │\n";
        output += "├─────────────────────────────┼─────────┼───────────┼────────────────────────┤\n";

        foreach (Todo todo in todos) {
            // Adjust the alignment and width as necessary
            string textColumn = todo.GetText().PadRight(27);
            string colorColumn = todo.GetColor().PadRight(7);
            string priorityColumn = todo.GetPriority().ToString().PadRight(9);
            string createdTimeColumn = todo.GetCreatedTime().ToString().PadRight(22);

            output += $"│ {textColumn} │ {colorColumn} │ {priorityColumn} │ {createdTimeColumn} │\n";
        }

        return output + "└─────────────────────────────┴─────────┴───────────┴────────────────────────┘\n";
    }
}