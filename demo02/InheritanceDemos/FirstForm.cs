using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.InheritanceDemos {
    public class FirstForm : Form {
        Label label1 = new Label();
        Label lblMessage = new Label();
        public override void InitializeComponents() {
            Components[0] = label1;
            label1.X = 5;
            label1.Y = 10;
            label1.Width = 20;
            label1.Height = 1;
            label1.Content = "What's your name?";

            Components[1] = new TextBox();
            Components[1].X = 5 + label1.Width + 1;
            Components[1].Y = 10;
            Components[1].Width = 20;
            Components[1].Height = 1;

            Components[2] = lblMessage;
            lblMessage.X = 5;
            lblMessage.Y = 12;
            lblMessage.Width = 20;
            lblMessage.Height = 1;
        }

        public override void Start() {
            //this is not going to work:
            //Components[1].Ask();

            //this will work, but it takes a lot of time if it explodes
            //try {
            //    TextBox t = (TextBox)Components[1];
            //    t.Ask();
            //    lblMessage.Content = "Hello " + Components[1].Content;
            //    lblMessage.Draw();
            //} catch (InvalidCastException problem) {
            //    Console.WriteLine("OH NOOOOOES!!! + " + problem.Message);
            //}

            //another syntax
            //if (Components[1] is TextBox) {
            //    TextBox t = (TextBox)Components[1];
            //    t.Ask();
            //    lblMessage.Content = "Hello " + Components[1].Content;
            //    lblMessage.Draw();
            //}

            //another syntax
            if (Components[1] is TextBox t) {
                t.Ask();
                lblMessage.Content = "Hello " + Components[1].Content;
                lblMessage.Draw();
            }

        }
    }
}
