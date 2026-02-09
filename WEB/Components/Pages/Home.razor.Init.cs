
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

            if (_isAscending)
                _records = _records.OrderBy(p => p.MonographName).ToList();
            else
                _records = _records.OrderByDescending(p => p.MonographName).ToList();

            _filteredList = _records;
            _pagedMonographs = _records;
            _MonographDropdown = _records.DistinctBy(r => r.MonographType).ToList();
            LoadTabMenu();
            CalculatePagination();
        }

        public void LoadTabMenu()
        {
            _tabMenu = new[] { "JSON", "Raw JSON", "DetailHtmlData" };
        }


        public void HandlePageChange(int newPage)
        {
            _currentPage = newPage;
            RefreshItems();
        }

        public void HandlePageSizeChange(int newSize)
        {
            _pageSize = newSize;
            _currentPage = 1; // Reset to page 1 to prevent index out of range
            CalculatePagination();
        }

        public void CalculatePagination()
        {
            _totalPages = (int)Math.Ceiling(_filteredList.Count / (double)_pageSize);
            RefreshItems();
        }

        public void RefreshItems()
        {
            _pagedMonographs = _filteredList
                .Skip((_currentPage - 1) * _pageSize)
                .Take(_pageSize)
                .ToList();
        }
    }
}
