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
                        Console.WriteLine("adding...");
                        break;
                    case "remove" or "r":
                        Console.WriteLine("removing...");
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

