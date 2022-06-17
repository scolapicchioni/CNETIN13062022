namespace demo02.InheritanceDemos;
public abstract class Component {
    //public Component() {
    //    Console.WriteLine("Component Default Constructor has been invoked!");
    //}
    public Component(string something) {
        Console.WriteLine("Component Constructor with a string has been invoked!");
        Content = something;
    }
    public int X { get; set; }
    public int Y { get; set; }

    protected int width;
    public int Width {
        get {
            return width;
        }
        set {
            if (value < 0) {
                throw new SizeNegativeException($"The value {value} cannot be negative!");
            }
            width = value;
        }
    }
    public int Height { get; set; }
    public string Content { get; set; } = String.Empty;
    //public virtual void Draw() {
    //    Console.SetCursorPosition(X, Y);
    //    for (int i = 0; i < Width; i++) {
    //        Console.Write("-");
    //    }
    //    Console.SetCursorPosition(X, Y + 1);
    //    Console.Write(Content);
    //    Console.SetCursorPosition(X, Y + 2);
    //    for (int i = 0; i < Width; i++) {
    //        Console.Write("-");
    //    }
    //}
    public abstract void Draw();
}
