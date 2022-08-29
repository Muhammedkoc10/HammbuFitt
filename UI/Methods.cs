using HammbuuFittDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{

    public static class Methods
    {
        public static void Clear(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is DateTimePicker)
                    ((DateTimePicker)item).Value = DateTime.Now.Date;
                if (item is RadioButton&&item.Name== "rbWoman")
                    ((RadioButton)item).Checked =false;
                if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = 1;
                if (item is CheckBox)
                    ((CheckBox)item).Checked = false;
                if (item is ComboBox)
                    ((ComboBox)item).SelectedValue = -1;
            }
        }
    }
}
