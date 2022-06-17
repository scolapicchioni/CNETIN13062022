namespace demo02.InheritanceDemos {
    public class Label : Component { //IS A
        public Label(string content) : base(content){
            Console.WriteLine("Label Constructor with a string has been invoked");
        }

        public Label() : base("hi") {
            Console.WriteLine("Label Default Constructor has been invoked");
        }
        public override void Draw() {
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Width; i++) {
                Console.Write("-");
            }
            Console.SetCursorPosition(X, Y + 1);
            Console.Write(Content);
            Console.SetCursorPosition(X, Y + 2);
            for (int i = 0; i < Width; i++) {
                Console.Write("-");
            }
        }
    }
}
