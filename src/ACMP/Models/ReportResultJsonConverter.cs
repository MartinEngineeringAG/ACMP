using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ACMP.Models
{
    public sealed class ReportResultJsonConverter : JsonConverter<ReportResult>
    {
        public override bool HandleNull => true;

        public override ReportResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var document = JsonDocument.ParseValue(ref reader))
            {
                var root = document.RootElement;
                if (root.ValueKind != JsonValueKind.Object)
                {
                    throw new JsonException($"Report results must be JSON objects, but found '{root.ValueKind}'.");
                }

                var columns = ReadColumns(root, options);
                var columnsByIndex = IndexColumns(columns);
                var rows = ReadRows(root, columns, columnsByIndex);

                return new ReportResult
                {
                    Columns = columns,
                    Rows = rows
                };
            }
        }

        public override void Write(Utf8JsonWriter writer, ReportResult value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();
            writer.WritePropertyName("Rows");
            writer.WriteStartArray();
            if (value.Rows is not null)
            {
                foreach (var row in value.Rows)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("Cells");
                    writer.WriteStartArray();
                    foreach (var cell in row.Cells)
                    {
                        WriteCellValue(writer, cell.Value, options);
                    }

                    writer.WriteEndArray();
                    writer.WriteEndObject();
                }
            }

            writer.WriteEndArray();
            writer.WritePropertyName("Columns");
            JsonSerializer.Serialize(writer, value.Columns, options);
            writer.WriteEndObject();
        }

        private static List<ReportColumn> ReadColumns(JsonElement root, JsonSerializerOptions options)
        {
            if (!root.TryGetProperty("Columns", out var columnsElement))
            {
                return new List<ReportColumn>();
            }

            if (columnsElement.ValueKind != JsonValueKind.Array)
            {
                throw new JsonException($"Report result 'Columns' must be a JSON array, but found '{columnsElement.ValueKind}'.");
            }

            return JsonSerializer.Deserialize<List<ReportColumn>>(columnsElement.GetRawText(), options)
                ?? new List<ReportColumn>();
        }

        private static Dictionary<int, ReportColumn> IndexColumns(List<ReportColumn> columns)
        {
            var columnsByIndex = new Dictionary<int, ReportColumn>();
            foreach (var column in columns)
            {
                if (!column.CellIndex.HasValue ||
                    column.CellIndex.Value < 0 ||
                    column.CellIndex.Value > int.MaxValue)
                {
                    throw new JsonException(
                        $"Report column '{column.Name}' has invalid CellIndex '{column.CellIndex}'.");
                }

                var index = (int)column.CellIndex.Value;
                if (columnsByIndex.ContainsKey(index))
                {
                    throw new JsonException($"Report columns contain duplicate CellIndex '{index}'.");
                }

                columnsByIndex[index] = column;
            }

            return columnsByIndex;
        }

        private static List<ReportRow> ReadRows(
            JsonElement root,
            List<ReportColumn> columns,
            Dictionary<int, ReportColumn> columnsByIndex)
        {
            if (!root.TryGetProperty("Rows", out var rowsElement))
            {
                return new List<ReportRow>();
            }

            if (rowsElement.ValueKind != JsonValueKind.Array)
            {
                throw new JsonException($"Report result 'Rows' must be a JSON array, but found '{rowsElement.ValueKind}'.");
            }

            var rows = new List<ReportRow>();
            foreach (var rowElement in rowsElement.EnumerateArray())
            {
                rows.Add(ReadRow(rowElement, columns, columnsByIndex));
            }

            return rows;
        }

        private static ReportRow ReadRow(
            JsonElement rowElement,
            List<ReportColumn> columns,
            Dictionary<int, ReportColumn> columnsByIndex)
        {
            if (rowElement.ValueKind != JsonValueKind.Object)
            {
                throw new JsonException($"Report rows must be JSON objects, but found '{rowElement.ValueKind}'.");
            }

            if (!rowElement.TryGetProperty("Cells", out var cellsElement) ||
                cellsElement.ValueKind != JsonValueKind.Array)
            {
                throw new JsonException("Report rows must contain a JSON array named 'Cells'.");
            }

            var cellCount = cellsElement.GetArrayLength();
            if (cellCount != columns.Count)
            {
                throw new JsonException(
                    $"Report row contains {cellCount} cells, but the result defines {columns.Count} columns.");
            }

            var row = new ReportRow();
            var index = 0;
            foreach (var cellElement in cellsElement.EnumerateArray())
            {
                if (!columnsByIndex.TryGetValue(index, out var column))
                {
                    throw new JsonException($"Report result does not define a column for cell index '{index}'.");
                }

                row.Cells.Add(new ReportCell
                {
                    Column = column,
                    Value = InferredObjectJsonConverter.ConvertElement(cellElement)
                });
                index++;
            }

            return row;
        }

        private static void WriteCellValue(Utf8JsonWriter writer, object? value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }

            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
