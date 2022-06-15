namespace demo02 {

    [AttributeUsage(AttributeTargets.All)]
    internal class SimoAttribute : Attribute {
        private readonly string someData;
        public SimoAttribute(string someData) {
            this.someData = someData;
        }
        public int MyProperty { get; set; }
    }
}
