public class Todo {
    private static int idCounter = 0;
    private int id;
    private string text;
    private string color;
    private int priority;
    private DateTime createdTime;

    public Todo(string text,int priority, string color) {
        this.text = text;
        this.color = color;
        this.priority = priority;
        createdTime = DateTime.Now;

        id = idCounter++;
    }

    public int GetId() {
        return id;
    }

    public string GetText() {
        return text;
    }

    public string GetColor() {
        return color;
    }

    public int GetPriority() {
        return priority;
    }

    public DateTime GetCreatedTime() {
        return createdTime;
    }

    public override string ToString() {
        return text + " - " + priority;
    }

    public override int GetHashCode() {
        return id;
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;
        Todo? objAsTodo = obj as Todo;
        if (objAsTodo == null) return false;
        else return Equals(objAsTodo);
    }

    public bool Equals(Todo other) {
        if (other == null) return false;
        return (this.id.Equals(other.GetId()));
    }
}
