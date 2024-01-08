public class Todo {
    private string text;
    private string color;
    private int priority;
    private DateTime createdTime;

    public Todo(string text, string color, int priority) {
        this.text = text;
        this.color = color;
        this.priority = priority;
        createdTime = DateTime.Now;
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
}
