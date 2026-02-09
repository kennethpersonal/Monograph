
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Formatters;
using SHARED.Models;
using System.Text.Json;
using WEB.Services;

namespace WEB.Components.Pages
{
    public partial class Home
    {


        protected override async Task OnInitializedAsync()
        {
            string? json_records = await _monograph.InvokeGetAsync<string>("api/v1/Monograph");
            _records = JsonSerializer.Deserialize<List<MonographModel>>(json_records);
            _filteredList = _records;
            _pagedMonographs = _records;
            LoadTabMenu();
            CalculatePagination();
        }

        public void LoadTabMenu()
        {
            _tabMenu = new[] { "JSON", "Raw JSON", "DetailHtmlData" };
        }


        public void HandlePageChange(int newPage)
        {
            currentPage = newPage;
            RefreshItems();
        }

        public void HandlePageSizeChange(int newSize)
        {
            pageSize = newSize;
            currentPage = 1; // Reset to page 1 to prevent index out of range
            CalculatePagination();
        }

        public void CalculatePagination()
        {
            totalPages = (int)Math.Ceiling(_filteredList.Count / (double)pageSize);
            RefreshItems();
        }

        public void RefreshItems()
        {
            _pagedMonographs = _filteredList
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
