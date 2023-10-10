using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    internal class ApplicationLayer
    {
        private GUI gui;
        private int count_person = 0;
        private Person[] people = new Person[100];

        public ApplicationLayer(GUI gui) 
        {
            this.gui = gui;
        }

        public void createPerson(string name, Int64 tel)
        {
            if(count_person < 100)
                people[count_person] = new Person(name, tel);
            count_person++;
        }

        public void printAllCodes()
        {
            gui.removeItem();
            for (int i = 0; i < count_person; i++)
                gui.addItem($"{people[i].Tel}: {people[i].Name}");
        }

        public void saveInFile()
        {

        }

        public void readFromFile()
        {

        }
    }
}
