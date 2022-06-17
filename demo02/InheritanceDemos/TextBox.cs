using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.InheritanceDemos {
    public class TextBox : Component {
        public TextBox() : base(string.Empty) {
            Console.WriteLine("TextBox Default Constructor has been invoked!");
        }
        public override void Draw() {
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Width; i++) {
                Console.Write("=");
            }
            Console.SetCursorPosition(X, Y + 1);
            Console.Write(Content);
            Console.SetCursorPosition(X, Y + 2);
            for (int i = 0; i < Width; i++) {
                Console.Write("=");
            }
        }
        public void Ask() {
            Console.SetCursorPosition(X, Y + 1);
            Content = Console.ReadLine();
        }
    }
}
