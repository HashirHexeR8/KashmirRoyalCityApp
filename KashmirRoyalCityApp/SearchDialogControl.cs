using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace KashmirRoyalCityApp
{
    public partial class SearchDialogControl : UserControl
    {
        public SearchDialogControl()
        {
            InitializeComponent();
        }

        public Button getCancelButton()
        {
            return btnCancel;
        }

        public Button getSearchButton()
        {
            return btnSearch;
        }

        public TextBox getSearchBox()
        {
            return tbSearchText;
        }

        public Label getSearchLable()
        {
            return lblSearchTitle;
        }
    }
}
