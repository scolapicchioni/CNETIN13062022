using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.InheritanceDemos {
    public class SecondForm : Form {
        public override void InitializeComponents() {
            Components[0] = new Label()   { X = 5, Y = 10, Height = 1, Width = 20, Content = "First Name: " };
            Components[1] = new TextBox() { X = 5, Y = 10, Height = 1, Width = 20 };
            Components[2] = new Label  () { X = 5, Y = 10, Height = 1, Width = 20, Content = "Last Name: " };
            Components[3] = new TextBox() { X = 5, Y = 10, Height = 1, Width = 20 };
            Components[4] = new Label() { X = 5, Y = 10, Height = 1, Width = 20, Content = "Date Of Birth: " };
            Components[5] = new TextBox() { X = 5, Y = 10, Height = 1, Width = 20 };
            Components[6] = new Label() { X = 5, Y = 10, Height = 1, Width = 20 };
            Draw();
        }

        public override void Start() {
            ((TextBox)Components[1]).Ask();
            ((TextBox)Components[3]).Ask();
            ((TextBox)Components[5]).Ask();

            //save the three Content properties on the db

            Components[6].Content = $"Data Saved: {Components[1].Content} {Components[3].Content} {Components[5].Content}";
        }
    }
}
