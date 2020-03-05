using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace week_quatro
{
    class movie
    {
        public string Title { get; set; }
        public int Ryear { get; set; }
        public movie()
        {

        }
        public movie (string mTitle, int mRyear)
        {
            this.Title = mTitle;
            this.Ryear = mRyear;
        }
        public void Showd()
        {
            string info = "title:" + this.Title;
            info += "\nRelease Year:" + this.Ryear;
            MessageBox.Show(info);
        }
    }
}
