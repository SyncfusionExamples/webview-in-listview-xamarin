using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class Controls : INotifyPropertyChanged
    {
        #region Fields
        
        private string controlName;
        private WebViewSource description;
        #endregion


        #region Constructor
        public Controls(string name, WebViewSource source)
        {
            controlName = name;
            description = source;
        }

        public Controls()
        {

        }
        #endregion

        #region Properties
        
        public string ControlName
        {
            get { return controlName; }
            set
            {
                if (controlName != value)
                {
                    controlName = value;
                    this.RaisedOnPropertyChanged("ControlName");
                }
            }
        }

        public WebViewSource Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
                this.RaisedOnPropertyChanged("Description");
            }
        }
        #endregion

        #region Interface implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
        #endregion
    }
}
