using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

using System.Reflection;

using InterfacesDescriptions;
using PluginInterfaces;


namespace MilitaryUnits
{
    public partial class Form1 : Form
    {
        [XmlArrayItem(typeof(Detachment))]
        [XmlElement("usersList")]
        private List<Detachment> list = new List<Detachment>();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
            }
            fieldsLimit();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
        
              

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         

        }
        private void fieldsLimit()
        {
            int selectedFormation = checkedListBox1.SelectedIndex;
            switch (selectedFormation)
            {
                case 0:
                    {
                        TnumberOfUnits.Enabled = true;
                        TpostOfCommander.Enabled = true;
                        TtypeOfArmy.Enabled = false;
                        Ttask.Enabled = false;
                        Tstaff.Enabled = false;

                        break;
                    }
                case 1:
                    {
                        TnumberOfUnits.Enabled = true;
                        TpostOfCommander.Enabled = true;
                        TtypeOfArmy.Enabled = true;
                        Ttask.Enabled = false;
                        Tstaff.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        TnumberOfUnits.Enabled = true;
                        TpostOfCommander.Enabled = true;
                        TtypeOfArmy.Enabled = true;
                        Ttask.Enabled = true;
                        Tstaff.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        TnumberOfUnits.Enabled = true;
                        TpostOfCommander.Enabled = true;
                        TtypeOfArmy.Enabled = true;
                        Ttask.Enabled = true;
                        Tstaff.Enabled = true;
                        break;
                    }
                case 4:
                    {
                        TnumberOfUnits.Enabled = true;
                        TpostOfCommander.Enabled = true;
                        TtypeOfArmy.Enabled = true;
                        Ttask.Enabled = true;
                        Tstaff.Enabled = true;
                        break;
                    }

            }
        }

        private void TnumberOfUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

          
        }

        private void button2_Click(object sender, EventArgs e)//добавление в список
        {
            if (TnumberOfUnits.Text.Length != 0)
            {
                int selectedFormation = checkedListBox1.SelectedIndex;
                int numOfUnits;
                string postOfCommander;
                string typeOfArmy;
                string task;
                string staff;

                switch (selectedFormation)
                {
                    case 0:
                        {
                            numOfUnits = int.Parse(TnumberOfUnits.Text);
                            postOfCommander = TpostOfCommander.Text;
                            Detachment detachment = new Detachment(numOfUnits, postOfCommander);
                            list.Add(detachment);
                            break;
                        }
                    case 1:
                        {
                            numOfUnits = int.Parse(TnumberOfUnits.Text);
                            postOfCommander = TpostOfCommander.Text;
                            typeOfArmy = TtypeOfArmy.Text;
                            Platoon detachment = new Platoon(numOfUnits, postOfCommander, typeOfArmy);
                            list.Add(detachment);
                            break;
                        }
                    case 2:
                        {
                            numOfUnits = int.Parse(TnumberOfUnits.Text);
                            postOfCommander = TpostOfCommander.Text;
                            typeOfArmy = TtypeOfArmy.Text;
                            task = Ttask.Text;
                            Company detachment = new Company(numOfUnits, postOfCommander, typeOfArmy, task);
                            list.Add(detachment);
                            break;
                        }
                    case 3:
                        {
                            numOfUnits = int.Parse(TnumberOfUnits.Text);
                            postOfCommander = TpostOfCommander.Text;
                            typeOfArmy = TtypeOfArmy.Text;
                            task = Ttask.Text;
                            staff = Tstaff.Text;
                            Battalion detachment = new Battalion(numOfUnits, postOfCommander, typeOfArmy, task, staff);
                            list.Add(detachment);
                            break;
                        }
                    case 4:
                        {
                            numOfUnits = Int32.Parse(TnumberOfUnits.Text);
                            postOfCommander = TpostOfCommander.Text;
                            typeOfArmy = TtypeOfArmy.Text;
                            task = Ttask.Text;
                            staff = Tstaff.Text;
                            Regiment detachment = new Regiment(numOfUnits, postOfCommander, typeOfArmy, task, staff);
                            list.Add(detachment);
                            break;
                        }

                }
                updateInfo();
            }
        }
      
        private void button3_Click(object sender, EventArgs e) //удаление
        {

            string chosedElem;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выбирете изменяемый элемент на листбоксе ПАЖАЛУСТА");
            }
            else
            {
                MessageBox.Show("Элемент  удален!");
                chosedElem = listBox1.SelectedItem.ToString();
                int i = 0;
                foreach (Detachment el in list) 
                {
                    if (el.getAccessTo() == chosedElem)
                    {
                        list.RemoveAt(i);
                        break;
                    }
                    i = i + 1;
                }
                updateInfo();
            }
        }

        private void updateInfo() //показать на форму весь список
        {
            listBox1.Items.Clear();
            foreach (Detachment el in list)
            {
                listBox1.Items.Add(el.getAccessTo());
            }
        }

        private void button5_Click(object sender, EventArgs e) //изменение элемента
        {
            if (TnumberOfUnits.Text.Length != 0)
            {
                string chosedElem;
                string typeChosedElem;
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Выбирете изменяемый элемент на листбоксе ПАЖАЛУСТА");
                }
                else
                {
                    MessageBox.Show("Элемент изменен!");
                    chosedElem = listBox1.SelectedItem.ToString();
                    int i = 0;
                    foreach (Detachment el in list) //нашли индекс элемента в списке
                    {
                        if (el.getAccessTo() == chosedElem)
                        {
                            break;
                        }
                        i = i + 1;
                    }
                    typeChosedElem = (list[i].GetType().ToString());
                    list[i].NumberOfUnits = int.Parse(TnumberOfUnits.Text);
                    list[i].PostOfCommander = TpostOfCommander.Text;
                    switch (typeChosedElem)
                    {
                        case "MilitaryUnits.Detachment":
                            {

                                break;
                            }
                        case "MilitaryUnits.Platoon":
                            {
                                (list[i]).changeFields(TtypeOfArmy.Text);
                                break;
                            }
                        case "MilitaryUnits.Company":
                            {
                                (list[i]).changeFields(TtypeOfArmy.Text, Ttask.Text);
                                break;
                            }
                        case "MilitaryUnits.Battalion":
                            {
                                (list[i]).changeFields(TtypeOfArmy.Text, Ttask.Text, Tstaff.Text);
                                break;
                            }
                        case "MilitaryUnits.Regiment":
                            {
                                (list[i]).changeFields(TtypeOfArmy.Text, Ttask.Text, Tstaff.Text);
                                break;
                            }
                    }
                    updateInfo();
                }
            }
        }



        private void button4_Click_1(object sender, EventArgs e)
        {


            if (XML.Checked == true)
            {

                /* var serial = new System.Xml.Serialization.XmlSerializer(list.GetType());

                 using (var stream = new FileStream("xml.txt", FileMode.Create))
                 {
                     serial.Serialize(stream, list);
                     stream.Flush();
                 }*/

                ///Получаем полный путь к файлу AboutLibrary.dll.
                ///Предполагаем, что он находится в папке, где и
                ///исполняемый файл
                String AboutLibName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "InterfacesDescriptions.dll");
                if (!File.Exists(AboutLibName)) { MessageBox.Show("File not found"); return; }
                ///Загружаем сборку
                Assembly AboutAssembly = Assembly.LoadFrom(AboutLibName);

                ///в цикле проходим по всем public-типам сборки
                foreach (Type t in AboutAssembly.GetExportedTypes())
                {
                    ///если это класс,который реализует интерфейс IAboutInt,
                    ///то это то,что нам нужно Smile
                    if (t.IsClass && typeof(ISerDecMethods).IsAssignableFrom(t))
                    {
                        ///создаем объект полученного класса
                        ISerDecMethods serDec = (ISerDecMethods)Activator.CreateInstance(t);
                        ///вызываем его метод GetAboutText
                      serDec.Ser(list);          
                        break;
                    }
                }


            }
            if (Binary.Checked == true)
            {

                BinaryFormatter binform = new BinaryFormatter();
                using (Stream fstream = new FileStream("binary.txt", FileMode.Create, FileAccess.Write))
                {
                    binform.Serialize(fstream, list);
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 0;


            if (XML.Checked == true)
            {

                /*  var serial = new System.Xml.Serialization.XmlSerializer(list.GetType());

                  using (var stream = new FileStream("xml.txt", FileMode.Open))
                  {
                   list=(List<Detachment>)serial.Deserialize(stream);
                      stream.Flush();
                  }
                  for (i = 0; i <= list.Count - 1; i++)
                  {
                      listBox1.Items.Add(list[i].getAccessTo());
                  }*/


                ///Получаем полный путь к файлу AboutLibrary.dll.
                ///Предполагаем, что он находится в папке, где и
                ///исполняемый файл
                String AboutLibName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "InterfacesDescriptions.dll");
                if (!File.Exists(AboutLibName)) { MessageBox.Show("File not found"); return; }
                ///Загружаем сборку
                Assembly AboutAssembly = Assembly.LoadFrom(AboutLibName);

                ///в цикле проходим по всем public-типам сборки
                foreach (Type t in AboutAssembly.GetExportedTypes())
                {
                    ///если это класс,который реализует интерфейс IAboutInt,
                    ///то это то,что нам нужно Smile
                    if (t.IsClass && typeof(ISerDecMethods).IsAssignableFrom(t))
                    {
                        ///создаем объект полученного класса
                               ISerDecMethods serDec = (ISerDecMethods)Activator.CreateInstance(t);
                        ///вызываем его метод GetAboutText
                        list = serDec.Dec();
                        for ( i = 0; i <= list.Count - 1; i++)
                        {
                            listBox1.Items.Add(list[i].getAccessTo());
                        }
                        
                        break;
                    }
                }


            }
            if (Binary.Checked == true)
            {

                BinaryFormatter binform = new BinaryFormatter();
                using (Stream fstream = new FileStream("binary.txt", FileMode.Open, FileAccess.Read))
                {

                    list = (List<Detachment>)binform.Deserialize(fstream);

                }
                listBox1.Items.Clear();
                for (i = 0; i <= list.Count - 1; i++)
                {
                    listBox1.Items.Add(list[i].getAccessTo());
                }
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ///Получаем полный путь к файлу AboutLibrary.dll.
            ///Предполагаем, что он находится в папке, где и
            ///исполняемый файл
            ///
          

            String AboutLibName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "InterfacesDescriptions.dll");
            if (!File.Exists(AboutLibName)) { MessageBox.Show("File not found"); return; }
            ///Загружаем сборку
            Assembly AboutAssembly = Assembly.LoadFrom(AboutLibName);
            // MessageBox.Show("wefewfewf");
            ///в цикле проходим по всем public-типам сборки
           //  bool b = true;
            foreach (Type t in AboutAssembly.GetExportedTypes())
            {

                ///если это класс,который реализует интерфейс IAboutInt,
                ///то это то,что нам нужно Smile
                     if (t.IsClass && typeof(IChangeAttriburesMethods).IsAssignableFrom(t))
                {
                    //     MessageBox.Show("wefewfewf");
                    ///создаем объект полученного класса
                       IChangeAttriburesMethods serDec = (IChangeAttriburesMethods)Activator.CreateInstance(t);
                    ///вызываем его метод GetAboutText
                         serDec.SerAttribute(list);
              //      b = false;

                    break;
                }
              
               
            }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {

            String AboutLibName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "InterfacesDescriptions.dll");
            if (!File.Exists(AboutLibName)) { MessageBox.Show("File not found"); return; }
            ///Загружаем сборку
            Assembly AboutAssembly = Assembly.LoadFrom(AboutLibName);
            // MessageBox.Show("wefewfewf");
            ///в цикле проходим по всем public-типам сборки
            foreach (Type t in AboutAssembly.GetExportedTypes())
            {
                ///если это класс,который реализует интерфейс IAboutInt,
                ///то это то,что нам нужно Smile
                if (t.IsClass && typeof(IChangeAttriburesMethods).IsAssignableFrom(t))
                {
                    //     MessageBox.Show("wefewfewf");
                    ///создаем объект полученного класса
                          IChangeAttriburesMethods serDec = (IChangeAttriburesMethods)Activator.CreateInstance(t);
                    ///вызываем его метод GetAboutText
                    list = serDec.DecAttribute();
                    for (int i = 0; i <= list.Count - 1; i++)
                    {
                        listBox1.Items.Add(list[i].getAccessTo());
                    }

                    break;
                }
            }
        }

        private void buttonAdapter_Click(object sender, EventArgs e)
        {//допустим проход по списку войск и если ко-во большое то вывод адаптир методы
            string armyAnswer;
            if (list.Count != 0)
            {
                for (int i = 0; i <= list.Count - 1; i++)
                {

                  
                    DoSomeActivity someAct;
                    someAct = new DoSomeActivity();
                    armyAnswer= someAct.Attack(); //в классе тупо вызываем метод
                    if (list[i].NumberOfUnits > 200)
                    {
                        someAct = new Adapter();
                        armyAnswer= someAct.Attack(); // а потом тыдыш и нам типа понадобился этот класс но с немного другими методами
                    }                               //                   тыдыш мы сделали какуюта магию и теперь появился новый класс у которого
                    MessageBox.Show(armyAnswer);                         //                    теже методы(наследовали же от 1 класса) но ток уже исправленные 
                }

            }
            else
                MessageBox.Show("list  is empty");
        }

        private void buttonDecorator_Click(object sender, EventArgs e)
        {
            int unitsNum;
            MainCommandsRealization simpleArmy;
            DecoratorBig decoratorBig;
            string armyAnswer;
            if (list.Count!=0 )
            {

                for (int i = 0; i <= list.Count - 1; i++)
                {
                    armyAnswer = "";
                    unitsNum = list[i].NumberOfUnits;
                    simpleArmy = new MainCommandsRealization(unitsNum);

                    if (unitsNum >= 200)
                    {
                        decoratorBig = new DecoratorBig(simpleArmy, unitsNum);
                        //   armyAnswer = decoratorBig.Settle();
                        DecoratorWeapon decorWeapon = new DecoratorWeapon(decoratorBig, unitsNum);
                        armyAnswer = decorWeapon.Settle();

                    }
                    else
                    {
                        DecoratorWeapon decorWeapon = new DecoratorWeapon(simpleArmy, unitsNum);
                        armyAnswer = decorWeapon.Settle();
                    }
                    MessageBox.Show(armyAnswer);


                }


            }
            else
            {
                MessageBox.Show("list is empty");
            }
        
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);

            for (int i = 0; i <= list.Count - 1; i++)
            {
                MessageBox.Show((i+1).ToString()+invoker.ExecuteCommand());
            }
        }
    }
}
