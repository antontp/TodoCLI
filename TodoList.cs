using System.Collections.Generic;
using System.Runtime.InteropServices;
class TodoList
{
    private List<Todo> todos;
    int totalTasks = 0;

    public TodoList() {
        todos = GenerateRandomTodos(5);
        totalTasks = todos.Count;
    }

    public void newTodo(string description, int todoPrio, string color) {
        todos.Add(new Todo(description, todoPrio, color));
        Console.WriteLine($"created new todo!");
    }

    public void removeTodo(int id) {
       Todo? found = todos.Find(t => t.Id == id);
        if (found != null) {
            todos.Remove(found);
            Console.WriteLine($"Removed todo \"{found.Description}\" with id {found.Id}");
        }
        else {
            Console.WriteLine($"Unable to find todo with id {id}");
        }
    }
    public void markTodo(int id, bool mark) {
       Todo? found = todos.Find(t => t.Id == id);
        if (found != null) {
            found.Status = mark;
            Console.WriteLine($"Todo \"{found.Description}\" with id {found.Id} marked [{(mark ? "DONE" : "UNDONE")}]");
        }
        else {
            Console.WriteLine($"Unable to find todo with id {id}");
        }
    }

    public void cleanTodos() {
        int todosDeleted = 0;
        List<Todo> todosCopy = new List<Todo>(todos);

        foreach (Todo todo in todosCopy) {
            if (todo.Status) {
                todos.Remove(todo);
                todosDeleted++;
            }
        }
        Console.WriteLine($"{todosDeleted} todos cleaned");
    }

    public void editTodo(int id, string attribute, string change) {
        Todo? found = todos.Find(t => t.Id == id);
        if (found == null) {
            Console.WriteLine($"Unable to find todo with id {id}");
            return;
        }
        switch (attribute) {
            case "color":
                found.Color = change;
                break;
            case "priority":
                try {
                    int prio = int.Parse(change);
                    found.Priority = prio;
                }
                catch (FormatException e) {
                    Console.WriteLine(e.Message);
                }
                break;
            default:
                found.Description = change;
                break;
        }
        Console.WriteLine($"Todo with id {found.Id} changed!");
    }

    public void showTodos() {Console.WriteLine(this.ToString());}

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

            Todo todo = new Todo(randomText, randomPriority, randomColor);
            todos.Add(todo);
        }

        return todos;
    }

    public override string ToString() {
        int maxDescriptionWidth = todos.Any() ? todos.Max(t => t.Description.Length) : 0;
        int descColumnWidth = Math.Max("Description".Length, maxDescriptionWidth);
        int idColumnWidth = 5;  // Define your idColumnWidth here. 

        string idHeader = "ID".PadLeft((idColumnWidth + "ID".Length) / 2).PadRight(idColumnWidth);
        string doneHeader = "Done".PadLeft(("Done".Length + 1) / 2).PadRight(5);
        string descHeader = "Description".PadLeft((descColumnWidth + "Description".Length) / 2).PadRight(descColumnWidth);
        string colorHeader = "Color".PadLeft((7 + "Color".Length) / 2).PadRight(7);
        string priorityHeader = "Priority".PadLeft((3 + "Priority".Length) / 2).PadRight(5);
        string createdHeader = "Created Time".PadLeft((22 + "Created Time".Length) / 2).PadRight(22);

        string output = "";
        output += "┌─────┬─────┬" + new String('─', descColumnWidth + 2) + "┬──────────┬─────────┬────────────────────────┐\n";
        output += $"│{idHeader}│{doneHeader}│ {descHeader} │ {priorityHeader} │ {colorHeader} │ {createdHeader} │\n";
        output += "├─────┼─────┼" + new String('─', descColumnWidth + 2) + "┼──────────┼─────────┼────────────────────────┤\n";

        foreach (Todo todo in todos) {
            string idColumn = todo.Id.ToString().PadLeft((idColumnWidth + 1) / 2).PadRight(idColumnWidth);
            string doneColumn = todo.Status ? " [x]".PadRight(5) : " [ ]".PadRight(5);
            string descColumn = todo.Description.PadRight(descColumnWidth);
            string priorityColumn = todo.Priority.ToString().PadRight(8);
            string colorColumn = todo.Color.PadRight(7);
            string createdTimeColumn = todo.GetCreatedTime().ToString().PadRight(22);

            output += $"│{idColumn}│{doneColumn}│ {descColumn} │ {priorityColumn} │ {colorColumn} │ {createdTimeColumn} │\n";
        }

        output += "└─────┴─────┴" + new String('─', descColumnWidth + 2) + "┴──────────┴─────────┴────────────────────────┘\n";

        return output;
    }

}