using DevExpress.Data.Filtering;
using System;

namespace BlazorDemo.Pages.FilterBuilder;

public class IsSalesDiscountFunction : ICustomFunctionDisplayAttributes {
    public const string FunctionName = "IsSalesDiscount";
    static readonly IsSalesDiscountFunction Instance = new IsSalesDiscountFunction();
    IsSalesDiscountFunction() { }
    public static void Register() {
        CriteriaOperator.RegisterCustomFunction(Instance);
    }
    public static bool Unregister() {
        return CriteriaOperator.UnregisterCustomFunction(Instance);
    }
    #region ICustomFunctionOperatorBrowsable Members
    FunctionCategory ICustomFunctionOperatorBrowsable.Category => FunctionCategory.Math;
    string ICustomFunctionOperatorBrowsable.Description => "The discount amount is 15% or more.";
    bool ICustomFunctionOperatorBrowsable.IsValidOperandCount(int count) {
        return count == 1;
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandType(int operandIndex, int operandCount, Type type) {
        return DevExpress.Data.Summary.SummaryItemTypeHelper.IsNumericalType(type);
    }
    int ICustomFunctionOperatorBrowsable.MaxOperandCount => 1;
    int ICustomFunctionOperatorBrowsable.MinOperandCount => 1;
    #endregion
    #region ICustomFunctionDisplayAttributes
    string ICustomFunctionDisplayAttributes.DisplayName => "Is sales discount";

    public object Image => null;
    #endregion
    #region ICustomFunctionOperator Members
    object ICustomFunctionOperator.Evaluate(params object[] operands) {
        var discount = Convert.ToDouble(operands[0]);
        return discount >= 0.15;
    }
    string ICustomFunctionOperator.Name => FunctionName;

    Type ICustomFunctionOperator.ResultType(params Type[] operands) {
        return typeof(bool);
    }
    #endregion
}

public class DoesNotBeginWithFunction : ICustomFunctionDisplayAttributes {
    public const string FunctionName = "DoesNotBeginWith";
    static readonly DoesNotBeginWithFunction Instance = new DoesNotBeginWithFunction();
    DoesNotBeginWithFunction() { }

    public static void Register() {
        CriteriaOperator.RegisterCustomFunction(Instance);
    }
    public static bool Unregister() {
        return CriteriaOperator.UnregisterCustomFunction(Instance);
    }
    #region ICustomFunctionOperatorBrowsable Members
    FunctionCategory ICustomFunctionOperatorBrowsable.Category => FunctionCategory.Text;

    string ICustomFunctionOperatorBrowsable.Description => "Selects items that do not start with the specified string.";

    bool ICustomFunctionOperatorBrowsable.IsValidOperandCount(int count) {
        return count == 2;
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandType(int operandIndex, int operandCount, Type type) {
        return type == typeof(string);
    }
    int ICustomFunctionOperatorBrowsable.MaxOperandCount => 2;

    int ICustomFunctionOperatorBrowsable.MinOperandCount => 2;
    #endregion
    #region ICustomFunctionDisplayAttributes
    string ICustomFunctionDisplayAttributes.DisplayName => "Does not begin with";

    public object Image => null;
    #endregion
    #region ICustomFunctionOperator Members
    object ICustomFunctionOperator.Evaluate(params object[] operands) {
        if(operands[0] == null || operands[1] == null) return false;

        var str1 = operands[0].ToString();
        var str2 = operands[1].ToString();
        return !str1.StartsWith(str2, StringComparison.InvariantCultureIgnoreCase);
    }
    string ICustomFunctionOperator.Name => FunctionName;

    Type ICustomFunctionOperator.ResultType(params Type[] operands) {
        return typeof(bool);
    }
    #endregion
}

public class IsWeekendFunction : ICustomFunctionDisplayAttributes {
    public const string FunctionName = "IsWeekend";
    static readonly IsWeekendFunction Instance = new IsWeekendFunction();
    IsWeekendFunction() { }

    public static void Register() {
        CriteriaOperator.RegisterCustomFunction(Instance);
    }
    public static bool Unregister() {
        return CriteriaOperator.UnregisterCustomFunction(Instance);
    }
    #region ICustomFunctionOperatorBrowsable Members
    FunctionCategory ICustomFunctionOperatorBrowsable.Category => FunctionCategory.DateTime;

    string ICustomFunctionOperatorBrowsable.Description => "Determines if a day falls on a weekend.";

    bool ICustomFunctionOperatorBrowsable.IsValidOperandCount(int count) {
        return count == 1;
    }
    bool ICustomFunctionOperatorBrowsable.IsValidOperandType(int operandIndex, int operandCount, Type type) {
        return type == typeof(DateTime) || type == typeof(DateTime?);
    }
    int ICustomFunctionOperatorBrowsable.MaxOperandCount => 1;

    int ICustomFunctionOperatorBrowsable.MinOperandCount => 1;
    #endregion
    #region ICustomFunctionDisplayAttributes
    string ICustomFunctionDisplayAttributes.DisplayName => "Is weekend";

    public object Image => null;
    #endregion
    #region ICustomFunctionOperator Members
    object ICustomFunctionOperator.Evaluate(params object[] operands) {
        var date = Convert.ToDateTime(operands[0]);
        return date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday;
    }
    string ICustomFunctionOperator.Name => FunctionName;

    Type ICustomFunctionOperator.ResultType(params Type[] operands) {
        return typeof(bool);
    }
    #endregion
}
