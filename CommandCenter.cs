class CommandCenter {    

    TodoList todos;
    Messages msg;
    public CommandCenter() {
        todos = new TodoList();
        msg = new Messages();
    }
    public void init() {
        msg.welcomeMessage();
        todos.showTodos();
        msg.displayCommands();
        startCLI();
    }
    private void startCLI() {
        while (true) {
            Console.Write(":");
            string? input = Console.ReadLine();
            if (input != null) {
                string[] input_bites = input.Split(' ');
                Console.WriteLine();
                switch (input_bites[0]) {

                    case "new" or "n":
                        if (input_bites.Length != 4) {
                            Console.WriteLine("Wrong use of remove");
                            break;
                        }
                        Console.WriteLine("adding...");
                        string what = input_bites[1];
                        string color = input_bites[3];
                        int todoPrio;
                        try {
                            todoPrio = int.Parse(input_bites[2]);
                            todos.newTodo(what, todoPrio, color);
                        }
                        catch (FormatException e) {
                            Console.WriteLine("Wrong use of 'new'");
                        }
                        break;

                    case "remove" or "r":
                        if (input_bites.Length != 2) {
                            Console.WriteLine("Wrong use of 'remove'");
                            break;
                        }
                        Console.WriteLine("removing...");
                        int todoId;
                        try {
                            todoId = int.Parse(input_bites[1]);
                            todos.removeTodo(todoId);
                        }
                        catch (FormatException e) {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "mark" or "m":
                        Console.WriteLine("done...");
                        break;

                    case "clean" or "c":
                        Console.WriteLine("cleaning...");
                        break;

                    case "edit" or "e":
                        Console.WriteLine("editing...");
                        break;

                    case "show" or "s":
                        todos.showTodos();
                        break;

                    case "quit" or "q":
                        msg.exitMessage();
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine($"{input} is not a command... try again");
                        break;
                }
            }
            else {
                Console.WriteLine("No command entered... try again");
            }
        }
    }
}

