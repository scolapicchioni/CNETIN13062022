using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.InheritanceDemos {
    public abstract class Form {
        public Component[] Components { get; set; } = new Component[20];
        public void Draw() {
            foreach (Component item in Components) {
                item?.Draw();
            }

        }

        public abstract void InitializeComponents();
        public abstract void Start();
    }
}
