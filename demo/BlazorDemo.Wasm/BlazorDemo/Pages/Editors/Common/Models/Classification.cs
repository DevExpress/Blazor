namespace BlazorDemo.Pages.Editors.Common.Models;

public class Classification {
    public int Id { get; set; }
    public string Value { get; set; }

    public Classification(int id, string value) {
        Id = id;
        Value = value;
    }

    public override int GetHashCode() {
        int result = 17;
        result = result * 31 + Value.GetHashCode();
        result = result * 31 + Id.GetHashCode();
        return result;
    }

    public override bool Equals(object obj) {
        var item = obj as Classification;
        if(item == null)
            return false;

        return item.Id == Id && item.Value == Value;
    }
}
