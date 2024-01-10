using System.Text.RegularExpressions;
class CommandCenter {    

    TodoList todos;
    Messages msg;
    
    Regex descriptionRegex;
    public CommandCenter() {

        todos = new TodoList();
        msg = new Messages();
        descriptionRegex = new Regex("\"([^\"]*)\"");

    }
    public void init() {

        msg.welcomeMessage();
        todos.showTodos();
        msg.initMessage();
        startCLI();

    }
    private void startCLI() {

        while (true) {

            Console.Write(":");
            string? input = Console.ReadLine();
            Console.WriteLine();

            if (input != null) {

                string command = Regex.Replace(input.Split()[0], @"[^0-9a-zA-Z\ ]+", "");
                string[] inputBites = input.Split(' ');

                switch (command) {

                    case "new" or "n":
                        // extracting description between quotation marks
                        Match match = descriptionRegex.Match(input);
                        if (!match.Success) {
                            Console.WriteLine("use quotation marks between description!");
                            break;
                        }
                        string description = match.Groups[1].Value;

                        // extracting color and priority
                        string[] attributes = input.Split('\"')[2].Trim().Split(' ');
                        if (attributes.Length != 2) {
                            Console.WriteLine("Wrong use of 'new'");
                            break;
                        }
                        string color = attributes[1];
                        int todoPrio;
                        try {
                            todoPrio = int.Parse(attributes[0]);
                            todos.newTodo(description, todoPrio, color);
                        }
                        catch (FormatException e) {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case "remove" or "r":
                        if (inputBites.Length != 2) {
                            Console.WriteLine("Wrong use of 'remove'");
                            break;
                        }
                        int todoId;
                        try {
                            todoId = int.Parse(inputBites[1]);
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
                    
                    case "help" or "h":
                        msg.displayCommands();
                        break;
                    
                    case "quit" or "q":
                        msg.exitMessage();
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine($"{input} is not a command... try again");
                        break;
                }
                // todos.showTodos();
            }
            else {
                Console.WriteLine("No command entered... try again");
            }
        }
    }
}

