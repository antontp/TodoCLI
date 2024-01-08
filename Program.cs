using System.Collections.Generic;

startProgram();


static void startProgram() {
    welcomeMessage();
    List<Todo> todoList = GenerateRandomTodos(5); // Change the number to generate more or fewer random todos
    show(todoList);
}

static void welcomeMessage() {
    Console.WriteLine(@" __          __  _                            _          _______        _        _____ _      _____   _ ");
    Console.WriteLine(@" \ \        / / | |                          | |        |__   __|      | |      / ____| |    |_   _| | |");
    Console.WriteLine(@"  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___      | | ___   __| | ___ | |    | |      | |   | |");
    Console.WriteLine(@"   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \     | |/ _ \ / _` |/ _ \| |    | |      | |   | |");
    Console.WriteLine(@"    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) |    | | (_) | (_| | (_) | |____| |____ _| |_  |_|");
    Console.WriteLine(@"     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/     |_|\___/ \__,_|\___/ \_____|______|_____| (_)");
    Console.WriteLine(@"                                                                                                        ");
    Console.WriteLine(@"                                                                                                        ");
}

static List<Todo> GenerateRandomTodos(int count) {
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

static void show(List<Todo> todoList) {
    Console.WriteLine("┌─────────────────────────────┬─────────┬───────────┬────────────────────────┐");
    Console.WriteLine("│ Text                        │ Color   │ Priority  │ Created Time           │");
    Console.WriteLine("├─────────────────────────────┼─────────┼───────────┼────────────────────────┤");

    foreach (Todo todo in todoList) {
        // Adjust the alignment and width as necessary
        string textColumn = todo.GetText().PadRight(27);
        string colorColumn = todo.GetColor().PadRight(7);
        string priorityColumn = todo.GetPriority().ToString().PadRight(9);
        string createdTimeColumn = todo.GetCreatedTime().ToString().PadRight(22);

        Console.WriteLine($"│ {textColumn} │ {colorColumn} │ {priorityColumn} │ {createdTimeColumn} │");
    }

    Console.WriteLine("└─────────────────────────────┴─────────┴───────────┴────────────────────────┘");
}

