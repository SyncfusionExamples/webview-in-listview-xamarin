using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class ControlsViewModel
    {
        #region Properties

        public ObservableCollection<Controls> ControlsInfo { get; set; }
        #endregion

        #region Constructor

        public ControlsViewModel()
        {
            ControlsInfo = new ObservableCollection<Controls>();
            GenerateInfo();
        }

        public void GenerateInfo()
        {
            for (int i = 0; i < ControlNames.Count(); i++)
            {
                var control = new Controls(ControlNames[i], WebSites[i]);
                ControlsInfo.Add(control);
            }
        }

        #endregion

        #region Fields

        string[] ControlNames = new string[] {
            "ListView",
            "TreeView",
            "DataGrid",
            "Accordion",
            "Cards",
            "AutoComplete",
            "ComboBox",
            "Maps",
            "Charts"
        };

        string[] WebSites = new string[]
        {
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-listview",
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-treeview",
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-datagrid",
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-accordion",
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-cards",
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-autocomplete",
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-combobox",
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-maps",
            "https://www.syncfusion.com/xamarin-ui-controls/xamarin-charts"
        };
        #endregion
    }
}
