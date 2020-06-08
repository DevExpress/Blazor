namespace BlazorDemo.Data {
    public enum Department { Motors, Electronics, Software }
    public class Person {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }

        public string Text => $"{FirstName} {LastName} ({Department} Dept.)";
    }
}