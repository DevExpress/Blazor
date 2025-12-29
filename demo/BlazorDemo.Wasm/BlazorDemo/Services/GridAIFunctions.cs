using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.Extensions;
using DevExpress.Blazor;
using DevExpress.Blazor.Internal;
using DevExpress.Data.Controls.ExpressionEditor;
using DevExpress.Data.Filtering;
using DevExpress.DataAccess.ExpressionEditor;

namespace BlazorDemo.Services {
    class CustomColorProvider : IExpressionEditorColorProvider {
        public Color GetColorForElement(ExpressionElementKind elementKind) {
            return Color.Azure;
        }
    }
    public class GridTools {
        IAIExtensionsContainer aiExtensionsContainer = default!;
        public GridTools(IAIExtensionsContainer container) {
            aiExtensionsContainer = container;
        }

        [AIIntegrationTool]
        [Description("Get all collumns names available in the grid.")]
        public IEnumerable<string> GetAvailableColumns([AIIntegrationToolTarget] DxGrid grid) {
            return grid.GetDataColumns().Select(x => x.FieldName);
        }

        [AIIntegrationTool]
        [Description("Groups the Grid data by the specified column. Optionally specify the grouping order. Example: 'Group the grid by Country.' Returns a confirmation or actionable error.")]
        public string GroupByColumn(
            [AIIntegrationToolTarget("Target Grid to group.")] DxGrid grid,
            [Description("The name of the column to group by. Use the column caption or field name.")] string columnName,
            [Description("The grouping order index (optional, default is 0). Lower index means higher grouping priority.")]
            int groupIndex = 0) {
            try {
                grid.GroupBy(columnName, groupIndex);
                return $"Grouping applied successfully on column '{columnName}' at index {groupIndex}.";
            } catch {
                return $"Error: Column '{columnName}' not found. Please check the column name and try again.";
            }
        }

        [AIIntegrationTool]
        [Description("Removes all grouping from the Grid. Returns a confirmation message.")]
        public string ClearGrouping(
            [AIIntegrationToolTarget("Target Grid to clear grouping from.")] DxGrid grid) {
            grid.ClearSort();
            return "All grouping cleared from the grid.";
        }

        [AIIntegrationTool]
        [Description("Sort the Grid by a specified column in ascending or descending order. Returns a confirmation message or an actionable error.")]
        public string SortByColumn([AIIntegrationToolTarget("Target Grid to sort.")] DxGrid grid, [Description("Column name. Must match one of the existing columns in the grid. Valid values (case-sensitive): Country, City, Address, Phone, CompanyName.")] string columnName, [Description("Sort order (Ascending or Descending).")] GridColumnSortOrder sortOrder) {
            try {
                grid.SortBy(columnName, sortOrder);
                return $"Sorting applied to '{columnName}' column in {sortOrder} order.";
            } catch {
                return $"Error: Column '{columnName}' not found. Please check the column name and try again.";
            }
        }

        [AIIntegrationTool]
        [Description("Remove sorting from the Grid. Returns a confirmation message.")]
        public string ClearSorting(
            [AIIntegrationToolTarget("Target Grid to remove sorting from.")]
            DxGrid grid) {
            grid.ClearSort();
            return $"Sorting removed from column.";
        }

        [AIIntegrationTool]
        [Description("Create and apply a grid filter from a natural-language prompt. Converts the prompt to a filter expression and applies it. Returns a summary of the filter applied or actionable error.")]
        public async Task<string> SetFilter(
            [AIIntegrationToolTarget("Target Grid to apply the filter to.")]
            DxGrid grid,
            [Description("Natural-language description of the filter. Examples: \"Show orders from 2024\", \"price > 100 and status = 'Paid'\".")]
            string userPrompt) {

            if(string.IsNullOrWhiteSpace(userPrompt))
                return "Error: filter prompt is empty.";

            var functions = ExpressionEditorContextHelper.GetFunctions().ToRequestFunctionInfo();

            var columns = grid.GetDataColumns()
                .Select(c => new PromptToFilterRequest.ColumnInfo(
                    c.FieldName,
                    c.Caption ?? c.FieldName,
                    c.Caption ?? c.FieldName,
                    typeof(string),
                    []))
                .ToList();

            try {
                var request = new PromptToFilterRequest(userPrompt, string.Empty, columns, functions);

                var result = await aiExtensionsContainer.PromptToExpressionAsync(request);

                if(string.IsNullOrEmpty(result.Response))
                    return "Error: failed to generate a filter expression.";
                grid.SetFilterCriteria(CriteriaOperator.Parse(result.Response));
            } catch(Exception ex) {
                return $"Error: generated filter expression is invalid. {ex.Message}";
            }

            return $"Filter applied";
        }

        [AIIntegrationTool]
        [Description("Clears all filters from the Grid. Returns a confirmation message.")]
        public string ClearFilter(
            [AIIntegrationToolTarget("Target Grid to clear filters from.")]
            DxGrid grid) {
            grid.ClearFilter();
            return "All filters cleared from the grid.";
        }
    }
}
