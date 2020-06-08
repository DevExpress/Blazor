using System;
using System.ComponentModel;
using System.Globalization;

namespace Demo.Blazor.Reports.NorthwindTraders {
    public class SortGroupsTypeEnumConverter : EnumConverter {
        #region inner classes
        struct SortGroupsTypeStrings {
            public const string None = "None";
            public const string Count = "Count";
            public const string TotalSales = "Total Sales";
            public const string LowestPrice = "Lowest Price";
            public const string HighestPrice = "Highest Price";
        }
        #endregion

        public SortGroupsTypeEnumConverter()
            : base(typeof(SortGroupsType)) {
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            return destinationType == typeof(string);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destType) {
            switch((SortGroupsType)value) {
                case SortGroupsType.Count:
                    return SortGroupsTypeStrings.Count;
                case SortGroupsType.HighestPrice:
                    return SortGroupsTypeStrings.HighestPrice;
                case SortGroupsType.LowestPrice:
                    return SortGroupsTypeStrings.LowestPrice;
                case SortGroupsType.TotalSales:
                    return SortGroupsTypeStrings.TotalSales;
                default:
                    return SortGroupsTypeStrings.None;
            }
        }
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType) {
            return srcType == typeof(string);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
            SortGroupsType type = SortGroupsType.None;
            if(Enum.TryParse<SortGroupsType>((string)value, false, out type)) {
                return type;
            }
            switch((string)value) {
                case SortGroupsTypeStrings.Count:
                    return SortGroupsType.Count;
                case SortGroupsTypeStrings.HighestPrice:
                    return SortGroupsType.HighestPrice;
                case SortGroupsTypeStrings.LowestPrice:
                    return SortGroupsType.LowestPrice;
                case SortGroupsTypeStrings.TotalSales:
                    return SortGroupsType.TotalSales;
                default:
                    return SortGroupsType.None;
            }
        }
    }

    [TypeConverter(typeof(SortGroupsTypeEnumConverter))]
    public enum SortGroupsType {
        None,
        Count,
        TotalSales,
        LowestPrice,
        HighestPrice
    }
}
