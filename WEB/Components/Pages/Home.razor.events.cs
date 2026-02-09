using Microsoft.AspNetCore.Components;
using SHARED.Models;

namespace WEB.Components.Pages
{
    public partial class Home
    {
        private void OnClickMonographs(MonographModel item)
        {
            _selectedMonograph = item;
        }

        private void OnSearch()
        {

            _filteredList = _records;

            if (!string.IsNullOrWhiteSpace(_searchText))
                _filteredList = _filteredList.Where(p => p.MonographName.Contains(_searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            

            if (_SelectedType != "Select a Monograph Type")
                _filteredList = _filteredList.Where(p => p.MonographType.Contains(_SelectedType, StringComparison.OrdinalIgnoreCase)).ToList();


            if (_isAscending)
                _filteredList = _filteredList.OrderBy(p => p.MonographName).ToList();
            else
                _filteredList = _filteredList.OrderByDescending(p => p.MonographName).ToList();

            _pagedMonographs = _filteredList;

        }

        private void OnClear()
        {

            _filteredList = _records;
            _pagedMonographs = _filteredList;
            _searchText = string.Empty;
            _SelectedType = "Select a Monograph Type";
            _isAscending = false;
            _currentPage = 1;
            _pageSize = 10;
            HandlePageSizeChange(_pageSize);

        }

        private void SetActiveTab(string tabName)
        {
            _activeTab = tabName;
        }

        // Helper method to keep the HTML clean
        private string GetActiveClass(string tabName)
        {
            return _activeTab == tabName ? "active" : "";
        }

        private void TypeToggleDropdown()
        {
            _isOpenType = !_isOpenType;
        }

        private void SelectTyeOption(string optionName)
        {
            _SelectedType = optionName;
            _isOpenType = false;
            OnSearch();
        }

        private void OnToggleSortBy(ChangeEventArgs e)
        {
            _isAscending = (bool)e.Value;
            OnSearch();
        }

    }
}
