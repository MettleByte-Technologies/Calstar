using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CsvHelper;
using System.Globalization;

public class CustomDateConverter : DefaultTypeConverter
{
    private readonly string[] _inputFormats;
    private const string OutputFormat = "yyyyMMdd";

    public CustomDateConverter(params string[] inputFormats)
    {
        _inputFormats = inputFormats;
    }

    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        if (DateTime.TryParseExact(text, _inputFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            return date.ToString(OutputFormat);
        }
        throw new InvalidOperationException($"Date format is incorrect. Expected formats are: {string.Join(", ", _inputFormats)}.");
    }

    public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
    {
        if (value is DateTime date)
        {
            return date.ToString(OutputFormat);
        }
        return base.ConvertToString(value, row, memberMapData);
    }
}
