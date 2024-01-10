public class Todo {
    private static int idCounter = 0;
    public int Id { get; }
    public bool Status { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }
    public int Priority { get; set; }

    private DateTime createdTime;

    public Todo(string description, int priority, string color) {
        this.Status = false;
        this.Description = description;
        this.Color = color;
        this.Priority = priority;
        createdTime = DateTime.Now;

        Id = idCounter++;
    }
    // public int GetId() {
    //     return id;
    // }

    // public string GetDescription() {
    //     return description;
    // }

    // public string GetColor() {
    //     return color;
    // }

    // public int GetPriority() {
    //     return priority;
    // }

    public DateTime GetCreatedTime() {
        return createdTime;
    }

    public override string ToString() {
        return $"TODO [ {Status} | {Description} | {Color} | {Priority}]";
    }

    public override int GetHashCode() {
        return Id;
    }

    public override bool Equals(object? obj) {
        if (obj == null) return false;
        Todo? objAsTodo = obj as Todo;
        if (objAsTodo == null) return false;
        else return Equals(objAsTodo);
    }

    public bool Equals(Todo other) {
        if (other == null) return false;
        return (this.Id.Equals(other.Id));
    }
}
