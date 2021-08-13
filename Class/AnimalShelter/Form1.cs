using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            /*
            int[] numberArray = new int[] { 1, 2, 3, 4, 5 };

            Customer customerOne;
            Customer[] customerArray = new Customer[5];
            customerArray[0] = new Customer("first", "last", new DateTime(1997, 4, 25));
            customerArray[1] = new Customer("first", "last", new DateTime(1997, 4, 25));
            customerArray[2] = new Customer("first", "last", new DateTime(1997, 4, 25));
            customerArray[3] = new Customer("first", "last", new DateTime(1997, 4, 25));
            customerArray[4] = new Customer("first", "last", new DateTime(1997, 4, 25));

            Customer[] customerArray2 =
            {
                new Customer("first", "last", new DateTime(1997, 4, 25)),
                new Customer("first", "last", new DateTime(1997, 4, 25)),
                new Customer("first", "last", new DateTime(1997, 4, 25)),
                new Customer("first", "last", new DateTime(1997, 4, 25)),
                new Customer("first", "last", new DateTime(1997, 4, 25))
            };
            */


            Customer cus =  new Customer(CusNewFirstName.Text, CusNewLastName.Text, 
               DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);

            Customers.Add(cus);

            CusNewFirstName.Text = "";
            CusNewLastName.Text = "";
            CusNewBirthday.Text = "";
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDesciption.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();

            CusPetInfo.Text = "";

            foreach (Pet pet in cus.MyPets)
            {
                CusPetInfo.Text += pet.Name + ":" + pet.MakeSound();
                
                if(pet is Cat)
                {
                    CusPetInfo.Text += ":" + (pet as Cat).Scratch();
                }
                else if(pet is Dog)
                {
                    CusPetInfo.Text += ":" + (pet as Dog).Bite();
                }

                CusPetInfo.Text += Environment.NewLine;
            }
        }

        /*
        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();

            foreach(Customer cus in Customers)
            {
                if(cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
        }
        */

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firstName = (string)CusList.Rows[e.RowIndex].Cells[0].Value;

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }

            CusDetailPanel.Show();
            CusNewPanel.Hide(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;

            Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 2));
            Cat cat = new Cat(1, "Lucas", "White", "Male");
            cus.Adopt(cat);
            Cat cat2 = new Cat(3, "Ruby", "Brown", "FeMale");
            cus.Adopt(cat2);

            Dog dog = new Dog(2, "Happy", "Black", "Male", DogBreed.Jindo);
            cus.Adopt(dog);

            Customers.Add(cus);
            CusList.Rows.Add(cus.FirstName, cus, CusAge, cus.IsQualified);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add(1);
            arrayList.Add(3);

            arrayList.Insert(2, 2);

            arrayList.Remove(2);
            arrayList.RemoveAt(1);

            int sum = 0;
            for(int index = 0; index < arrayList.Count; index++)
            {
                int num = (int)arrayList[index]; // 형변환 필요
                sum += num;
            }

          
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);

            int sum2 = 0;
            for(int index = 0; index < intList.Count; index++)
            {
                int value = intList[index];
                sum2 += value;
            }

            foreach(int value in intList)
            {
                sum += value;
            }
        }
        */
    }
}
