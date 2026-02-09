using Microsoft.AspNetCore.Components;
using SHARED.Models;
using WEB.Services;

namespace WEB.Components.Pages
{
    public partial class Home
    {
        [Inject] public IMonograph _monograph { get; set; }


        public List<MonographModel> _records = new();
        public List<MonographModel> _filteredList = new();
        private List<MonographModel> _pagedMonographs = new();

        public string _searchText { get; set; }
        public string _SelectedType = "Select a Monograph Type";
        public string _activeTab = "JSON";
        public bool _isAscending = true;

        private bool _isOpenType = false;

        public MonographModel? _selectedRecord;

        public IEnumerable<string> _tabMenu = Array.Empty<string>();



        public List<MonographModel> PagedItems = new();

        public int currentPage = 1;
        public int pageSize = 10; // Default size
        public int totalPages;


    }
}
