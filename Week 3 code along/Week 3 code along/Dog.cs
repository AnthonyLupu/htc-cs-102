using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_code_along
{
    class Goose
    {
        public string Name;
        public string Age;
        public string Atk;

        public void Honk() 
        {
            MessageBox.Show("my name " + Name + "my age is" + Age);
        }

        public void Attack()
        {
            MessageBox.Show("die nerd");
            MessageBox.Show("you take " + Atk + "damage");
        }
    }
}
